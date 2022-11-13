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

            showPlayerScoreLabel.Text = me.Score.ToString();
            showPlayerCardsLabel.Text = me.GetCards();
            showDealerScoreLabel.Text = dealer.Score.ToString();
            showDealerCardsLabel.Text = dealer.GetCards();
        }

        void hitButton_Click(object sender, EventArgs e)
        {
            me.AddCard(deck.DrawCard());
            me.GetCards();
            showPlayerScoreLabel.Text = me.Score.ToString();
            showPlayerCardsLabel.Text = me.GetCards();

            if (me.Score == 21)
            {
                hitButton.Enabled = false;
                stayButton_Click(this, new EventArgs());
            }
            else if (me.Score > 21)
            {
                var form = new EndScreen("YOU LOSE!");
                form.ShowDialog();
                ResetState();
            }
        }

        void stayButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                dealer.AddCard(deck.DrawCard());
                dealer.GetCards();
                showDealerScoreLabel.Text = dealer.Score.ToString();
                showDealerCardsLabel.Text = dealer.GetCards();

                if (dealer.Score > 21)
                {
                    showDealerScoreLabel.Text = dealer.Score.ToString();
                    showDealerCardsLabel.Text = dealer.GetCards();
                    var form = new EndScreen("YOU WIN!");
                    form.ShowDialog();
                    ResetState();
                    return;
                }
                else if (dealer.Score > me.Score)
                {
                    showDealerScoreLabel.Text = dealer.Score.ToString();
                    showDealerCardsLabel.Text = dealer.GetCards();
                    var form = new EndScreen("YOU LOSE!");
                    form.ShowDialog();
                    ResetState();
                    return;
                }
                else if (dealer.Score == me.Score && dealer.Score == 21)
                {
                    showDealerScoreLabel.Text = dealer.Score.ToString();
                    showDealerCardsLabel.Text = dealer.GetCards();
                    var form = new EndScreen("TIE!");
                    form.ShowDialog();
                    ResetState();
                    return;
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

            showPlayerScoreLabel.Text = "0";
            showPlayerCardsLabel.Text = "-";
            showDealerScoreLabel.Text = "0";
            showDealerCardsLabel.Text = "-";
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
