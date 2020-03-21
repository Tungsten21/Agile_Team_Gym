using System;
using System.Collections.Generic;

namespace GymClasses
{
    public class clsTrainerCollection
    {

        //private member for the list
        List<clsTrainer> pTrainerList = new List<clsTrainer>();
        //private data member for thisTrainer
        clsTrainer pThisTrainer = new clsTrainer();




        //constructor for the class

        public clsTrainerCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //excecute the stored procedure
            DB.Execute("sproc_tblTrainer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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
        public clsTrainer ThisTrainer
        {
            get
            {
                //return the privata data
                return pThisTrainer;
            }
            set
            {
                pThisTrainer = value;
            }
        }
        public int Add()
        {
            //adds a new record to the database based on the valuees of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FullName", pThisTrainer.FullName);
            DB.AddParameter("@Gender", pThisTrainer.Gender);
            DB.AddParameter("@DateOfBirth", pThisTrainer.DateOfBirth);
            DB.AddParameter("@RetrainedLastThreeYears", pThisTrainer.Retrained);
            DB.AddParameter("@EmailAddress", pThisTrainer.EmailAddress);
            //exeute the query returning the primary key value
            return DB.Execute("sproc_tblTrainer_Insert");


        }

        public void Delete()
        {
            //deletes the record pointed to by thisTrainer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@TrainerID", pThisTrainer.TrainerID);
            //execute the stored procedure
            DB.Execute("sproc_tblTrainer_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisTrainer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@TrainerID", pThisTrainer.TrainerID);
            DB.AddParameter("@FullName", pThisTrainer.FullName);
            DB.AddParameter("@Gender", pThisTrainer.Gender);
            DB.AddParameter("@DateOfBirth", pThisTrainer.DateOfBirth);
            DB.AddParameter("@RetrainedLastThreeYears", pThisTrainer.Retrained);
            DB.AddParameter("@EmailAddress", pThisTrainer.EmailAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblTrainer_Update");
        }

        public void ReportByGender(string Gender)
        {
            //filters the records based on gender
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the gender param to the database
            DB.AddParameter("@Gender", Gender);
            //execute the store procedure
            DB.Execute("sproc_tblTrainer_FilterByGender");
            //poplulate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index = 0;
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            pTrainerList = new List<clsTrainer>();
            //while there are records to process
            while (Index < RecordCount)
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
    }
}