using System;

namespace Cape_Senior_Center_Inventory_System.DemoStuff
{
    public class UserLinkedOrgBuilder
    {
        protected string _UserGUID;
        protected string _MemberID;
        protected string _AllianceID;
        protected bool? _Is_Primary;
        protected DateTime? _Last_Update;
        protected string _Last_Update_By;
        protected DateTime? _Created_On;
        protected string _Created_By;

        private UserLinkedOrgBuilder() { }

        public static UserLinkedOrgBuilder userLinkedOrgBuilder()
        {
            return new UserLinkedOrgBuilder();
        }

        public User_Linked_Org build()
        {
            return new User_Linked_Org()
            {
                Alliance_ID = _AllianceID,
                CreateBy = _Created_By,
                User_GUID = _UserGUID,
                Member_ID = _MemberID,
                IsPrimary = _Is_Primary,
                LastUpdate = _Last_Update,
                LastUpdateBy = _Last_Update_By,
                CreatedOn = _Created_On
            };
        }

        public UserLinkedOrgBuilder User_GUID(string user_GUID)
        {
            _UserGUID = user_GUID;
            return this;
        }
        public UserLinkedOrgBuilder Member_ID(string member_ID)
        {
            _MemberID = member_ID;
            return this;
        }
        public UserLinkedOrgBuilder Alliance_ID(string alliance_ID)
        {
            _AllianceID = alliance_ID;
            return this;
        }
        public UserLinkedOrgBuilder IsPrimary(bool? isPrimary)
        {
            _Is_Primary = isPrimary;
            return this;
        }
        public UserLinkedOrgBuilder LastUpdate(DateTime? lastUpdate)
        {
            _Last_Update = lastUpdate;
            return this;
        }
        public UserLinkedOrgBuilder LastUpdateBy(string lastUpdateBy)
        {
            _Last_Update_By = lastUpdateBy;
            return this;
        }
        public UserLinkedOrgBuilder CreatedOn(DateTime? createdOn)
        {
            _Created_On = createdOn;
            return this;
        }
        public UserLinkedOrgBuilder CreateBy(string createBy)
        {
            _Created_By = createBy;
            return this;
        }
    }
}
