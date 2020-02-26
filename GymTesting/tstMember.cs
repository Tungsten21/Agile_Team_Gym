using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GymTesting
{
    [TestClass]
    public class tstMember
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //test to see that it exists
            Assert.IsNotNull(AMember);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //Create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //Create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AMember.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.Active, TestData);
        }
        [TestMethod]
        public void DateaddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AMember.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.DateAdded, TestData);
        }
        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMember.AddressNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.AddressNo, TestData);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMember.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.CountyNo, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AMember.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AMember.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AMember.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AMember.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.Town, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = AMember.Find(AddressNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestAddressNoFound()
        {
            //Create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AMember.Find(AddressNo);
            //Check the address no 
            if (AMember.AddressNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        //!!!!!!!!!!!!!

       
        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AMember.Find(AddressNo);
            //check the property
            if (AMember.Street != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AMember.Find(AddressNo);
            //check the property
            if (AMember.Town != "Test Town")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AMember.Find(AddressNo);
            //check the property
            if (AMember.PostCode != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCountyNoFound()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AMember.Find(AddressNo);
            //check the property
            if (AMember.CountyNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AMember.Find(AddressNo);
            //check the property
            if (AMember.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AMember.Find(AddressNo);
            //check the property
            if (AMember.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }

}
