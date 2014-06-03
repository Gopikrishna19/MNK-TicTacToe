using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    /// <summary>
    /// Interface for the main game
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Refers to the player whose turn is now to play
        /// </summary>
        private int _turn;

        /// <summary>
        /// Stores the GameBoard's Status
        /// </summary>
        private Board gameBoard;

        /// <summary>
        /// A multi-usable property to access _turn
        /// </summary>
        public int Turn
        {
            get { return _turn; }
            set
            {
                _turn = value;
                // Whenever the turn is changed, reflect it to the label on the Form
                lblBoardMessages.Text = (_turn == 1 ? "Your turn!" : "My turn! Please wait ...");
                Application.DoEvents();
            }
        }

        /// <summary>
        /// Constructor of MainForm for initializing form variables and contents of the game interface
        /// </summary>
        public MainForm()
        {
            // Initialize Form Components
            // Written natively by Visual Studio
            InitializeComponent();

            Show();

            // Set or reset all to initial values
            ResetAll();

        }

        /// <summary>
        /// Sets or resets all to initial values
        /// </summary>
        void ResetAll()
        {
            // Initialize Board
            gameBoard = new Board();

            // Clear all PictureBoxes
            foreach (var control in Controls)
            {
                if (control.GetType() == typeof(PictureBox))
                    ((PictureBox)control).Image = null;
            }

            // Make sure player want to play first or not
            if (MessageBox.Show("Do you want to play first?", "Choose an option ...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Turn = 1;
            else
            {
                Turn = 2;
                makeCPUsMove(0, 0, true);
            }
        }

        /// <summary>
        /// Upadte the Game Board when a PictureBox i.e. a cell is clicked.
        /// </summary>
        /// <param name="picBox">The particular PictureBox that is being clikced by the user</param>        
        private void pictureBox_click(object picBox, EventArgs e)
        {
            PictureBox currentPicBox = (PictureBox)picBox;

            // Each PictureBox in the Form is treated as the cell for TicTacToe Game.
            // Each PictureBox is named as "picXY", eg: "pic01", "pic02".
            // And each PictureBox is assigned a Tag with two intergers in the form of X,Y indicating the indices of the cell.
            // This Tag is used to get the corrensponding Board positions as follows.
            string[] position = currentPicBox.Tag.ToString().Split(',');
            Point markPosition = new Point(int.Parse(position[0]), int.Parse(position[1]));

            // Change the State of the Board only if the given position is N := Nothing
            if (gameBoard[markPosition.X, markPosition.Y] == State.N)
            {
                // Update Game Board
                gameBoard[markPosition.X, markPosition.Y] = (State)Turn;

                // Set clicked PictureBox to current player's symbol
                // Do it before going to next turn
                SuspendLayout();
                currentPicBox.Image = imgStates.Images[Turn - 1];
                currentPicBox.Refresh();
                Turn = Turn % 2 + 1;
                // Force refresh the form
                // Resume suspended layout
                ResumeLayout(true);

                // Check Board's status
                switch (gameBoard.getBoardStatus())
                {
                    case Status.Success:
                        // If X := CPU wins
                        MessageBox.Show("I win!", "You Lose!", MessageBoxButtons.OK);
                        lblBoardMessages.Text = "I Win!";

                        // Update game statistics
                        Properties.Settings.Default.Failure += 1;
                        Properties.Settings.Default.Save();

                        // Show End Game
                        showEndGame("Do you wanna play another game?");

                        // Reset all values
                        ResetAll();

                        break;
                    case Status.Failure:
                        // If O := Player wins
                        MessageBox.Show("You win!", "Congratulations!", MessageBoxButtons.OK);
                        lblBoardMessages.Text = "You Win!";

                        // Update game statistics
                        Properties.Settings.Default.Success += 1;
                        Properties.Settings.Default.Save();

                        // Show End Game
                        showEndGame("Do you wanna play another game?");

                        // Reset all values
                        ResetAll();
                        break;

                    case Status.Draw:
                        // Declare Draw and show End Game
                        lblBoardMessages.Text = "Draw!";

                        Properties.Settings.Default.Draw += 1;
                        Properties.Settings.Default.Save();

                        // Show End Game
                        showEndGame("This match is a Draw!" + Environment.NewLine + "Do you wanna play another game?");

                        // Reset All values
                        ResetAll();
                        break;

                    // In all other cases (incomplete board), continue playing
                    case Status.Incomplete:
                        // If it is turn 2, make the CPU to perform a move
                        if (Turn == 2) makeCPUsMove(markPosition.X, markPosition.Y);
                        break;
                }
            }
            else
            {
                // If the clicked cell is already marked
                lblBoardMessages.Text = "It's already marked!!";
            }
        }

        /// <summary>
        /// Shows the End Game message to the user with the given message
        /// </summary>
        /// <param name="message">The message to display on the End Game dialog</param>
        private void showEndGame(string message)
        {
            if (MessageBox.Show(message, "End Game", MessageBoxButtons.YesNo) == DialogResult.No)
                Application.Exit();
        }

        /// <summary>
        /// Perform the CPU's Move
        /// </summary>
        /// <param name="random">Make a random move?</param>
        private void makeCPUsMove(int OsRow, int OsCol, bool random = false)
        {
            int row = 0, col = 0;
            // If to make a random move
            if (random)
            {
                Random rand = new Random();
                row = rand.Next(0, 4);
                col = rand.Next(0, 5);
                // pictureBox_click(Controls["pic" + row.ToString() + col.ToString()], new EventArgs());
            }
            // Else make a move based on Alpha-Beta Search
            else
            {
                GameTreeNode gtn = new GameTreeNode(gameBoard, OsRow, OsCol);
                gtn.NextTurn = (State)Turn;
                SearchTree gt = new SearchTree();
                gtn.Text = "Root";
                GameTreeNode newMove;
                if (gt.insertNode(gtn))
                    newMove = gt.immResult;
                else
                {
                    newMove = gt.getNextBestMove();
                    //gt.ShowDialog();
                }
                row = newMove.Row;
                col = newMove.Column;
            }
            // Perform a click operation at on the PictureBox                  
            pictureBox_click(Controls["pic" + row.ToString() + col.ToString()], new EventArgs());
        }

        /// <summary>
        /// Start a new Game
        /// </summary>        
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirm with player to start a new game
            if (MessageBox.Show("Are you sure you want to start a new game?", "New Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetAll();
            }
        }

        /// <summary>
        /// Display Statistics
        /// </summary>
        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Statistics()).ShowDialog();
        }

        /// <summary>
        /// Show Difficulty Settings
        /// </summary>
        private void difficultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Difficulty()).ShowDialog();
        }

        /// <summary>
        /// Exit the Game
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check with user before exiting the game
            if (ShowExitDialog() == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Show Exit Dialog
        /// </summary>
        /// <returns>Returns the player's choice to continue exiting</returns>
        private DialogResult ShowExitDialog()
        {
            return MessageBox.Show("Are you sure you want to exit the game?", "Exit Game", MessageBoxButtons.YesNo);
        }

        /// <summary>
        /// Check with player before closing the game
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Before closing confirm with player
            // If player chooses no, cancel closing
            if (ShowExitDialog() == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
