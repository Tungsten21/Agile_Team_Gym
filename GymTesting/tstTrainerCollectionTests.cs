using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GymClasses;
using System.Collections.Generic;

namespace GymTesting
{
    [TestClass]
    public class tstTrainerCollectionTests
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsTrainerCollection AllTrainers = new clsTrainerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllTrainers);
        }

        [TestMethod]
        public void TrainerListOK()
        {
            //create an instance of the class we want to create
            clsTrainerCollection AllTrainers = new clsTrainerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsTrainer> TestList = new List<clsTrainer>();
            //add an item to the list
            //create the item of test data
            clsTrainer TestItem = new clsTrainer();
            //set its properites
            TestItem.FullName = "Ross O'Donegan";
            TestItem.Gender = "Male";
            TestItem.EmailAddress = "rodonegan11@gmail.com";
            TestItem.DateOfBirth = DateTime.Parse("20/05/1999");
            TestItem.TrainerID = 20;
            TestItem.Retrained = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllTrainers.TrainerList = TestList;
            //test to see that the wo values are the same
            Assert.AreEqual(AllTrainers.TrainerList, TestList);
        }

        [TestMethod]
        public void ThisTrainerPropertyOK()
        {
            //create an instance of the class we want to create
            clsTrainerCollection TestList = new clsTrainerCollection();
            //create some test data to assign to the property
            clsTrainer TestItem = new clsTrainer();
            //set the properties of the test object
            TestItem.FullName = "Ross O'Donegan";
            TestItem.Gender = "Male";
            TestItem.EmailAddress = "rodonegan11@gmail.com";
            TestItem.DateOfBirth = DateTime.Parse("20/05/1999");
            TestItem.TrainerID = 20;
            TestItem.Retrained = false;
            //asign the data to the property
            TestList.ThisTrainer = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(TestList.ThisTrainer, TestItem);
                
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsTrainerCollection AllTrainers = new clsTrainerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsTrainer> TestList = new List<clsTrainer>();
            //add an item to the list
            //create the item of test data
            clsTrainer TestItem = new clsTrainer();
            //set its properites
            TestItem.FullName = "Ross O'Donegan";
            TestItem.Gender = "Male";
            TestItem.EmailAddress = "rodonegan11@gmail.com";
            TestItem.DateOfBirth = DateTime.Parse("20/05/1999");
            TestItem.TrainerID = 20;
            TestItem.Retrained = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllTrainers.TrainerList = TestList;
            //test to see that the wo values are the same
            Assert.AreEqual(AllTrainers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsTrainerCollection AllTrainers = new clsTrainerCollection();
            //create the item of test data
            clsTrainer TestItem = new clsTrainer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TrainerID = 44;
            TestItem.FullName = "Ross O'Donegan";
            TestItem.EmailAddress = "rodonegan11@gmail.com";
            TestItem.Gender = "Male";
            TestItem.Retrained = true;
            TestItem.DateOfBirth = DateTime.Parse("17/05/2000");
            //set ThisAddress to the test data
            AllTrainers.ThisTrainer = TestItem;
            //add the record
            PrimaryKey = AllTrainers.Add();
            //set the primary key to the test data
            TestItem.TrainerID = PrimaryKey;
            //find the record
            AllTrainers.ThisTrainer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllTrainers.ThisTrainer, TestItem);
            

        }
        
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsTrainerCollection AllTrainers = new clsTrainerCollection();
            //create an item of test data
            clsTrainer TestItem = new clsTrainer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TrainerID = 44;
            TestItem.FullName = "Ross O'Donegan";
            TestItem.EmailAddress = "rodonegan11@gmail.com";
            TestItem.Gender = "Male";
            TestItem.Retrained = true;
            TestItem.DateOfBirth = DateTime.Parse("17/05/2000");
            //set ThisTrainer to the test data
            AllTrainers.ThisTrainer = TestItem;
            //add the record
            PrimaryKey = AllTrainers.Add();
            //set the primary key of the test data
            TestItem.TrainerID = PrimaryKey;
            //find the record
            AllTrainers.ThisTrainer.Find(PrimaryKey);
            //delete the record
            AllTrainers.Delete();
            //now find the record
            Boolean Found = AllTrainers.ThisTrainer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsTrainerCollection AllTrainers = new clsTrainerCollection();
            //create an item of test data
            clsTrainer TestItem = new clsTrainer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.FullName = "Ross O'DoneganUPDATE";
            TestItem.EmailAddress = "rodonegan11@gmail.com";
            TestItem.Gender = "Male";
            TestItem.Retrained = true;
            TestItem.DateOfBirth = DateTime.Parse("17/05/2000");
            //set ThisTrainer to the test data
            AllTrainers.ThisTrainer = TestItem;
            //set the primary key of the test data
            PrimaryKey = AllTrainers.Add();
            //set the primary key of the test data
            TestItem.TrainerID = PrimaryKey;
            //modify the test data
            TestItem.FullName = "2Ross O'DoneganUPDATE";
            TestItem.EmailAddress = "2rodonegan11@gmail.com";
            TestItem.Gender = "Female";
            TestItem.Retrained = true;
            TestItem.DateOfBirth = DateTime.Parse("27/05/2000");
            //set the record based on the new test data
            AllTrainers.ThisTrainer = TestItem;
            //update the record
            AllTrainers.Update();
            //fimd the record
            AllTrainers.ThisTrainer.Find(PrimaryKey);
            //test to see ThisTrainer matches the test data
            Assert.AreEqual(AllTrainers.ThisTrainer, TestItem);
            //
        }

        //No longer needed report method works

        [TestMethod]
        public void ReportByGenderMethodOK()
        {
            //create an instance of the class containing unflitered results
            clsTrainerCollection AllTrainers = new clsTrainerCollection();
            //create  an instance of the filtered data
            clsTrainerCollection FilteredTrainers = new clsTrainerCollection();
            //apply a blank string (should return all records)
            FilteredTrainers.ReportByGender("");
            Assert.AreEqual(AllTrainers.Count, FilteredTrainers.Count);
        }

        [TestMethod]
        public void ReportByGenderNoneFound()
        {
            //create an instance of the filtered data
            clsTrainerCollection FilteredTrainers = new clsTrainerCollection();
            //apply a gender that doesnt exist
            FilteredTrainers.ReportByGender("Hello");
            //test to see that that there are no records
            Assert.AreEqual(0, FilteredTrainers.Count);
            
        }

        [TestMethod]
        public void ReportByGenderFound()
        {
            //create an instance of the filtered data
            clsTrainerCollection FilteredTrainers = new clsTrainerCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a gender that doesn't exist (but is in the database)
            FilteredTrainers.ReportByGender("TEST");
            //check that the correct number of records are found
            if(FilteredTrainers.Count == 2)
            {
                //check that the first record ID is 58
                if(FilteredTrainers.TrainerList[0].TrainerID != 58)
                {
                    OK = false;
                }
                //check that the second record ID is 59
                if (FilteredTrainers.TrainerList[1].TrainerID != 59)
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
