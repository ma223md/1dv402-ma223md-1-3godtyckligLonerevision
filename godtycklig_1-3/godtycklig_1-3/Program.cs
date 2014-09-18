using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace godtycklig_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definiera variabler
            int numberOfSalaries;

            // Kalla metoden ReadInt för att få antal löner
            numberOfSalaries = ReadInt("Mata in antal löner: ");

            // Kalla metoden ProcessSalaries för att mata in löner och bearbeta dom
            ProcessSalaries(numberOfSalaries);

        }

        static void ProcessSalaries(int numberOfSalaries)
        {
            // Definiera variabler
            int []salaries = new int[numberOfSalaries];
            int i, n;

            // Felmeddelande om inmatat antal är mindre än 2
            if (numberOfSalaries < 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR! Behövs minst 2 löner för uträkningen");
                Console.ResetColor();
                return;
            }

            // Låt användaren skriva in lönerna
            for (n = 1, i = 0; n <= numberOfSalaries; n++)
            {
                Console.Write("Lön {0}: ", n);
                salaries[i] = int.Parse(Console.ReadLine());
                i++;
            }

            // Räkna ut median, medel och spridning på lönerna
            Console.WriteLine(salaries[0]);
            Console.WriteLine(salaries[1]);
            Console.WriteLine(salaries[2]);
        }


        static int ReadInt(string prompt)
        {
            // Mata in antal löner
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());

        }

    }
}
