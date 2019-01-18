using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Beep.Beep.Dealership.App.Core
{
    public static class HelperFunction
    {
        public static bool IsInternetAvailable
        {
            get
            {
                try
                {
                    using(WebClient wb = new WebClient())
                    {
                        using (wb.OpenRead("http://google.com"))
                        {
                            return true;
                        }
                    }
                }
                catch { return false; }
            }
        }
    }
}
