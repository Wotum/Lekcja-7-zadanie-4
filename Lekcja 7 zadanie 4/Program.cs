using System;

namespace Rok_Przestepny;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Podaj rok do sprawdzenia:");
        int rok;

        if (int.TryParse(Console.ReadLine(), out rok))
        {
            if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0))
            {
                Console.WriteLine($"{rok} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{rok} nie jest rokiem przestępnym");
            }
        }
        else
        {
            Console.WriteLine("Podano nieprawidłową wartość roczną");
        }

    }

}