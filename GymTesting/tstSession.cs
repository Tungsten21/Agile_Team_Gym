using System;
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
        public void DatePropertyOK()
        {
            //create an instance of the class we want to create
            clsSession ASession = new clsSession();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ASession.datetime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASession.datetime, TestData);
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
            string type = "Cycling";
            ASession.Type = type;
            Assert.AreEqual(ASession.Type, type);
        }
        //	[TestMethod]
        //       public void DateTimePropertyOK()
        //       {
        //            clsSession ASession = new clsSession();
        //           DateTime datetime = DateTime;
        //            ASession .datetime = datetime;
        //            Assert.AreEqual(ASession .DateTime , datetime);
        //        }

        [TestMethod]
        public void CostPropertyOK()
        {
            clsSession ASession = new clsSession();
            Double cost = 0.0;
            ASession.Cost = cost;
            Assert.AreEqual(ASession.Cost,  cost);
        }

    }


}
