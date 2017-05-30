namespace Assignment_3___Kiet_Tiet
{
    partial class Assignment3Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment3Form));
            this.CoinGroupBox = new System.Windows.Forms.GroupBox();
            this.HeadPictureBox = new System.Windows.Forms.PictureBox();
            this.TailPictureBox = new System.Windows.Forms.PictureBox();
            this.FlipCoinButton = new System.Windows.Forms.Button();
            this.FormTabControl = new System.Windows.Forms.TabControl();
            this.Assignment3A = new System.Windows.Forms.TabPage();
            this.EvenOddGroupBox = new System.Windows.Forms.GroupBox();
            this.EvenOddButton = new System.Windows.Forms.Button();
            this.EvenOddOutput = new System.Windows.Forms.Label();
            this.EvenOddInput = new System.Windows.Forms.TextBox();
            this.EvenOddLabel = new System.Windows.Forms.Label();
            this.PickFruitGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowFruitButton = new System.Windows.Forms.Button();
            this.FruitListBox = new System.Windows.Forms.ListBox();
            this.AvocadoPictureBox = new System.Windows.Forms.PictureBox();
            this.ApplePictureBox = new System.Windows.Forms.PictureBox();
            this.KiwiPictureBox = new System.Windows.Forms.PictureBox();
            this.AddItionGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AdditionOutputLabel = new System.Windows.Forms.Label();
            this.Number3TextBox = new System.Windows.Forms.TextBox();
            this.Number2TextBox = new System.Windows.Forms.TextBox();
            this.Number1TextBox = new System.Windows.Forms.TextBox();
            this.Number3 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.Label();
            this.Number1 = new System.Windows.Forms.Label();
            this.Assignment3B = new System.Windows.Forms.TabPage();
            this.CoinGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TailPictureBox)).BeginInit();
            this.FormTabControl.SuspendLayout();
            this.Assignment3A.SuspendLayout();
            this.EvenOddGroupBox.SuspendLayout();
            this.PickFruitGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvocadoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiwiPictureBox)).BeginInit();
            this.AddItionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoinGroupBox
            // 
            this.CoinGroupBox.Controls.Add(this.HeadPictureBox);
            this.CoinGroupBox.Controls.Add(this.TailPictureBox);
            this.CoinGroupBox.Controls.Add(this.FlipCoinButton);
            this.CoinGroupBox.Location = new System.Drawing.Point(5, 5);
            this.CoinGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CoinGroupBox.Name = "CoinGroupBox";
            this.CoinGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CoinGroupBox.Size = new System.Drawing.Size(174, 223);
            this.CoinGroupBox.TabIndex = 0;
            this.CoinGroupBox.TabStop = false;
            this.CoinGroupBox.Text = "Coin Face";
            // 
            // HeadPictureBox
            // 
            this.HeadPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HeadPictureBox.Image")));
            this.HeadPictureBox.Location = new System.Drawing.Point(5, 17);
            this.HeadPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeadPictureBox.Name = "HeadPictureBox";
            this.HeadPictureBox.Size = new System.Drawing.Size(159, 162);
            this.HeadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeadPictureBox.TabIndex = 0;
            this.HeadPictureBox.TabStop = false;
            // 
            // TailPictureBox
            // 
            this.TailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TailPictureBox.Image")));
            this.TailPictureBox.Location = new System.Drawing.Point(5, 17);
            this.TailPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.TailPictureBox.Name = "TailPictureBox";
            this.TailPictureBox.Size = new System.Drawing.Size(159, 162);
            this.TailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TailPictureBox.TabIndex = 2;
            this.TailPictureBox.TabStop = false;
            // 
            // FlipCoinButton
            // 
            this.FlipCoinButton.Location = new System.Drawing.Point(5, 183);
            this.FlipCoinButton.Margin = new System.Windows.Forms.Padding(2);
            this.FlipCoinButton.Name = "FlipCoinButton";
            this.FlipCoinButton.Size = new System.Drawing.Size(159, 31);
            this.FlipCoinButton.TabIndex = 1;
            this.FlipCoinButton.Text = "Coin Face";
            this.FlipCoinButton.UseVisualStyleBackColor = true;
            this.FlipCoinButton.Click += new System.EventHandler(this.FlipCoinButton_Click);
            // 
            // FormTabControl
            // 
            this.FormTabControl.Controls.Add(this.Assignment3A);
            this.FormTabControl.Controls.Add(this.Assignment3B);
            this.FormTabControl.Location = new System.Drawing.Point(6, 7);
            this.FormTabControl.Name = "FormTabControl";
            this.FormTabControl.SelectedIndex = 0;
            this.FormTabControl.Size = new System.Drawing.Size(412, 539);
            this.FormTabControl.TabIndex = 1;
            // 
            // Assignment3A
            // 
            this.Assignment3A.BackColor = System.Drawing.Color.Plum;
            this.Assignment3A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Assignment3A.Controls.Add(this.EvenOddGroupBox);
            this.Assignment3A.Controls.Add(this.PickFruitGroupBox);
            this.Assignment3A.Controls.Add(this.AddItionGroupBox);
            this.Assignment3A.Controls.Add(this.CoinGroupBox);
            this.Assignment3A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignment3A.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Assignment3A.Location = new System.Drawing.Point(4, 22);
            this.Assignment3A.Name = "Assignment3A";
            this.Assignment3A.Padding = new System.Windows.Forms.Padding(3);
            this.Assignment3A.Size = new System.Drawing.Size(404, 513);
            this.Assignment3A.TabIndex = 0;
            this.Assignment3A.Text = "Part A";
            // 
            // EvenOddGroupBox
            // 
            this.EvenOddGroupBox.Controls.Add(this.EvenOddButton);
            this.EvenOddGroupBox.Controls.Add(this.EvenOddOutput);
            this.EvenOddGroupBox.Controls.Add(this.EvenOddInput);
            this.EvenOddGroupBox.Controls.Add(this.EvenOddLabel);
            this.EvenOddGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvenOddGroupBox.Location = new System.Drawing.Point(189, 234);
            this.EvenOddGroupBox.Name = "EvenOddGroupBox";
            this.EvenOddGroupBox.Size = new System.Drawing.Size(207, 110);
            this.EvenOddGroupBox.TabIndex = 4;
            this.EvenOddGroupBox.TabStop = false;
            this.EvenOddGroupBox.Text = "Even and Odd";
            // 
            // EvenOddButton
            // 
            this.EvenOddButton.Location = new System.Drawing.Point(6, 71);
            this.EvenOddButton.Name = "EvenOddButton";
            this.EvenOddButton.Size = new System.Drawing.Size(195, 28);
            this.EvenOddButton.TabIndex = 5;
            this.EvenOddButton.Text = "Even or Odd";
            this.EvenOddButton.UseVisualStyleBackColor = true;
            this.EvenOddButton.Click += new System.EventHandler(this.EvenOddButton_Click);
            // 
            // EvenOddOutput
            // 
            this.EvenOddOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EvenOddOutput.Location = new System.Drawing.Point(90, 44);
            this.EvenOddOutput.Name = "EvenOddOutput";
            this.EvenOddOutput.Size = new System.Drawing.Size(111, 22);
            this.EvenOddOutput.TabIndex = 6;
            this.EvenOddOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EvenOddInput
            // 
            this.EvenOddInput.Location = new System.Drawing.Point(90, 19);
            this.EvenOddInput.Name = "EvenOddInput";
            this.EvenOddInput.Size = new System.Drawing.Size(111, 22);
            this.EvenOddInput.TabIndex = 5;
            this.EvenOddInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EvenOddLabel
            // 
            this.EvenOddLabel.AutoSize = true;
            this.EvenOddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvenOddLabel.Location = new System.Drawing.Point(6, 22);
            this.EvenOddLabel.Name = "EvenOddLabel";
            this.EvenOddLabel.Size = new System.Drawing.Size(78, 16);
            this.EvenOddLabel.TabIndex = 0;
            this.EvenOddLabel.Text = "Odd / Even:";
            // 
            // PickFruitGroupBox
            // 
            this.PickFruitGroupBox.Controls.Add(this.ShowFruitButton);
            this.PickFruitGroupBox.Controls.Add(this.FruitListBox);
            this.PickFruitGroupBox.Controls.Add(this.AvocadoPictureBox);
            this.PickFruitGroupBox.Controls.Add(this.ApplePictureBox);
            this.PickFruitGroupBox.Controls.Add(this.KiwiPictureBox);
            this.PickFruitGroupBox.Location = new System.Drawing.Point(10, 234);
            this.PickFruitGroupBox.Name = "PickFruitGroupBox";
            this.PickFruitGroupBox.Size = new System.Drawing.Size(169, 264);
            this.PickFruitGroupBox.TabIndex = 3;
            this.PickFruitGroupBox.TabStop = false;
            this.PickFruitGroupBox.Text = "Pick Fruit";
            // 
            // ShowFruitButton
            // 
            this.ShowFruitButton.Location = new System.Drawing.Point(6, 231);
            this.ShowFruitButton.Name = "ShowFruitButton";
            this.ShowFruitButton.Size = new System.Drawing.Size(157, 24);
            this.ShowFruitButton.TabIndex = 6;
            this.ShowFruitButton.Text = "Show Fruit";
            this.ShowFruitButton.UseVisualStyleBackColor = true;
            this.ShowFruitButton.Click += new System.EventHandler(this.ShowFruitButton_Click);
            // 
            // FruitListBox
            // 
            this.FruitListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FruitListBox.FormattingEnabled = true;
            this.FruitListBox.ItemHeight = 16;
            this.FruitListBox.Items.AddRange(new object[] {
            "Apple",
            "Avocado",
            "Kiwi"});
            this.FruitListBox.Location = new System.Drawing.Point(6, 175);
            this.FruitListBox.Name = "FruitListBox";
            this.FruitListBox.Size = new System.Drawing.Size(157, 52);
            this.FruitListBox.TabIndex = 4;
            // 
            // AvocadoPictureBox
            // 
            this.AvocadoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvocadoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AvocadoPictureBox.Image")));
            this.AvocadoPictureBox.Location = new System.Drawing.Point(6, 22);
            this.AvocadoPictureBox.Name = "AvocadoPictureBox";
            this.AvocadoPictureBox.Size = new System.Drawing.Size(157, 150);
            this.AvocadoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvocadoPictureBox.TabIndex = 5;
            this.AvocadoPictureBox.TabStop = false;
            this.AvocadoPictureBox.Visible = false;
            // 
            // ApplePictureBox
            // 
            this.ApplePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApplePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ApplePictureBox.Image")));
            this.ApplePictureBox.Location = new System.Drawing.Point(6, 22);
            this.ApplePictureBox.Name = "ApplePictureBox";
            this.ApplePictureBox.Size = new System.Drawing.Size(157, 150);
            this.ApplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ApplePictureBox.TabIndex = 0;
            this.ApplePictureBox.TabStop = false;
            this.ApplePictureBox.Visible = false;
            // 
            // KiwiPictureBox
            // 
            this.KiwiPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KiwiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("KiwiPictureBox.Image")));
            this.KiwiPictureBox.Location = new System.Drawing.Point(6, 19);
            this.KiwiPictureBox.Name = "KiwiPictureBox";
            this.KiwiPictureBox.Size = new System.Drawing.Size(157, 150);
            this.KiwiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KiwiPictureBox.TabIndex = 4;
            this.KiwiPictureBox.TabStop = false;
            this.KiwiPictureBox.Visible = false;
            // 
            // AddItionGroupBox
            // 
            this.AddItionGroupBox.Controls.Add(this.AddButton);
            this.AddItionGroupBox.Controls.Add(this.AdditionOutputLabel);
            this.AddItionGroupBox.Controls.Add(this.Number3TextBox);
            this.AddItionGroupBox.Controls.Add(this.Number2TextBox);
            this.AddItionGroupBox.Controls.Add(this.Number1TextBox);
            this.AddItionGroupBox.Controls.Add(this.Number3);
            this.AddItionGroupBox.Controls.Add(this.Number2);
            this.AddItionGroupBox.Controls.Add(this.Number1);
            this.AddItionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItionGroupBox.Location = new System.Drawing.Point(193, 6);
            this.AddItionGroupBox.Name = "AddItionGroupBox";
            this.AddItionGroupBox.Size = new System.Drawing.Size(199, 222);
            this.AddItionGroupBox.TabIndex = 2;
            this.AddItionGroupBox.TabStop = false;
            this.AddItionGroupBox.Text = "Add It Up - Value Return";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(9, 164);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(172, 26);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add It Up !!!";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AdditionOutputLabel
            // 
            this.AdditionOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdditionOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionOutputLabel.Location = new System.Drawing.Point(81, 125);
            this.AdditionOutputLabel.Name = "AdditionOutputLabel";
            this.AdditionOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.AdditionOutputLabel.TabIndex = 6;
            this.AdditionOutputLabel.Text = "0";
            this.AdditionOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Number3TextBox
            // 
            this.Number3TextBox.Location = new System.Drawing.Point(81, 90);
            this.Number3TextBox.Name = "Number3TextBox";
            this.Number3TextBox.Size = new System.Drawing.Size(100, 22);
            this.Number3TextBox.TabIndex = 5;
            this.Number3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Number2TextBox
            // 
            this.Number2TextBox.Location = new System.Drawing.Point(81, 58);
            this.Number2TextBox.Name = "Number2TextBox";
            this.Number2TextBox.Size = new System.Drawing.Size(100, 22);
            this.Number2TextBox.TabIndex = 4;
            this.Number2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Number1TextBox
            // 
            this.Number1TextBox.Location = new System.Drawing.Point(81, 28);
            this.Number1TextBox.Name = "Number1TextBox";
            this.Number1TextBox.Size = new System.Drawing.Size(100, 22);
            this.Number1TextBox.TabIndex = 3;
            this.Number1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Number3
            // 
            this.Number3.AutoSize = true;
            this.Number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number3.Location = new System.Drawing.Point(6, 91);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(69, 16);
            this.Number3.TabIndex = 2;
            this.Number3.Text = "Number 3:";
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2.Location = new System.Drawing.Point(6, 59);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(69, 16);
            this.Number2.TabIndex = 1;
            this.Number2.Text = "Number 2:";
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1.Location = new System.Drawing.Point(6, 29);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(69, 16);
            this.Number1.TabIndex = 0;
            this.Number1.Text = "Number 1:";
            // 
            // Assignment3B
            // 
            this.Assignment3B.Location = new System.Drawing.Point(4, 22);
            this.Assignment3B.Name = "Assignment3B";
            this.Assignment3B.Padding = new System.Windows.Forms.Padding(3);
            this.Assignment3B.Size = new System.Drawing.Size(404, 535);
            this.Assignment3B.TabIndex = 1;
            this.Assignment3B.Text = "Part B";
            this.Assignment3B.UseVisualStyleBackColor = true;
            // 
            // Assignment3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(426, 556);
            this.Controls.Add(this.FormTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Assignment3Form";
            this.Text = "Assignment 3 - Kiet Tiet";
            this.CoinGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TailPictureBox)).EndInit();
            this.FormTabControl.ResumeLayout(false);
            this.Assignment3A.ResumeLayout(false);
            this.EvenOddGroupBox.ResumeLayout(false);
            this.EvenOddGroupBox.PerformLayout();
            this.PickFruitGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvocadoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiwiPictureBox)).EndInit();
            this.AddItionGroupBox.ResumeLayout(false);
            this.AddItionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CoinGroupBox;
        private System.Windows.Forms.PictureBox HeadPictureBox;
        private System.Windows.Forms.TabControl FormTabControl;
        private System.Windows.Forms.TabPage Assignment3A;
        private System.Windows.Forms.TabPage Assignment3B;
        private System.Windows.Forms.Button FlipCoinButton;
        private System.Windows.Forms.GroupBox AddItionGroupBox;
        private System.Windows.Forms.GroupBox PickFruitGroupBox;
        private System.Windows.Forms.ListBox FruitListBox;
        private System.Windows.Forms.PictureBox AvocadoPictureBox;
        private System.Windows.Forms.PictureBox ApplePictureBox;
        private System.Windows.Forms.PictureBox KiwiPictureBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label AdditionOutputLabel;
        private System.Windows.Forms.TextBox Number3TextBox;
        private System.Windows.Forms.TextBox Number2TextBox;
        private System.Windows.Forms.TextBox Number1TextBox;
        private System.Windows.Forms.Label Number3;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.GroupBox EvenOddGroupBox;
        private System.Windows.Forms.Button EvenOddButton;
        private System.Windows.Forms.Label EvenOddOutput;
        private System.Windows.Forms.TextBox EvenOddInput;
        private System.Windows.Forms.Label EvenOddLabel;
        private System.Windows.Forms.Button ShowFruitButton;
        private System.Windows.Forms.PictureBox TailPictureBox;
    }
}

