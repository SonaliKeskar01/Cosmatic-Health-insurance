using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
  public  class DbConstants
    {
        public const string spStudents = "usp_Students";
        public const string spStudentDetailsByRollnumber = "usp_StudentDetailsByRollnumber";
        public const string spCreateNewStudent = "usp_CreateNewStudent";
        public const string spUpdateStudent = "usp_UpdateStudent";
        public const string spDeleteStudent = "usp_DeleteStudent";
        public const string spArchiveStudent = "usp_ArchiveStudent";
        public const string spTodaysBirthdays = "usp_TodaysBirthdays";
       public const string spLogErrorToDB = "usp_LogErrorToDB";
        public const string spUpdateWishes = "usp_UpdateWishes";
        public const string spGetUserTypes = "usp_GetUserTypes";
        public const string spRegister = "usp_Register";
        public const string spLogin = "usp_Login";
    }
}
