using System;

namespace GymTesting
{
    public class clsSession
    {
        private int mSessionID;
        private int mTrainerID;
        private int mBranchID;
        private string mSessionType;
        private decimal mCost;
        private DateTime mDateTime;
        private bool mEquipmentRequired;

        public int SessionID
        {
            get
            {
                return mSessionID;
            }
            set
            {
                mSessionID = value;
            }
        }

        public int TrainerID
        {
            get
            {
                return mTrainerID;
            }
            set
            {
                mTrainerID = value;
            }
        }
        public int BranchID
        {
            get
            {
                return mBranchID;
            }
            set
            {
                 mBranchID = value;
            }
        }
        public String SessionType
        {
            get
            {
                return mSessionType;
            }
            set
            {
               mSessionType = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return mDateTime;
            }
            set
            {
                mDateTime = value;
            }
        }
        public Decimal Cost
        {
            get
            {
                return mCost;
            }
            set
            {
                mCost = value;
            }
        }

        public bool EquipmentRequired
        {
            get
            {
                return mEquipmentRequired;
            }
            set
            {
                mEquipmentRequired = value;
            }
        }
        public bool Find(int SessionID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SessionID", SessionID);
            DB.Execute("sproc_SessionTable_FilterBySessionID");
            if (DB.Count == 1)
            {
                mSessionID = Convert.ToInt32(DB.DataTable.Rows[0]["SessionID"]);
                mTrainerID = Convert.ToInt32(DB.DataTable.Rows[0]["TrainerID"]);
                mBranchID = Convert.ToInt32(DB.DataTable.Rows[0]["BranchID"]);
                mSessionType = Convert.ToString(DB.DataTable.Rows[0]["SessionType"]);
                mCost = Convert.ToDecimal(DB.DataTable.Rows[0]["Cost"]);
                mEquipmentRequired = Convert.ToBoolean(DB.DataTable.Rows[0]["EquipmentRequired"]);
                mDateTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DateTime"]);
                return true;
            }
            else
            {
                return false;
            }
        }
        
            public string Valid(string trainerID, string branchID, string type, string dateTime, string cost)
        { 
            String Error = "";

            DateTime DateTemp;

            if (trainerID.Length == 0)
            {
                Error = Error + "The TrainerID can not be blank : ";
            }
            if (trainerID.Length > 6)
            {
                Error = Error + "The TrainerID must be less than 6 characters : ";
            }

            if (branchID.Length == 0)
            {
                Error = Error + "The BranchID can not be blank : ";
            }
            if (branchID.Length > 6)
            {
                Error = Error + "The BranchID must be less than 6 characters : ";
            }


            try
            {
                DateTemp = Convert.ToDateTime(dateTime);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
            }

            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            if (type.Length == 0)
            {
                Error = Error + "The Type may not be blank : ";
            }
            if (type.Length > 50)
            {
                Error = Error + "The Type must be less than 50 characters : ";
            }

            return Error;

            }

    }
}

