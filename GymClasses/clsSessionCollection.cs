using GymTesting;
using System;
using System.Collections.Generic;

namespace GymClasses
{
    public class clsSessionCollection
    {

        List<clsSession> mSessionList = new List<clsSession>();
        clsSession mThisSession = new clsSession();
        public clsSessionCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_SessionTable_SelectAll");
            PopulateArray(DB);
        }

        public List<clsSession> SessionList
        {
            get
            {
                return mSessionList;
            }
            set
            {
                mSessionList = value;
            }
        }

        public int Count {
            get
            {
                return mSessionList.Count;
            }
            set
            {
            }
        }
        public clsSession ThisSession
        {
            get
            {
                return mThisSession;
            }
            set
            {
                mThisSession = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TrainerID", mThisSession.TrainerID);
            DB.AddParameter("@BranchID", mThisSession.BranchID);
            DB.AddParameter("@SessionType", mThisSession.SessionType);
            DB.AddParameter("@DateTime", mThisSession.DateTime);
            DB.AddParameter("@Cost", mThisSession.Cost);
            DB.AddParameter("@EquipmentRequired", mThisSession.EquipmentRequired);
            return DB.Execute("sproc_SessionTable_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SessionID", mThisSession.SessionID);
            DB.Execute("sproc_SessionTable_Delete");
        }

        public int Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SessionID", mThisSession.SessionID);
            DB.AddParameter("@TrainerID", mThisSession.TrainerID);
            DB.AddParameter("@BranchID", mThisSession.BranchID);
            DB.AddParameter("@SessionType", mThisSession.SessionType);
            DB.AddParameter("@DateTime", mThisSession.DateTime);
            DB.AddParameter("@Cost", mThisSession.Cost);
            DB.AddParameter("@EquipmentRequired", mThisSession.EquipmentRequired);
            return DB.Execute("sproc_SessionTable_Update");
        }

        public void ReportBySessionType (string SessionType)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SessionType", SessionType);
            DB.Execute("sproc_SessionTable_FilterBySessionType");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mSessionList = new List<clsSession>();
            while (Index < RecordCount)
            {
                clsSession ASession = new clsSession();
                ASession.SessionID = Convert.ToInt32(DB.DataTable.Rows[Index]["SessionID"]);
                ASession.TrainerID = Convert.ToInt32(DB.DataTable.Rows[Index]["TrainerID"]);
                ASession.BranchID = Convert.ToInt32(DB.DataTable.Rows[Index]["BranchID"]);
                ASession.SessionType = Convert.ToString(DB.DataTable.Rows[Index]["SessionType"]);
                ASession.Cost = Convert.ToDouble(DB.DataTable.Rows[Index]["Cost"]);
                ASession.DateTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateTime"]);
                ASession.EquipmentRequired = Convert.ToBoolean(DB.DataTable.Rows[Index]["EquipmentRequired"]);
                mSessionList.Add(ASession);
                Index++;
            }
        }
    }
}
