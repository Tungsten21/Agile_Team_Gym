using System;
using System.Collections.Generic;

namespace GymClasses
{
    public class clsTrainerCollection
    {

        //private member for the list
        List<clsTrainer> pTrainerList = new List<clsTrainer>();


        //constructor for the class

        public clsTrainerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblTrainer_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while( Index < RecordCount)
            {
                //create a blank trainer
                clsTrainer ATrainer = new clsTrainer();
                //read in the fields from the current record
                ATrainer.TrainerID = Convert.ToInt32(DB.DataTable.Rows[Index]["TrainerID"]);
                ATrainer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                ATrainer.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                ATrainer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ATrainer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ATrainer.Retrained = Convert.ToBoolean(DB.DataTable.Rows[Index]["RetrainedLastThreeYears"]);
                //add the record to private data member
                pTrainerList.Add(ATrainer);
                //point to the next record
                Index++;
            }
        }
        public List<clsTrainer> TrainerList
        {
            get
            {
                //return the property for the trainer list
                return pTrainerList;
            }
            set
            {
                //set the private data
                pTrainerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return pTrainerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsTrainer ThisTrainer { get; set; }
    }
}