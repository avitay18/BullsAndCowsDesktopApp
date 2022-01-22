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
    public partial class ColorForm : Form
    {
        private Color m_Color;
        public ColorForm()
        {
            InitializeComponent();
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {

        }
        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            this.m_Color = clickedButton.BackColor;
            this.Close();
        }

        public Color Color
        {
            get
            {
                return this.m_Color;
            }
        }
        private void colorsAndLettersToButtons()
        {
            this.m_ColoredButtonList[0].BackColor = Color.Purple;
            this.m_ColoredButtonList[1].BackColor = Color.Red;
            this.m_ColoredButtonList[2].BackColor = Color.Green;
            this.m_ColoredButtonList[3].BackColor = Color.Aqua;
            this.m_ColoredButtonList[4].BackColor = Color.Blue;
            this.m_ColoredButtonList[5].BackColor = Color.Yellow;
            this.m_ColoredButtonList[6].BackColor = Color.Brown;
            this.m_ColoredButtonList[7].BackColor = Color.White;
        }
    }
}
