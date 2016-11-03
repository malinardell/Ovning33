using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Är MFF Sveriges bästa lag? ");
            string answer = Console.ReadLine();
            if (answer == "j" || answer == "J")
                Console.WriteLine("Helt rätt");

            Console.Write("Ange temperaturen i Svedala: ");
            int temperature1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange temperaturen i Jukkasjärvi: ");
            int temperature2 = Convert.ToInt32(Console.ReadLine());

            if (temperature1 < temperature2)
                Console.WriteLine("Det är kallast i Svedala");
            else if(temperature2 < temperature1)
                Console.WriteLine("Det är kallast i Jukkasjärvi");
            else
                Console.WriteLine("Det är lika kallt i båda städerna");

            Console.Write("Ange temperaturen i Svedala: ");
            int temperature3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange temperaturen i Jukkasjärvi: ");
            int temperature4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange temperaturen i Visby: ");
            int temperature5 = Convert.ToInt32(Console.ReadLine());

            int midTemperature = (temperature3 + temperature4 + temperature5) / 3;

            if (temperature3 > temperature4 && temperature3 > temperature5)
                Console.WriteLine("Det är varmast i Svedala och medeltemperaturen är: " + midTemperature);
            else if (temperature4 > temperature3 && temperature4 > temperature5)
                Console.WriteLine("Det är varmast i Jukkasjärvi och medeltemperaturen är: " + midTemperature);
            else
                Console.WriteLine("Det är varmast i visby och medeltemperaturen är: " + midTemperature);

            int var = 10;
            if (var = 10)
                Console.WriteLine("Den är 10");


        }
    }
}
