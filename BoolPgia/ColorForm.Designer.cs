using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace BoolPgia
{
    partial class ColorForm
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

            this.SuspendLayout();

            for (int i = 0; i < 8; i++)
            {
                if (i == 4)
                {
                    this.m_X = 10;
                    this.m_Y += 70;
                }
                this.m_ColorButton = new Button();
                this.m_ColorButton.Location = new Point(this.m_X, this.m_Y);
                this.m_ColorButton.Size = new Size(60, 60);
                this.m_ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
                this.m_ColoredButtonList.Add(this.m_ColorButton);
                this.m_X += 70;

            }
            colorsAndLettersToButtons();
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 160);
            foreach (Button button in this.m_ColoredButtonList)
            {
                this.Controls.Add(button);
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = "ColorsForm";
            this.Text = "Choose A Color";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ColorForm_Load);
            this.MaximizeBox = false;
            this.ResumeLayout(false);
        }

        #endregion
        private List<Button> m_ColoredButtonList = new List<Button>();
        private Button m_ColorButton;
        private int m_X = 10;
        private int m_Y = 10;
    }
}