using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Beep.Beep.Dealership.App.Core.Entities
{
    public class Vehicle : IDisposable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Double Price { get; set; }
        public Boolean Sold { get; set; }
        public string Name { get; set; }
        public UInt32 Year { get; set; }

        public void Dispose()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (var propertyInfo in properties)
            {
                try
                {
                    if (propertyInfo.PropertyType == typeof(string))
                    {
                        propertyInfo.SetValue(this, String.Empty, null);
                    }

                    if (propertyInfo.PropertyType == typeof(Double) ||
                       propertyInfo.PropertyType == typeof(UInt32))
                    {
                        propertyInfo.SetValue(this, 0, null);
                    }

                    if (propertyInfo.PropertyType == typeof(Boolean))
                    {
                        propertyInfo.SetValue(this, false, null);
                    }
                }
                catch { /* do nothing */ }
            }
        }
    }
}
