﻿using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GymTesting
{
    [TestClass]
    public class tstSession
    {


        [TestMethod]
        public void InstanceOK()
        {
            clsSession ASession = new clsSession();
            Assert.IsNotNull(ASession);

        }
        [TestMethod]
        public void EquipmentRequiredPropertyOK()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //create the test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ASession.EquipmentRequired = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASession.EquipmentRequired, TestData);
        }
        [TestMethod]
        public void DateTimePropertyOK()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ASession.DateTime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASession.DateTime, TestData);
        }
        [TestMethod]
        public void SessionIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //create some test data to assign to the property
            int TestID = 1;
            //assign the data to the property
            ASession.SessionID = TestID;
            //test to see that the two values are the same
            Assert.AreEqual(ASession.SessionID, TestID);
        }

        [TestMethod]
        public void TrainerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsTrainer ATrainer = new clsTrainer();
            //create some test data to assign to the property
            int testID = 2;
            //assign the data to the property
            ATrainer.TrainerID = testID;
            //test to see that the two values are the same
            Assert.AreEqual(ATrainer.TrainerID, testID);
        }
        [TestMethod]
        public void TypePropertyOK()
        {
            clsSession ASession = new clsSession();
            string type = "Swimming";
            ASession.SessionType = type;
            Assert.AreEqual(ASession.SessionType, type);
        }


        [TestMethod]
        public void CostPropertyOK()
        {
            clsSession ASession = new clsSession();
            Double cost = 0.0;
            ASession.Cost = cost;
            Assert.AreEqual(ASession.Cost, cost);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //boolean variable to store the result of the validaiton
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SessionID = 4;
            //invoke the method
            Found = ASession.Find(SessionID);
            //test to see th the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestSessionIDFound()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SessionID = 4;
            //invoke the method
            Found = ASession.Find(SessionID);
            //check the Session ID
            if (ASession.SessionID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTrainerIDFound()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SessionID = 4;
            //invoke the method
            Found = ASession.Find(SessionID);
            //check the Session ID
            if (ASession.TrainerID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBranchIDFound()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SessionID = 4;
            //invoke the method
            Found = ASession.Find(SessionID);
            //check the Session ID
            if (ASession.BranchID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSessionTypeFound()
        {
            clsSession ASession = new clsSession();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SessionID = 4;
            Found = ASession.Find(SessionID);
            if (ASession.SessionType != "Swimming")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCostFound()
        {
        //create an instance of the class we want to create
                 clsSession ASession = new clsSession();
        //boolean variable to store the result of the search
               Boolean Found = false;
        //boolean variable to record if data is OK(assume it is)
              Boolean OK = true;
            //create some test data to use with the method
            Int32 SessionID = 4;
            //invoke the method
            Found = ASession.Find(SessionID);
        //check the Session ID
             if (ASession.Cost != Convert.ToDouble(3))
             {
                 OK = false;
             }
            Assert.IsTrue(OK);
        }

[TestMethod]
        public void TestDateTimeFound()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SessionID = 4;
            //invoke the method
            Found = ASession.Find(SessionID);
            //check the property
            if (ASession.DateTime != Convert.ToDateTime("03/04/2020 04:43:23"))
            {
                OK = false;
            }
            //test ot see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEquipmenRequiedFound()
        {
            clsSession ASession = new clsSession();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SessionID = 4;
            Found = ASession.Find(SessionID);
            if (ASession.EquipmentRequired != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }

}