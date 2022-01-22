using System;
using System.Windows.Forms;

namespace BoolPgia
{
    partial class EntryForm
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
            this.m_NumberOfGuesses = 4;
            this.StartButton = new System.Windows.Forms.Button();
            this.NumberOfChancesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(134, 86);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(104, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NumberOfChancesButton
            // 
            this.NumberOfChancesButton.Location = new System.Drawing.Point(12, 12);
            this.NumberOfChancesButton.Name = "NumberOfChancesButton";
            this.NumberOfChancesButton.Size = new System.Drawing.Size(226, 23);
            this.NumberOfChancesButton.TabIndex = 1;
            this.NumberOfChancesButton.Text = String.Format("Number of chances: {0}", this.m_NumberOfGuesses);
            this.NumberOfChancesButton.UseVisualStyleBackColor = true;
            this.NumberOfChancesButton.Click += new System.EventHandler(this.NumberOfChancesButton_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(250, 128);
            this.Controls.Add(this.NumberOfChancesButton);
            this.Controls.Add(this.StartButton);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "EntryForm";
            this.Text = "Bool Pgia";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.MaximizeBox = false;
            this.ResumeLayout(false);
        }

        #endregion

        private int m_NumberOfGuesses;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button NumberOfChancesButton;
    }
}