using System;

namespace GymClasses
{
    public class clsMember
    {

        private Int32 mMemberID;
        private string mFullName;
        private string mAddress;
        private DateTime mDOB;
        private String mPhoneNumber;
        private Boolean mMedicalConditions;


        public int MemberID
        {
            get
            {
                return mMemberID;
            }
            set
            {
                mMemberID = value;
            }
        }

        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        public bool MedicalConditions
        {
            get
            {
                return mMedicalConditions;
            }
            set
            {
                mMedicalConditions = value;
            }
        }


        public bool Find(int MemberID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the MemberID to search for
            DB.AddParameter("@MemberID", MemberID);
            //execute the stored procedure
            DB.Execute("sproc_MemberTable_FilterByMemberID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data Members
                mMemberID = Convert.ToInt32(DB.DataTable.Rows[0]["MemberID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mMedicalConditions = Convert.ToBoolean(DB.DataTable.Rows[0]["MedicalConditions"]);
                //return that everything worked OK
                return true;
            }
                //if no record was found
                 else
                {
                    return false;
                }
        }


        public string Valid(string FullName, string Address, string DOB, string PhoneNumber)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DataTemp;
           
            //if the fullName is blank
            if (FullName.Length == 0)
            {
                //record the error
                Error = Error + "Please enter a full name : ";
            }
            if (FullName.Length == 1)
            {
                Error = Error + "Please enter a valid full name : ";
            }
            if (FullName.Length > 40)
            {
                Error = Error + "Please enter a full name less then 40 characters long : ";
            }
            if (!FullName.Contains(" "))
            {
                Error = Error + "Please enter a valid full name using the following format: 'Firstname Lastname' : ";
            }
            if (FullName == null || FullName == "")
            {
                Error = Error + "Please enter a full name : ";
            }
            
            try
            {
                DataTemp = Convert.ToDateTime(DOB);
                if (DataTemp < DateTime.Now.Date.AddYears(-65) || DataTemp > DateTime.Now.Date.AddYears(-18))
                {
                    Error = Error + "Please make sure the member is between 18 and 65 years old : ";
                }
            }
            catch
            {
                Error = Error + "Please enter a valid date following the correct format: yyyy/mm/dd : ";
            }

            if (Address.Length < 10)
            {
                Error = Error + "Please enter a valid address : ";
            }
            if (Address.Length > 50)
            {
                Error = Error + "Please enter an address with less then 50 characters long : ";
            }


            if (PhoneNumber.Length > 15)
            {
                Error = Error + "Please enter a valid phone number : ";
            }

            if (PhoneNumber.Length < 11)
            {
                Error = Error + "Please enter a valid phone number : ";
            }

            foreach (char c in PhoneNumber)
            {
                if (c < '0' || c > '9')
                {
                    Error = Error + "Please enter a valid phone number : ";
                }
            }
            return Error;
        }

    }
}



    