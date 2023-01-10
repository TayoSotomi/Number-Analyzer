
using System.Security.Cryptography.X509Certificates;

bool Cont = true;

while(Cont == true)
{
    Console.WriteLine("What is your name");
    string name = Console.ReadLine();

    Console.WriteLine(name +" enter an integer between 1 and 100 ");
    int result = int.Parse(Console.ReadLine());

    if (result % 2 != 0 && result < 60)
    {
        Console.WriteLine(result + " Odd and less than 60");
    }
    else if (result % 2 == 0 && result >= 2 && result <= 24)
    {
        Console.WriteLine("Even and less than 25.");
    }
    else if (result % 2 == 0 && result >= 26 && result <= 60)
    {
        Console.WriteLine("Even and greater than 60");
    }
    else if (result % 2 != 0 && result > 60)
    {
        Console.WriteLine("Odd and greater than 60");
    }

    Console.WriteLine(name +" would you like to continue? y/n");
    string Answ = Console.ReadLine();

    if (Answ == "y")
    {
        Cont = true;
    }
    else
    {
        Cont = false;
    }
}

