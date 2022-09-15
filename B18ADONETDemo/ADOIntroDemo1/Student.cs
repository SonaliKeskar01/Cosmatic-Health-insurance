using System;
using System.Data.SqlClient;
namespace ADOIntroDemo1
{
    //class/model/entity/domain model/business object
   public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int CorseId { get; set; }
    }
}
