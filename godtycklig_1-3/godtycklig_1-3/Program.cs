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
            while (true)
            {
                try
                {
                    numberOfSalaries = ReadInt("Mata in antal löner: "); 
                    break;
                } 
                catch(FormatException) // Felmeddelande om något annat än ett heltal matas in
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Antalet måste vara ett heltal!");
                    Console.ResetColor();
                }
            }
            
            // Felmeddelande om inmatat antal är mindre än 2
            if (numberOfSalaries < 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR! Behövs minst 2 löner för uträkningen");
                Console.ResetColor();
                return;
            }

            // Kalla metoden ProcessSalaries för att mata in löner och bearbeta dom
            ProcessSalaries(numberOfSalaries);

        }

        static void ProcessSalaries(int numberOfSalaries)
        {
            // Definiera variabler
            int []salaries = new int[numberOfSalaries];
            int[] median = new int[numberOfSalaries];
            int i, n;
            double avarageSalary, salarySpread;

            // Låt användaren skriva in lönerna
            while (true)
            {
                try
                {
                    for (n = 1, i = 0; n <= numberOfSalaries; n++)
                    {
                        Console.Write("Ange lön {0}: ", n);
                        salaries[i] = int.Parse(Console.ReadLine());
                        i++;
                    }
                    break;
                }
                // Felmeddelande om annat än heltal anges
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Antalet måste vara ett heltal!");
                    Console.ResetColor();
                    return;
                }

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
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());

        }

    }
}
