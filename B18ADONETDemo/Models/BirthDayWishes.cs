using System;

namespace Models
{
    public class BirthDayWishes
    {
        public int Id { get; set; }
        public int FriendId { get; set; }
        public bool IsEmailSent { get; set; }
        public DateTime EmailSentDate { get; set; }
        public bool IsMessageSent { get; set; }
        public DateTime MessageSentDate { get; set; }

    }
}
