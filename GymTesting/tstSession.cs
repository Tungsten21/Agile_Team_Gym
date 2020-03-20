using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GymTesting
{
    [TestClass]
    public class tstSession
    {
        string trainerID = "3";
        string branchID = "2";
        string type = "Swimming";
        string cost = "5";
        string dateTime = DateTime.Now.Date.ToString();


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


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that hte result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TrianerIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable tos tore any error message 
            string Error = "";
            string trainerID = "";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that hte result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TrainerIDMin()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string trainerID = "a"; //this should be ok
                                    //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string trainerID = "aa"; //this should be ok
                                     //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string trainerID = "aaaaa"; //this should be ok
                                        //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TrainerIDMax()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string trainerID = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerIDMid()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string trainerID = "aaa"; //this should be ok
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string trainerID = "aaaaaa";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String TrainerID = "";
            TrainerID = TrainerID.PadRight(100, 'a') + " ";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message 
            string Error = "";
            string branchID = "";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that hte result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void BranchIDMin()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string branchID = "a"; //this should be ok
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string branchID = "aa"; //this should be ok
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string branchID = "aaaaa"; //this should be ok
                                       //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BranchIDMax()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string branchID = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDMid()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string branchID = "aaa"; //this should be ok
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string branchID = "aaaaaa";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String BranchID = "";
            BranchID = BranchID.PadRight(100, 'a') + " ";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

       [TestMethod]
        public void DateTimeExtremeMin()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
           //set the date totodays date
            TestDate = DateTime.Now.Date;
          //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string dateTime = TestDate.ToString();
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
               [TestMethod]
        public void DateTimeMinLessOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string dateTime = TestDate.ToString();
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateTimeMin()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
       
       [TestMethod]
       public void DateTimeExtremeMax()
       {
           //create an instance of the class we want to create
           clsSession ASession = new clsSession();
           //string variable to store any error message
           String Error = "";
           //create a variable to store the test date data
           DateTime TestDate;
           //set the date totodays date
           TestDate = DateTime.Now.Date;
           //change the date to whatever the date is plus 100 years
           TestDate = TestDate.AddYears(100);
           //convert the date variable to a string variable
           string dateTime = TestDate.ToString();
           //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateTimeInvalidData()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //set the DateTie to a non date value
            String dateTime = "this is not a date!";
           Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string type = "";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeMin()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string type = "a";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string type = "aa";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Type = "";
            Type = Type.PadRight(49, 'a');
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMax()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Type = "";
            Type = Type.PadRight(50, 'a');
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string type = "";
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeMid()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Type = "";
            Type = Type.PadRight(25, 'a');
            //invoke the method
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



    }

}