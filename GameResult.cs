using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    internal class GameResult
    {
        private static int indexer = new Random(Guid.NewGuid().GetHashCode()).Next();
        public int Index { get; }
        public GameAccount Player { get; }
        public GameAccount Opponent { get; }
        public bool Victory { get; }

        private int gameRating;
        public int GameRating
        {
            get => gameRating;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Рейтинг, на який грають гравці, не може бути від'ємним");
                gameRating = value;
            }
        }

        public GameResult(GameAccount player, GameAccount opponent, bool victory, int gameRating)
        {
            Index = indexer++;
            Player = player;
            Opponent = opponent;
            Victory = victory;
            GameRating = gameRating;
        }
    }
}
