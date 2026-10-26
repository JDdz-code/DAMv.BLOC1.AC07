using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Text;

public class CodeQuest
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        const string LINE= "\n---------------------------------\n";
        const string WELCOME= "¡Welcome to the Arcanist Academy!";

        string nameMage;


        Console.WriteLine(LINE);
        Console.WriteLine(WELCOME);
        Console.WriteLine(LINE);
        int power = 0;
        int nivel = 1;
        int Day = 0;
        int totalHoras = 0;
           

        Console.Write("Insert your name: ");
        nameMage = Console.ReadLine();
        Console.WriteLine(LINE);

         Random rnd = new();
        while (Day < 5)
        {
            Day++;

          

            power += rnd.Next(1, 11);
            totalHoras= rnd.Next(1, 25);

            int nivel_anterior = nivel;
            nivel = 1 + (power / 10);


            Console.WriteLine($"⌛ Dia {Day} → {nameMage}, ja has meditat {totalHoras} hores i el teu poder ara és de {power} punts!");


            if (nivel > nivel_anterior)
            {
                Console.WriteLine($"⭐ → {nameMage} ha pujat al nivell {nivel}!");

            }


        }
        if (power < 20) {
            Console.WriteLine("Repeteixes a 2a convocatòria");
            Console.WriteLine("Raoden el Elantrí");

        }

        else if ((power > 20) && (power < 30))
        {
            Console.WriteLine("Encara confons la vareta amb una cullera");
            Console.WriteLine("Zyn el Buguejat");
        }

        else if ((power > 30) && (power < 35))
        {
            Console.WriteLine("Ets un Invocador de Brises Màgiques.");
            Console.WriteLine("Arka Nullpointer");
        }
        else if ((power > 35) && (power < 40))
        {
            Console.WriteLine("Uau! Pots invocar dracs sense cremar el laboratori!");
            Console.WriteLine("Elarion de les Brases");
        }
        else
        {
            Console.WriteLine("Has assolit el rang de Mestre dels Arcans!");
            Console.WriteLine("ITB - Wizard el Gris");
        }
    }
}

