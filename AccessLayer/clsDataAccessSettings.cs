using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace AccessLayer
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString { set; get; }
    }
}
