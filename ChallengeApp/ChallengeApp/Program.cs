using ChallengeApp;

var employee = new Employee("Wojtek", "Wawrzynkiewicz");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(7);
employee.AddGrade(4);
employee.AddGrade(1);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
