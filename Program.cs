using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datetypengrößen
            short a0= short.MaxValue;
            short a1 = short.MinValue;
            ushort a2 = 2*short.MaxValue + 1;
            int b = int.MaxValue;
            long c = long.MaxValue;
            Console.WriteLine("Short : " + a0 + " Int; " + b + " Long:" + c);
            Console.WriteLine("Short.min : " + a1 + " Short.max: " + a0 + " ushort: " + a2);

            //Verzweigungen (if - else Anweisung)

            int x = 5;
            int y = 7;
            if (x + y > 10)
            {
                Console.WriteLine("Das Ergebnis ist größer als 10");
            }
            else if (x+y ==10)
            {
                Console.WriteLine("Das Ergebnis ist genau 10");

            }
            else
            {
                Console.WriteLine("Das Ergebnis ist kleiner al 10");
            }

            //Shleifen
            //Wiederholte Abläufe

            int zähler = 0;
            while (zähler>-100)
            {
                Console.WriteLine("Der Zähler ist :" + zähler);
                //zähler = zähler + 1;
                // zähler +=1;
                zähler--;
            }
            int zähler2 = 0;
            do
            {
                Console.WriteLine("Der Zähler2 ist :" + zähler2);
                zähler2++;


            } while (zähler2 < 10);
            }



        }
    }
