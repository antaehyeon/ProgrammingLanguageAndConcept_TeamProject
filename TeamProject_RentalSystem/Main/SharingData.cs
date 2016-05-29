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
        private List<AccountVO> accountList;

        // 로그인 화면에서 파일을 한번만 써주기 위한 체크값
        private bool loginWriteCheck = false;

        // 대여 쪽 데이터
        // 대여할 때 입력하는 갯수 데이터
        private string inputNumData;

        // 현재 로그인 한 ID
        private string currentId;

        public SharingData()
        {
            ItemList = new List<itemVO>();
            RentList = new List<rentVO>();
            accountList = new List<AccountVO>();

            inputNumData = "";
            CurrentId = "";
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

        internal List<AccountVO> AccountList
        {
            get { return accountList; }
            set {  accountList = value; }
        }

        public string InputNumData
        {
            get { return inputNumData; }
            set { inputNumData = value; }
        }

        public string CurrentId
        {
            get { return currentId; }
            set { currentId = value; }
        }

        public bool LoginWriteCheck
        {
            get { return loginWriteCheck; }
            set { loginWriteCheck = value; }
        }
    }
}
