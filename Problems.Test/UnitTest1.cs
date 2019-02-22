using NUnit.Framework;
using Problems.Program;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test] 
        public void TestPrefix()
        {
            Program s= new Program();
            Assert.AreEqual("5,1:Hello", s.Prefix("Hello"));
            Assert.AreEqual("0,0:", s.Prefix(""));
            Assert.AreEqual("27,5:what    ...  did you say?? ", s.Prefix("what    ...  did you say?? "));
        }

    }
}