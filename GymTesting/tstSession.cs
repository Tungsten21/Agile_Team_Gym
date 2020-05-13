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
        string sessionType = "Swimming";
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
            clsSession ASession = new clsSession();
            Boolean TestData = true;
            ASession.EquipmentRequired = TestData;
            Assert.AreEqual(ASession.EquipmentRequired, TestData);
        }

        [TestMethod]
        public void DateTimePropertyOK()
        {
            clsSession ASession = new clsSession();
            DateTime TestData = DateTime.Now.Date;
            ASession.DateTime = TestData;
            Assert.AreEqual(ASession.DateTime, TestData);
        }
        [TestMethod]
        public void SessionIDPropertyOK()
        {
            clsSession ASession = new clsSession();
            int TestData = 4;
            ASession.SessionID = TestData;
            Assert.AreEqual(ASession.SessionID, TestData);
        }

        [TestMethod]
        public void TrainerIDPropertyOK()
        {
            clsSession ASession = new clsSession();
            int TestData = 3;
            ASession.TrainerID = TestData;
            Assert.AreEqual(ASession.TrainerID, TestData);
        }
        [TestMethod]
        public void BranchIDPropertyOK()
        {
            clsSession ASession = new clsSession();
            int TestData = 2;
            ASession.BranchID = TestData;
            Assert.AreEqual(ASession.BranchID, TestData);
        }
        [TestMethod]
        public void TypePropertyOK()
        {
            clsSession ASession = new clsSession();
            string TestData = "Swimming";
            ASession.SessionType = TestData;
            Assert.AreEqual(ASession.SessionType, TestData);
        }


        [TestMethod]
        public void CostPropertyOK()
        {
            clsSession ASession = new clsSession();
            Decimal TestData = 0;
            ASession.Cost = TestData;
            Assert.AreEqual(ASession.Cost, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsSession ASession = new clsSession();
            Boolean Found = false;
            Int32 SessionID = 4;
            Found = ASession.Find(SessionID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestSessionIDFound()
        {
            clsSession ASession = new clsSession();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SessionID = 4;
            Found = ASession.Find(SessionID);
            if (ASession.SessionID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTrainerIDFound()
        {
            clsSession ASession = new clsSession();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SessionID = 4;
            Found = ASession.Find(SessionID);
            if (ASession.TrainerID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBranchIDFound()
        {
            clsSession ASession = new clsSession();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SessionID = 4;
            Found = ASession.Find(SessionID);
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
            clsSession ASession = new clsSession();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SessionID = 4;
            Found = ASession.Find(SessionID);
            if (ASession.Cost != Convert.ToDecimal(3))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateTimeFound()
        {
            clsSession ASession = new clsSession();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SessionID = 4;
            Found = ASession.Find(SessionID);
           if (ASession.DateTime != Convert.ToDateTime("03/05/2020 00:00:00"))
            {
                OK = false;
            }
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
            clsSession ASession = new clsSession();
            String Error = "";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TrianerIDMinLessOne()
        {
            clsSession ASession = new clsSession();
            string Error = "";
            string trainerID = "";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TrainerIDMin()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string trainerID = "a"; 
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerIDMinPlusOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string trainerID = "aa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerIDMaxLessOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string trainerID = "aaaaa"; 
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TrainerIDMax()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string trainerID = "aaaaaa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerIDMid()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string trainerID = "aaa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrainerIDMaxPlusOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string trainerID = "aaaaaaa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TrainerIDExtremeMax()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            String TrainerID = "";
            trainerID = TrainerID.PadRight(10, 'a') + "";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
           Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDMinLessOne()
        {
            clsSession ASession = new clsSession();
            string Error = "";
            string branchID = "";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void BranchIDMin()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string branchID = "a";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDMinPlusOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string branchID = "aa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDMaxLessOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string branchID = "aaaaa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BranchIDMax()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string branchID = "aaaaaa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDMid()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string branchID = "aaa"; 
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDMaxPlusOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string branchID = "aaaaaaa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BranchIDExtremeMax()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            String BranchID = "";
            branchID = BranchID.PadRight(50, 'a') + "";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }

       [TestMethod]
        public void DateTimeExtremeMin()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string dateTime = TestDate.ToString();
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }
               [TestMethod]
        public void DateTimeMinLessOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string dateTime = TestDate.ToString();
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateTimeMin()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }
        // the date for a session has to be in the future.

        //       [TestMethod]
        //       public void DateTimeExtremeMax()
        //       {
        //           clsSession ASession = new clsSession();
        //           String Error = "";
        //           DateTime TestDate;
        //           TestDate = DateTime.Now.Date;
        //           TestDate = TestDate.AddYears(100);
        //           string dateTime = TestDate.ToString();
        //           Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
        //           Assert.AreNotEqual(Error, "");
        //       }

        [TestMethod]
        public void DateTimeInvalidData()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            String dateTime = "this is not a date!";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SessionTypeMinLessOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string sessionType = "";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SessionTypeMin()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string sessionType = "a";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SessionTypeMinPlusOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string sessionType = "aa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SessionTypeMaxLessOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string Type = "";
            Type = Type.PadRight(49, 'a');
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SessionTypeMax()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string Type = "";
            Type = Type.PadRight(50, 'a');
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SessionTypeMaxPlusOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string type = "";
            Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SessionsTypeMid()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string Type = "";
            Type = Type.PadRight(25, 'a');
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SessionTypeExtremeMax()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            String Type = "";
            sessionType = Type.PadRight(500, 'a') + "";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostMinLessOne()
        {
            clsSession ASession = new clsSession();
            string Error = "";
            string cost = "";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CostMin()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string cost = "a";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMinPlusOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string cost = "aa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMaxLessOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string cost = "aaaaa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CostMax()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string cost = "aaaaaa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMid()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string cost = "aaa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMaxPlusOne()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            string cost = "aaaaaaa";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostExtremeMax()
        {
            clsSession ASession = new clsSession();
            String Error = "";
            String Cost = "";
            cost = Cost.PadRight(10, 'a') + "";
            Error = ASession.Valid(trainerID, branchID, sessionType, dateTime, cost);
            Assert.AreNotEqual(Error, "");
        }



    }

}