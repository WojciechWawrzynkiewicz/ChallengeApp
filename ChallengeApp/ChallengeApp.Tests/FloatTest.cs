namespace ChallengeApp.Tests
{
    internal class FloatTest
    {
        [Test]
        public void TypeTest()
        {
            // arange
            float number1 = 1.55f;
            float number2 = 1.55f;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }
    }
}
