using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_RentalSystem
{
    class itemVO
    {
        private string itemNo;
        private string itemName;

        public itemVO(string itemNo, string itemName)
        {
            this.itemNo = itemNo;
            this.itemName = itemName;
        }

        public string ItemNo
        {
            get { return itemNo; }
            set { itemNo = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
    }
}
