using ChallengeApp;

Employee employee1 = new Employee("Wojtek", "abc", 24);
Employee employee2 = new Employee("Marek", "abcd", 27);
Employee employee3 = new Employee("Jacek", "abcde", 31);

// Employee 1
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(9);

// Employee 2
employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(9);
employee2.AddScore(8);
employee2.AddScore(6);

// Employee 3
employee3.AddScore(3);
employee3.AddScore(7);
employee3.AddScore(5);
employee3.AddScore(3);
employee3.AddScore(1);


Employee bestScoreEmployee = employee1;
int bestScore = employee1.Result;

if (employee2.Result > bestScore)
{
    bestScoreEmployee = employee2;
    bestScore = employee2.Result;
} 
if (employee3.Result > bestScore)
{
    bestScoreEmployee = employee3;
    bestScore = employee3.Result;
}

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;
Console.WriteLine("Employee score " + employee1.Name + " = " + result1);
Console.WriteLine("Employee score " + employee2.Name + " = " + result2);
Console.WriteLine("Employee score " + employee3.Name + " = " + result3);

Console.WriteLine("Best score employee is: " + bestScoreEmployee.Name);