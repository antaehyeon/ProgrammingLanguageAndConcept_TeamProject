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
    }
}
