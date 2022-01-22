using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolPgia
{
    public partial class EntryForm : Form
    {

        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game newGame = new Game();
            GameForm gameForm = new GameForm(this.m_NumberOfGuesses, newGame);
            gameForm.ShowDialog();
            this.Close();
        }


        private void NumberOfChancesButton_Click(object sender, EventArgs e)
        {
            if (this.m_NumberOfGuesses < 10 && this.m_NumberOfGuesses >= 4)
            {
                this.NumberOfChancesButton.Text = String.Format("Number of chances: {0}", ++this.m_NumberOfGuesses);
            }
            else
            {
                this.m_NumberOfGuesses = 4;
                this.NumberOfChancesButton.Text = String.Format("Number of chances: {0}", this.m_NumberOfGuesses);
            }
        }
    }
}
