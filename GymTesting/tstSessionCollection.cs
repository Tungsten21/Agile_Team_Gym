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
        public void InstanceOK()
        {
           clsSessionCollection AllSession = new clsSessionCollection();
           Assert.IsNotNull(AllSession);
        }

        [TestMethod]
        public void SessionListOK()
        {
            clsSessionCollection AllSession = new clsSessionCollection();
            List<clsSession> TestList = new List<clsSession>();
            clsSession TestItem = new clsSession();
            TestItem.EquipmentRequired = false;
            TestItem.SessionID = 1;
            TestItem.SessionType = "Some Type";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.TrainerID = 4;
            TestItem.BranchID = 3;
            TestItem.Cost = 5;
           TestList.Add(TestItem);
           AllSession.SessionList = TestList;
            Assert.AreEqual(AllSession.SessionList, TestList);
        }

 //       [TestMethod]
 //      public void CountPropertyOK()
 //       {
 //           clsSessionCollection AllSession = new clsSessionCollection();
 //           Int32 SomeCount = 2;
//            AllSession.Count = SomeCount;
//            Assert.AreEqual(AllSession.Count, SomeCount);
//       }

        [TestMethod]
        public void ThisSessionPropertyOK()
        {
            clsSessionCollection AllSession = new clsSessionCollection();
           clsSession TestSession = new clsSession();
            TestSession.EquipmentRequired = false;
            TestSession.SessionID = 1;
            TestSession.SessionType = "Some Type";
            TestSession.DateTime = DateTime.Now.Date;
            TestSession.TrainerID = 4;
            TestSession.BranchID = 3;
            TestSession.Cost = 5;
            AllSession.ThisSession = TestSession;
           Assert.AreEqual(AllSession.ThisSession, TestSession);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            clsSessionCollection AllSession = new clsSessionCollection();
            List<clsSession> TestList = new List<clsSession>();
            clsSession TestItem = new clsSession();
            TestItem.EquipmentRequired = false;
            TestItem.SessionID = 1;
            TestItem.SessionType = "Some Type";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.TrainerID = 4;
            TestItem.BranchID = 3;
            TestItem.Cost = 5;
            TestList.Add(TestItem);
            AllSession.SessionList = TestList;
            Assert.AreEqual(AllSession.Count, TestList.Count);
        }


        //        [TestMethod]
        //        public void TwoRecordsPresent()
        //        {
        //           clsSessionCollection AllSession = new clsSessionCollection();
        //           Assert.AreEqual(AllSession.Count, 2);
        //       }
        [TestMethod]
        public void AddMethodOK()
        {
            clsSessionCollection AllSession = new clsSessionCollection();
            clsSession TestItem = new clsSession();
            Int32 PrimaryKey = 0;
            TestItem.EquipmentRequired = true;
            TestItem.TrainerID = 4;
            TestItem.BranchID = 3;
            TestItem.SessionID = 51;
            TestItem.SessionType = "Some Type";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.Cost = 5;
            AllSession.ThisSession = TestItem;
            PrimaryKey = AllSession.Add();
            //set the primary key of the test data
            TestItem.SessionID = PrimaryKey;
            //find the record
            AllSession.ThisSession.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSession.ThisSession, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSessionCollection AllSession = new clsSessionCollection();
            clsSession TestItem = new clsSession();
            Int32 PrimaryKey = 0;
            TestItem.EquipmentRequired = true;
            TestItem.TrainerID = 4;
            TestItem.BranchID = 3;
            TestItem.SessionID = 51;
            TestItem.SessionType = "Some Type";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.Cost = 5;
            AllSession.ThisSession = TestItem;
            PrimaryKey = AllSession.Add();
            TestItem.SessionID = PrimaryKey;
            AllSession.ThisSession.Find(PrimaryKey);
            AllSession.Delete();
            Boolean Found = AllSession.ThisSession.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSessionCollection AllSession = new clsSessionCollection();
            clsSession TestItem = new clsSession();
            Int32 PrimaryKey = 0;
            TestItem.EquipmentRequired = true;
            TestItem.TrainerID = 4;
            TestItem.BranchID = 3;
            TestItem.SessionID = 51;
            TestItem.SessionType = "Some Type";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.Cost = 5;
            AllSession.ThisSession = TestItem;
            PrimaryKey = AllSession.Add();
            TestItem.SessionID = PrimaryKey;
            
            TestItem.EquipmentRequired = true;
            TestItem.TrainerID = 4;
            TestItem.BranchID = 3;
            TestItem.SessionID = 51;
            TestItem.SessionType = "Some Type";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.Cost = 5;
            AllSession.ThisSession = TestItem;
            PrimaryKey = AllSession.Update();
            AllSession.ThisSession.Find(PrimaryKey);
            Assert.AreEqual(AllSession.ThisSession, TestItem);

        }

        [TestMethod]
        public void ReportBySessionTypeMehtodOK()
        {
            clsSessionCollection AllSession = new clsSessionCollection();
            clsSessionCollection FilteredSessions = new clsSessionCollection();
            FilteredSessions.ReportBySessionType("");
            Assert.AreEqual(AllSession.Count, FilteredSessions.Count);
        }

        [TestMethod]
        public void ReportBySessionTypeNoneFound()
        {
            clsSessionCollection FilteredSessions = new clsSessionCollection();
            FilteredSessions.ReportBySessionType("xxxxxx");
            Assert.AreEqual(0, FilteredSessions.Count);
        }

        [TestMethod]
        public void ReportBySessionTypeTestDataFound()
        {
            clsSessionCollection FilteredSessions = new clsSessionCollection();
            Boolean OK = true;
            FilteredSessions.ReportBySessionType("xxx xxx");
            if (FilteredSessions.Count == 2)
            {
                if( FilteredSessions.SessionList[0].SessionID != 19)
                {
                    OK = false;
                }
                if (FilteredSessions.SessionList[1].SessionID != 20)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }
    }
}
