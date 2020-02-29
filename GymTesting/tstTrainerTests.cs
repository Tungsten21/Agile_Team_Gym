using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GymTesting
{
    [TestClass]
    public class tstTrainerTests
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create and instance of the class we want to create
            clsTrainer ATrainer = new clsTrainer();
            //test to see that it exists
            Assert.IsNotNull(ATrainer);
        }
        [TestMethod]
        public void RetrainedPropertyOK()
        {
            //create an instance of the class we weant to create
            clsTrainer ATrainer = new clsTrainer();
            //create the test data to the property
            Boolean TestData = true;
            //assign the data to the property
            ATrainer.Retrained = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATrainer.Retrained, TestData);
        }
        [TestMethod]
        public void DatePropertyOK()
        {
            //create an instance of the class we want to create
            clsTrainer ATrainer = new clsTrainer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ATrainer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATrainer.DateOfBirth, TestData);
        }
        [TestMethod]
        public void TrainedIDPropertyOK()
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
        public void FullNamePropertyOK()
        {
            clsTrainer ATrainer = new clsTrainer();
            string name = "Robert Smith";
            ATrainer.FullName = name;
            Assert.AreEqual(ATrainer.FullName, name);
        }
        [TestMethod]
        public void GenderPropertyOK()
        {
            clsTrainer ATrainer = new clsTrainer();
            string male = "Male";
            ATrainer.Gender = male;
            Assert.AreEqual(ATrainer.Gender, male);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            clsTrainer ATrainer = new clsTrainer();
            string email = "testemail67@gmail.com";
            ATrainer.EmailAddress = email;
            Assert.AreEqual(ATrainer.EmailAddress, email);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsTrainer ATrainer = new clsTrainer();
            //boolean variable to store the result of the validaiton
            Boolean Found = false;
            //create some test data to use with the method
            int TestTrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TestTrainerID);
        }
        [TestMethod]
        public void TestTrainerIDFound()
        {
            //create an instance of the class we want to create
            clsTrainer ATrainer = new clsTrainer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TestTrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TestTrainerID);
            //check the trainer ID
            if (ATrainer.TrainerID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsTrainer ATrainer = new clsTrainer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TestTrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TestTrainerID);
            //check the property
            if (ATrainer.DateOfBirth != Convert.ToDateTime("19/05/1992"))
            {
                OK = false;
            }
            //test ot see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestGenderFound()
        {
            clsTrainer ATrainer = new clsTrainer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestTrainerID = 2;
            Found = ATrainer.Find(TestTrainerID);
            if (ATrainer.Gender != "Male")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {
            clsTrainer ATrainer = new clsTrainer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestTrainerID = 2;
            Found = ATrainer.Find(TestTrainerID);
            if(ATrainer.EmailAddress != "tonygunn27@hotmail.co.uk")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestRetrainedFound()
        {
            clsTrainer ATrainer = new clsTrainer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestTrainerID = 2;
            Found = ATrainer.Find(TestTrainerID);
            if (ATrainer.Retrained != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFullNameFound()
        {
            clsTrainer ATrainer = new clsTrainer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestTrainerID = 2;
            Found = ATrainer.Find(TestTrainerID);
            if (ATrainer.FullName != "Tony Gunn")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
