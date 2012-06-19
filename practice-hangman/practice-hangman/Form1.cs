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
        int randomInt(int i1,int i2)
        {
            int wordSeed;

            System.Random RandNum = new System.Random();
            wordSeed = RandNum.Next(i1, i2);

            return wordSeed;
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
            int random;

            answerBox1.Text = "?"; //This resets the boxes to question marks. Just in case someone was playing a game and starts a new one -h3
            answerBox2.Text = "?";
            answerBox3.Text = "?";
            answerBox4.Text = "?";
            answerBox5.Text = "?";

            pictureBox.Image = WindowsFormsApplication1.Properties.Resources.zeroW; //Setting the picturebox to the "zerowrong" image -h3

            random = randomInt(1, 10); //Getting a random number for the word -h3

            wordSwitch(random); //Sending the word-choosing somewhere else because that's one giant switch statement -h3
            //-*-*-*-If anyone has a better way of doing this please please share it-*-*-*-    -h3

            
        }

        void wordSwitch(int switchInt)
        {
            char c1;
            char c2;
            char c3;
            char c4;
            char c5;

            switch (switchInt)
            {
                case 1:
                    {
                        c1 = 'W';
                        c2 = 'O';
                        c3 = 'R';
                        c4 = 'D';
                        c5 = '1';
                        setEqual(c1, c2, c3, c4, c5);

                        break;
                    }
                case 2:
                    {
                        c1 = 'W';
                        c2 = 'O';
                        c3 = 'R';
                        c4 = 'D';
                        c5 = '2';
                        setEqual(c1, c2, c3, c4, c5);

                        break;
                    }
                case 3:
                    {
                        c1 = 'W';
                        c2 = 'O';
                        c3 = 'R';
                        c4 = 'D';
                        c5 = '3';
                        setEqual(c1, c2, c3, c4, c5);

                        break;
                    }
                case 4:
                    {
                        c1 = 'W';
                        c2 = 'O';
                        c3 = 'R';
                        c4 = 'D';
                        c5 = '4';
                        setEqual(c1, c2, c3, c4, c5);

                        break;
                    }
                case 5:
                    {
                        c1 = 'W';
                        c2 = 'O';
                        c3 = 'R';
                        c4 = 'D';
                        c5 = '5';
                        setEqual(c1, c2, c3, c4, c5);

                        break;
                    }
                case 6:
                    {
                        c1 = 'W';
                        c2 = 'O';
                        c3 = 'R';
                        c4 = 'D';
                        c5 = '6';
                        setEqual(c1, c2, c3, c4, c5);

                        break;
                    }
                case 7:
                    {
                        c1 = 'W';
                        c2 = 'O';
                        c3 = 'R';
                        c4 = 'D';
                        c5 = '7';
                        setEqual(c1, c2, c3, c4, c5);

                        break;
                    }
                case 8:
                    {
                        c1 = 'W';
                        c2 = 'O';
                        c3 = 'R';
                        c4 = 'D';
                        c5 = '8';
                        setEqual(c1, c2, c3, c4, c5);

                        break;
                    }
                case 9:
                    {
                        c1 = 'W';
                        c2 = 'O';
                        c3 = 'R';
                        c4 = 'D';
                        c5 = '9';
                        setEqual(c1, c2, c3, c4, c5);

                        break;
                    }
                default:
                    {
                        MessageBox.Show("Something has gone wrong. Contact us somehow.", "ERROR");

                        break;
                    }
            }
        }
        /*
        //Using this to test my new class. No touchy please -h3
        private void testButton_Click(object sender, EventArgs e)
        {
            Main startGame = Main();
        }
    }


    //I'm testing something with this class. No touchy please -h3
    static class Main
    {
        public static void startGame()
        {
            int randomNum = randomGen(1, 2);

            getWord(randomNum);
        }

        public static int randomGen(int i1, int i2)
        {
            int wordSeed;

            System.Random RandNum = new System.Random();
            wordSeed = RandNum.Next(i1, i2);

            return wordSeed;
        }

        public static void getWord(int seed)
        {
            char a1;
            char a2;
            char a3;
            char a4;
            char a5;

            switch (seed)
            {
                case 1:
                    {
                        a1 = 'W';
                        a2 = 'O';
                        a3 = 'R';
                        a4 = 'D';
                        a5 = '1';
                        break;
                    }
                case 2:
                    {
                        a1 = 'W';
                        a2 = 'O';
                        a3 = 'R';
                        a4 = 'D';
                        a5 = '2';
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Something broke. :(", "Error");
                        break;
                    }
            }
        }*/
    }
}
