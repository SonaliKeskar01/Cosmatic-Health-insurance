using System;

namespace Models
{
    public class ErrorLogs
    {
        public int LogId { get; set; }
        public int FriendId { get; set; }
        public string ErrorMessage { get; set; }
        public string MethodName { get; set; }

        public DateTime  ErrorDateTime { get; set; }

    }
}
