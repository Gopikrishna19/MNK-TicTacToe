using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    /// <summary>
    /// Interface for viewing the game statistics
    /// </summary>
    public partial class Statistics : Form
    {
        /// <summary>
        /// Constructor: Initializes the form components of the interface
        /// </summary>
        public Statistics()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On loading the interface, update the stats with existing difficulty values
        /// </summary>        
        private void Statistics_Load(object sender, EventArgs e)
        {
            // Call load values that does the job
            LoadValues();
        }

        /// <summary>
        /// Calculate the total wins, loses, draws and other values stored in the app settings
        /// </summary>
        private void LoadValues()
        {
            int wins = Properties.Settings.Default.Success;
            int lose = Properties.Settings.Default.Failure;
            int draw = Properties.Settings.Default.Draw;

            lblTotal.Text = (wins + lose + draw).ToString();
            lblWins.Text = wins.ToString();
            lblLoses.Text = lose.ToString();
            lblDraws.Text = draw.ToString();
            lblPercentage.Text = Math.Round((double)wins / (wins + lose), 2).ToString() + "%";
        }

        /// <summary>
        /// On clicking OK close the stats
        /// </summary>        
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// On clicking Clear button, clear the settings and save the settings of the application
        /// and refresh the interface
        /// </summary>        
        private void btnClear_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Draw = 0;
            Properties.Settings.Default.Failure = 0;
            Properties.Settings.Default.Success = 0;
            Properties.Settings.Default.Save();

            LoadValues();
        }
    }
}
