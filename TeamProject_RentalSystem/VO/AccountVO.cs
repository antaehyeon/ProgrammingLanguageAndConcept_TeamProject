﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_RentalSystem
{
    class AccountVO
    {
        private string userId;
        private string userPw;
        private string accessLevel;
        private string phoneNum;

        public AccountVO() { }
        public AccountVO(string userId, string userPw, string accessLevel, string phoneNum)
        {
            this.userId = userId;
            this.userPw = userPw;
            this.accessLevel = accessLevel;
            this.phoneNum = phoneNum;
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string UserPw
        {
            get { return userPw; }
            set { userPw = value; }
        }

        public string AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; }
        }

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
    }
}
