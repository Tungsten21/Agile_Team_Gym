using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GymClasses;

namespace GymTesting
{
    [TestClass]
    public class tstBranchcollection
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsBranchCollection AllBranches = new clsBranchCollection();

            Assert.IsNotNull(AllBranches);
        }

        [TestMethod]
        public void BranchListOK()
        {

            clsBranchCollection AllBranches = new clsBranchCollection();


            List<clsBranch> Test = new List<clsBranch>();

            clsBranch Test1 = new clsBranch();

            Test1.GymCity = "leicester";
            Test1.GymAddress = "le3 8gt";
            Test1.DateOpened = DateTime.Parse("2012/08/12");
            Test1.GymID = 10;
            Test1.Ammenities = false;
            Test.Add(Test1);
            AllBranches.BranchList = Test;
            Assert.AreEqual(AllBranches.BranchList, Test);
        }

        [TestMethod]
        public void ThisBranchPropertyOK()
        {

            clsBranchCollection Test = new clsBranchCollection();

            clsBranch Test1 = new clsBranch();
            Test1.GymCity = "leicester";
            Test1.GymAddress = "le3 8gt";
            Test1.DateOpened = DateTime.Parse("2012/08/12");
            Test1.GymID = 10;
            Test1.Ammenities = true;
            Test.ThisBranch = Test1;

            Assert.AreEqual(Test.ThisBranch, Test1);

        }

        [TestMethod]
        public void ListAndCountOK()
        {

            clsBranchCollection AllBranches = new clsBranchCollection();

            List<clsBranch> Test = new List<clsBranch>();
            clsBranch Test1 = new clsBranch();
            Test1.GymCity = "leicester";
            Test1.GymAddress = "le3 8gt";
            Test1.DateOpened = DateTime.Parse("2012/08/12");
            Test1.GymID = 10;
            Test1.Ammenities = false;
            Test.Add(Test1);
            AllBranches.BranchList = Test;
            Assert.AreEqual(AllBranches.Count, Test.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {

            clsBranchCollection AllBranches = new clsBranchCollection();
            clsBranch Test1 = new clsBranch();
            Int32 PrimaryKey = 0;
            Test1.GymCity = "leicester ";
            Test1.GymAddress = "le3 8gt";
            Test1.DateOpened = DateTime.Parse("2012/08/12");
            Test1.GymID = 20;
            Test1.Ammenities = true;
            AllBranches.ThisBranch = Test1;

            PrimaryKey = AllBranches.Add();

            Test1.GymID = PrimaryKey;

            AllBranches.ThisBranch.Find(PrimaryKey);

            Assert.AreEqual(AllBranches.ThisBranch, Test1);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {

            clsBranchCollection AllBranches = new clsBranchCollection();

            clsBranch Test1 = new clsBranch();
            Int32 PrimaryKey = 0;

            Test1.GymCity = "leicester";
            Test1.GymAddress = "le3 8gt";
            Test1.DateOpened = DateTime.Parse("2012/08/12");
            Test1.GymID = 20;
            Test1.Ammenities = true;

            AllBranches.ThisBranch = Test1;
            PrimaryKey = AllBranches.Add();

            Test1.GymID = PrimaryKey;
            AllBranches.ThisBranch.Find(PrimaryKey);
            AllBranches.Delete();
            Boolean Found = AllBranches.ThisBranch.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {

            clsBranchCollection AllBranches = new clsBranchCollection();

            clsBranch Test1 = new clsBranch();
            Int32 PrimaryKey = 0;

            Test1.GymCity = "leicester";
            Test1.GymAddress = "le3 8gt";
            Test1.DateOpened = DateTime.Parse("2012/09/12");
            Test1.Ammenities = true;

            AllBranches.ThisBranch = Test1;

            PrimaryKey = AllBranches.Add();

            Test1.GymID = PrimaryKey;
            Test1.GymCity = "leicester";
            Test1.GymAddress = "le3 8gt";
            Test1.DateOpened = DateTime.Parse("2012/08/12");
            Test1.Ammenities = true;
            AllBranches.ThisBranch = Test1;
            AllBranches.Update();
            AllBranches.ThisBranch.Find(PrimaryKey);
            Assert.AreEqual(AllBranches.ThisBranch, Test1);

        }

        [TestMethod]
        public void ReportByDATEOPENEDMethodOK()
        {
            clsBranchCollection AllBranches = new clsBranchCollection();

            clsBranchCollection FilteredBranchs = new clsBranchCollection();

            FilteredBranchs.ReportByDateOpened("");
            Assert.AreEqual(AllBranches.Count, FilteredBranchs.Count);
        }

        [TestMethod]
        public void ReportByDATEOPENEDNoneFound()
        {

            clsBranchCollection FilteredBranchs = new clsBranchCollection();
            FilteredBranchs.ReportByDateOpened("2010/05/07");
            Assert.AreEqual(0, FilteredBranchs.Count);

        }

        [TestMethod]
        public void ReportByDateOpenedFound()
        {
            clsBranchCollection FilteredBranchs = new clsBranchCollection();
            Boolean OK = true;
            FilteredBranchs.ReportByDateOpened("2018-03-15");
            if (FilteredBranchs.Count == 2)
            {
                if (FilteredBranchs.BranchList[0].GymID != 4)
                {
                    OK = false;
                }
                if (FilteredBranchs.BranchList[1].GymID != 5)
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

