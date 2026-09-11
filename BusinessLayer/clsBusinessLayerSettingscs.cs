using AccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsBusinessLayerSettings
    {
        public static String ConnectionString { set {clsDataAccessSettings.ConnectionString=value; } }
    }
}
