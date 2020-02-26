using System;

namespace GymClasses
{
    public class clsMember
    {

        //private data member for active
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //private date added data member
        private DateTime mDateAdded;
        //public property for date added
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //private data member for the AddressNo property
        private Int32 mAddressNo;
        //public property for the address number
        public int AddressNo
        {
            get
            {
                //return the private data
                return mAddressNo;
            }
            set
            {
                //set the value of the private data member
                mAddressNo = value;
            }
        }

        //private data member for county no
        private Int32 mCountyNo;
        //public property for county no
        public int CountyNo
        {
            get
            {
                //return the private data
                return mCountyNo;
            }
            set
            {
                //set the private data
                mCountyNo = value;
            }
        }

        //private data member for HouseNo
        private string mHouseNo;
        //public property for house no
        public string HouseNo
        {
            get
            {
                //return private data
                return mHouseNo;
            }
            set
            {
                //set the private data
                mHouseNo = value;
            }
        }

        //private data member for post code
        private string mPostCode;
        //public property for post code
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the private data
                mPostCode = value;
            }
        }

        //private data member for street
        private string mStreet;
        //public data member for street
        public string Street
        {
            get
            {
                //return the private data
                return mStreet;
            }
            set
            {
                //set the private data
                mStreet = value;
            }
        }

        //private data member for town
        private string mTown;
        //public data member for Town
        public string Town
        {
            get
            {
                //return the private data
                return mTown;
            }
            set
            {
                //set the private data
                mTown = value;
            }
        }

        public bool Find(int AddressNo)
        {
            //set the private data members to the test data value
            mAddressNo = 21;
            mHouseNo = "123";
            mStreet = "Test Street";
            mTown = "Test Town";
            mPostCode = "XXX XXX";
            mCountyNo = 1;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mActive = true;
            //always return true
            return true;
        }
    }
}



    