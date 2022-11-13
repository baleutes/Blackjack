namespace L1
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            var gameScreen = new GameScreen();
            gameScreen.Show();
            this.Hide();
        }

        private void quitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}