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

            do
            {
                numberOfSalaries = ReadInt("Mata in antal löner: "); // Kalla metoden ReadInt för att få antal löner
 
                // Felmeddelande om inmatat antal är mindre än 2
                if (numberOfSalaries < 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR! Behövs minst 2 löner för uträkningen");
                    Console.ResetColor();   
                }

                else
                {
                    // Kalla metoden ProcessSalaries för att mata in löner och bearbeta dom
                    ProcessSalaries(numberOfSalaries);
                }

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Tryck valfri tangent för ny beräkning, ESC avslutar.");
                Console.WriteLine("");
                Console.ResetColor();

            } // Om annan tangent än ESC trycks startas ny beräkning
            while (Console.ReadKey(true).Key != ConsoleKey.Escape); 
        }
        
        static void ProcessSalaries(int numberOfSalaries)
        {
            // Definiera variabler
            int []salaries = new int[numberOfSalaries];
            int[] median = new int[numberOfSalaries];
            int i, n;
            double avarageSalary, salarySpread;

            for (i = 0; i < numberOfSalaries; i++)
            {
                salaries[i] = ReadInt("Ange lön" + (i + 1) + ":");
            }

            Console.WriteLine("-------------------------------");
            // Räkna ut medellön
            avarageSalary = Math.Round(salaries.Average());
            Console.WriteLine("Medellön: {0, 20:c0}", avarageSalary);

            // Räkna ut lönespridning
            salarySpread = salaries.Max() - salaries.Min();
            Console.WriteLine("Lönespridning: {0, 15:c0}", salarySpread);

            // Gör kopia på array för att räkna ut median
            Array.Copy(salaries, median, numberOfSalaries);
            Array.Sort(median);
            Console.WriteLine("Medianlön:{0, 20:c}", median[median.Length / 2]);
            Console.WriteLine("-------------------------------");

            // Skriv ut värdena i samma ordning som de skrevs in
            for (i = 0, n = 0; i < numberOfSalaries; i++)
            {
                //Console.Write(salaries[i] + " ");
                Console.Write("{0, 7}", salaries[i]);
                n++;
                if ( n > 2 && n % 3 == 0)
                {
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
        }

        static int ReadInt(string prompt)
        {
            // Mata in antal löner
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException) // Felmeddelande om något annat än ett heltal matas in
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Antalet måste vara ett heltal!");
                    Console.ResetColor();
                }
            }
        }
    }
}
