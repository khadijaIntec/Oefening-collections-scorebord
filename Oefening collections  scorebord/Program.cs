using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_collections__scorebord
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = true;
            string name;
            List<Persoon> Personen = new List<Persoon>();

            do
            {
                Console.WriteLine("Geef een naam om een speler toe te voegen of Type stope om te stoppen");
                name = Console.ReadLine();
                if (name.ToUpper() != "STOP")
                {
                    Personen.Add(new Persoon() { Naam = name, Score = 0 });
                }
                else
                {
                    stop = false;
                }
            } while (stop);
            
            stop = true;

            Console.Clear();
            Console.WriteLine("Naam\t\t|SCORE");
            Console.WriteLine(new string ('-', 50));

            do
            {
                foreach (var item in Personen)
                {
                    Console.WriteLine(item);

                }
                Console.WriteLine(("Geef de naam van een speler om zijn score te verhogen"));
                name = Console.ReadLine();

                if (name.ToUpper() != "STOP")
                {
                    
                    for (int i = 0; i < Personen.Count; i++)
                    {
                        if (Personen.ElementAt(i).Naam == name)
                        {
                            Console.Clear();
                            Personen.ElementAt(i).Score++;
                        }
                    }
                }
                else
                    stop = false;
            } while (stop);
            Console.ReadLine();
        }
    }

    class Persoon
    {
        public string Naam { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return Naam + "\t\t|" + Score;
        }
    }
}