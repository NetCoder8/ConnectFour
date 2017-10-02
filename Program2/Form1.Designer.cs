namespace Program2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGamePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeamRed = new System.Windows.Forms.TextBox();
            this.txtTeamBlack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTeamRedPlayer = new System.Windows.Forms.Label();
            this.lblTeamBlackPlayer = new System.Windows.Forms.Label();
            this.picTeamRed = new System.Windows.Forms.PictureBox();
            this.picTeamBlack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGamePanel
            // 
            this.pnlGamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGamePanel.Location = new System.Drawing.Point(433, 125);
            this.pnlGamePanel.Name = "pnlGamePanel";
            this.pnlGamePanel.Size = new System.Drawing.Size(770, 660);
            this.pnlGamePanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Program2.Resource1.sidebar2;
            this.panel2.Controls.Add(this.lblWinner);
            this.panel2.Controls.Add(this.lblCurrentPlayer);
            this.panel2.Controls.Add(this.btnStartGame);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTeamRed);
            this.panel2.Controls.Add(this.txtTeamBlack);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblStartingLabel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 810);
            this.panel2.TabIndex = 18;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Green;
            this.lblWinner.Location = new System.Drawing.Point(113, 581);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 44);
            this.lblWinner.TabIndex = 16;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.ForeColor = System.Drawing.Color.Gold;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(211, 35);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(0, 20);
            this.lblCurrentPlayer.TabIndex = 15;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Black;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(133, 734);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(141, 51);
            this.btnStartGame.TabIndex = 9;
            this.btnStartGame.Text = "Start New Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Current Player:";
            // 
            // txtTeamRed
            // 
            this.txtTeamRed.Location = new System.Drawing.Point(182, 446);
            this.txtTeamRed.Name = "txtTeamRed";
            this.txtTeamRed.Size = new System.Drawing.Size(128, 20);
            this.txtTeamRed.TabIndex = 13;
            // 
            // txtTeamBlack
            // 
            this.txtTeamBlack.Location = new System.Drawing.Point(182, 385);
            this.txtTeamBlack.Name = "txtTeamBlack";
            this.txtTeamBlack.Size = new System.Drawing.Size(128, 20);
            this.txtTeamBlack.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Team Red";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Team Black";
            // 
            // lblStartingLabel
            // 
            this.lblStartingLabel.AutoSize = true;
            this.lblStartingLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblStartingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingLabel.ForeColor = System.Drawing.Color.Gold;
            this.lblStartingLabel.Location = new System.Drawing.Point(36, 316);
            this.lblStartingLabel.Name = "lblStartingLabel";
            this.lblStartingLabel.Size = new System.Drawing.Size(0, 17);
            this.lblStartingLabel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTeamRedPlayer);
            this.panel1.Controls.Add(this.lblTeamBlackPlayer);
            this.panel1.Controls.Add(this.picTeamRed);
            this.panel1.Controls.Add(this.picTeamBlack);
            this.panel1.Location = new System.Drawing.Point(81, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 197);
            this.panel1.TabIndex = 8;
            // 
            // lblTeamRedPlayer
            // 
            this.lblTeamRedPlayer.AutoSize = true;
            this.lblTeamRedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamRedPlayer.ForeColor = System.Drawing.Color.Gold;
            this.lblTeamRedPlayer.Location = new System.Drawing.Point(94, 135);
            this.lblTeamRedPlayer.Name = "lblTeamRedPlayer";
            this.lblTeamRedPlayer.Size = new System.Drawing.Size(0, 17);
            this.lblTeamRedPlayer.TabIndex = 3;
            // 
            // lblTeamBlackPlayer
            // 
            this.lblTeamBlackPlayer.AutoSize = true;
            this.lblTeamBlackPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamBlackPlayer.ForeColor = System.Drawing.Color.Gold;
            this.lblTeamBlackPlayer.Location = new System.Drawing.Point(91, 39);
            this.lblTeamBlackPlayer.Name = "lblTeamBlackPlayer";
            this.lblTeamBlackPlayer.Size = new System.Drawing.Size(0, 17);
            this.lblTeamBlackPlayer.TabIndex = 2;
            // 
            // picTeamRed
            // 
            this.picTeamRed.BackgroundImage = global::Program2.Resource1.teamRed;
            this.picTeamRed.Location = new System.Drawing.Point(25, 119);
            this.picTeamRed.Name = "picTeamRed";
            this.picTeamRed.Size = new System.Drawing.Size(50, 50);
            this.picTeamRed.TabIndex = 1;
            this.picTeamRed.TabStop = false;
            // 
            // picTeamBlack
            // 
            this.picTeamBlack.BackgroundImage = global::Program2.Resource1.teamBlack;
            this.picTeamBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTeamBlack.Location = new System.Drawing.Point(25, 23);
            this.picTeamBlack.Name = "picTeamBlack";
            this.picTeamBlack.Size = new System.Drawing.Size(50, 50);
            this.picTeamBlack.TabIndex = 0;
            this.picTeamBlack.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Program2.Resource1.connect4Header;
            this.pictureBox1.Location = new System.Drawing.Point(433, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 80);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 811);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlGamePanel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGamePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTeamRedPlayer;
        private System.Windows.Forms.Label lblTeamBlackPlayer;
        private System.Windows.Forms.PictureBox picTeamRed;
        private System.Windows.Forms.PictureBox picTeamBlack;
        private System.Windows.Forms.Label lblStartingLabel;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeamBlack;
        private System.Windows.Forms.TextBox txtTeamRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

