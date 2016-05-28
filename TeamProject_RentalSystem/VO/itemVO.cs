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
        private string itemNum;

        public itemVO() { }
        public itemVO(string itemNo, string itemName, string itemNum)
        {
            this.itemNo = itemNo;
            this.itemName = itemName;
            this.ItemNum = itemNum;
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

        public string ItemNum
        {
            get { return itemNum; }
            set { itemNum = value; }
        }
    }
}
