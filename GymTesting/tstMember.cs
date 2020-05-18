using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GymTesting
{
    [TestClass]
    public class tstMember
    {

        string FullName = "Sofyan Koultouma";
        string Address = "1 Leicester road";
        string DOB = DateTime.Now.Date.AddYears(-28).ToString();
        string PhoneNumber = "07856681287";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //test to see that it exists
            Assert.IsNotNull(AMember);
        }

        [TestMethod]
        public void MemberIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            int TestData = 11;
            //assign the data to the property
            AMember.MemberID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.MemberID, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            //create instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            string TestData = "Sofyan Koultouma";
            //asign the data to the property
            AMember.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.FullName, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            String TestData = "1 Leicester road";
            //assign the data to the property
            AMember.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.Address, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AMember.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.DOB, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //create some test data to assign to the property
            string TestData = "07856681287";
            //assign the data to the property
            AMember.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.PhoneNumber, TestData);
        }

        [TestMethod]
        public void MedicalConditionsPropertyOK()
        {
            //create an instance of the class we weant to create
            clsMember AMember = new clsMember();
            //create the test data to the property
            Boolean TestData = true;
            //assign the data to the property
            AMember.MedicalConditions = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMember.MedicalConditions, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 TestData = 7;
            //invoke the method
            Found = AMember.Find(TestData);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestMemberIDFound()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TestData = 11;
            //invoke the method
            Found = AMember.Find(TestData);
            //check the Member ID
            if (AMember.MemberID != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            clsMember AMember = new clsMember();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestData = 10;
            Found = AMember.Find(TestData);
            if (AMember.FullName != "James Bond")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsMember AMember = new clsMember();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestData = 11;
            Found = AMember.Find(TestData);
            if (AMember.Address != "1 Leicester Road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK, assuming it is
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TestData = 10;
            //invoke the method
            Found = AMember.Find(TestData);
            //check the property
            if (AMember.DOB != Convert.ToDateTime("01-12-1954"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsMember AMember = new clsMember();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestData = 11;
            Found = AMember.Find(TestData);
            if (AMember.PhoneNumber != "07856681247")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestMedicalConditionsFound()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK, assuming it is
            Boolean OK = true;
            //create some test data to use with the method
            Int32 MemberID = 11;
            //invoke the method
            Found = AMember.Find(MemberID);
            //check the property
            if (AMember.MedicalConditions != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsMember AMember = new clsMember();
            string Error = "";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMin()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FullNameMinMinusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "A";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinBoundary()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "A A";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "AA A";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxMinusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "AAAAAAAAAAAAAAAAAAAA AAAAAAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxBoundary()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "AAAAAAAAAAAAAAAAAAAA AAAAAAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "AAAAAAAAAAAAAAAAAAAA AAAAAAAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "AAAAAAAAAA AAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNamExtremeMax()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "";
            FullName = FullName.PadRight(100, 'A') + "";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameContainsSpace()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "AAAAAAAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameNotBlank()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String FullName = "";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMin()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.AddYears(-100).ToString();
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinMinusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.AddYears(-65).AddDays(-1).ToString();
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinBoundary()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.AddYears(-65).ToString();
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinPlusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.AddYears(-65).AddDays(1).ToString();
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxMinusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.AddYears(-18).AddDays(-1).ToString();
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxBoundary()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.AddYears(-18).ToString();
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxPlusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.AddYears(-18).AddDays(1).ToString();
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMid()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.AddYears(-28).ToString();
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMax()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.AddYears(100).ToString();
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBInvalidData()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            String DOB = "this is not a date!";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBNotBlank()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string DOB = "";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMin()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string Address = "road";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinMinusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string Address = "A A AA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string Address = "AAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string Address = "AAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxMinusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string Address = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(50, 'a');
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string Address = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string Address = "AAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string Address = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressNotBlank()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string Address = "";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMin()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string PhoneNumber = "AAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinMinusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string PhoneNumber = "AAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinBoundary()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string PhoneNumber = "AAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string PhoneNumber = "AAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxMinusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string PhoneNumber = "AAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxBoundary()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string PhoneNumber = "AAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string PhoneNumber = "AAAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string PhoneNumber = "AAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string PhoneNumber = "AAAAAAAAAAAAAAAA";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberNotBlank()
        {
            clsMember AMember = new clsMember();
            String Error = "";
            string PhoneNumber = "";
            Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }
    }
}