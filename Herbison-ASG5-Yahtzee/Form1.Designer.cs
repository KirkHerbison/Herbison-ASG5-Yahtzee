﻿namespace Herbison_ASG5_Yahtzee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelDie1Hold = new System.Windows.Forms.Label();
            this.labelDie2Hold = new System.Windows.Forms.Label();
            this.labelDie3Hold = new System.Windows.Forms.Label();
            this.labelDie4Hold = new System.Windows.Forms.Label();
            this.labelDie5Hold = new System.Windows.Forms.Label();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.imageListDice = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxDie1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDie1Hold
            // 
            this.labelDie1Hold.AutoSize = true;
            this.labelDie1Hold.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDie1Hold.Location = new System.Drawing.Point(147, 250);
            this.labelDie1Hold.Name = "labelDie1Hold";
            this.labelDie1Hold.Size = new System.Drawing.Size(69, 73);
            this.labelDie1Hold.TabIndex = 0;
            this.labelDie1Hold.Text = "0";
            // 
            // labelDie2Hold
            // 
            this.labelDie2Hold.AutoSize = true;
            this.labelDie2Hold.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDie2Hold.Location = new System.Drawing.Point(380, 250);
            this.labelDie2Hold.Name = "labelDie2Hold";
            this.labelDie2Hold.Size = new System.Drawing.Size(69, 73);
            this.labelDie2Hold.TabIndex = 1;
            this.labelDie2Hold.Text = "0";
            // 
            // labelDie3Hold
            // 
            this.labelDie3Hold.AutoSize = true;
            this.labelDie3Hold.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDie3Hold.Location = new System.Drawing.Point(613, 250);
            this.labelDie3Hold.Name = "labelDie3Hold";
            this.labelDie3Hold.Size = new System.Drawing.Size(69, 73);
            this.labelDie3Hold.TabIndex = 2;
            this.labelDie3Hold.Text = "0";
            // 
            // labelDie4Hold
            // 
            this.labelDie4Hold.AutoSize = true;
            this.labelDie4Hold.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDie4Hold.Location = new System.Drawing.Point(846, 250);
            this.labelDie4Hold.Name = "labelDie4Hold";
            this.labelDie4Hold.Size = new System.Drawing.Size(69, 73);
            this.labelDie4Hold.TabIndex = 3;
            this.labelDie4Hold.Text = "0";
            // 
            // labelDie5Hold
            // 
            this.labelDie5Hold.AutoSize = true;
            this.labelDie5Hold.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDie5Hold.Location = new System.Drawing.Point(1079, 250);
            this.labelDie5Hold.Name = "labelDie5Hold";
            this.labelDie5Hold.Size = new System.Drawing.Size(69, 73);
            this.labelDie5Hold.TabIndex = 4;
            this.labelDie5Hold.Text = "0";
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(148, 498);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(183, 81);
            this.buttonRoll.TabIndex = 5;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // imageListDice
            // 
            this.imageListDice.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDice.ImageStream")));
            this.imageListDice.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDice.Images.SetKeyName(0, "Die0.bmp");
            this.imageListDice.Images.SetKeyName(1, "Die1.bmp");
            this.imageListDice.Images.SetKeyName(2, "Die2.bmp");
            this.imageListDice.Images.SetKeyName(3, "Die3.bmp");
            this.imageListDice.Images.SetKeyName(4, "Die4.bmp");
            this.imageListDice.Images.SetKeyName(5, "Die5.bmp");
            this.imageListDice.Images.SetKeyName(6, "Die6.bmp");
            // 
            // pictureBoxDie1
            // 
            this.pictureBoxDie1.Location = new System.Drawing.Point(102, 97);
            this.pictureBoxDie1.Name = "pictureBoxDie1";
            this.pictureBoxDie1.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDie1.TabIndex = 6;
            this.pictureBoxDie1.TabStop = false;
            this.pictureBoxDie1.Click += new System.EventHandler(this.pictureBoxDie1_Click);
            // 
            // pictureBoxDie2
            // 
            this.pictureBoxDie2.Location = new System.Drawing.Point(339, 97);
            this.pictureBoxDie2.Name = "pictureBoxDie2";
            this.pictureBoxDie2.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDie2.TabIndex = 7;
            this.pictureBoxDie2.TabStop = false;
            this.pictureBoxDie2.Click += new System.EventHandler(this.pictureBoxDie2_Click);
            // 
            // pictureBoxDie3
            // 
            this.pictureBoxDie3.Location = new System.Drawing.Point(569, 97);
            this.pictureBoxDie3.Name = "pictureBoxDie3";
            this.pictureBoxDie3.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxDie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDie3.TabIndex = 8;
            this.pictureBoxDie3.TabStop = false;
            this.pictureBoxDie3.Click += new System.EventHandler(this.pictureBoxDie3_Click);
            // 
            // pictureBoxDie4
            // 
            this.pictureBoxDie4.Location = new System.Drawing.Point(798, 97);
            this.pictureBoxDie4.Name = "pictureBoxDie4";
            this.pictureBoxDie4.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxDie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDie4.TabIndex = 9;
            this.pictureBoxDie4.TabStop = false;
            this.pictureBoxDie4.Click += new System.EventHandler(this.pictureBoxDie4_Click);
            // 
            // pictureBoxDie5
            // 
            this.pictureBoxDie5.Location = new System.Drawing.Point(1032, 97);
            this.pictureBoxDie5.Name = "pictureBoxDie5";
            this.pictureBoxDie5.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxDie5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDie5.TabIndex = 10;
            this.pictureBoxDie5.TabStop = false;
            this.pictureBoxDie5.Click += new System.EventHandler(this.pictureBoxDie5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 983);
            this.Controls.Add(this.pictureBoxDie5);
            this.Controls.Add(this.pictureBoxDie4);
            this.Controls.Add(this.pictureBoxDie3);
            this.Controls.Add(this.pictureBoxDie2);
            this.Controls.Add(this.pictureBoxDie1);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.labelDie5Hold);
            this.Controls.Add(this.labelDie4Hold);
            this.Controls.Add(this.labelDie3Hold);
            this.Controls.Add(this.labelDie2Hold);
            this.Controls.Add(this.labelDie1Hold);
            this.Name = "Form1";
            this.Text = "Herbison Yahtzee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDie1Hold;
        private System.Windows.Forms.Label labelDie2Hold;
        private System.Windows.Forms.Label labelDie3Hold;
        private System.Windows.Forms.Label labelDie4Hold;
        private System.Windows.Forms.Label labelDie5Hold;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.ImageList imageListDice;
        private System.Windows.Forms.PictureBox pictureBoxDie1;
        private System.Windows.Forms.PictureBox pictureBoxDie2;
        private System.Windows.Forms.PictureBox pictureBoxDie3;
        private System.Windows.Forms.PictureBox pictureBoxDie4;
        private System.Windows.Forms.PictureBox pictureBoxDie5;
    }
}

