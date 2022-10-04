using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    internal class GameAccount
    {
        public string UserName { get; set; }

        private int currentRating;
        public int CurrentRating
        {
            get => currentRating;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Ви намагаєтесь зробити рейтинг менше нуля");
                currentRating = value;
            }
        }

        private List<GameResult> stats;
        public int GamesCount => stats.Count;

        public GameAccount(string name)
        {
            UserName = name;
            currentRating = 50;
            stats = new List<GameResult>();
        }

        public void WinGame(GameAccount opponent, int rating)
        {
            this.CurrentRating += rating;
            GameResult victory = new GameResult(this, opponent, true, rating);
            stats.Add(victory);

            opponent.CurrentRating -= rating;
            GameResult defeat = new GameResult(opponent, this, false, rating);
            opponent.stats.Add(defeat);
        }

        public void LoseGame(GameAccount opponent, int rating)
        {
            this.CurrentRating -= rating;
            GameResult defeat = new GameResult(this, opponent, false, rating);
            stats.Add(defeat);

            opponent.CurrentRating += rating;
            GameResult victory = new GameResult(opponent, this, true, rating);
            opponent.stats.Add(victory);
        }

        public void PrintStats()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine($"Остаточний рейтинг гравця {this.UserName}: {this.CurrentRating}");
            Console.WriteLine($"Статистика усіх минулих ігор користувача {this.UserName}:");
            Console.WriteLine($"Усього ігор: {GamesCount}");
            foreach (var game in stats)
            {
                Console.WriteLine("***");
                Console.WriteLine($"Гра з індексом {game.Index}");
                Console.WriteLine($"Оппонентом був {game.Opponent.UserName}");
                if (game.Victory)
                    Console.WriteLine("Гра завершилась перемогою!!!");
                else
                    Console.WriteLine("Гра завершилась поразкою :((");
                Console.WriteLine($"Рейтинг, на який була гра: {game.GameRating}");

            }

            Console.WriteLine("************************************************************");
        }
    }
}
