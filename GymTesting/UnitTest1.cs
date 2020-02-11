using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GymTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsTrainer ATrainer = new clsTrainer();
            //test to see that it exists
            Assert.IsNotNull(ATrainer);
        }
    }
}
