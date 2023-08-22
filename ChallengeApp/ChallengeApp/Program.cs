// Program obliczający ilość cyfr w liczbie

int number = 325844;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

// c - counter
// int c0,c1,c2,c3,c4,c5,c6,c7,c8,c9 = 0; <---- dlaczego nie mogę tak zapisać?
// kompilator wyrzuca mi błąd
int c0 = 0;
int c1 = 0;
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;
int c6 = 0;
int c7 = 0;
int c8 = 0;
int c9 = 0;

foreach(char letter in letters)
{
    if (letter == '0')
    {
        c0++;
    }
    else if (letter == '1')
    {
        c1++;
    }
    else if (letter == '2') 
    { 
        c2++;
    }
    else if (letter == '3')
    {
        c3++;
    }
    else if (letter == '4')
    {
        c4++;
    }
    else if (letter == '5')
    {
        c5++;
    }
    else if (letter == '6')
    {
        c6++;
    }
    else if (letter == '7')
    {
        c7++;
    }
    else if (letter == '8')
    {
        c8++;
    }
    else if (letter == '9')
    {
        c9++;
    }
}

Console.WriteLine("Liczba powtórzeń cyfr w podanej liczbie " + number + " to: ");
Console.WriteLine("0 " + "-> " + c0);
Console.WriteLine("1 " + "-> " + c1);
Console.WriteLine("2 " + "-> " + c2);
Console.WriteLine("3 " + "-> " + c3);
Console.WriteLine("4 " + "-> " + c4);
Console.WriteLine("5 " + "-> " + c5);
Console.WriteLine("6 " + "-> " + c6);
Console.WriteLine("7 " + "-> " + c7);
Console.WriteLine("8 " + "-> " + c8);
Console.WriteLine("9 " + "-> " + c9);