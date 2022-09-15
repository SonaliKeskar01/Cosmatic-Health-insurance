using System;


namespace Models.Account
{
    public class UserType
    {

        public int UserTypeId { get; set; }
        public Guid UserTypeGuid { get; set; }
        public string UserTypeName { get; set; }

        public override string ToString()
        {
            return UserTypeName;
        }
    }
}
