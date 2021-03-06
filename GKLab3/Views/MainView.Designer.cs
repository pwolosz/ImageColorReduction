﻿namespace GKLab3.Views
{
    partial class mainView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.beforeImagePictureBox = new System.Windows.Forms.PictureBox();
            this.errorB = new System.Windows.Forms.Label();
            this.errorG = new System.Windows.Forms.Label();
            this.errorR = new System.Windows.Forms.Label();
            this.kLabel = new System.Windows.Forms.Label();
            this.kComboBox = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.methodLabel = new System.Windows.Forms.Label();
            this.reduceColorsButton = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Label();
            this.gColor = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.gTextBox = new System.Windows.Forms.TextBox();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.colorsTextBox = new System.Windows.Forms.TextBox();
            this.rLabel = new System.Windows.Forms.Label();
            this.colorsLabel = new System.Windows.Forms.Label();
            this.methodsComboBox = new System.Windows.Forms.ComboBox();
            this.openImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforeImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.beforeImagePictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.errorB);
            this.splitContainer1.Panel2.Controls.Add(this.errorG);
            this.splitContainer1.Panel2.Controls.Add(this.errorR);
            this.splitContainer1.Panel2.Controls.Add(this.kLabel);
            this.splitContainer1.Panel2.Controls.Add(this.kComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.filterLabel);
            this.splitContainer1.Panel2.Controls.Add(this.filterComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.methodLabel);
            this.splitContainer1.Panel2.Controls.Add(this.reduceColorsButton);
            this.splitContainer1.Panel2.Controls.Add(this.bColor);
            this.splitContainer1.Panel2.Controls.Add(this.gColor);
            this.splitContainer1.Panel2.Controls.Add(this.bTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.gTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.rTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.colorsTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.rLabel);
            this.splitContainer1.Panel2.Controls.Add(this.colorsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.methodsComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.openImageButton);
            this.splitContainer1.Size = new System.Drawing.Size(703, 545);
            this.splitContainer1.SplitterDistance = 487;
            this.splitContainer1.TabIndex = 1;
            // 
            // beforeImagePictureBox
            // 
            this.beforeImagePictureBox.Location = new System.Drawing.Point(4, 4);
            this.beforeImagePictureBox.Name = "beforeImagePictureBox";
            this.beforeImagePictureBox.Size = new System.Drawing.Size(100, 50);
            this.beforeImagePictureBox.TabIndex = 0;
            this.beforeImagePictureBox.TabStop = false;
            // 
            // errorB
            // 
            this.errorB.AutoSize = true;
            this.errorB.ForeColor = System.Drawing.Color.Red;
            this.errorB.Location = new System.Drawing.Point(113, 141);
            this.errorB.Name = "errorB";
            this.errorB.Size = new System.Drawing.Size(0, 13);
            this.errorB.TabIndex = 18;
            // 
            // errorG
            // 
            this.errorG.AutoSize = true;
            this.errorG.ForeColor = System.Drawing.Color.Red;
            this.errorG.Location = new System.Drawing.Point(113, 114);
            this.errorG.Name = "errorG";
            this.errorG.Size = new System.Drawing.Size(0, 13);
            this.errorG.TabIndex = 17;
            // 
            // errorR
            // 
            this.errorR.AutoSize = true;
            this.errorR.ForeColor = System.Drawing.Color.Red;
            this.errorR.Location = new System.Drawing.Point(113, 87);
            this.errorR.Name = "errorR";
            this.errorR.Size = new System.Drawing.Size(0, 13);
            this.errorR.TabIndex = 16;
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(43, 194);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(14, 13);
            this.kLabel.TabIndex = 15;
            this.kLabel.Text = "K";
            // 
            // kComboBox
            // 
            this.kComboBox.FormattingEnabled = true;
            this.kComboBox.Location = new System.Drawing.Point(63, 191);
            this.kComboBox.Name = "kComboBox";
            this.kComboBox.Size = new System.Drawing.Size(121, 21);
            this.kComboBox.TabIndex = 14;
            this.kComboBox.SelectedValueChanged += new System.EventHandler(this.KValueChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(28, 167);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(29, 13);
            this.filterLabel.TabIndex = 13;
            this.filterLabel.Text = "Filter";
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(63, 164);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterComboBox.TabIndex = 12;
            this.filterComboBox.SelectedValueChanged += new System.EventHandler(this.ChangeFilter);
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(81, 226);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(43, 13);
            this.methodLabel.TabIndex = 11;
            this.methodLabel.Text = "Method";
            // 
            // reduceColorsButton
            // 
            this.reduceColorsButton.Location = new System.Drawing.Point(63, 269);
            this.reduceColorsButton.Name = "reduceColorsButton";
            this.reduceColorsButton.Size = new System.Drawing.Size(86, 28);
            this.reduceColorsButton.TabIndex = 10;
            this.reduceColorsButton.Text = "Reduce colors";
            this.reduceColorsButton.UseVisualStyleBackColor = true;
            this.reduceColorsButton.Click += new System.EventHandler(this.ReduceColorsClick);
            // 
            // bColor
            // 
            this.bColor.AutoSize = true;
            this.bColor.Location = new System.Drawing.Point(43, 141);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(14, 13);
            this.bColor.TabIndex = 9;
            this.bColor.Text = "B";
            // 
            // gColor
            // 
            this.gColor.AutoSize = true;
            this.gColor.Location = new System.Drawing.Point(42, 114);
            this.gColor.Name = "gColor";
            this.gColor.Size = new System.Drawing.Size(15, 13);
            this.gColor.TabIndex = 8;
            this.gColor.Text = "G";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(63, 138);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(45, 20);
            this.bTextBox.TabIndex = 7;
            this.bTextBox.Text = "2";
            this.bTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // gTextBox
            // 
            this.gTextBox.Location = new System.Drawing.Point(63, 111);
            this.gTextBox.Name = "gTextBox";
            this.gTextBox.Size = new System.Drawing.Size(45, 20);
            this.gTextBox.TabIndex = 6;
            this.gTextBox.Text = "2";
            this.gTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(63, 84);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(45, 20);
            this.rTextBox.TabIndex = 5;
            this.rTextBox.Text = "2";
            this.rTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // colorsTextBox
            // 
            this.colorsTextBox.Location = new System.Drawing.Point(63, 58);
            this.colorsTextBox.Name = "colorsTextBox";
            this.colorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorsTextBox.TabIndex = 4;
            this.colorsTextBox.Text = "2";
            this.colorsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(42, 87);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(15, 13);
            this.rLabel.TabIndex = 3;
            this.rLabel.Text = "R";
            // 
            // colorsLabel
            // 
            this.colorsLabel.AutoSize = true;
            this.colorsLabel.Location = new System.Drawing.Point(21, 61);
            this.colorsLabel.Name = "colorsLabel";
            this.colorsLabel.Size = new System.Drawing.Size(36, 13);
            this.colorsLabel.TabIndex = 2;
            this.colorsLabel.Text = "Colors";
            // 
            // methodsComboBox
            // 
            this.methodsComboBox.FormattingEnabled = true;
            this.methodsComboBox.Location = new System.Drawing.Point(24, 242);
            this.methodsComboBox.Name = "methodsComboBox";
            this.methodsComboBox.Size = new System.Drawing.Size(161, 21);
            this.methodsComboBox.TabIndex = 1;
            this.methodsComboBox.SelectedValueChanged += new System.EventHandler(this.ChangeMethod);
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(63, 12);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(86, 28);
            this.openImageButton.TabIndex = 0;
            this.openImageButton.Text = "Load image";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.LoadImageButtonClick);
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(703, 545);
            this.Controls.Add(this.splitContainer1);
            this.Name = "mainView";
            this.Text = "GkLab3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beforeImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.TextBox colorsTextBox;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.Label colorsLabel;
        private System.Windows.Forms.ComboBox methodsComboBox;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.Label bColor;
        private System.Windows.Forms.Label gColor;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox gTextBox;
        private System.Windows.Forms.Button reduceColorsButton;
        private System.Windows.Forms.PictureBox beforeImagePictureBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.ComboBox kComboBox;
        private System.Windows.Forms.Label errorB;
        private System.Windows.Forms.Label errorG;
        private System.Windows.Forms.Label errorR;
    }
}