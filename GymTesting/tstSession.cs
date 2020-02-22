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
    }
}
