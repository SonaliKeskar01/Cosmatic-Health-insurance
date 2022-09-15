using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
  public static  class ConfigConstant
    {
        public static string ConnectionString
        {
            get
            {
                //need to read  value from app.config file =System.Configuration assembly
                return ConfigurationManager.ConnectionStrings["PracticeDB"].ConnectionString;
            }
        }
        public static string ArchievedDBConnectionString
        {
            get
            {
                //need to read  value from app.config file =System.Configuration assembly
                return ConfigurationManager.ConnectionStrings["B18ArchievedDB"].ConnectionString;
            }
        }
        public static string StudentDBConnectionString
        {
            get
            {
                //need to read  value from app.config file =System.Configuration assembly
                return ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
            }
        }
    }
}
