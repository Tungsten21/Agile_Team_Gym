using System;

namespace GymClasses
{
    public class clsBranch
    {

        private Int32 mGymID;
        private string mGymCity;
        private string mGymAddress;
        private DateTime mDateOpened;
        private int mSessionCount;
        private bool mAmmenities;


        public int GymID
        {
            get
            {
                return mGymID;
            }
            set
            {
                mGymID = value;
            }
        }

        public string GymCity
        {
            get
            {
                return mGymCity;
            }
            set
            {
                mGymCity = value;
            }
        }

        public string GymAddress
        {
            get
            {
                return mGymAddress;
            }
            set
            {
                mGymAddress = value;
            }
        }

        public DateTime DateOpened
        {
            get
            {
                return mDateOpened;
            }
            set
            {
                mDateOpened = value;
            }
        }

        public int SessionCount
        {
            get
            {
                return mSessionCount;
            }
            set
            {
                mSessionCount = value;
            }
        }

        public bool Ammenities
        {
            get
            {
                return mAmmenities;
            }
            set
            {
                mAmmenities = value;
            }
        }


        public bool Find(int GymID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the GymID to search for
            DB.AddParameter("@GymID", GymID);

            DB.Execute("sproc_BranchTable_FilterByGymID");

            if (DB.Count == 1)
            {

                mGymID = Convert.ToInt32(DB.DataTable.Rows[0]["GymID"]);
                mGymCity = Convert.ToString(DB.DataTable.Rows[0]["GymCity"]);
                mGymAddress = Convert.ToString(DB.DataTable.Rows[0]["GymAddress"]);
                mDateOpened = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOpened"]);
                mSessionCount = Convert.ToInt32(DB.DataTable.Rows[0]["SessionCount"]);
                mAmmenities = Convert.ToBoolean(DB.DataTable.Rows[0]["Ammenities"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }


        public string Valid(string GymCity, string GymAddress, string DateOpened)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DataTemp;

            //if the GymCity is blank

            if (GymCity.Length == 0)
            {

                Error = Error + "Please enter a city name : ";
            }
            if (GymCity.Length == 1)
            {
                Error = Error + "Please enter a valid city name : ";
            }


            try
            {
                DataTemp = Convert.ToDateTime(DateOpened);



                if (DataTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "Please enter a valid date following the correct format: yyyy/mm/dd : ";
            }

            if (GymAddress.Length < 5)
            {
                Error = Error + "Please enter a valid Gym Post Code : ";
            }
            if (GymAddress.Length > 15)
            {
                Error = Error + "Please enter an Gym Post Code with less then 15 characters long : ";
            }

            return Error;
        }

    }
}




