using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GymClasses;
using System.Collections.Generic;

namespace GymTesting
{
    [TestClass]
    public class tstSessionCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an istance of the class we want to create
            clsSessionCollection AllSession = new clsSessionCollection();
            //test to see that it exists
            Assert.IsNotNull(AllSession);
        }

        [TestMethod]
        public void SessionListOK()
        {
            //create an instance of the class we want to create
            clsSessionCollection AllSession = new clsSessionCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSession> TestList = new List<clsSession>();
            //add an item to the list
            //create the item of test data
            clsSession TestItem = new clsSession();
            //set its properties
            TestItem.EquipmentRequired = false;
            TestItem.SessionID = 1;
            TestItem.SessionType = "Swimming";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.TrainerID = 4;
            TestItem.BranchID = 3;
            TestItem.Cost = 5;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSession.SessionList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSession.SessionList, TestList);
        }
    }
}
