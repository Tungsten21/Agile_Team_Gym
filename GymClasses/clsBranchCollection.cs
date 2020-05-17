using System;
using System.Collections.Generic;


namespace GymClasses
{
    public class clsBranchCollection
    {

        
        List<clsBranch> mBranchList = new List<clsBranch>();
        
        clsBranch mThisBranch = new clsBranch();

        public clsBranchCollection()
        {
           
            clsDataConnection DB = new clsDataConnection();
            
            DB.Execute("sproc_BranchTable_SelectAll");
            
            PopulateArray(DB);
        }
        public List<clsBranch> BranchList
        {
            get
            {
                
                return mBranchList;
            }
            set
            {
              
                mBranchList = value;
            }
        }
        public int Count
        {
            get
            {
                return mBranchList.Count;
            }
            set
            {

            }
        }
        public clsBranch ThisBranch
        {
            get
            {
               
                return mThisBranch;
            }
            set
            {
                mThisBranch = value;
            }
        }
        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@GymCity", mThisBranch.GymCity);
            DB.AddParameter("@GymAddress", mThisBranch.GymAddress);
            DB.AddParameter("@DateOpened", mThisBranch.DateOpened);
            DB.AddParameter("@SessionCount", mThisBranch.SessionCount);
            DB.AddParameter("@Ammenities", mThisBranch.Ammenities);
            
            return DB.Execute("sproc_BranchTable_Insert");
        }

        public void Delete()
        {

            
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("@GymID", mThisBranch.GymID);
           
            DB.Execute("sproc_BranchTable_Delete");
        }

        public void Update()
        {
           
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@GymID", mThisBranch.GymID);
            DB.AddParameter("@GymCity", mThisBranch.GymCity);
            DB.AddParameter("@GymAddress", mThisBranch.GymAddress);
            DB.AddParameter("@DateOpened", mThisBranch.DateOpened);
            DB.AddParameter("@SessionCount", mThisBranch.SessionCount);
            DB.AddParameter("@Ammenities", mThisBranch.Ammenities);
            
            DB.Execute("sproc_Branchtable_Update");
        }

        public void ReportByDateOpened(string DateOpened)
        {
            
            clsDataConnection DB = new clsDataConnection();
           
            DB.AddParameter("@DateOpened", DateOpened);
   
            DB.Execute("sproc_BranchTable_FilterByDateOpened");
          
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {

            Int32 Index = 0;
           
            Int32 RecordCount;
            
            RecordCount = DB.Count;
           
            mBranchList = new List<clsBranch>();
        
            while (Index < RecordCount)
            {
                //create a blank Branch
                clsBranch ABranch = new clsBranch();
                
                ABranch.GymID = Convert.ToInt32(DB.DataTable.Rows[Index]["GymhID"]);
                ABranch.GymCity = Convert.ToString(DB.DataTable.Rows[Index]["GymCity"]);
                ABranch.GymAddress = Convert.ToString(DB.DataTable.Rows[Index]["GymAddress"]);
                ABranch.DateOpened = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOpened"]);
                ABranch.SessionCount = Convert.ToInt32(DB.DataTable.Rows[Index]["SessionCount"]);
                ABranch.Ammenties = Convert.ToBoolean(DB.DataTable.Rows[Index]["Ammenties"]);

                mBranchList.Add(ABranch);
                
                Index++;
            }
        }
    }
}

