using System;
using System.Drawing;
using System.Windows.Forms;

namespace JeuDeLaVieGraf
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Randomize = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LengthText = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(713, 201);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Randomize
            // 
            this.Randomize.Location = new System.Drawing.Point(698, 151);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(90, 23);
            this.Randomize.TabIndex = 2;
            this.Randomize.Text = "Randomize";
            this.Randomize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Click += new System.EventHandler(this.button2_Click);
            // 
            // LengthText
            // 
            this.LengthText.Location = new System.Drawing.Point(698, 123);
            this.LengthText.Name = "LengthText";
            this.LengthText.Size = new System.Drawing.Size(76, 22);
            this.LengthText.TabIndex = 3;
            this.LengthText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(634, 126);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(58, 20);
            this.Length.TabIndex = 5;
            this.Length.Text = "Length:";
            this.Length.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.LengthText);
            this.Controls.Add(this.Randomize);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        private System.Windows.Forms.Label Length;

        private System.Windows.Forms.TextBox LengthText;

        private System.Windows.Forms.Label Width;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.Button Randomize;
        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Start;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}