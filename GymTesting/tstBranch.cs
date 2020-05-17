using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GymClasses;


namespace GymTesting
{
    [TestClass]
    public class tstBranch
    {

        string GymCity = "leicester";
        string GymAddress = "le3 8gt";
        string DATEOPENED = DateTime.Now.Date.AddYears(-10).ToString();


        [TestMethod]
        public void InstanceOK()
        {
            clsBranch ABranch = new clsBranch();
            Assert.IsNotNull(ABranch);
        }

        [TestMethod]
        public void GymIDPropertyOK()
        {
            clsBranch ABranch = new clsBranch();
            int TestData = 5;
            ABranch.GymID = TestData;
            Assert.AreEqual(ABranch.GymID, TestData);
        }

        [TestMethod]
        public void GymCityPropertyOK()
        {
            clsBranch ABranch = new clsBranch();
            string TestData = "leicester";
            ABranch.GymCity = TestData;
            Assert.AreEqual(ABranch.GymCity, TestData);
        }
        [TestMethod]
        public void GymAddressPropertyOK()
        {
            clsBranch ABranch = new clsBranch();
            String TestData = "le3 8gt";
            ABranch.GymAddress = TestData;
            Assert.AreEqual(ABranch.GymAddress, TestData);
        }

        [TestMethod]
        public void DATEOPENEDPropertyOK()
        {
            clsBranch ABranch = new clsBranch();
            DateTime TestData = DateTime.Now.Date;
            ABranch.DateOpened = TestData;
            Assert.AreEqual(ABranch.DateOpened, TestData);
        }



        [TestMethod]
        public void AmmenitiesPropertyOK()
        {
            //create an instance of the class we weant to create
            clsBranch ABranch = new clsBranch();
            //create the test data to the property
            Boolean TestData = true;
            ABranch.Ammenities = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ABranch.Ammenities, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsBranch ABranch = new clsBranch();
            Boolean Found = false;
            Int32 TestData = 1;
            Found = ABranch.Find(TestData);
        }

        [TestMethod]
        public void TestGymIDFound()
        {

            clsBranch ABranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestData = 4;
            Found = ABranch.Find(TestData);
            if (ABranch.GymID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGymCityFound()
        {
            clsBranch ABranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestData = 3;
            Found = ABranch.Find(TestData);
            if (ABranch.GymCity != "Wayne Rooney")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGymAddressFound()
        {
            clsBranch ABranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestData = 3;
            Found = ABranch.Find(TestData);
            if (ABranch.GymAddress != "55 South Leicester Road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDATEOPENEDFound()
        {

            clsBranch ABranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestData = 2;
            Found = ABranch.Find(TestData);
            if (ABranch.DateOpened != Convert.ToDateTime("1985/01/18"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAmmenitiesFound()
        {
            clsBranch ABranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestData = 2;
            Found = ABranch.Find(TestData);
            if (ABranch.Ammenities != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsBranch ABranch = new clsBranch();
            string Error = "";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GymCityExtremeMin()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void GymCityMinMinusOne()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "A";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GymCityMinBoundary()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "A A";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GymCityMinPlusOne()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "AA A";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GymCityMaxMinusOne()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "AAAAAAAAAAAAAAAAAAAA AAAAAAAAAAAAAAAAAAAA";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GymCityMaxBoundary()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "AAAAAAAAAAAAAAAAAAAA AAAAAAAAAAAAAAAAAAAA";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GymCityMaxPlusOne()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "AAAAAAAAAAAAAAAAAAAA AAAAAAAAAAAAAAAAAAAA";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GymCityMid()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "AAAAAAAAAA AAAAAAAAAA";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GymCityxtremeMax()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "";
            GymCity = GymCity.PadRight(100, 'A') + "";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GymCityContainsSpace()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "AAAAAAAAAAAAAAAAAAAA";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GymCityNotBlank()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String GymCity = "";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDExtremeMin()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DATEOPENED = TestDate.AddYears(-100).ToString();
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDMinMinusOne()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DATEOPENED = TestDate.AddYears(-65).AddDays(-1).ToString();
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDMinBoundary()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DATEOPENED = TestDate.AddYears(-65).ToString();
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDMinPlusOne()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DATEOPENED = TestDate.AddYears(-65).AddDays(-1).ToString();
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDMaxMinusOne()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DATEOPENED = TestDate.AddYears(-18).AddDays(-1).ToString();
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDMaxBoundary()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DATEOPENED = TestDate.AddYears(-18).ToString();
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDMaxPlusOne()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DATEOPENED = TestDate.AddYears(-18).AddDays(-1).ToString();
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDMid()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DATEOPENED = TestDate.AddYears(-10).ToString();
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDExtremeMax()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DATEOPENED = TestDate.AddYears(100).ToString();
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDInvalidData()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            String DATEOPENED = "this is not a date!";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DATEOPENEDNotBlank()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            string DATEOPENED = "";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GymAddressExtremeMin()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            string GymAddress = "road";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void GymAddressMinPlusOne()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            string GymAddress = "AA A AAA";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GymAddressMaxMinusOne()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            string GymAddress = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void GymAddressMid()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            string GymAddress = "ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void GymAddressNotBlank()
        {
            clsBranch ABranch = new clsBranch();
            String Error = "";
            string GymAddress = "";
            Error = ABranch.Valid(GymCity, GymAddress, DATEOPENED);
            Assert.AreNotEqual(Error, "");
        }
    }
}





