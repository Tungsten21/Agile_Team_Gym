using System;

namespace GymTesting
{
    public class clsSession
    {
        private int mSessionID;
        private int mTrainerID;
        private int mBranchID;
        private string mSessionType;
        private double mCost;
        private DateTime mDateTime;
        private bool mEquipmentRequired;

        public int SessionID
        {
            get
            {
                //this line of code sends data out of the property
                return mSessionID;
            }
            set
            {
                //this line of code allows data into the property
                mSessionID = value;
            }
        }

        public int TrainerID
        {
            get
            {
                //this line of code sends data out of the property
                return mTrainerID;
            }
            set
            {
                //this line of code allows data into the property
                mTrainerID = value;
            }
        }
        public int BranchID
        {
            get
            {
                //this line of code sends data out of the property
                return mBranchID;
            }
            set
            {
                //this line of code allows data into the property
                mBranchID = value;
            }
        }
        public String SessionType
        {
            get
            {
                //this line of code sends data out of the property
                return mSessionType;
            }
            set
            {
                //this line of code allows data into the property
                mSessionType = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                //this line of code sends data out of the property
                return mDateTime;
            }
            set
            {
                //this line of code allows data into the property
                mDateTime = value;
            }
        }
        public Double Cost
        {
            get
            {
                //this line of code sends data out of the property
                return mCost;
            }
            set
            {
                //this line of code allows data into the property
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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the SessionID to search for
            DB.AddParameter("@SessionID", SessionID);
            //execute the stored procedure
            DB.Execute("sproc_SessionTable_FilterBySessionID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //set the private data members to th test data value
                mSessionID = Convert.ToInt32(DB.DataTable.Rows[0]["SessionID"]);
                mTrainerID = Convert.ToInt32(DB.DataTable.Rows[0]["TrainerID"]);
                mBranchID = Convert.ToInt32(DB.DataTable.Rows[0]["BranchID"]);
                mSessionType = Convert.ToString(DB.DataTable.Rows[0]["SessionType"]);
                mCost = Convert.ToDouble(DB.DataTable.Rows[0]["Cost"]);
                mEquipmentRequired = Convert.ToBoolean(DB.DataTable.Rows[0]["EquipmentRequired"]);
                mDateTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DateTime"]);
                // always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a probelm
                return false;
            }
        }
        // function for th public validation method
        public string Valid(string trainerID, string branchID, string type, string dateTime, string cost)
        { //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            
            //if the TrainerID is blank
            if (trainerID.Length == 0)
            {
                //record the error
                Error = Error + "The TrainerID may not be blank : ";
            }
            //if the TrainerID is greater than 6 characters
            if (trainerID.Length > 6)
            {
                //record the error
                Error = Error + "The TrainerID must be less than 6 characters : ";
            }

            if (branchID.Length == 0)
            {
                //record the error
                Error = Error + "The branchID may not be blank : ";
            }
            //if the TrainerID is greater than 6 characters
            if (branchID.Length > 6)
            {
                //record the error
                Error = Error + "The branchID must be less than 6 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateTime);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                
            }

            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
                        //is the street blank
            if (type.Length == 0)
            {
                //record the error
                Error = Error + "The Type may not be blank : ";
            }
            //if the street is too long
            if (type.Length > 50)
            {
                //record the error
                Error = Error + "The Type must be less than 50 characters : ";
            }
            //return any error messages
            return Error;

            

        }

    }
}

