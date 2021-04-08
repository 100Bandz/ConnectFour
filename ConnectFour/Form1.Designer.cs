
namespace ConnectFour
{
    partial class ConnectFour
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
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.btnResetScore = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lbRedScore1 = new System.Windows.Forms.Label();
            this.lbYellowScore1 = new System.Windows.Forms.Label();
            this.lbGamesPlayed1 = new System.Windows.Forms.Label();
            this.lbTies1 = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbRedScore = new System.Windows.Forms.Label();
            this.lbYellowScore = new System.Windows.Forms.Label();
            this.lbGamesPlayed = new System.Windows.Forms.Label();
            this.lbTies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGame
            // 
            this.pbGame.Location = new System.Drawing.Point(12, 12);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(700, 600);
            this.pbGame.TabIndex = 1;
            this.pbGame.TabStop = false;
            this.pbGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGame_Paint);
            this.pbGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbGame_MouseClick);
            // 
            // btnResetScore
            // 
            this.btnResetScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetScore.Location = new System.Drawing.Point(758, 85);
            this.btnResetScore.Name = "btnResetScore";
            this.btnResetScore.Size = new System.Drawing.Size(139, 37);
            this.btnResetScore.TabIndex = 2;
            this.btnResetScore.Text = "Reset Score";
            this.btnResetScore.UseVisualStyleBackColor = true;
            this.btnResetScore.Click += new System.EventHandler(this.btnResetScore_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(758, 26);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(139, 37);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lbRedScore1
            // 
            this.lbRedScore1.AutoSize = true;
            this.lbRedScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRedScore1.ForeColor = System.Drawing.Color.Red;
            this.lbRedScore1.Location = new System.Drawing.Point(718, 207);
            this.lbRedScore1.Name = "lbRedScore1";
            this.lbRedScore1.Size = new System.Drawing.Size(100, 24);
            this.lbRedScore1.TabIndex = 4;
            this.lbRedScore1.Text = "RedScore:";
            // 
            // lbYellowScore1
            // 
            this.lbYellowScore1.AutoSize = true;
            this.lbYellowScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYellowScore1.ForeColor = System.Drawing.Color.Gold;
            this.lbYellowScore1.Location = new System.Drawing.Point(718, 260);
            this.lbYellowScore1.Name = "lbYellowScore1";
            this.lbYellowScore1.Size = new System.Drawing.Size(121, 24);
            this.lbYellowScore1.TabIndex = 5;
            this.lbYellowScore1.Text = "YellowScore:";
            // 
            // lbGamesPlayed1
            // 
            this.lbGamesPlayed1.AutoSize = true;
            this.lbGamesPlayed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGamesPlayed1.Location = new System.Drawing.Point(718, 371);
            this.lbGamesPlayed1.Name = "lbGamesPlayed1";
            this.lbGamesPlayed1.Size = new System.Drawing.Size(137, 24);
            this.lbGamesPlayed1.TabIndex = 6;
            this.lbGamesPlayed1.Text = "Games Played:";
            // 
            // lbTies1
            // 
            this.lbTies1.AutoSize = true;
            this.lbTies1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTies1.Location = new System.Drawing.Point(718, 316);
            this.lbTies1.Name = "lbTies1";
            this.lbTies1.Size = new System.Drawing.Size(51, 24);
            this.lbTies1.TabIndex = 7;
            this.lbTies1.Text = "Ties:";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.Location = new System.Drawing.Point(718, 153);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(55, 24);
            this.lbTurn.TabIndex = 8;
            this.lbTurn.Text = "Turn:";
            // 
            // lbRedScore
            // 
            this.lbRedScore.AutoSize = true;
            this.lbRedScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRedScore.Location = new System.Drawing.Point(824, 207);
            this.lbRedScore.Name = "lbRedScore";
            this.lbRedScore.Size = new System.Drawing.Size(85, 24);
            this.lbRedScore.TabIndex = 9;
            this.lbRedScore.Text = "redscore";
            // 
            // lbYellowScore
            // 
            this.lbYellowScore.AutoSize = true;
            this.lbYellowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYellowScore.Location = new System.Drawing.Point(845, 260);
            this.lbYellowScore.Name = "lbYellowScore";
            this.lbYellowScore.Size = new System.Drawing.Size(110, 24);
            this.lbYellowScore.TabIndex = 10;
            this.lbYellowScore.Text = "yellowscore";
            // 
            // lbGamesPlayed
            // 
            this.lbGamesPlayed.AutoSize = true;
            this.lbGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGamesPlayed.Location = new System.Drawing.Point(861, 371);
            this.lbGamesPlayed.Name = "lbGamesPlayed";
            this.lbGamesPlayed.Size = new System.Drawing.Size(67, 24);
            this.lbGamesPlayed.TabIndex = 11;
            this.lbGamesPlayed.Text = "games";
            // 
            // lbTies
            // 
            this.lbTies.AutoSize = true;
            this.lbTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTies.Location = new System.Drawing.Point(775, 316);
            this.lbTies.Name = "lbTies";
            this.lbTies.Size = new System.Drawing.Size(38, 24);
            this.lbTies.TabIndex = 12;
            this.lbTies.Text = "ties";
            // 
            // ConnectFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(944, 629);
            this.Controls.Add(this.lbTies);
            this.Controls.Add(this.lbGamesPlayed);
            this.Controls.Add(this.lbYellowScore);
            this.Controls.Add(this.lbRedScore);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.lbTies1);
            this.Controls.Add(this.lbGamesPlayed1);
            this.Controls.Add(this.lbYellowScore1);
            this.Controls.Add(this.lbRedScore1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnResetScore);
            this.Controls.Add(this.pbGame);
            this.Name = "ConnectFour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four";
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Button btnResetScore;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lbRedScore1;
        private System.Windows.Forms.Label lbYellowScore1;
        private System.Windows.Forms.Label lbGamesPlayed1;
        private System.Windows.Forms.Label lbTies1;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbRedScore;
        private System.Windows.Forms.Label lbYellowScore;
        private System.Windows.Forms.Label lbGamesPlayed;
        private System.Windows.Forms.Label lbTies;
    }
}

