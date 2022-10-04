using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***");
            GameAccount pl1 = new GameAccount("Василь");
            Console.WriteLine("Василь сів за гральний стіл!");
            GameAccount pl2 = new GameAccount("Остап");
            Console.WriteLine("Остап приєднався до гри!");

            Console.WriteLine("\n***");
            Console.WriteLine("Перша гра почалась!");
            Console.WriteLine("Гра на 13 рейтингу");
            pl1.WinGame(pl2, 13);
            Console.WriteLine("Хто виграв дізнаємось у статистиці");

            Console.WriteLine("\n***");
            Console.WriteLine("Друга гра почалась!");
            Console.WriteLine("Гра на 8 рейтингу");
            pl1.LoseGame(pl2, 8);
            Console.WriteLine("Хто виграв дізнаємось у статистиці");

            Console.WriteLine("\n***");
            Console.WriteLine("Третя гра почалась!");
            Console.WriteLine("Гра на 17 рейтингу");
            pl1.LoseGame(pl2, 17);
            Console.WriteLine("Хто виграв дізнаємось у статистиці");

            pl1.PrintStats();
            Console.WriteLine();
            pl2.PrintStats();

            Console.ReadLine();
        }
    }
}
