namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult()
        {
            // arange

            var employee = new Employee("Wojtek", "jkvda", 24);
            employee.SubScore(-2);
            employee.SubScore(5);
            employee.SubScore(7);
            employee.SubScore(-5);
            employee.SubScore(-8);

            

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(0, result);
        }
    }
}