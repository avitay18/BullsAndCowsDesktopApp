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
    public partial class GameForm : Form
    {

        private int m_CurrentLevel = 1;
        private readonly Game r_CurrentGame;
        private readonly int r_GameHeight;
        public GameForm(int i_NumberOfGuesses, Game i_NewGame)
        {
            InitializeComponent(i_NumberOfGuesses);
            this.r_CurrentGame = i_NewGame;
            this.r_GameHeight = i_NumberOfGuesses;
        }

        public List<Button> ButtonsList
        {
            get
            {
                return this.m_ButtonsList[this.m_CurrentLevel - 1];
            }
        }

        public List<Button> ResultButtonList
        {
            get
            {
                return this.m_ShowGuessResultButtonsList[this.m_CurrentLevel - 1];
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ColorForm colorForm = new ColorForm();
            colorForm.ShowDialog();
            if(!this.r_CurrentGame.IsColorAlreadySelected(colorForm.Color, ButtonsList))
            {
                clickedButton.BackColor = colorForm.Color;
            }

            if(checkRow())
            {
                this.m_ArrowButtonsList[this.m_CurrentLevel - 1].Enabled = true;
            }
        }

        private void arrowButton_Click(object sender, EventArgs e)
        {
            Button arrowButton = sender as Button;
            this.r_CurrentGame.CheckAndUpdateUserGuess(ButtonsList, ResultButtonList);
            if(this.r_CurrentGame.CheckWin(ResultButtonList) || this.m_CurrentLevel == this.r_GameHeight)
            {
                this.r_CurrentGame.ShowComputerGuess(this.m_ComputerButtonsList);
                disableAllControls();
                return;
            }
            arrowButton.Enabled = false;
            this.r_CurrentGame.DisableCurrentRow(ButtonsList);
            this.m_CurrentLevel++;
            this.r_CurrentGame.EnableNextRow(ButtonsList);
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            
        }
        private bool checkRow()
        {
            int counter = 0;
            foreach(Button button in ButtonsList)
            {
                if(button.BackColor != DefaultBackColor)
                {
                    counter++;
                }
            }

            return counter == ButtonsList.Count;
        }
        private void disableAllControls()
        {
            foreach(Control control in this.Controls)
            {
                control.Enabled = false;
            }
        }
    }
}
