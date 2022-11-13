using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    internal class Player
    {
        public int Score { get; private set; } = 0;

        readonly List<string> cards = new();

        public string GetCards() => string.Join(", ", cards);

        public void AddCard(string card)
        {
            cards.Add(card);
            Score += CalculateScore(card);
        }

        static int CalculateScore(string card)
        {
            var score = 0;

            if (card[2] == 2)
            {
                score = 2;
            }
            else if (card[2] == 3)
            {
                score = 3;
            }
            else if (card[2] == 4)
            {
                score = 4;
            }
            else if (card[2] == 5)
            {
                score = 5;
            }
            else if (card[2] == 6)
            {
                score = 6;
            }
            else if (card[2] == 7)
            {
                score = 7;
            }
            else if (card[2] == 8)
            {
                score = 8;
            }
            else if (card[2] == 9)
            {
                score = 9;
            }
            else if (card[2] == 1)
            {
                score = 10;
            }
            else if (card[2] == 'J' || card[2] == 'Q' || card[2] == 'K')
            {
                score = 10;
            }
            else if (card[2] == 'A')
            {
                score = 11;
            }

            return score;
        }
    }
}
