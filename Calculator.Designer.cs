namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.display = new System.Windows.Forms.TextBox();
            this.cleanButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.commaButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.timesButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Enabled = false;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(2, 27);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(320, 53);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDetection);
            // 
            // cleanButton
            // 
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanButton.Location = new System.Drawing.Point(2, 289);
            this.cleanButton.Margin = new System.Windows.Forms.Padding(0);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(80, 50);
            this.cleanButton.TabIndex = 1;
            this.cleanButton.TabStop = false;
            this.cleanButton.Text = "C";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(82, 289);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(0);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(80, 50);
            this.zeroButton.TabIndex = 2;
            this.zeroButton.TabStop = false;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // commaButton
            // 
            this.commaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commaButton.Location = new System.Drawing.Point(162, 289);
            this.commaButton.Margin = new System.Windows.Forms.Padding(0);
            this.commaButton.Name = "commaButton";
            this.commaButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.commaButton.Size = new System.Drawing.Size(80, 50);
            this.commaButton.TabIndex = 3;
            this.commaButton.TabStop = false;
            this.commaButton.Text = ".";
            this.commaButton.UseVisualStyleBackColor = true;
            this.commaButton.Click += new System.EventHandler(this.CommaButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.equalButton.CausesValidation = false;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(242, 289);
            this.equalButton.Margin = new System.Windows.Forms.Padding(0);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(80, 50);
            this.equalButton.TabIndex = 4;
            this.equalButton.TabStop = false;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(2, 239);
            this.oneButton.Margin = new System.Windows.Forms.Padding(0);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(80, 50);
            this.oneButton.TabIndex = 5;
            this.oneButton.TabStop = false;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(82, 239);
            this.twoButton.Margin = new System.Windows.Forms.Padding(0);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(80, 50);
            this.twoButton.TabIndex = 6;
            this.twoButton.TabStop = false;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(162, 239);
            this.threeButton.Margin = new System.Windows.Forms.Padding(0);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(80, 50);
            this.threeButton.TabIndex = 7;
            this.threeButton.TabStop = false;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(242, 239);
            this.plusButton.Margin = new System.Windows.Forms.Padding(0);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(80, 50);
            this.plusButton.TabIndex = 8;
            this.plusButton.TabStop = false;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(2, 189);
            this.fourButton.Margin = new System.Windows.Forms.Padding(0);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(80, 50);
            this.fourButton.TabIndex = 9;
            this.fourButton.TabStop = false;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(82, 189);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(0);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(80, 50);
            this.fiveButton.TabIndex = 10;
            this.fiveButton.TabStop = false;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(162, 189);
            this.sixButton.Margin = new System.Windows.Forms.Padding(0);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(80, 50);
            this.sixButton.TabIndex = 11;
            this.sixButton.TabStop = false;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(242, 189);
            this.minusButton.Margin = new System.Windows.Forms.Padding(0);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(80, 50);
            this.minusButton.TabIndex = 12;
            this.minusButton.TabStop = false;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(2, 139);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(0);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(80, 50);
            this.sevenButton.TabIndex = 13;
            this.sevenButton.TabStop = false;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(82, 139);
            this.eightButton.Margin = new System.Windows.Forms.Padding(0);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(80, 50);
            this.eightButton.TabIndex = 14;
            this.eightButton.TabStop = false;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(162, 139);
            this.nineButton.Margin = new System.Windows.Forms.Padding(0);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(80, 50);
            this.nineButton.TabIndex = 15;
            this.nineButton.TabStop = false;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // timesButton
            // 
            this.timesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesButton.Location = new System.Drawing.Point(242, 139);
            this.timesButton.Margin = new System.Windows.Forms.Padding(0);
            this.timesButton.Name = "timesButton";
            this.timesButton.Size = new System.Drawing.Size(80, 50);
            this.timesButton.TabIndex = 16;
            this.timesButton.TabStop = false;
            this.timesButton.Text = "x";
            this.timesButton.UseVisualStyleBackColor = true;
            this.timesButton.Click += new System.EventHandler(this.TimesButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(242, 89);
            this.divisionButton.Margin = new System.Windows.Forms.Padding(0);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(80, 50);
            this.divisionButton.TabIndex = 17;
            this.divisionButton.TabStop = false;
            this.divisionButton.Text = "÷";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(324, 24);
            this.menu.TabIndex = 18;
            this.menu.Text = "menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(324, 345);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.timesButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.commaButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.display);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Calculator";
            this.Text = "Calculator 1.0";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button commaButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button timesButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

