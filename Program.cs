using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лб._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите имя кота: ");
            Cat cat = new Cat( (uint)rnd.Next(1, 20)) 
            {
                Name = Console.ReadLine()
            };
            Console.WriteLine($"Возраст: {cat.Age}");
            cat.Health = rnd.Next(1,10);
            Console.WriteLine($"Здоровье: {cat.Health}");
            while (cat.Health > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(cat.Health);
                Console.ResetColor();
                Console.WriteLine("Введите команду ''Feed'' или ''Punish'': ");
                string str = Console.ReadLine();
                if (str == "Feed")
                {
                    Console.WriteLine("Введите значение foodCount: ");
                    cat.Feed(Convert.ToInt32(Console.ReadLine()));
                }
                else if (str == "Punish")
                {
                    Console.WriteLine("Введите значение punch: ");
                    cat.Punish(Convert.ToInt32(Console.ReadLine()));
                }
                if (str == "Age")
                {
                    Console.Write("Возраст: ");
                    Console.WriteLine(cat.Age);
                }
            }

            if (cat.Health == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(cat.Health);
                Console.ResetColor();
            }
            else
                Console.WriteLine(cat.Health);
            
            Console.WriteLine("GAME OVER");
            Console.ReadKey();
            //я скачал TortoiseGit
        }
    }
}

