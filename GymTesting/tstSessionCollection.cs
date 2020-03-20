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

    }
}
