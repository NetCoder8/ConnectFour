// Michael Eckel
// 5-11-17
// Main Class - used to display the new game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game currentGame = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            currentGame = new Game(pnlGamePanel);

            pnlGamePanel.Enabled = false;
            lblStartingLabel.Text = "Enter the names of the two players and then" + " \n\tClick 'Start Game' to begin.";
        }

        

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (txtTeamBlack.Text != " " && txtTeamRed.Text != "")
            {
                pnlGamePanel.Controls.Clear();
                currentGame = new Game(pnlGamePanel);

                // creates two players
                Player teamBlack = new Player(txtTeamBlack.Text, "black");
                Player teamRed = new Player(txtTeamRed.Text, "red");


                // adds the players to the current game
                currentGame.AddPlayers(teamBlack, teamRed);
                currentGame.UpdateName += CurrentGame_UpdateName;
                currentGame.GameOver += CurrentGame_GameOver;
                currentGame.TheWinner += CurrentGame_TheWinner;

                // sets the players name to assigned team and sets the current player to team black
                lblTeamBlackPlayer.Text = teamBlack.Name;
                lblTeamRedPlayer.Text = teamRed.Name;
                currentGame.CurrentPlayer = teamBlack;
                lblCurrentPlayer.Text = teamBlack.Name;
                lblStartingLabel.Visible = false;
                lblWinner.Text = "";

                pnlGamePanel.Enabled = true;

                btnStartGame.Enabled = false;
                btnStartGame.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter the player names");
            }
        }

        // Subscriber for the UpdatePlayer event    
        private void CurrentGame_UpdateName(string playerName)
        {
            lblCurrentPlayer.Text = playerName;
        }

        // subscriber for TheWinner event
        private void CurrentGame_TheWinner(string winnerName)
        {
            lblWinner.Text = winnerName;
        }

        // Subscriber for the game over event
        private void CurrentGame_GameOver(Panel theGame)
        {
           
            pnlGamePanel.Enabled = false;
            btnStartGame.Enabled = true;
            btnStartGame.Visible = true;
            txtTeamBlack.Text = "";
            txtTeamRed.Text = "";
            lblTeamBlackPlayer.Text = "";
            lblTeamRedPlayer.Text = "";
            lblCurrentPlayer.Text = "";
            lblStartingLabel.Visible = true;
        }
    }
}