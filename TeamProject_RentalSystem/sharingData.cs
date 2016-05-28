using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Singleton Design Pattern
/// </summary>
namespace TeamProject_RentalSystem
{
    class SharingData
    {
        private static SharingData sData;
        private List<itemVO> itemList;
        private List<rentVO> rentList;

        public SharingData()
        {
            ItemList = new List<itemVO>();
            RentList = new List<rentVO>();
        }

        public static SharingData GetInstance()
        {
            if (sData == null) sData = new SharingData();
            return sData;
        }

        internal List<itemVO> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }

        internal List<rentVO> RentList
        {
            get { return rentList; }
            set { rentList = value; }
        }
    }
}
