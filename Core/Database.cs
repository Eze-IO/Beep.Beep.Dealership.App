using Beep.Beep.Dealership.App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Beep.Beep.Dealership.App.Core
{
    public static class Database
    {
        /*--------------------------------------------------------------------------------------------------------------------------------------*/
        //Links for making api calls to the AWS Lambda functions
        private const String _getListUrl = "https://vo4yd50tli.execute-api.us-east-1.amazonaws.com/prod/BeepBeepInventoryGetList";
        private const String _getItemUrl = "https://unyka7kh40.execute-api.us-east-1.amazonaws.com/prod/BeepBeepInventoryGetItem";
        private const String _putItemUrl = "https://inout6gox5.execute-api.us-east-1.amazonaws.com/prod/BeepBeepInventoryPutItem";
        private const String _deleteItemUrl = "https://342cdgz7r4.execute-api.us-east-1.amazonaws.com/prod/BeepBeepInventoryDeleteItem";
        /*--------------------------------------------------------------------------------------------------------------------------------------*/

        public static async Task<Car[]> GetAllItems()
        {
            HttpWebRequest rq = null;
            try
            {
                if (HelperFunction.IsInternetAvailable)
                {
                    rq = (HttpWebRequest)HttpWebRequest.Create(_getListUrl);
                    rq.Method = "GET";
                    rq.ContentType = "application/json";
                    using (HttpWebResponse rs = (HttpWebResponse)rq.GetResponse())
                    {
                        if (rs.StatusCode != HttpStatusCode.OK)
                        {
                            throw new WebException("Failed to get the items!", WebExceptionStatus.ReceiveFailure);
                        }
                        else
                        {
                            String response = String.Empty;
                            using (StreamReader sr = new StreamReader(rs.GetResponseStream()))
                            {
                                response = await sr.ReadToEndAsync();
                                sr.Close();
                            }
                            List<Car> list = new List<Car>();
                            JArray array = JArray.Parse(response);
                            foreach(JObject item in array)
                            {
                                var id = item.GetValue("ID");
                                if(!string.IsNullOrEmpty((String)id))
                                {
                                    try
                                    {
                                        Car c = new Car(Convert.ToUInt32(id));
                                        c.Name = (String)item.GetValue("Name");
                                        c.Make = (String)item.GetValue("Make");
                                        c.Model = (String)item.GetValue("Model");
                                        c.Color = (String)item.GetValue("Color");
                                        c.Year = (UInt32)item.GetValue("Year");
                                        c.Price = (Double)item.GetValue("Price");
                                        c.Sold = (Boolean)item.GetValue("Sold");
                                        list.Add(c);
                                    }
                                    catch { continue; }
                                }
                            }
                            return list.ToArray();
                        }
                    }
                }
                throw new WebException("There is no internet connection!", WebExceptionStatus.ConnectFailure);
            }
            catch (Exception ex) { Library.WriteLog(ex); return null; }
            finally { rq.Abort(); }
        }

        private static String _lastSearch = null;

        public static String GetLastSearch()
        {
            if (String.IsNullOrEmpty(_lastSearch))
                return string.Empty;
            return _lastSearch;
        }

        private const String _all = "*";

        public static async Task<Car[]> SearchForItems(String search)
        {
            _lastSearch = search;
            search = search.ToLower();
            if (search.Equals(_all) || string.IsNullOrEmpty(search))
                return await Database.GetAllItems();

            List<Car> list = new List<Car>();
            var items = await Database.GetAllItems();
            foreach(Car car in items)
            {
                String soldStatus = "unsold";
                String sPrice = (string.Format("${0:0.00}", car.Price));
                if (car.Sold)
                    soldStatus = "sold";
                String toSearch = String.Format("ID({0}) Name({1}) Make({2}) Model({3}) Color({4}) Year({5}) Price({6}) Price({7}) {8}, Status({9})",
                    car.ID, car.Name, car.Make, car.Model, car.Color, car.Year, sPrice, car.Price, soldStatus, soldStatus);
                toSearch = toSearch.ToLower();

                foreach(var s in search.Split(' '))
                {
                    if (toSearch.IndexOf(s) > -1)
                        list.Add(car);
                }
            }
            return list.ToArray();
        }

        public static async Task<Car> GetAnItem(int ID) { return await GetAnItem((UInt32)ID); }

        public static async Task<Car> GetAnItem(uint ID)
        {
            HttpWebRequest rq = null;
            try
            {
                if (HelperFunction.IsInternetAvailable)
                {
                    rq = (HttpWebRequest)HttpWebRequest.Create(_getItemUrl);

                    JObject item = new JObject();
                    item["ID"] = ID.ToString();

                    var data = Encoding.ASCII.GetBytes(item.ToString());
                    rq.Method = "POST";
                    rq.ContentType = "application/json";
                    rq.ContentLength = data.Length;

                    using (var stream = rq.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                    }
                    using (HttpWebResponse rs = (HttpWebResponse)rq.GetResponse())
                    {
                        if (rs.StatusCode != HttpStatusCode.OK)
                        {
                            throw new WebException("Failed to get the item!", WebExceptionStatus.ReceiveFailure);
                        }
                        else
                        {
                            String response = String.Empty;
                            using (StreamReader sr = new StreamReader(rs.GetResponseStream()))
                            {
                                response = await sr.ReadToEndAsync();
                                sr.Close();
                            }
                            Car c = null;
                            JObject _item = JObject.Parse(response);
                            var id = (String)item.GetValue("ID");
                            if (!string.IsNullOrEmpty(id))
                            {
                                try
                                {
                                    c = new Car(Convert.ToUInt32(id));
                                    c.Name = (String)_item.GetValue("Name");
                                    c.Make = (String)_item.GetValue("Make");
                                    c.Model = (String)_item.GetValue("Model");
                                    c.Color = (String)_item.GetValue("Color");
                                    c.Year = (UInt32)_item.GetValue("Year");
                                    c.Price = (Double)_item.GetValue("Price");
                                    c.Sold = (Boolean)_item.GetValue("Sold");
                                }
                                catch { return null; }
                            }
                            return c;
                        }
                    }
                }
                throw new WebException("There is no internet connection!", WebExceptionStatus.ConnectFailure);
            }
            catch(Exception ex) { Library.WriteLog(ex); return null; }
            finally { rq.Abort(); }
        }

        public static async Task<Boolean> SaveAnItem(Vehicle machine)
        {
            bool result = false;
            HttpWebRequest rq = null;
            try
            {
                if (HelperFunction.IsInternetAvailable)
                {
                    rq = (HttpWebRequest)HttpWebRequest.Create(_putItemUrl);
                    
                    JObject item = new JObject();
                    item["Name"] = machine.Name.ToString();
                    item["Make"] = machine.Make.ToString();
                    item["Model"] = machine.Model.ToString();
                    item["Color"] = machine.Color.ToString();
                    item["Year"] = machine.Year.ToString();
                    item["Price"] = machine.Price.ToString();
                    item["Sold"] = machine.Sold.ToString();

                    var data = Encoding.ASCII.GetBytes(item.ToString());
                    rq.Method = "POST";
                    rq.ContentType = "application/json";
                    rq.ContentLength = data.Length;

                    using (var stream = rq.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                    }
                    using (HttpWebResponse rs = (HttpWebResponse)rq.GetResponse())
                    {
                        if (rs.StatusCode != HttpStatusCode.OK)
                        {
                            throw new WebException("Failed to save the item!", WebExceptionStatus.ReceiveFailure);
                        }

                        String response = String.Empty;
                        using (StreamReader sr = new StreamReader(rs.GetResponseStream()))
                        {
                            result = Convert.ToBoolean(sr.ReadToEnd());
                            sr.Close();
                        }
                    }
                    return result;
                }
                throw new WebException("There is no internet connection!", WebExceptionStatus.ConnectFailure);
            }
            catch(Exception ex) { Library.WriteLog(ex); return result; }
            finally { rq.Abort(); }
        }

        public static async Task<Boolean> UpdateAnItem(Car car)
        {
            try
            {
                Car c = await GetAnItem(car.ID);
                if (car.Equals(c))
                    if (await SaveAnItem(c.ToVehicle()))
                        return await RemoveAnItem(c.ID);
                return false;
            }
            catch(Exception ex) { Library.WriteLog(ex);  return false; }
        }

        public static async Task<Boolean> RemoveAnItem(int ID) { return await RemoveAnItem((UInt32)ID); }

        public static async Task<Boolean> RemoveAnItem(uint ID)
        {
            bool result = false;
            HttpWebRequest rq = null;
            try
            {
                if (HelperFunction.IsInternetAvailable)
                {
                    rq = (HttpWebRequest)HttpWebRequest.Create(_deleteItemUrl);

                    JObject item = new JObject();
                    item["ID"] = ID.ToString();

                    var data = Encoding.ASCII.GetBytes(item.ToString());
                    rq.Method = "POST";
                    rq.ContentType = "application/json";
                    rq.ContentLength = data.Length;

                    using (var stream = rq.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                    }
                    using (HttpWebResponse rs = (HttpWebResponse)rq.GetResponse())
                    {
                        if (rs.StatusCode != HttpStatusCode.OK)
                        {
                            throw new WebException("Failed to remove the item!", WebExceptionStatus.ReceiveFailure);
                        }

                        String response = String.Empty;
                        using (StreamReader sr = new StreamReader(rs.GetResponseStream()))
                        {
                            result = Convert.ToBoolean(sr.ReadToEnd());
                            sr.Close();
                        }
                    }
                    return result;
                }
                throw new WebException("There is no internet connection!", WebExceptionStatus.ConnectFailure);
            }
            catch(Exception ex) { Library.WriteLog(ex); return result; }
            finally { rq.Abort(); }
        }
    }
    
}
