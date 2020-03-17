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

       
    }
}
