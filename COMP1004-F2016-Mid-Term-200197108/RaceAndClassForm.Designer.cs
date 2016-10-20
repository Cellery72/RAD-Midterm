﻿namespace COMP1004_F2016_Mid_Term_200197108
{
    partial class RaceAndClassForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.RaceGroupBox = new System.Windows.Forms.GroupBox();
            this.HalflingRadioButton = new System.Windows.Forms.RadioButton();
            this.DwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.ElfRadioButton = new System.Windows.Forms.RadioButton();
            this.HumanRadioButton = new System.Windows.Forms.RadioButton();
            this.NextButton = new System.Windows.Forms.Button();
            this.RaceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(16, 433);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(151, 49);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RaceGroupBox
            // 
            this.RaceGroupBox.Controls.Add(this.HalflingRadioButton);
            this.RaceGroupBox.Controls.Add(this.DwarfRadioButton);
            this.RaceGroupBox.Controls.Add(this.ElfRadioButton);
            this.RaceGroupBox.Controls.Add(this.HumanRadioButton);
            this.RaceGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceGroupBox.Location = new System.Drawing.Point(16, 15);
            this.RaceGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.RaceGroupBox.Name = "RaceGroupBox";
            this.RaceGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.RaceGroupBox.Size = new System.Drawing.Size(195, 214);
            this.RaceGroupBox.TabIndex = 5;
            this.RaceGroupBox.TabStop = false;
            this.RaceGroupBox.Text = "Select Race";
            // 
            // HalflingRadioButton
            // 
            this.HalflingRadioButton.AutoSize = true;
            this.HalflingRadioButton.Location = new System.Drawing.Point(8, 148);
            this.HalflingRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.HalflingRadioButton.Name = "HalflingRadioButton";
            this.HalflingRadioButton.Size = new System.Drawing.Size(109, 27);
            this.HalflingRadioButton.TabIndex = 5;
            this.HalflingRadioButton.Text = "Halfling";
            this.HalflingRadioButton.UseVisualStyleBackColor = true;
            this.HalflingRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // DwarfRadioButton
            // 
            this.DwarfRadioButton.AutoSize = true;
            this.DwarfRadioButton.Location = new System.Drawing.Point(8, 113);
            this.DwarfRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.DwarfRadioButton.Name = "DwarfRadioButton";
            this.DwarfRadioButton.Size = new System.Drawing.Size(88, 27);
            this.DwarfRadioButton.TabIndex = 4;
            this.DwarfRadioButton.Text = "Dwarf";
            this.DwarfRadioButton.UseVisualStyleBackColor = true;
            this.DwarfRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // ElfRadioButton
            // 
            this.ElfRadioButton.AutoSize = true;
            this.ElfRadioButton.Location = new System.Drawing.Point(8, 79);
            this.ElfRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ElfRadioButton.Name = "ElfRadioButton";
            this.ElfRadioButton.Size = new System.Drawing.Size(57, 27);
            this.ElfRadioButton.TabIndex = 3;
            this.ElfRadioButton.Text = "Elf";
            this.ElfRadioButton.UseVisualStyleBackColor = true;
            this.ElfRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // HumanRadioButton
            // 
            this.HumanRadioButton.AutoSize = true;
            this.HumanRadioButton.Checked = true;
            this.HumanRadioButton.Location = new System.Drawing.Point(8, 44);
            this.HumanRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.HumanRadioButton.Name = "HumanRadioButton";
            this.HumanRadioButton.Size = new System.Drawing.Size(101, 27);
            this.HumanRadioButton.TabIndex = 0;
            this.HumanRadioButton.TabStop = true;
            this.HumanRadioButton.Text = "Human";
            this.HumanRadioButton.UseVisualStyleBackColor = true;
            this.HumanRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(487, 433);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(151, 49);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // RaceAndClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 540);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RaceGroupBox);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RaceAndClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race And Class Selection";
            this.RaceGroupBox.ResumeLayout(false);
            this.RaceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox RaceGroupBox;
        private System.Windows.Forms.RadioButton HalflingRadioButton;
        private System.Windows.Forms.RadioButton DwarfRadioButton;
        private System.Windows.Forms.RadioButton ElfRadioButton;
        private System.Windows.Forms.RadioButton HumanRadioButton;
        protected System.Windows.Forms.Button NextButton;
    }
}