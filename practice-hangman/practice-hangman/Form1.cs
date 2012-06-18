using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This is an easy way to update the answer box. Use like this: 'setEqual(c1, c2, c3, c4, c5);'
        void setEqual(char a1, char a2, char a3, char a4, char a5)
        {
            answerBox1.Text = a1.ToString();
            answerBox2.Text = a2.ToString();
            answerBox3.Text = a3.ToString();
            answerBox4.Text = a4.ToString();
            answerBox5.Text = a5.ToString();
        }

        public void startButton_Click(object sender, EventArgs e)
        {
            char c1 = 'E';
            char c2 = 'D';
            char c3 = 'C';
            char c4 = 'B';
            char c5 = 'A';

            setEqual(c1, c2, c3, c4, c5);
        }
    }
}
