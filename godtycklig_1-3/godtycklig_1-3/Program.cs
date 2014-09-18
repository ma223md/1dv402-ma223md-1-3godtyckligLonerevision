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
            for (n = 1, i = 0; n <= numberOfSalaries; n++)
            {
                Console.Write("Lön {0}: ", n);
                salaries[i] = int.Parse(Console.ReadLine());
                i++;
            }

            // Räkna ut medellön
            avarageSalary = salaries.Average();
            Console.WriteLine("Medellön: {0}", avarageSalary);

            // Räkna ut lönespridning
            salarySpread = salaries.Max() - salaries.Min();
            Console.WriteLine("Lönespridning: {0}", salarySpread);

            // Gör kopia på array för att räkna ut median
            Array.Copy(salaries, median, numberOfSalaries);
            Array.Sort(median);
            Console.WriteLine("Medianlön: {0}", median[median.Length/2]);
            Console.WriteLine(median[0]);
            Console.WriteLine(median[1]);
            Console.WriteLine(median[2]);

        }


        static int ReadInt(string prompt)
        {
            // Mata in antal löner
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());

        }

    }
}
