var number = 356211111;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char c in letters)
{
    if (c == '0')
    {
        counter0++;
    }
    else if (c == '1')
    {
        counter1++;
    }
    else if (c == '2')
    {
        counter2++;
    }
    else if (c == '3')
    {
        counter3++;
    }
    else if (c == '4')
    {
        counter4++;
    }
    else if (c == '5')
    {
        counter5++;
    }
    else if (c == '6')
    {
        counter6++;
    }
    else if (c == '7')
    {
        counter7++;
    }
    else if (c == '8')
    {
        counter8++;
    }
    else if (c == '9')
    {
        counter9++;
    }
}

Console.WriteLine("Liczba 0 występuje w liczbie: " + counter0);
Console.WriteLine("Liczba 1 występuje w liczbie: " + counter1);
Console.WriteLine("Liczba 2 występuje w liczbie: " + counter2);
Console.WriteLine("Liczba 3 występuje w liczbie: " + counter3);
Console.WriteLine("Liczba 4 występuje w liczbie: " + counter4);
Console.WriteLine("Liczba 5 występuje w liczbie: " + counter5);
Console.WriteLine("Liczba 6 występuje w liczbie: " + counter6);
Console.WriteLine("Liczba 7 występuje w liczbie: " + counter7);
Console.WriteLine("Liczba 8 występuje w liczbie: " + counter8);
Console.WriteLine("Liczba 9 występuje w liczbie: " + counter9);