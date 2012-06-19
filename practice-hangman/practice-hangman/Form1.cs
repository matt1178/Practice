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
    public partial class Hangman : Form
    {
        public Hangman()
        {
            InitializeComponent();
        }

        //A way for making a random number based off of System Time. -h3
        void randomInt(int i1,int i2)
        {
            int wordSeed;

            System.Random RandNum = new System.Random();
            wordSeed = RandNum.Next(i1, i2);
        }

        //This is an easy way to update the answer box. Use like this: 'setEqual(c1, c2, c3, c4, c5);' -h3
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
            //This is where most code gets executed, so why keep it all in this event? I threw it out to a different method -h3
            main();
        }

        void main()
        {
            char c1;
            char c2;
            char c3;
            char c4;
            char c5;

            pictureBox.Image = WindowsFormsApplication1.Properties.Resources.zeroW;
        }
    }
}
