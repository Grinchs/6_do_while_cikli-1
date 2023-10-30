using System;

class Program
{
    static void Main()
    {
        string pareizaParole = "Gatis"; 

        Console.WriteLine("Ievadiet paroli: ");
        string ievaditaParole = Console.ReadLine();

        while (ievaditaParole != pareizaParole)
        {
            Console.WriteLine("Parole ir ievadita nepareizi!");
            ievaditaParole = Console.ReadLine();
        }

        Console.WriteLine("Parole ir ievadita pareizi!");
        Console.ReadLine();
    }
}
