namespace WindowsFormsApplication1
{
    partial class Hangman
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
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.answerBox1 = new System.Windows.Forms.TextBox();
            this.answerBox2 = new System.Windows.Forms.TextBox();
            this.answerBox3 = new System.Windows.Forms.TextBox();
            this.answerBox4 = new System.Windows.Forms.TextBox();
            this.answerBox5 = new System.Windows.Forms.TextBox();
            this.aButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.gButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.jButton = new System.Windows.Forms.Button();
            this.iButton = new System.Windows.Forms.Button();
            this.hButton = new System.Windows.Forms.Button();
            this.kButton = new System.Windows.Forms.Button();
            this.uButton = new System.Windows.Forms.Button();
            this.tButton = new System.Windows.Forms.Button();
            this.lButton = new System.Windows.Forms.Button();
            this.sButton = new System.Windows.Forms.Button();
            this.rButton = new System.Windows.Forms.Button();
            this.nButton = new System.Windows.Forms.Button();
            this.mButton = new System.Windows.Forms.Button();
            this.qButton = new System.Windows.Forms.Button();
            this.pButton = new System.Windows.Forms.Button();
            this.oButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.wButton = new System.Windows.Forms.Button();
            this.vButton = new System.Windows.Forms.Button();
            this.zButton = new System.Windows.Forms.Button();
            this.xButton = new System.Windows.Forms.Button();
            this.yButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.giveupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 183);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(93, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::WindowsFormsApplication1.Properties.Resources.blank;
            this.pictureBox.Location = new System.Drawing.Point(218, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(147, 223);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // answerBox1
            // 
            this.answerBox1.Location = new System.Drawing.Point(38, 12);
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.Size = new System.Drawing.Size(23, 20);
            this.answerBox1.TabIndex = 2;
            this.answerBox1.Text = "?";
            this.answerBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerBox2
            // 
            this.answerBox2.Location = new System.Drawing.Point(67, 12);
            this.answerBox2.Name = "answerBox2";
            this.answerBox2.Size = new System.Drawing.Size(23, 20);
            this.answerBox2.TabIndex = 3;
            this.answerBox2.Text = "?";
            this.answerBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerBox3
            // 
            this.answerBox3.Location = new System.Drawing.Point(96, 12);
            this.answerBox3.Name = "answerBox3";
            this.answerBox3.Size = new System.Drawing.Size(23, 20);
            this.answerBox3.TabIndex = 4;
            this.answerBox3.Text = "?";
            this.answerBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerBox4
            // 
            this.answerBox4.Location = new System.Drawing.Point(125, 12);
            this.answerBox4.Name = "answerBox4";
            this.answerBox4.Size = new System.Drawing.Size(23, 20);
            this.answerBox4.TabIndex = 5;
            this.answerBox4.Text = "?";
            this.answerBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerBox5
            // 
            this.answerBox5.Location = new System.Drawing.Point(154, 12);
            this.answerBox5.Name = "answerBox5";
            this.answerBox5.Size = new System.Drawing.Size(23, 20);
            this.answerBox5.TabIndex = 6;
            this.answerBox5.Text = "?";
            this.answerBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aButton
            // 
            this.aButton.Location = new System.Drawing.Point(12, 38);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(27, 23);
            this.aButton.TabIndex = 7;
            this.aButton.Text = "A";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click_1);
            // 
            // eButton
            // 
            this.eButton.Location = new System.Drawing.Point(144, 38);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(27, 23);
            this.eButton.TabIndex = 8;
            this.eButton.Text = "E";
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.eButton_Click_1);
            // 
            // dButton
            // 
            this.dButton.Location = new System.Drawing.Point(111, 38);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(27, 23);
            this.dButton.TabIndex = 9;
            this.dButton.Text = "D";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click_1);
            // 
            // gButton
            // 
            this.gButton.Location = new System.Drawing.Point(12, 67);
            this.gButton.Name = "gButton";
            this.gButton.Size = new System.Drawing.Size(27, 23);
            this.gButton.TabIndex = 10;
            this.gButton.Text = "G";
            this.gButton.UseVisualStyleBackColor = true;
            this.gButton.Click += new System.EventHandler(this.gButton_Click_1);
            // 
            // fButton
            // 
            this.fButton.Location = new System.Drawing.Point(177, 38);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(27, 23);
            this.fButton.TabIndex = 11;
            this.fButton.Text = "F";
            this.fButton.UseVisualStyleBackColor = true;
            this.fButton.Click += new System.EventHandler(this.fButton_Click_1);
            // 
            // jButton
            // 
            this.jButton.Location = new System.Drawing.Point(111, 67);
            this.jButton.Name = "jButton";
            this.jButton.Size = new System.Drawing.Size(27, 23);
            this.jButton.TabIndex = 12;
            this.jButton.Text = "J";
            this.jButton.UseVisualStyleBackColor = true;
            this.jButton.Click += new System.EventHandler(this.jButton_Click_1);
            // 
            // iButton
            // 
            this.iButton.Location = new System.Drawing.Point(78, 67);
            this.iButton.Name = "iButton";
            this.iButton.Size = new System.Drawing.Size(27, 23);
            this.iButton.TabIndex = 13;
            this.iButton.Text = "I";
            this.iButton.UseVisualStyleBackColor = true;
            this.iButton.Click += new System.EventHandler(this.iButton_Click_1);
            // 
            // hButton
            // 
            this.hButton.Location = new System.Drawing.Point(45, 67);
            this.hButton.Name = "hButton";
            this.hButton.Size = new System.Drawing.Size(27, 23);
            this.hButton.TabIndex = 14;
            this.hButton.Text = "H";
            this.hButton.UseVisualStyleBackColor = true;
            this.hButton.Click += new System.EventHandler(this.hButton_Click_1);
            // 
            // kButton
            // 
            this.kButton.Location = new System.Drawing.Point(144, 67);
            this.kButton.Name = "kButton";
            this.kButton.Size = new System.Drawing.Size(27, 23);
            this.kButton.TabIndex = 15;
            this.kButton.Text = "K";
            this.kButton.UseVisualStyleBackColor = true;
            this.kButton.Click += new System.EventHandler(this.kButton_Click_1);
            // 
            // uButton
            // 
            this.uButton.Location = new System.Drawing.Point(78, 125);
            this.uButton.Name = "uButton";
            this.uButton.Size = new System.Drawing.Size(27, 23);
            this.uButton.TabIndex = 16;
            this.uButton.Text = "U";
            this.uButton.UseVisualStyleBackColor = true;
            this.uButton.Click += new System.EventHandler(this.uButton_Click_1);
            // 
            // tButton
            // 
            this.tButton.Location = new System.Drawing.Point(45, 125);
            this.tButton.Name = "tButton";
            this.tButton.Size = new System.Drawing.Size(27, 23);
            this.tButton.TabIndex = 17;
            this.tButton.Text = "T";
            this.tButton.UseVisualStyleBackColor = true;
            this.tButton.Click += new System.EventHandler(this.tButton_Click_1);
            // 
            // lButton
            // 
            this.lButton.Location = new System.Drawing.Point(177, 67);
            this.lButton.Name = "lButton";
            this.lButton.Size = new System.Drawing.Size(27, 23);
            this.lButton.TabIndex = 18;
            this.lButton.Text = "L";
            this.lButton.UseVisualStyleBackColor = true;
            this.lButton.Click += new System.EventHandler(this.lButton_Click_1);
            // 
            // sButton
            // 
            this.sButton.Location = new System.Drawing.Point(12, 125);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(27, 23);
            this.sButton.TabIndex = 19;
            this.sButton.Text = "S";
            this.sButton.UseVisualStyleBackColor = true;
            this.sButton.Click += new System.EventHandler(this.sButton_Click_1);
            // 
            // rButton
            // 
            this.rButton.Location = new System.Drawing.Point(177, 96);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(27, 23);
            this.rButton.TabIndex = 20;
            this.rButton.Text = "R";
            this.rButton.UseVisualStyleBackColor = true;
            this.rButton.Click += new System.EventHandler(this.rButton_Click_1);
            // 
            // nButton
            // 
            this.nButton.Location = new System.Drawing.Point(45, 96);
            this.nButton.Name = "nButton";
            this.nButton.Size = new System.Drawing.Size(27, 23);
            this.nButton.TabIndex = 21;
            this.nButton.Text = "N";
            this.nButton.UseVisualStyleBackColor = true;
            this.nButton.Click += new System.EventHandler(this.nButton_Click_1);
            // 
            // mButton
            // 
            this.mButton.Location = new System.Drawing.Point(12, 96);
            this.mButton.Name = "mButton";
            this.mButton.Size = new System.Drawing.Size(27, 23);
            this.mButton.TabIndex = 22;
            this.mButton.Text = "M";
            this.mButton.UseVisualStyleBackColor = true;
            this.mButton.Click += new System.EventHandler(this.mButton_Click_1);
            // 
            // qButton
            // 
            this.qButton.Location = new System.Drawing.Point(144, 96);
            this.qButton.Name = "qButton";
            this.qButton.Size = new System.Drawing.Size(27, 23);
            this.qButton.TabIndex = 23;
            this.qButton.Text = "Q";
            this.qButton.UseVisualStyleBackColor = true;
            this.qButton.Click += new System.EventHandler(this.qButton_Click_1);
            // 
            // pButton
            // 
            this.pButton.Location = new System.Drawing.Point(111, 96);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(27, 23);
            this.pButton.TabIndex = 24;
            this.pButton.Text = "P";
            this.pButton.UseVisualStyleBackColor = true;
            this.pButton.Click += new System.EventHandler(this.pButton_Click_1);
            // 
            // oButton
            // 
            this.oButton.Location = new System.Drawing.Point(78, 96);
            this.oButton.Name = "oButton";
            this.oButton.Size = new System.Drawing.Size(27, 23);
            this.oButton.TabIndex = 25;
            this.oButton.Text = "O";
            this.oButton.UseVisualStyleBackColor = true;
            this.oButton.Click += new System.EventHandler(this.oButton_Click_1);
            // 
            // cButton
            // 
            this.cButton.Location = new System.Drawing.Point(78, 38);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(27, 23);
            this.cButton.TabIndex = 26;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click_1);
            // 
            // bButton
            // 
            this.bButton.Location = new System.Drawing.Point(45, 38);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(27, 23);
            this.bButton.TabIndex = 27;
            this.bButton.Text = "B";
            this.bButton.UseVisualStyleBackColor = true;
            this.bButton.Click += new System.EventHandler(this.bButton_Click_1);
            // 
            // wButton
            // 
            this.wButton.Location = new System.Drawing.Point(144, 125);
            this.wButton.Name = "wButton";
            this.wButton.Size = new System.Drawing.Size(27, 23);
            this.wButton.TabIndex = 28;
            this.wButton.Text = "W";
            this.wButton.UseVisualStyleBackColor = true;
            this.wButton.Click += new System.EventHandler(this.wButton_Click_1);
            // 
            // vButton
            // 
            this.vButton.Location = new System.Drawing.Point(111, 125);
            this.vButton.Name = "vButton";
            this.vButton.Size = new System.Drawing.Size(27, 23);
            this.vButton.TabIndex = 29;
            this.vButton.Text = "V";
            this.vButton.UseVisualStyleBackColor = true;
            this.vButton.Click += new System.EventHandler(this.vButton_Click_1);
            // 
            // zButton
            // 
            this.zButton.Location = new System.Drawing.Point(111, 154);
            this.zButton.Name = "zButton";
            this.zButton.Size = new System.Drawing.Size(27, 23);
            this.zButton.TabIndex = 30;
            this.zButton.Text = "Z";
            this.zButton.UseVisualStyleBackColor = true;
            this.zButton.Click += new System.EventHandler(this.zButton_Click_1);
            // 
            // xButton
            // 
            this.xButton.Location = new System.Drawing.Point(177, 125);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(27, 23);
            this.xButton.TabIndex = 31;
            this.xButton.Text = "X";
            this.xButton.UseVisualStyleBackColor = true;
            this.xButton.Click += new System.EventHandler(this.xButton_Click_1);
            // 
            // yButton
            // 
            this.yButton.Location = new System.Drawing.Point(78, 154);
            this.yButton.Name = "yButton";
            this.yButton.Size = new System.Drawing.Size(27, 23);
            this.yButton.TabIndex = 32;
            this.yButton.Text = "Y";
            this.yButton.UseVisualStyleBackColor = true;
            this.yButton.Click += new System.EventHandler(this.yButton_Click_1);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 212);
            this.progressBar.Maximum = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(192, 23);
            this.progressBar.TabIndex = 33;
            // 
            // giveupButton
            // 
            this.giveupButton.Location = new System.Drawing.Point(111, 183);
            this.giveupButton.Name = "giveupButton";
            this.giveupButton.Size = new System.Drawing.Size(93, 23);
            this.giveupButton.TabIndex = 34;
            this.giveupButton.Text = "Give Up";
            this.giveupButton.UseVisualStyleBackColor = true;
            this.giveupButton.Click += new System.EventHandler(this.giveupButton_Click_1);
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 247);
            this.Controls.Add(this.giveupButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.yButton);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.zButton);
            this.Controls.Add(this.vButton);
            this.Controls.Add(this.wButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.oButton);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.qButton);
            this.Controls.Add(this.mButton);
            this.Controls.Add(this.nButton);
            this.Controls.Add(this.rButton);
            this.Controls.Add(this.sButton);
            this.Controls.Add(this.lButton);
            this.Controls.Add(this.tButton);
            this.Controls.Add(this.uButton);
            this.Controls.Add(this.kButton);
            this.Controls.Add(this.hButton);
            this.Controls.Add(this.iButton);
            this.Controls.Add(this.jButton);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.gButton);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.eButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.answerBox5);
            this.Controls.Add(this.answerBox4);
            this.Controls.Add(this.answerBox3);
            this.Controls.Add(this.answerBox2);
            this.Controls.Add(this.answerBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.startButton);
            this.Name = "Hangman";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox answerBox1;
        private System.Windows.Forms.TextBox answerBox2;
        private System.Windows.Forms.TextBox answerBox3;
        private System.Windows.Forms.TextBox answerBox4;
        private System.Windows.Forms.TextBox answerBox5;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button jButton;
        private System.Windows.Forms.Button iButton;
        private System.Windows.Forms.Button hButton;
        private System.Windows.Forms.Button kButton;
        private System.Windows.Forms.Button uButton;
        private System.Windows.Forms.Button tButton;
        private System.Windows.Forms.Button lButton;
        private System.Windows.Forms.Button sButton;
        private System.Windows.Forms.Button rButton;
        private System.Windows.Forms.Button nButton;
        private System.Windows.Forms.Button mButton;
        private System.Windows.Forms.Button qButton;
        private System.Windows.Forms.Button pButton;
        private System.Windows.Forms.Button oButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button wButton;
        private System.Windows.Forms.Button vButton;
        private System.Windows.Forms.Button zButton;
        private System.Windows.Forms.Button xButton;
        private System.Windows.Forms.Button yButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button giveupButton;
    }
}

