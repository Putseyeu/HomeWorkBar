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
            int heal = maxHeal;
            int damage;
            bool itWorks = true;
            string userInput;
            int part = 100 / maxHeal; 
            Console.WriteLine($"Это ваш показатель здоровья и при значении {heal} едениц будет зеленый цвет.");
            DrawBar(maxHeal, heal, part);
            Console.WriteLine($"Наносите урон от {minHeal} до {maxHeal} и ваше значение здоровья измениться.");

            while (itWorks != false)
            {
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int result) != true)
                {
                    Console.WriteLine("Допустимые значение от 0 до 10");                    
                }
                else 
                {   
                    damage = Convert.ToInt32(userInput);
                    
                    if (damage < minHeal || damage > maxHeal)
                    {
                        Console.WriteLine($"Допустимый значение от {minHeal} до {maxHeal}");                        
                    }
                    else
                    {
                        heal = maxHeal - damage;
                        DrawBar(maxHeal, heal, part);
                    }                    
                }                 
            }
        }

        static void DrawBar(int maxHeal, int heal, int part)
        {
            string bar = "";
            string barHeal = "";
            ConsoleColor defaultColor = Console.ForegroundColor;

            for (int i = 0; i < heal; i++)
            {
                bar += "#";
            }

            Console.Write("[");
            int healthPercentage = heal * part; 
            if (healthPercentage <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (50 >= healthPercentage || healthPercentage <= 80)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (healthPercentage >= 90)
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
