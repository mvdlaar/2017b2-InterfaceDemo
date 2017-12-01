using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Huisdier> huisdieren = new List<Huisdier>();

            Huisdier mijnHuisdier = new Hond();
            mijnHuisdier.Naam = "Fikkie";
            huisdieren.Add(mijnHuisdier);

            mijnHuisdier = new Schildpad();
            mijnHuisdier.Naam = "Michealangelo";
            huisdieren.Add(mijnHuisdier);

            mijnHuisdier = new Goudvis();
            mijnHuisdier.Naam = "Fishstick";
            huisdieren.Add(mijnHuisdier);

            mijnHuisdier = new Salamander();
            mijnHuisdier.Naam = "Sammie";
            huisdieren.Add(mijnHuisdier);

            foreach (Huisdier d in huisdieren)
            {
                Console.WriteLine(d.Eten());
                if (d is Hond)
                {
                    Console.WriteLine((d as Hond).Blaffen());
                }
                if (d is IZwemmen)
                {
                    Console.WriteLine((d as IZwemmen).Zwemmen());
                }
                if (d is ILopen)
                {
                    Console.WriteLine((d as ILopen).Lopen());
                }
            }

            Console.ReadKey();
        }
    }
}
