﻿
namespace BildSpel
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.Nej1 = new System.Windows.Forms.Button();
            this.Ja1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Är detta din bild?";
            // 
            // Nej1
            // 
            this.Nej1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nej1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nej1.Location = new System.Drawing.Point(445, 360);
            this.Nej1.Name = "Nej1";
            this.Nej1.Size = new System.Drawing.Size(121, 56);
            this.Nej1.TabIndex = 23;
            this.Nej1.Text = "Nej";
            this.Nej1.UseVisualStyleBackColor = false;
            this.Nej1.Click += new System.EventHandler(this.Nej1_Click);
            // 
            // Ja1
            // 
            this.Ja1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Ja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ja1.Location = new System.Drawing.Point(250, 360);
            this.Ja1.Name = "Ja1";
            this.Ja1.Size = new System.Drawing.Size(121, 56);
            this.Ja1.TabIndex = 22;
            this.Ja1.Text = "Ja";
            this.Ja1.UseVisualStyleBackColor = false;
            this.Ja1.Click += new System.EventHandler(this.Ja1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nej1);
            this.Controls.Add(this.Ja1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form7";
            this.Text = "Williams Spel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nej1;
        private System.Windows.Forms.Button Ja1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}