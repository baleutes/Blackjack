using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1
{
    public partial class GameScreen : Form
    {
        bool canDealCards = false;
        Deck deck = new();
        Player me = new();
        Player dealer = new();

        public GameScreen()
        {
            InitializeComponent();
            ResetState();
        }

        void dealButton_Click(object sender, EventArgs e)
        {
            SwitchButtonStates();

            me.AddCard(deck.DrawCard());
            me.AddCard(deck.DrawCard());

            dealer.AddCard(deck.DrawCard());
            dealer.AddCard(deck.DrawCard());
        }

        void hitButton_Click(object sender, EventArgs e)
        {
            me.AddCard(deck.DrawCard());
        }

        void stayButton_Click(object sender, EventArgs e)
        {
            var dealerDrawsCard = true;
            while (dealerDrawsCard)
            {
                dealer.AddCard(deck.DrawCard());

                if (dealer.Score > me.Score)
                {
                    //TODO: Dealer wins
                }
                else if (dealer.Score > 21)
                {
                    //TODO: dealer lose me win
                }
                else if (dealer.Score == me.Score && dealer.Score == 21)
                {
                    //TODO: nobody wins; tie
                }
            }
        }

        void resetButton_Click(object sender, EventArgs e)
        {
            ResetState();
        }

        void ResetState()
        {
            canDealCards = false;
            SwitchButtonStates();

            deck = new Deck();
            me = new();
            dealer = new();
        }

        void SwitchButtonStates()
        {
            this.canDealCards = !canDealCards;
            this.dealButton.Enabled = canDealCards;
            this.hitButton.Enabled = !canDealCards;
            this.stayButton.Enabled = !canDealCards;
            this.resetButton.Enabled = !canDealCards;
        }
    }
}
