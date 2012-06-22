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

        string c1;
        string c2;
        string c3;
        string c4;
        string c5;

        string i1;
        int i2 = 0;

        int wrong = 0;

        public void startButton_Click_1(object sender, EventArgs e)
        {
            answerBox1.Text = "?";
            answerBox2.Text = "?";
            answerBox3.Text = "?";
            answerBox4.Text = "?";
            answerBox5.Text = "?";

            //Random number generator (based off of system time)
            System.Random RandNum = new System.Random();
            int wordSeed = RandNum.Next(1, 18);

            switch (wordSeed)
            {
                case 1: //      "SNIPE"
                    {
                        c1 = "S";
                        c2 = "N";
                        c3 = "I";
                        c4 = "P";
                        c5 = "E";

                        break;
                    }

                case 2: //      "SHOOT"
                    {
                        c1 = "S";
                        c2 = "H";
                        c3 = "O";
                        c4 = "O";
                        c5 = "T";

                        break;
                    }

                case 3: //      "BURNS"
                    {
                        c1 = "B";
                        c2 = "U";
                        c3 = "R";
                        c4 = "N";
                        c5 = "S";

                        break;
                    }

                case 4: //      "KEYED"
                    {
                        c1 = "K";
                        c2 = "E";
                        c3 = "Y";
                        c4 = "E";
                        c5 = "D";

                        break;
                    }

                case 5: //      "LUNCH"
                    {
                        c1 = "L";
                        c2 = "U";
                        c3 = "N";
                        c4 = "C";
                        c5 = "H";

                        break;
                    }

                case 6: //      "HELLO"
                    {
                        c1 = "H";
                        c2 = "E";
                        c3 = "L";
                        c4 = "L";
                        c5 = "O";

                        break;
                    }

                case 7: //      "MUDDY"
                    {
                        c1 = "M";
                        c2 = "U";
                        c3 = "D";
                        c4 = "D";
                        c5 = "Y";

                        break;
                    }

                case 8: //      "SUNNY"
                    {
                        c1 = "S";
                        c2 = "U";
                        c3 = "N";
                        c4 = "N";
                        c5 = "Y";

                        break;
                    }

                case 9: //      "CLOUD"
                    {
                        c1 = "C";
                        c2 = "L";
                        c3 = "O";
                        c4 = "U";
                        c5 = "D";

                        break;
                    }

                case 10: //     "RAINY"
                    {
                        c1 = "R";
                        c2 = "A";
                        c3 = "I";
                        c4 = "N";
                        c5 = "Y";

                        break;
                    }

                case 11: //     "WINDY"
                    {
                        c1 = "W";
                        c2 = "I";
                        c3 = "N";
                        c4 = "D";
                        c5 = "Y";

                        break;
                    }

                case 12: //     "STORM"
                    {
                        c1 = "S";
                        c2 = "T";
                        c3 = "O";
                        c4 = "R";
                        c5 = "M";

                        break;
                    }

                case 13: //     "FOGGY"
                    {
                        c1 = "F";
                        c2 = "O";
                        c3 = "G";
                        c4 = "G";
                        c5 = "Y";

                        break;
                    }

                case 14: //     "MISTY"
                    {
                        c1 = "M";
                        c2 = "I";
                        c3 = "S";
                        c4 = "T";
                        c5 = "Y";

                        break;
                    }

                case 15: //     "SNOWY"
                    {
                        c1 = "S";
                        c2 = "N";
                        c3 = "O";
                        c4 = "W";
                        c5 = "Y";

                        break;
                    }
                case 16: //     "REPLY"
                    {
                        c1 = "R";
                        c2 = "E";
                        c3 = "P";
                        c4 = "L";
                        c5 = "Y";

                        break;
                    }
                case 17: //     "GOING"
                    {
                        c1 = "G";
                        c2 = "O";
                        c3 = "I";
                        c4 = "N";
                        c5 = "G";

                        break;
                    }
                case 18: //     "
                    {
                        c1 = "";
                        c2 = "";
                        c3 = "";
                        c4 = "";
                        c5 = "";

                        break;
                    }
                case 19: //     "
                    {
                        c1 = "";
                        c2 = "";
                        c3 = "";
                        c4 = "";
                        c5 = "";

                        break;
                    }
                case 20: //     "
                    {
                        c1 = "";
                        c2 = "";
                        c3 = "";
                        c4 = "";
                        c5 = "";

                        break;
                    }
                case 21: //     "
                    {
                        c1 = "";
                        c2 = "";
                        c3 = "";
                        c4 = "";
                        c5 = "";

                        break;
                    }
            }

            //This puts the color of all buttons back to the default for a new game.
            aButton.BackColor = Color.LightGray;
            bButton.BackColor = Color.LightGray;
            cButton.BackColor = Color.LightGray;
            dButton.BackColor = Color.LightGray;
            eButton.BackColor = Color.LightGray;
            fButton.BackColor = Color.LightGray;
            gButton.BackColor = Color.LightGray;
            hButton.BackColor = Color.LightGray;
            iButton.BackColor = Color.LightGray;
            jButton.BackColor = Color.LightGray;
            kButton.BackColor = Color.LightGray;
            lButton.BackColor = Color.LightGray;
            mButton.BackColor = Color.LightGray;
            nButton.BackColor = Color.LightGray;
            oButton.BackColor = Color.LightGray;
            pButton.BackColor = Color.LightGray;
            qButton.BackColor = Color.LightGray;
            rButton.BackColor = Color.LightGray;
            sButton.BackColor = Color.LightGray;
            tButton.BackColor = Color.LightGray;
            uButton.BackColor = Color.LightGray;
            vButton.BackColor = Color.LightGray;
            wButton.BackColor = Color.LightGray;
            xButton.BackColor = Color.LightGray;
            yButton.BackColor = Color.LightGray;
            zButton.BackColor = Color.LightGray;
            startButton.BackColor = Color.LightGray;
            progressBar.Value = 0;
        }

        private void giveupButton_Click_1(object sender, EventArgs e)
        {
            answerBox1.Text = c1;
            answerBox2.Text = c2;
            answerBox3.Text = c3;
            answerBox4.Text = c4;
            answerBox5.Text = c5;

            progressBar.Value = 10;
        }


        //These can't be ELSE-IF statements - or rlse the word "CALL" wouldn't work (the 'L' is in there twice, ELSE-IF skips the 2nd time) -h3
        private void aButton_Click_1(object sender, EventArgs e)
        {
            i1 = "A";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "A";
                aButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "A";
                aButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "A";
                aButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "A";
                aButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "A";
                aButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                aButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void bButton_Click_1(object sender, EventArgs e)
        {
            i1 = "B";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "B";
                bButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "B";
                bButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "B";
                bButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "B";
                bButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "B";
                bButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                bButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void cButton_Click_1(object sender, EventArgs e)
        {
            i1 = "C";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "C";
                cButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "C";
                cButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "C";
                cButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "C";
                cButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "C";
                cButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                cButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void dButton_Click_1(object sender, EventArgs e)
        {
            i1 = "D";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "D";
                dButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "D";
                dButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "D";
                dButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "D";
                dButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "D";
                dButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                dButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void eButton_Click_1(object sender, EventArgs e)
        {
            i1 = "E";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "E";
                eButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "E";
                eButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "E";
                eButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "E";
                eButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "E";
                eButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                eButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void fButton_Click_1(object sender, EventArgs e)
        {
            i1 = "F";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "F";
                fButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "F";
                fButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "F";
                fButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "F";
                fButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "F";
                fButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                fButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void gButton_Click_1(object sender, EventArgs e)
        {
            i1 = "G";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "G";
                gButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "G";
                gButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "G";
                gButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "G";
                gButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "G";
                gButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                gButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void hButton_Click_1(object sender, EventArgs e)
        {
            i1 = "H";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "H";
                hButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "H";
                hButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "H";
                hButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "H";
                hButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "H";
                hButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                hButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void iButton_Click_1(object sender, EventArgs e)
        {
            i1 = "I";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "I";
                iButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "I";
                iButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "I";
                iButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "I";
                iButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "I";
                iButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                iButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void jButton_Click_1(object sender, EventArgs e)
        {
            i1 = "J";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "J";
                jButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "J";
                jButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "J";
                jButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "J";
                jButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "J";
                jButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                jButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void kButton_Click_1(object sender, EventArgs e)
        {
            i1 = "K";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "K";
                kButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "K";
                kButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "K";
                kButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "K";
                kButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "K";
                kButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                kButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void lButton_Click_1(object sender, EventArgs e)
        {
            i1 = "L";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "L";
                lButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c2)
            {
                answerBox2.Text = "L";
                lButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "L";
                lButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "L";
                lButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "L";
                lButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                lButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void mButton_Click_1(object sender, EventArgs e)
        {
            i1 = "M";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "M";
                mButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "M";
                mButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "M";
                mButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "M";
                mButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "M";
                mButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                mButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void nButton_Click_1(object sender, EventArgs e)
        {
            i1 = "N";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "N";
                nButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "N";
                nButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "N";
                nButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "N";
                nButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "N";
                nButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                nButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void oButton_Click_1(object sender, EventArgs e)
        {
            i1 = "O";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "O";
                oButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "O";
                oButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "O";
                oButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "O";
                oButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "O";
                oButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                oButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void pButton_Click_1(object sender, EventArgs e)
        {
            i1 = "P";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "P";
                pButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "P";
                pButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "P";
                pButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "P";
                pButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "P";
                pButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                pButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void qButton_Click_1(object sender, EventArgs e)
        {
            i1 = "Q";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "Q";
                qButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "Q";
                qButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "Q";
                qButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "Q";
                qButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "Q";
                qButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                qButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void rButton_Click_1(object sender, EventArgs e)
        {
            i1 = "R";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "R";
                rButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "R";
                rButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "R";
                rButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "R";
                rButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "R";
                rButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                rButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void sButton_Click_1(object sender, EventArgs e)
        {
            i1 = "S";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "S";
                sButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "S";
                sButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "S";
                sButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "S";
                sButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "S";
                sButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                sButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void tButton_Click_1(object sender, EventArgs e)
        {
            i1 = "T";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "T";
                tButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "T";
                tButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "T";
                tButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "T";
                tButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "T";
                tButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                tButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void uButton_Click_1(object sender, EventArgs e)
        {
            i1 = "U";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "U";
                uButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "U";
                uButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "U";
                uButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "U";
                uButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "U";
                uButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                uButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void vButton_Click_1(object sender, EventArgs e)
        {
            i1 = "V";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "V";
                vButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "V";
                vButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "V";
                vButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "V";
                vButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "V";
                vButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                vButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void wButton_Click_1(object sender, EventArgs e)
        {
            i1 = "W";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "W";
                wButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "W";
                wButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "W";
                wButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "W";
                wButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "W";
                wButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                wButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void xButton_Click_1(object sender, EventArgs e)
        {
            i1 = "X";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "X";
                xButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "X";
                xButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "X";
                xButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "X";
                xButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "X";
                xButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                xButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void yButton_Click_1(object sender, EventArgs e)
        {
            i1 = "Y";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "Y";
                yButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "Y";
                yButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "Y";
                yButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "Y";
                yButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "Y";
                yButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                yButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }

        private void zButton_Click_1(object sender, EventArgs e)
        {
            i1 = "Z";
            i2 = 0;

            if (i1 == c1)
            {
                answerBox1.Text = "Z";
                zButton.BackColor = Color.Green;
                i2++;

            }
            if (i1 == c2)
            {
                answerBox2.Text = "Z";
                zButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c3)
            {
                answerBox3.Text = "Z";
                zButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c4)
            {
                answerBox4.Text = "Z";
                zButton.BackColor = Color.Green;
                i2++;
            }
            if (i1 == c5)
            {
                answerBox5.Text = "Z";
                zButton.BackColor = Color.Green;
                i2++;
            }
            if (i2 == 0)
            {
                zButton.BackColor = Color.Red;
                wrong++;
                progressBar.Value = progressBar.Value + 1;
            }
        }
    }
}
