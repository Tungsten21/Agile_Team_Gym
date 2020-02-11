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
                clsMember aMember = new clsMember();
                //test to see if it exists
                Assert.IsNotNull(aMember);
            }
        }
    }

