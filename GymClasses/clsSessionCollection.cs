using GymTesting;
using System;
using System.Collections.Generic;

namespace GymClasses
{
    public class clsSessionCollection
    {

        List<clsSession> mSessionList = new List<clsSession>();
        

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
        public clsSession ThisSession { get; set; }

       
        public clsSessionCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_SessionTable_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsSession ASession = new clsSession();
                ASession.SessionID = Convert.ToInt32(DB.DataTable.Rows[0]["SessionID"]);
                ASession.TrainerID = Convert.ToInt32(DB.DataTable.Rows[0]["TrainerID"]);
                ASession.BranchID = Convert.ToInt32(DB.DataTable.Rows[0]["BranchID"]);
                ASession.SessionType = Convert.ToString(DB.DataTable.Rows[0]["SessionType"]);
                ASession.Cost = Convert.ToDouble(DB.DataTable.Rows[0]["Cost"]);
                ASession.DateTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DateTime"]);
                ASession.EquipmentRequired = Convert.ToBoolean(DB.DataTable.Rows[0]["EquipmentRequired"]);
                mSessionList.Add(ASession);
                Index++;
            }
        }

    }
    }
