using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas23
{
    class Program
    {

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static int Sum(List<int> numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number; // isto sto i sum = sum + number
            }
            return sum;
        }

        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>();

            string unos;
            do
            {
                Console.Write("Unesite broj (ostaviti prazan unos za kraj rada) > ");
                unos = Console.ReadLine();
                if (unos != "")
                {
                    brojevi.Add(Convert.ToInt32(unos));
                }
            } while (unos != "");

            int rezultat = Sum(brojevi);
            Console.WriteLine("Suma unetih brojeva je {0}", rezultat);

            Console.ReadKey();
        }

        static void Liste()
        {
            List<int> brojevi = new List<int>();
            List<string> stringovi = new List<string>();
            List<double> brojevi2 = new List<double>();

            string unos;
            do
            {
                Console.Write("Unesite broj (ostaviti prazan unos za kraj rada) > ");
                unos = Console.ReadLine();
                if (unos != "")
                {
                    brojevi.Add(Convert.ToInt32(unos));
                }
            } while (unos != "");

            Console.WriteLine("Unetih brojeva ima {0} i oni su: ", brojevi.Count);
            foreach (int broj in brojevi)
            {
                string parnost;

                if (IsEven(broj))
                {
                    parnost = "paran";
                }
                else
                {
                    parnost = "neparan";
                }

                parnost = (broj % 2 != 0) ? "neparan" : "paran";

                Console.WriteLine("Broj {0} je {1}", broj, parnost);
            }
        }

        static void Zadatak1()
        {
            int broj1, broj2, rezultat;

            Console.Write("Unesite prvi broj >");
            broj1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite drugi broj >");
            broj2 = Convert.ToInt32(Console.ReadLine());

            if (IsEven(broj1) || IsEven(broj2))
            {
                rezultat = broj1 + broj2;
                Console.WriteLine("Rezultat {0} + {1} = {2}", broj1, broj2, rezultat);
            }
            else
            {
                if (broj1 > broj2)
                {
                    rezultat = broj2 - broj1;
                    Console.WriteLine("Rezultat {0} - {1} = {2}", broj2, broj1, rezultat);
                }
                else
                {
                    rezultat = broj1 - broj2;
                    Console.WriteLine("Rezultat {0} - {1} = {2}", broj1, broj2, rezultat);
                }
            }
        }

        static void ConsoleRead()
        {
            Console.WriteLine("Ovo je neki red teksta.");
            Console.Write("Ovo je neki");
            Console.Write("drugi red teksta");
            Console.WriteLine();

            string entry;

            Console.Write("Unesite neki broj >");
            entry = Console.ReadLine();

            double broj = Convert.ToDouble(entry);
            Console.WriteLine("Korisnik je otkucao '{0}'", entry);
            Console.WriteLine("{0} * {0} = {1}", broj, broj * broj);

            Console.ReadKey();
        }
    }
}
