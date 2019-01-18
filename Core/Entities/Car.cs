using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Beep.Beep.Dealership.App.Core.Entities
{
    public class Car : Vehicle
    {
        private uint _ID = 0;
        public Car(UInt32 ID) { this._ID = ID; }
        public UInt32 ID { get { return _ID; } }

        public override bool Equals(object obj)
        {
            try
            {
                if (String.IsNullOrEmpty(Name))
                    return false;
                Car c = (Car)obj;
                return (_ID == c.ID);
            }
            catch { return false; }
        }

        public override int GetHashCode()
        {
            return ((int)this.ID);
        }
    }

    public static class CarEx {
        public static Vehicle ToVehicle(this Car car)
        {
            var v = new Vehicle();
            v.Name = car.Name;
            v.Make = car.Make;
            v.Model = car.Model;
            v.Color = car.Color;
            v.Year = car.Year;
            v.Price = car.Price;
            v.Sold = car.Sold;
            return v;
        }
    }

}
