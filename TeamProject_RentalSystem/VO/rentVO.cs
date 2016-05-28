using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_RentalSystem
{
    class rentVO
    {
        private string rentNo;
        private string rentTime;
        private string rentId;
        private string rentNum;
        
        public rentVO() { }
        public rentVO(string rentNo, string rentTime, string rentId, string rentNum)
        {
            this.rentNo = rentNo;
            this.rentTime = rentTime;
            this.rentId = rentId;
            this.RentNum = rentNum;
        }

        public string RentNo
        {
            get { return rentNo; }
            set { rentNo = value; }
        }

        public string RentTime
        {
            get { return rentTime; }
            set { rentTime = value; }
        }

        public string RentId
        {
            get { return rentId; }
            set { rentId = value; }
        }

        public string RentNum
        {
            get { return rentNum; }
            set { rentNum = value; }
        }
    }
}
