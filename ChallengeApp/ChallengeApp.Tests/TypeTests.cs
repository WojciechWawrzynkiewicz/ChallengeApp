namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TypeTest()
        {
            // arange
            var user1 = GetUser("Wojtek", "abc");
            var user2 = GetUser("Wojtek", "abc");

            // act
            
            // assert
            Assert.AreEqual(user1.Login, user2.Login);
        }

        private User GetUser(string login, string password)
        {
            return new User(login, password);
        }
    }
}
