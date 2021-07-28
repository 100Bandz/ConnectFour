using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class ConnectFour : Form
    {
        private readonly int[,] boardArray = new int[6, 7]; //empty: -1  Red: 0  Yellow: 1

        private bool GameOver;
        private int Games;
        private int ScoreRed, ScoreYellow;
        private readonly int Ties = 0;

        private int turn;

        public ConnectFour()
        {
            InitializeComponent();
            newGame();
        }


        public void newGame() //Method #1
        {
            for (var irow = 0; irow < 6; irow = irow + 1)
            for (var icolumn = 0; icolumn < 7; icolumn = icolumn + 1)
                boardArray[irow, icolumn] = -1;
            // makes all the array value empty
            turn = 0; // Red always starts
            lbTurn.Text = "Turn: Red";
            GameOver = false;

            Games = Games + 1;

            lbGamesPlayed.Text = Games.ToString();
            lbTies.Text = Ties.ToString();
            lbRedScore.Text = ScoreRed.ToString();
            lbYellowScore.Text = ScoreYellow.ToString();

            pbGame.Invalidate();
        }

        public int IdentifyRow(int icolumn) //Method #2
        {
            for (var irow = 5; irow >= 0; irow = irow - 1)
                if (boardArray[irow, icolumn] == -1)
                    return irow;
                //Identifies row

            return -1; //Column is full
        }

        public bool IdentifyHorizontal(int irow, int icolumn)
        {
            //Checks for horizontal win
            if (icolumn >= 1 && icolumn <= 4)
                if (boardArray[irow, icolumn] == boardArray[irow, icolumn - 1] &&
                    boardArray[irow, icolumn] == boardArray[irow, icolumn + 1] &&
                    boardArray[irow, icolumn] == boardArray[irow, icolumn + 2])
                    return true;

            if (icolumn >= 2 && icolumn <= 5)
                if (boardArray[irow, icolumn] == boardArray[irow, icolumn - 2] &&
                    boardArray[irow, icolumn] == boardArray[irow, icolumn - 1] &&
                    boardArray[irow, icolumn] == boardArray[irow, icolumn + 1])
                    return true;

            if (icolumn <= 3)
                if (boardArray[irow, icolumn] == boardArray[irow, icolumn + 1] &&
                    boardArray[irow, icolumn] == boardArray[irow, icolumn + 2] &&
                    boardArray[irow, icolumn] == boardArray[irow, icolumn + 3])
                    return true;

            if (icolumn >= 3)
                if (boardArray[irow, icolumn] == boardArray[irow, icolumn - 1] &&
                    boardArray[irow, icolumn] == boardArray[irow, icolumn - 2] &&
                    boardArray[irow, icolumn] == boardArray[irow, icolumn - 3])
                    return true;
            return false;
        }

        public bool IdentifyVertical(int irow, int icolumn)
        {
            if (irow <= 2)
                if (boardArray[irow, icolumn] == boardArray[irow + 1, icolumn] &&
                    boardArray[irow, icolumn] == boardArray[irow + 2, icolumn] &&
                    boardArray[irow, icolumn] == boardArray[irow + 3, icolumn])
                    return true;
                //Checks for vertical win
            return false;
        }

        public bool IdentifyDiagonal(int irow, int icolumn)
        {
            //Up left
            if (irow >= 1 && icolumn >= 1 && irow <= 3 && icolumn <= 4)
                if (boardArray[irow, icolumn] == boardArray[irow - 1, icolumn - 1] &&
                    boardArray[irow, icolumn] == boardArray[irow + 1, icolumn + 1] &&
                    boardArray[irow, icolumn] == boardArray[irow + 2, icolumn + 2])
                    return true;
            if (irow <= 2 && icolumn <= 3)
                if (boardArray[irow, icolumn] == boardArray[irow + 1, icolumn + 1] &&
                    boardArray[irow, icolumn] == boardArray[irow + 2, icolumn + 2] &&
                    boardArray[irow, icolumn] == boardArray[irow + 3, icolumn + 3])
                    return true;
            if (irow >= 2 && icolumn >= 2 && irow <= 4 && icolumn <= 5)
                if (boardArray[irow, icolumn] == boardArray[irow - 1, icolumn - 1] &&
                    boardArray[irow, icolumn] == boardArray[irow - 2, icolumn - 2] &&
                    boardArray[irow, icolumn] == boardArray[irow + 1, icolumn + 1])
                    return true;
            if (irow >= 3 && icolumn >= 3)
                if (boardArray[irow, icolumn] == boardArray[irow - 1, icolumn - 1] &&
                    boardArray[irow, icolumn] == boardArray[irow - 2, icolumn - 2] &&
                    boardArray[irow, icolumn] == boardArray[irow - 3, icolumn - 3])
                    return true;


            //Up right
            if (icolumn >= 3 && irow <= 2)
            {
                if (boardArray[irow, icolumn] == boardArray[irow + 1, icolumn - 1] &&
                    boardArray[irow, icolumn] == boardArray[irow + 2, icolumn - 2] &&
                    boardArray[irow, icolumn] == boardArray[irow + 3, icolumn - 3]) return true;
            }

            else if (icolumn >= 2 && irow >= 1 && icolumn <= 5 && irow <= 3)
            {
                if (boardArray[irow, icolumn] == boardArray[irow + 1, icolumn - 1] &&
                    boardArray[irow, icolumn] == boardArray[irow + 2, icolumn - 2] &&
                    boardArray[irow, icolumn] == boardArray[irow - 1, icolumn + 1]) return true;
            }

            else if (icolumn >= 1 && irow >= 2 && icolumn <= 4 && irow <= 4)
            {
                if (boardArray[irow, icolumn] == boardArray[irow + 1, icolumn - 1] &&
                    boardArray[irow, icolumn] == boardArray[irow - 1, icolumn + 1] &&
                    boardArray[irow, icolumn] == boardArray[irow - 2, icolumn + 2]) return true;
            }

            else if (irow >= 3 && icolumn <= 3)
            {
                if (boardArray[irow, icolumn] == boardArray[irow - 1, icolumn + 1] &&
                    boardArray[irow, icolumn] == boardArray[irow - 2, icolumn + 2] &&
                    boardArray[irow, icolumn] == boardArray[irow - 3, icolumn + 3]) return true;
            }


            return false;
        }

        private void pbGame_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var penColor = Color.White;

            var DrawPen = new Pen(penColor, 3);
            var GameBoard = new SolidBrush(Color.RoyalBlue);

            Brush DrawBrush = new SolidBrush(Color.SeaShell);
            var Redpiece = new SolidBrush(Color.Red);
            var Yellowpiece = new SolidBrush(Color.Yellow);
            g.FillRectangle(GameBoard, 0, 0, 700, 600);


            //Brush for piece slots

            for (var i = 15; i < 700; i = i + 100)
            for (var j = 15; j < 600; j = j + 100)
            {
                g.DrawEllipse(DrawPen, i, j, 75, 75);
                g.FillEllipse(DrawBrush, i, j, 75, 75);
            }

            //For statement to make the rows and columns

            for (var irow = 0; irow < 6; irow = irow + 1)
            for (var icolumn = 0; icolumn < 7; icolumn = icolumn + 1)
                if (boardArray[irow, icolumn] == 0) // Draw Red Circle
                    g.FillEllipse(Redpiece, icolumn * 100 + 15, irow * 100 + 15, 75, 75);

                else if (boardArray[irow, icolumn] == 1)
                    g.FillEllipse(Yellowpiece, icolumn * 100 + 15, irow * 100 + 15, 75, 75); //Draws yellow circle
        }

        private void pbGame_MouseClick(object sender, MouseEventArgs e)
        {
            int mx, icolumn, irow;
            bool Horizontal, Vertical, Diagonal;

            if (GameOver)
            {
                MessageBox.Show("The game is over. Please start a new game.");
                return;

                //Prevents user from playing after the game has ended
            }

            mx = e.X;

            if (mx < 100)
                icolumn = 0;

            else if (mx < 200)
                icolumn = 1;

            else if (mx < 300)
                icolumn = 2;

            else if (mx < 400)
                icolumn = 3;
            else if (mx < 500)
                icolumn = 4;

            else if (mx < 600)
                icolumn = 5;

            else
                icolumn = 6;

            //Finds position (row, column) of mouse

            irow = IdentifyRow(icolumn);
            if (irow == -1) // column is full
            {
                //message box and return
                MessageBox.Show("Column is full!");
            }
            else
            {
                boardArray[irow, icolumn] = turn; // play
                pbGame.Invalidate();

                Horizontal = IdentifyHorizontal(irow, icolumn);

                Vertical = IdentifyVertical(irow, icolumn);

                Diagonal = IdentifyDiagonal(irow, icolumn);

                if (Horizontal)
                {
                    //Checks for Horizontal win
                    GameOver = true;
                    if (turn == 0)
                    {
                        MessageBox.Show("Red Won!");
                        ScoreRed = ScoreRed + 1;
                        lbRedScore.Text = ScoreRed.ToString();
                        //Yellow Victory
                    }
                    else
                    {
                        MessageBox.Show("Yellow Won!");
                        ScoreYellow = ScoreYellow + 1;
                        lbYellowScore.Text = ScoreYellow.ToString();
                        //Yellow Victory
                    }
                }

                if (Vertical)
                {
                    //Checks for vertical win
                    GameOver = true;
                    if (turn == 0)
                    {
                        MessageBox.Show("Red Won!");
                        ScoreRed = ScoreRed + 1;
                        lbRedScore.Text = ScoreRed.ToString();
                        //Red victory
                    }
                    else
                    {
                        MessageBox.Show("Yellow Won!");
                        ScoreYellow = ScoreYellow + 1;
                        lbYellowScore.Text = ScoreYellow.ToString();
                        //Yellow Victory
                    }
                }

                if (Diagonal)
                {
                    //Checks for Diagonal win
                    GameOver = true;
                    if (turn == 0)
                    {
                        MessageBox.Show("Red Won!");
                        ScoreRed = ScoreRed + 1;
                        lbRedScore.Text = ScoreRed.ToString();
                        //Red victory
                    }
                    else
                    {
                        MessageBox.Show("Yellow Won!");
                        ScoreYellow = ScoreYellow + 1;
                        lbYellowScore.Text = ScoreYellow.ToString();
                        //Yellow victory
                    }
                }

                if (turn == 0)
                {
                    turn = turn + 1;
                    //Changes turn to Yellow
                    lbTurn.Text = "Turn: Yellow";
                }
                else
                {
                    turn = turn - 1;
                    //Changes turn to Red
                    lbTurn.Text = "Turn: Red";
                }
            }
        }

        private void btnResetScore_Click(object sender, EventArgs e)
        {
            Games = 0;
            ScoreRed = 0;
            ScoreYellow = 0;

            lbGamesPlayed.Text = Games.ToString();
            lbRedScore.Text = ScoreRed.ToString();
            lbYellowScore.Text = ScoreYellow.ToString();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            newGame();
            lbTurn.Text = "Turn: Red";
        }
    }
}