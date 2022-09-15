using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace ADO.NET
{
    public static class ConfigConstant
    {
        public static string ConnectionString
        {
            get
            {
                //need to read  value from app.config file =System.Configuration assembly
                return ConfigurationManager.ConnectionStrings["PracticeDB"].ConnectionString;
            }
        }
    }
}
