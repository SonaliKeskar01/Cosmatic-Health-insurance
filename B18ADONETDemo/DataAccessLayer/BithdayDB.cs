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
   public class BithdayDB
    {
       public List<Friends>TodaysBirthdays()
        {
            List<Friends> friends = new List<Friends>();
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(ConfigConstant.ConnectionString);
                SqlCommand cmd = new SqlCommand(DbConstants.spTodaysBirthdays,con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
             SqlDataReader reader=   cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Friends f = new Friends();
                        f.FriendId = (int)reader["FriendId"];
                        f.Name = reader["Name"].ToString();
                        f.NickName = reader["NickName"].ToString();
                        f.Email = reader["Email"].ToString();
                        f.EmailSubject = reader["EmailSubject"].ToString();
                        f.EmailBody = reader["EmailBody"].ToString();
                        f.Mobile = reader["Mobile"].ToString();
                        f.MobileMessage= reader["MobileMessage"].ToString();

                        friends.Add(f);
                    }
                }
            }
            catch(Exception ex)
            {
                ErrorDB db = new ErrorDB();
                db.LogError(new ErrorLogs()
                {
                    FriendId = -1,
                    ErrorMessage = ex.Message ,
                    MethodName= "BithdayDB.TodaysBirthdays"
                }) ;


            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return friends;
        }
        public bool UpdateEmailWishesStatusToDB(Friends friend)
        {
            bool status = false;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConfigConstant.ConnectionString);
                SqlCommand cmd = new SqlCommand(DbConstants.spUpdateWishes, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FriendId", friend.FriendId);
                cmd.Parameters.AddWithValue("@IsEmailSent", true);
                cmd.Parameters.AddWithValue("@IsMessageSent", false);

                con.Open();
                cmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                ErrorDB db = new ErrorDB();
                db.LogError(new ErrorLogs ()
                {
                    FriendId = friend.FriendId,
                    ErrorMessage = ex.Message,
                    MethodName = "BithdayDB.UpdateEmailWishesStatusToDB"
                });
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return status;
        }
    }
}
