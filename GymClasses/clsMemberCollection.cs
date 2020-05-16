using System;
using System.Collections.Generic;


namespace GymClasses
{
    public class clsMemberCollection
    {

        //private member for the list
        List<clsMember> mMemberList = new List<clsMember>();
        //private data member for this Member
        clsMember mThisMember = new clsMember();

        public clsMemberCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //excecute the stored procedure
            DB.Execute("sproc_MemberTable_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public List<clsMember> MemberList
        {
            get
            {
                //return the property for the Member list
                return mMemberList;
            }
            set
            {
                //set the private data
                mMemberList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mMemberList.Count;
            }
            set
            {

            }
        }
        public clsMember ThisMember
        {
            get
            {
                //return the privata data
                return mThisMember;
            }
            set
            {
                mThisMember = value;
            }
        }
        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisMember.FullName);
            DB.AddParameter("@Address", mThisMember.Address);
            DB.AddParameter("@DOB", mThisMember.DOB);
            DB.AddParameter("@PhoneNumber", mThisMember.PhoneNumber);
            DB.AddParameter("@MedicalConditions", mThisMember.MedicalConditions);
            //exeute the query returning the primary key value
            return DB.Execute("sproc_MemberTable_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisMember
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@MemberID", mThisMember.MemberID);
            //execute the stored procedure
            DB.Execute("sproc_MemberTable_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisMember
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@MemberID", mThisMember.MemberID);
            DB.AddParameter("@FullName", mThisMember.FullName);
            DB.AddParameter("@Address", mThisMember.Address);
            DB.AddParameter("@DOB", mThisMember.DOB);
            DB.AddParameter("@PhoneNumber", mThisMember.PhoneNumber);
            DB.AddParameter("@MedicalConditions", mThisMember.MedicalConditions);
            //execute the stored procedure
            DB.Execute("sproc_Membertable_Update");
        }

        public void ReportByDOB(string DOB)
        {
            //filters the records based on the DOB
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the DOB param to the database
            DB.AddParameter("@DOB", DOB);
            //execute the store procedure
            DB.Execute("sproc_MemberTable_FilterByDOB");
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
            mMemberList = new List<clsMember>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank member
                clsMember AMember = new clsMember();
                //read in the fields from the current record
                AMember.MemberID = Convert.ToInt32(DB.DataTable.Rows[Index]["MemberID"]);
                AMember.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AMember.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AMember.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AMember.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AMember.MedicalConditions = Convert.ToBoolean(DB.DataTable.Rows[Index]["MedicalConditions"]);
                //add the record to private data member
                mMemberList.Add(AMember);
                //point to the next record
                Index++;
            }
        }
    }
}
