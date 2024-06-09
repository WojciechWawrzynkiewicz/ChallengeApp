namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arange

            var user = new User("Wojtek", "qwer1234");
            user.AddScore(4);
            user.AddScore(6);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(10, result);
        }
    }
}