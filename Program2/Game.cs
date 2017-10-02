// Michael Eckel
// 5-11-17
// Game Class - used to create a new game

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public class Game
    {
        // creates a panel for the game
        public Panel Board { get; set; }

        // an array of PictureBox squares
        public PictureBox[,] GameBoard { get; set; }
        public string[,] fillArray = new string[6, 7];

        // an array of players
        private List<Player> gamePlayers = new List<Player>();
        private Player currentPlayer;
        private bool gameOver = false;

        //token images
        private Image blackToken = Resource1.SingleBlackToken;
        private Image redToken = Resource1.SingleRedToken;
        private Image blankBoardPiece = Resource1.boardSquare1;


        // Delegates
        public delegate void UpdatePlayerName(string playerName);

        public event UpdatePlayerName UpdateName;

        public delegate void Winner(string winnerName);

        public event Winner TheWinner;

        public delegate void EndGame(Panel theGame);

        public event EndGame GameOver;


        // constructors
        public Game()
        {
        }

        public Game(Panel theBoard)
        {
            this.Board = theBoard;
            GameBoard = new PictureBox[6, 7];
            DrawBoard();
        }


        public Player CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        public List<Player> GamePlayers
        {
            get { return gamePlayers; }
        }

        // method to draw the gameboard
        private void DrawBoard()
        {
            int left = 0;
            int top = 0;

            for (int row = 0; row <= GameBoard.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= GameBoard.GetUpperBound(1); col++)
                {
                    GameBoard[row, col] = new PictureBox();
                    GameBoard[row, col].Width = 110;
                    GameBoard[row, col].Height = 110;
                    GameBoard[row, col].Image = blankBoardPiece;
                    GameBoard[row, col].Location = new Point(left, top);
                    GameBoard[row, col].Tag = col;
                    GameBoard[row, col].Click += Game_Click;
                    left += 110;

                    Board.Controls.Add(GameBoard[row, col]);
                }
                left = 0;
                top += 110;
            }
        }

        // On-Click method for the gameboard squares
        private void Game_Click(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox) sender;

            int col = Convert.ToInt16(clicked.Tag);
            bool spotfilled = false;


            for (int x = fillArray.GetUpperBound(0); x >= 0; x--)
            {
                if (fillArray[x, col] == null && !spotfilled)
                {
                    fillArray[x, col] = currentPlayer.Team;

                    if (currentPlayer.Team == "black")
                    {
                        GameBoard[x, col].Image = blackToken;
                    }
                    else if (currentPlayer.Team == "red")
                    {
                        GameBoard[x, col].Image = redToken;
                    }


                    CheckWinner(col, x);
                    spotfilled = true;

                    if (IsTie())
                    {
                        TheWinner("It's a draw");
                        GameOver(Board);
                        gameOver = true;
                    }

                    if (!gameOver)
                    {
                        SwitchPlayer();
                    }
                }
            }
        }

        public bool IsTie()
        {
            for (int col = 0; col < this.fillArray.GetLength(1); col++)
                if (fillArray[0, col] == null)
                {
                    return false;
                }

            return true;
        }

        // Check Winner method
        public void CheckWinner(int col, int row)
        {
            if (CheckHorizontal(col, row))
            {
                TheWinner(currentPlayer.Name + " Wins!");
                GameOver(Board);
                gameOver = true;
            }

            if (CheckVertical(col, row))
            {
                TheWinner(currentPlayer.Name + " Wins!");
                GameOver(Board);
                gameOver = true;
            }

            if (CheckForwardDiagonal(col, row))
            {
                TheWinner(currentPlayer.Name + " Wins!");
                GameOver(Board);
                gameOver = true;
            }

            if (CheckBackwardDiagonal(col, row))
            {
                TheWinner(currentPlayer.Name + " Wins!");
                GameOver(Board);
                gameOver = true;
            }
        }

        // Method to check for a horizontal winner 
        public bool CheckHorizontal(int col, int row)
        {
            if (fillArray[row, col] == null)
            {
                return false;
            }

            int count = 1;
            int colCursor = col - 1;
            while (colCursor >= 0 && fillArray[row, colCursor] == fillArray[row, col])
            {
                count++;
                colCursor--;
            }
            colCursor = col + 1;
            while (colCursor < fillArray.GetLength(1) && fillArray[row, colCursor] == fillArray[row, col])
            {
                count++;
                colCursor++;
            }
            if (count < 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Method to check for a Vertical winner 
        public bool CheckVertical(int col, int row)
        {
            if (fillArray[row, col] == null)
            {
                return false;
            }

            int count = 1;
            int rowCursor = row - 1;
            while (rowCursor >= 0 && fillArray[rowCursor, col] == fillArray[row, col])
            {
                count++;
                rowCursor--;
            }
            rowCursor = row + 1;
            while (rowCursor < fillArray.GetLength(0) && fillArray[rowCursor, col] == fillArray[row, col])
            {
                count++;
                rowCursor++;
            }
            if (count < 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Method to check for a forward diagonal winner
        public bool CheckForwardDiagonal(int col, int row)
        {
            if (fillArray[row, col] == null)
            {
                return false;
            }

            int count = 1;
            int rowCursor = row - 1;
            int colCursor = col + 1;

            while (rowCursor >= 0 && colCursor < fillArray.GetLength(1) &&
                   fillArray[rowCursor, colCursor] == fillArray[row, col])
            {
                count++;
                rowCursor--;
                colCursor++;
            }

            rowCursor = row + 1;
            colCursor = col - 1;

            while (rowCursor < fillArray.GetLength(0) && colCursor >= 0 &&
                   fillArray[rowCursor, colCursor] == fillArray[row, col])
            {
                count++;
                rowCursor++;
                colCursor--;
            }

            if (count < 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Method to check for a backward diagonal winner 
        public bool CheckBackwardDiagonal(int col, int row)
        {
            if (fillArray[row, col] == null)
            {
                return false;
            }

            int count = 1;
            int rowCursor = row + 1;
            int colCursor = col + 1;
            while (rowCursor < fillArray.GetLength(0) && colCursor < fillArray.GetLength(1) &&
                   fillArray[rowCursor, colCursor] == fillArray[row, col])
            {
                count++;
                rowCursor++;
                colCursor++;
            }
            rowCursor = row - 1;
            colCursor = col - 1;
            while (rowCursor >= 0 && colCursor >= 0 && fillArray[rowCursor, colCursor] == fillArray[row, col])
            {
                count++;
                rowCursor--;
                colCursor--;
            }

            if (count < 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Method that switches players after a turn
        private void SwitchPlayer()
        {
            if (currentPlayer.Team == "black")
            {
                currentPlayer = gamePlayers[1];
                UpdateName(currentPlayer.Name);
            }
            else
            {
                currentPlayer = gamePlayers[0];
                UpdateName(currentPlayer.Name);
            }
        }

        // Method that adds the players to the game
        public void AddPlayers(Player teamBlack, Player teamRed)
        {
            gamePlayers.Add(teamBlack);
            gamePlayers.Add(teamRed);
        }
    }
}