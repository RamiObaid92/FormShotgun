using FormShotgun.Classes;
using Action = FormShotgun.Classes.Action;

namespace FormShotgun
{
    public partial class Form1 : Form
    {
        private GameLogic _gameLogic;
        public Form1()
        {
            InitializeComponent();
            _gameLogic = new GameLogic(this);
        }

        public void AddImageBullet(FlowLayoutPanel panel)
        {

            PictureBox bullet = new()
            {
                Image = Image.FromFile(@"C:\Users\zob_9\Downloads\bullet.PNG"),
                SizeMode = PictureBoxSizeMode.AutoSize,
            };

            panel.Controls.Add(bullet);
            panel.Controls.SetChildIndex(bullet, 0);
        }

        public void UpdateBulletImage(FlowLayoutPanel panel, int bulletCount)
        {
            panel.Controls.Clear();
            for (int i = 0; i < bulletCount; i++)
            {
                AddImageBullet(panel);
            }
        }

        public void UpdateBulletCount(int playerBullets, int computerBullets)
        {
            UpdateBulletImage(flpPlayer, playerBullets);
            UpdateBulletImage(flpComputer, computerBullets);

            buttonShoot.Enabled = playerBullets > 0;
            buttonShotgun.Enabled = playerBullets >= 3;
        }

        public void ActivateButtons(bool enable)
        {
            buttonBlock.Enabled = enable;
            buttonReload.Enabled = enable;
            buttonShoot.Enabled = enable && _gameLogic.GetPlayerBullets() > 0;
            buttonShotgun.Enabled = enable && _gameLogic.GetPlayerBullets() >= 3;
        }
        private void buttonReload_Click(object sender, EventArgs e)
        {
            _gameLogic.PlayRound(Action.Load);
            //Audio för ladda vapen.
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            _gameLogic.PlayRound(Action.Shoot);
            //Audio för skjuta vapen.
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            _gameLogic.PlayRound(Action.Block);
            //Audio för blocka.
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            _gameLogic.PlayRound(Action.Shotgun);
            //Audio för Shotgun
        }

        public void DisplayPlayerActions(string playerAction, string computerAction)
        {
            labelPlayerAction.Text = playerAction;
            labelComputerAction.Text = computerAction;
        }

        public void DisplayEndMessage(string message)
        {
            DialogResult result = MessageBox.Show(message, "Game over", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _gameLogic.ResetGame();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            _gameLogic.StartGame();
            ActivateButtons(true);
            //Kanske någon Audio här för startgame?
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            _gameLogic.ResetGame();
            //Samma audio som start game troligen.
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
