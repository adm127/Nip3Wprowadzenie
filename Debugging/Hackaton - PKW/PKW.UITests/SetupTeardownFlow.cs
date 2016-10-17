using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKW.UITests
{
    [TestClass]
    public class SetupTeardownFlow
    {
        public static StreamWriter Log = new StreamWriter("c:\\logfile.txt");


        [ClassInitialize]
        public static void SetupFixture(TestContext context)
        {
            Log.WriteLine("+++++     Fixture Setup");
        }

        [TestCleanup]
        public static void SetupFixture(TestContext context)
        {
            Log.WriteLine("+++++     Fixture Setup");
        }

        [TestCleanup]
        public static void TeardownFixture()
        {
            Log.WriteLine("+++++     TestCleanup");
            Log.Close();
        }

        [TestInitialize]
        public void SetupTest()
        {
            Log.WriteLine("+ + +     Test Setup");
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Log.WriteLine(" + +      Test Teardown");
        }

        [TestMethod]
        [TestCategory("Draw")]
        public void TestB()
        {
            Log.WriteLine("  B       Test B");
        }

        [TestMethod]
        [TestCategory("Draw")]
        public void TestA()
        {
            Log.WriteLine("  A       Test A");
        }
    }
}