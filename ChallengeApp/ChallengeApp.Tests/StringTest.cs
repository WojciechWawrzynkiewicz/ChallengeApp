

namespace ChallengeApp.Tests
{
    internal class StringTest
    {
        [Test]
        public void TypeTest()
        {
            // arange
            String name1 = "Wojtek";
            String name2 = "Wojtek";

            // act

            // assert
            Assert.AreEqual(name1, name2);
        }
    }
}
