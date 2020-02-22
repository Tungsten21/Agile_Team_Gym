using System;

namespace GymClasses
{
    public class clsTrainer
    {
        //trainerID private admin variable
        private Int32 pTrainerID;
        private string pFullname;
        private string pGender;
        private string pEmailAddress;
        private DateTime pDateOfBirth;
        private Boolean pRetrianed;
        

        //trainerID public property
        public int TrainerID
        {
            get
            {
                //this line of code sends data out of the property
                return pTrainerID;
            }
            set
            {
                //this line of coe allows data into the property
                pTrainerID = value;
            }
        }
        public string FullName
        {
            get
            {
                return pFullname;
            }
            set
            {
                pFullname = value;
            }
        }
        public string Gender
        {
            get
            {
                return pGender;
            }
            set
            {
                pGender = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return pEmailAddress;
            }
            set
            {
                pEmailAddress = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return pDateOfBirth;
            }
            set
            {
                pDateOfBirth = value;
            }
        }
        public bool Retrained
        {
            get
            {
                return pRetrianed;
            }
            set
            {
                pRetrianed = value;
            }
        }

        public bool Find(int testTrainerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the TrainerID to search for
            DB.AddParameter("@Trainer", TrainerID);
            //execute the stored procedure
            DB.Execute("sproc_tblTrainer_FilterByTrainerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data Trainers
                pTrainerID = Convert.ToInt32(DB.DataTable.Rows[0]["TrainerID"]);
                pFullname = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                pGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                pDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                pEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                pRetrianed = Convert.ToBoolean(DB.DataTable.Rows[0]["RetrainedLastThreeYears"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a probelm
                return false;
            }
        }
    }
} 