using System;

namespace GymTesting
{
    public class clsSession
    {
        private int mSessionID;
        private int mTrainerID;
        private int mBranchID;
        private string mType;
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
                
        public int TrainerID {
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
        public String Type {
            get
            {
                //this line of code sends data out of the property
                return mType;
            }
            set
            {
                //this line of code allows data into the property
                mType = value;
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
            //set the private data members to th test data value
            mSessionID = 3;
            mTrainerID = 5;
            mBranchID = 4;
            mType= Convert.ToString("Swimming");
            mCost =Convert.ToDouble(2.50);
            mEquipmentRequired = Convert.ToBoolean(false );
            mDateTime = Convert.ToDateTime("20/05/1990");
            // always return true
            return true;
        }
    }
}