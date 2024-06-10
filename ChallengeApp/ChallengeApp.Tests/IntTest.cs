
namespace ChallengeApp.Tests
{
    internal class IntTest
    {
        [Test]
        public void TypeTest()
        {
            // arange
            int number1 = 7;
            int number2 = 7;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }
    }
}
