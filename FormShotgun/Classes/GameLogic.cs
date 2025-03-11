using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormShotgun.Classes
{
    // Klass för själva spellogiken, hur spelet hanteras beroende på olika händelser
    public class GameLogic
    {
        private HumanPlayer _humanPlayer;
        private ComputerPlayer _computerPlayer;
        private Form1 _gameUI;
        private bool _gameOver;
        private bool _playerWon;
        private bool _playerLost;
        private bool _draw;
        public GameLogic(Form1 gameUI)
        {
            _gameUI = gameUI;
            StartGame();
        }

        public void StartGame()
        {
            _humanPlayer = new HumanPlayer();
            _computerPlayer = new ComputerPlayer();
        }

        public void PlayRound(Action playerAction)
        {
            if (_gameOver == true)
            {
                return;
            }

            int playerBullets = _humanPlayer.Bullets;
            Action computerAction = _computerPlayer.GenerateAction(playerBullets);
            DetermineOutcome(playerAction, computerAction);
            WinCondition(playerAction, computerAction);
            _gameUI.UpdateBulletCount(_humanPlayer.Bullets, _computerPlayer.Bullets);
        }

        public void DetermineOutcome(Action playerAction, Action computerAction)
        {
            var actionPair = (playerAction, computerAction);


            switch (actionPair)
            {
                case (Action.Load, Action.Load):
                    _humanPlayer.IncreaseBullets(1);
                    _computerPlayer.IncreaseBullets(1);
                    break;

                case (Action.Load, Action.Block):
                    _humanPlayer.IncreaseBullets(1);
                    break;

                case (Action.Block, Action.Load):
                    _computerPlayer.IncreaseBullets(1);
                    break;

                case (Action.Block, Action.Block):
                    break;

                case (Action.Shoot, Action.Block):
                    if (_humanPlayer.HasBullets())
                    {
                        _humanPlayer.DecreaseBullets(1);
                    }
                    break;

                case (Action.Block, Action.Shoot):
                    if (_computerPlayer.HasBullets())
                    {
                        _computerPlayer.DecreaseBullets(1);
                    }
                    break;

                case (Action.Shoot, Action.Shoot):
                    if (_humanPlayer.HasBullets() && _computerPlayer.HasBullets())
                    {
                        _humanPlayer.DecreaseBullets(1);
                        _computerPlayer.DecreaseBullets(1);
                    }
                    break;

                case (Action.Shoot, Action.Load):
                    if (_humanPlayer.HasBullets())
                    {
                        _gameOver = true;
                        _playerWon = true;
                    }
                    break;

                case (Action.Load, Action.Shoot):
                    if (_computerPlayer.HasBullets())
                    {
                        _gameOver = true;
                        _playerLost = true;
                    }
                    break;

                case (Action.Shotgun, Action.Block):
                    if (_humanPlayer.CanUseShotgun())
                    {
                        _gameOver = true;
                        _playerWon = true;
                    }
                    break;

                case (Action.Shotgun, Action.Load):
                    if (_humanPlayer.CanUseShotgun())
                    {
                        _gameOver = true;
                        _playerWon = true;
                    }
                    break;

                case (Action.Shotgun, Action.Shoot):
                    if (_humanPlayer.CanUseShotgun() && _computerPlayer.HasBullets())
                    {
                        _gameOver = true;
                        _playerWon = true;
                    }
                    break;

                case (Action.Block, Action.Shotgun):
                    if (_computerPlayer.CanUseShotgun())
                    {
                        _gameOver = true;
                        _playerLost = true;
                    }
                    break;

                case (Action.Load, Action.Shotgun):
                    if (_computerPlayer.CanUseShotgun())
                    {
                        _gameOver = true;
                        _playerLost = true;
                    }
                    break;

                case (Action.Shoot, Action.Shotgun):
                    if (_computerPlayer.CanUseShotgun())
                    {
                        _gameOver = true;
                        _playerLost = true;
                    }
                    break;

                case (Action.Shotgun, Action.Shotgun):
                    if (_humanPlayer.CanUseShotgun() && _computerPlayer.CanUseShotgun())
                    {
                        _gameOver = true;
                        _draw = true;
                    }
                    break;
            }
            _gameUI.DisplayPlayerActions(playerAction.ToString(), computerAction.ToString());
        }

        public int GetPlayerBullets()
        {
            return _humanPlayer.Bullets;
        }
        public void WinCondition(Action playerAction, Action computerAction)
        {
            if (_gameOver == true)
            {
                _gameUI.ActivateButtons(false);
                if (_playerWon == true)
                {
                    _gameUI.DisplayEndMessage($"YOU WON WITH {playerAction.ToString()}! \n\n Would you like to play again?");
                }
                else if (_playerLost == true)
                {
                    _gameUI.DisplayEndMessage($"YOU LOST! Computer used {computerAction.ToString()} \n\n Would you like to play again?");

                }
                else if (_draw == true)
                {
                    _gameUI.DisplayEndMessage($"Draw! Both players used Shotgun \n\n Would you like to play again?");

                }
            }
        }

        public void ResetGame()
        {
            _humanPlayer = new HumanPlayer();
            _computerPlayer = new ComputerPlayer();
            _gameOver = false;
            _draw = false;
            _playerWon = false;
            _playerLost = false;
            _gameUI.UpdateBulletCount(_humanPlayer.Bullets, _computerPlayer.Bullets);
            _gameUI.ActivateButtons(true);
            _gameUI.DisplayPlayerActions("", "");
        }
    }
}
