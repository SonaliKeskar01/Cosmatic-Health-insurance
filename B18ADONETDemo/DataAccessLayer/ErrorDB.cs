using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class ErrorDB
    {
        public void LogError(ErrorLogs error)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(ConfigConstant.ConnectionString);
                SqlCommand cmd = new SqlCommand(DbConstants.spLogErrorToDB,con);
                cmd.CommandType = CommandType.StoredProcedure;

                //add parameters
                cmd.Parameters.AddWithValue("@FriendId", error.FriendId);
                cmd.Parameters.AddWithValue("@ErrorMessage", error.ErrorMessage);
                cmd.Parameters.AddWithValue("@MethodName", error.MethodName);

                con.Open();
                cmd.ExecuteNonQuery();

            }
            
            finally
            {
                if(con != null)
                {
                    con.Close();
                }

            }
        }
    }
}
