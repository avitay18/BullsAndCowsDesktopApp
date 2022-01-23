using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolPgia
{
    public class Game
    {
        private const int k_AmountOfSelections = 4;
        private List<Color> m_ComputerSelection;
        private readonly List<Color> m_ColorsList = new List<Color>
                                                              {
                                                                  Color.Purple, Color.Red, Color.Green, Color.Aqua, Color.Blue, Color.Yellow, Color.Brown, Color.White
                                                              };
        private Random m_Rand = new Random();

        public Game()
        {
            generateAiSelection();
        }

        public List<Color> ComputerSelection
        {
            get
            {
                return this.m_ComputerSelection;
            }
        }

        private void generateAiSelection()
        {
            m_ComputerSelection = new List<Color>();
            for (int i = 0; i < k_AmountOfSelections; i++)
            {
                int selectionIndex = this.m_Rand.Next(this.m_ColorsList.Count);
                this.m_ComputerSelection.Add(this.m_ColorsList[selectionIndex]);
                this.m_ColorsList.RemoveAt(selectionIndex);
            }
        }
        public bool IsColorAlreadySelected(Color i_Color, List<Button> i_ButtonsList)
        {

            foreach (Button button in i_ButtonsList)
            {
                if (i_Color == button.BackColor)
                {
                    string message = String.Format("This color is already selected!{0}Please select a different color", Environment.NewLine);
                    string caption = "Color Selection Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        public void CheckAndUpdateUserGuess(List<Button> i_GuessButtons, List<Button> i_ResultsButtonList)
        {
            int i = 0;
            int VCounter = 0;

            foreach (Button button in i_GuessButtons)
            {
                if (button.BackColor == ComputerSelection[i])
                {
                    i_ResultsButtonList[VCounter++].BackColor = Color.Black;
                }

                i++;
            }

            i = 0;
            foreach (Button button in i_GuessButtons)
            {
                if (ComputerSelection.Contains(button.BackColor))
                {
                    if (ComputerSelection.IndexOf(button.BackColor) != i)
                    {
                        i_ResultsButtonList[VCounter++].BackColor = Color.Yellow;
                    }
                }
                i++;
            }
        }
        public void DisableCurrentRow(List<Button> i_ButtonsList)
        {
            foreach (Button button in i_ButtonsList)
            {
                button.Enabled = false;
            }
        }

        public void EnableNextRow(List<Button> i_ButtonsList)
        {
            foreach (Button button in i_ButtonsList)
            {
                button.Enabled = true;
            }
        }

        public bool CheckWin(List<Button> i_ResultsButtonList)
        {
            int counter = 0;
            foreach (Button button in i_ResultsButtonList)
            {
                if (button.BackColor == Color.Black)
                {
                    counter++;
                }
            }

            return counter == this.m_ComputerSelection.Count;
        }
        public void ShowComputerGuess(List<Button> i_ComputerGuess)
        {
            int i = 0;
            foreach (Button button in i_ComputerGuess)
            {
                i_ComputerGuess[i].BackColor = this.m_ComputerSelection[i];
                i++;
            }
        }
    }
}
