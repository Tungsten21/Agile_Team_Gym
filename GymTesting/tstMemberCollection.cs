using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GymClasses;

namespace GymTesting
{
    [TestClass]
    public class tstMemberCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsMemberCollection AllMembers = new clsMemberCollection();
            //test to see that it exists
            Assert.IsNotNull(AllMembers);
        }

        [TestMethod]
        public void MemberListOK()
        {
            //create an instance of the class we want to create
            clsMemberCollection AllMembers = new clsMemberCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsMember> Test = new List<clsMember>();
            //add an item to the liste
            //create the item of test data
            clsMember Test1 = new clsMember();
            //set its properites
            Test1.FullName = "Sofyan Koultouma";
            Test1.Address = "1 Leicester Road";
            Test1.PhoneNumber = "07856681247";
            Test1.DOB = DateTime.Parse("1998/07/08");
            Test1.MemberID = 10;
            Test1.MedicalConditions = false;
            //add the item to the test list
            Test.Add(Test1);
            //asign the data to the property
            AllMembers.MemberList = Test;
            //test to see that the wo values are the same
            Assert.AreEqual(AllMembers.MemberList, Test);
        }

        [TestMethod]
        public void ThisMemberPropertyOK()
        {
            //create an instance of the class we want to create
            clsMemberCollection Test = new clsMemberCollection();
            //create some test data to assign to the property
            clsMember Test1 = new clsMember();
            //set the properties of the test object
            Test1.FullName = "Sofyan Koultouma";
            Test1.Address = "1 Leicester Road";
            Test1.PhoneNumber = "07856681247";
            Test1.DOB = DateTime.Parse("1998/07/08");
            Test1.MemberID = 10;
            Test1.MedicalConditions = false;
            //asign the data to the property
            Test.ThisMember = Test1;
            //test to see that the two values are the same
            Assert.AreEqual(Test.ThisMember, Test1);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsMemberCollection AllMembers = new clsMemberCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsMember> Test = new List<clsMember>();
            //add an item to the list
            //create the item of test data
            clsMember Test1 = new clsMember();
            //set the properties of the test object
            Test1.FullName = "Sofyan Koultouma";
            Test1.Address = "1 Leicester Road";
            Test1.PhoneNumber = "07856681247";
            Test1.DOB = DateTime.Parse("1998/07/08");
            Test1.MemberID = 10;
            Test1.MedicalConditions = false;
            //add the item to the test list
            Test.Add(Test1);
            //asign the data to the property
            AllMembers.MemberList = Test;
            //test to see that the wo values are the same
            Assert.AreEqual(AllMembers.Count, Test.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsMemberCollection AllMembers = new clsMemberCollection();
            //create the item of test data
            clsMember Test1 = new clsMember();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            Test1.FullName = "Sofyan Koultouma";
            Test1.Address = "1 Leicester Road";
            Test1.PhoneNumber = "07856681247";
            Test1.DOB = DateTime.Parse("1988/07/08");
            Test1.MemberID = 20;
            Test1.MedicalConditions = true;
            //set ThisAddress to the test data
            AllMembers.ThisMember = Test1;
            //add the record
            PrimaryKey = AllMembers.Add();
            //set the primary key to the test data
            Test1.MemberID = PrimaryKey;
            //find the record
            AllMembers.ThisMember.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllMembers.ThisMember, Test1);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsMemberCollection AllMembers = new clsMemberCollection();
            //create an item of test data
            clsMember Test1 = new clsMember();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            Test1.FullName = "Sofyan Koultouma";
            Test1.Address = "1 Leicester Road";
            Test1.PhoneNumber = "07856681247";
            Test1.DOB = DateTime.Parse("1988/07/08");
            Test1.MemberID = 20;
            Test1.MedicalConditions = true;
            //set ThisMember to the test data
            AllMembers.ThisMember = Test1;
            //add the record
            PrimaryKey = AllMembers.Add();
            //set the primary key of the test data
            Test1.MemberID = PrimaryKey;
            //find the record
            AllMembers.ThisMember.Find(PrimaryKey);
            //delete the record
            AllMembers.Delete();
            //now find the record
            Boolean Found = AllMembers.ThisMember.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsMemberCollection AllMembers = new clsMemberCollection();
            //create an item of test data
            clsMember Test1 = new clsMember();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            Test1.FullName = "Sofyan Ronaldo";
            Test1.Address = "1 Leicester Road";
            Test1.PhoneNumber = "07745984535";
            Test1.DOB = DateTime.Parse("1988/07/08");
            Test1.MedicalConditions = true;
            //set ThisMember to the test data
            AllMembers.ThisMember = Test1;
            //set the primary key of the test data
            PrimaryKey = AllMembers.Add();
            //set the primary key of the test data
            Test1.MemberID = PrimaryKey;
            //modify the test data
            Test1.FullName = "Cristiano Ronaldo";
            Test1.Address = "1 London Road";
            Test1.PhoneNumber = "07405610874";
            Test1.DOB = DateTime.Parse("1978/07/08");
            Test1.MedicalConditions = true;
            //set the record based on the new test data
            AllMembers.ThisMember = Test1;
            //update the record
            AllMembers.Update();
            //fimd the record
            AllMembers.ThisMember.Find(PrimaryKey);
            //test to see ThisMember matches the test data
            Assert.AreEqual(AllMembers.ThisMember, Test1);
            //
        }

        [TestMethod]
        public void ReportByDOBMethodOK()
        {
            //create an instance of the class containing unflitered results
            clsMemberCollection AllMembers = new clsMemberCollection();
            //create  an instance of the filtered data
            clsMemberCollection FilteredMembers = new clsMemberCollection();
            //apply a blank string (should return all records)
            FilteredMembers.ReportByDOB("");
            Assert.AreEqual(AllMembers.Count, FilteredMembers.Count);
        }

        [TestMethod]
        public void ReportByDOBNoneFound()
        {
            //create an instance of the filtered data
            clsMemberCollection FilteredMembers = new clsMemberCollection();
            //apply a DOB that doesnt exist
            FilteredMembers.ReportByDOB("2001/01/01");
            //test to see that that there are no records
            Assert.AreEqual(0, FilteredMembers.Count);

        }

        [TestMethod]
        public void ReportByDOBFound()
        {
            //create an instance of the filtered data
            clsMemberCollection FilteredMembers = new clsMemberCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a DOB that doesn't exist (but is in the database)
            FilteredMembers.ReportByDOB("1990-03-05");
            //check that the correct number of records are found
            if (FilteredMembers.Count == 2)
            {
                //check that the first record ID is 4
                if (FilteredMembers.MemberList[0].MemberID != 4)
                {
                    OK = false;
                }
                //check that the second record ID is 5
                if (FilteredMembers.MemberList[1].MemberID != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to to see the correct amount of records were shown
            Assert.IsTrue(OK);


        }
    }
}
