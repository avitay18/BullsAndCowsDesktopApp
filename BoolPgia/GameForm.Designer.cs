using System.Collections.Generic;
using System.Windows.Forms;

namespace BoolPgia
{
    partial class GameForm
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
        private void InitializeComponent(int i_NumberOfGuesses)
        {

            this.SuspendLayout();

            for (int i = 1; i <= 4; i++)
            {
                this.m_ComputerGuess = new Button();
                this.m_ComputerButtonsList.Add(this.m_ComputerGuess);
                this.m_ComputerGuess.Location = new System.Drawing.Point(this.m_X, this.m_Y - 80);
                this.m_ComputerGuess.Margin = new System.Windows.Forms.Padding(4);
                this.m_ComputerGuess.Name = string.Format("ComputerGuess{0}", i);
                this.m_ComputerGuess.Size = new System.Drawing.Size(60, 60);
                this.m_ComputerGuess.UseVisualStyleBackColor = true;
                this.m_ComputerGuess.Enabled = false;
                this.m_ComputerGuess.BackColor = System.Drawing.Color.Black;
                this.m_X += 70;
            }

            for (int i = 0; i < i_NumberOfGuesses; i++)
            {
                this.m_X = 15;
                List<Button> newRowClickButton = new List<Button>();
                List<Button> newRowGuessButton = new List<Button>();
                for (int j = 1; j <= 4; j++)
                {

                    this.m_UserGuessButton = new Button();
                    newRowClickButton.Add(this.m_UserGuessButton);
                    this.m_UserGuessButton.Location = new System.Drawing.Point(this.m_X, this.m_Y);
                    this.m_UserGuessButton.Margin = new System.Windows.Forms.Padding(4);
                    this.m_UserGuessButton.Name = string.Format("userGuess{0}", j);
                    this.m_UserGuessButton.Size = new System.Drawing.Size(60, 60);
                    this.m_UserGuessButton.TabIndex = 4;
                    this.m_UserGuessButton.UseVisualStyleBackColor = true;
                    if (i == 0)
                    {
                        this.m_UserGuessButton.Enabled = true;
                    }
                    else
                    {
                        this.m_UserGuessButton.Enabled = false;
                    }
                    this.m_UserGuessButton.Click += new System.EventHandler(this.button_Click);
                    this.m_X += 70;
                }
                this.m_ButtonsList.Add(newRowClickButton);
                this.m_Y += 15;
                this.m_ArrowButton = new Button();
                this.m_ArrowButtonsList.Add(this.m_ArrowButton);
                this.m_ArrowButton.Location = new System.Drawing.Point(this.m_X, this.m_Y);
                this.m_ArrowButton.Margin = new System.Windows.Forms.Padding(4);
                this.m_ArrowButton.Name = "arrowButton";
                this.m_ArrowButton.Size = new System.Drawing.Size(65, 25);
                this.m_ArrowButton.TabIndex = 44;
                this.m_ArrowButton.Text = "-->>";
                this.m_ArrowButton.UseVisualStyleBackColor = true;
                this.m_ArrowButton.Enabled = false;
                this.m_ArrowButton.Click += new System.EventHandler(this.arrowButton_Click);
                this.m_Y -= 10;
                this.m_X += 80;

                int oddX = this.m_X;
                int evenX = this.m_X + 25;
                for (int k = 1; k <= 4; k++)
                {
                    this.m_CheckTheGuessButton = new Button();
                    newRowGuessButton.Add(this.m_CheckTheGuessButton);
                    this.m_CheckTheGuessButton.Location = new System.Drawing.Point(k % 2 != 0 ? oddX : evenX, k <= 2 ? this.m_Y : this.m_Y + 25);
                    this.m_CheckTheGuessButton.Margin = new System.Windows.Forms.Padding(4);
                    this.m_CheckTheGuessButton.Name = string.Format("checkUserGuess{0}", k);
                    this.m_CheckTheGuessButton.Size = new System.Drawing.Size(20, 20);
                    this.m_CheckTheGuessButton.TabIndex = 4;
                    this.m_CheckTheGuessButton.UseVisualStyleBackColor = true;
                    this.m_CheckTheGuessButton.Enabled = false;

                }
                this.m_ShowGuessResultButtonsList.Add(newRowGuessButton);
                this.m_Y += 70;
            }

            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(this.m_X + 60, this.m_Y);
            foreach (Button button in this.m_ArrowButtonsList)
            {
                this.Controls.Add(button);
            }

            foreach (Button button in this.m_ComputerButtonsList)
            {
                this.Controls.Add(button);
            }
            foreach (List<Button> button in this.m_ButtonsList)
            {
                for (int i = 0; i < button.Count; i++)
                {
                    this.Controls.Add(button[i]);
                }
            }

            foreach (List<Button> guessButton in this.m_ShowGuessResultButtonsList)
            {
                for (int i = 0; i < guessButton.Count; i++)
                {
                    this.Controls.Add(guessButton[i]);
                }
            }

            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bool Pgia";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.MaximizeBox = false;
            this.ResumeLayout(false);
        }

        #endregion

        private List<List<Button>> m_ButtonsList = new List<List<Button>>();
        private List<List<Button>> m_ShowGuessResultButtonsList = new List<List<Button>>();
        private List<Button> m_ArrowButtonsList = new List<Button>();
        private List<Button> m_ComputerButtonsList = new List<Button>();
        private int m_X = 15;
        private int m_Y = 100;
        private Button m_UserGuessButton;
        private Button m_ArrowButton;
        private Button m_CheckTheGuessButton;
        private Button m_ComputerGuess;
    }
}