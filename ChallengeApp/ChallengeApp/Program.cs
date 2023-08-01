string name = "Ewa";
bool women = true;
int age = 23;

if (women == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (women == false && age < 17)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Nie jestem żadnym z powyższych wariantów, " +
        "jestem: " + name + " i mam " + age + "lat/a");
}