using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBar
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxHeal = 10;
            int minHeal = 0;
            int heal = 10;
            bool itWorks = true;
            string userInput;
            Console.WriteLine($"Это ваш показатель здоровья и при значении {heal} будет зеленый цвет.");
            DrawBar(maxHeal, heal);
            Console.WriteLine("Введите значение от 0 до 10.");

            while (itWorks != false)
            {
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int result) != true)
                {
                    Console.WriteLine("Допустимые значение от 0 до 10");                    
                }
                else 
                {                    
                    heal = Convert.ToInt32(userInput);
                    if (heal < minHeal || heal > maxHeal)
                    {
                        Console.WriteLine("Допустимый значение от 0 до 10");
                        //itWorks = false;
                    }
                    else
                    {
                        DrawBar(maxHeal, heal);
                    }                    
                }                
            }
        }

        static void DrawBar(int maxHeal, int heal)
        {
            string bar = "";
            string barHeal = "";
            ConsoleColor defaultColor = Console.ForegroundColor;

            for (int i = 0; i < heal; i++)
            {
                bar += "#";
            }

            Console.Write("[");

            if (heal <= 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (5 >= heal || heal <= 8)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (heal >= 9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.Write(bar);

            for (int i = heal; i < maxHeal; i++)
            {
                barHeal += "_";
            }
            Console.ForegroundColor = defaultColor;
            Console.Write(barHeal);
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}
