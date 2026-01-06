using ConsoleApp1.If_Else;
using NUnit;
using NUnit.Framework;

namespace PractiseTest
{
    [TestFixture]
    public class Class1
    {
        private EvenOdd eo;
        [SetUp]
        public void setup()
        {
            eo= new EvenOdd();
        }

        [Test]
        public void GivenAnEvenNumber_WhenCallingeveodd_ThenReturnEven()
        {
            string expected = "even";
           
            string actual = eo.eveodd(10);
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void GivenAnOddNumber_WhenCallingeveodd_ThenReturnOdd()
        {
            string expected = "odd";

            string actual = eo.eveodd(9);
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
