using System;
using System.Collections;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        int aa = 0, bb = 0, cc = 0, dd = 0, ee = 0, ff = 0, gg = 0, hh = 0, jj = 0;
        string[][] textinbox = new string[2][];
        bool win = false;
        bool loose = false;
        Random wow = new Random();
        ArrayList myList = new ArrayList();

        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i < 10; i++)
            {
                myList.Add(i);
            }
            win = false;

            printbox();

        }





        private void button1_Click(object sender, EventArgs e)
        {
            aa = 1;
            button1.Visible = false;
            myList.Remove(1);
            enemyai();
            printbox();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bb = 1;
            button2.Visible = false;
            myList.Remove(2);
            enemyai();
            printbox();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cc = 1;
            button3.Visible = false;
            myList.Remove(3);
            enemyai();
            printbox();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dd = 1;
            button4.Visible = false;
            myList.Remove(4);
            enemyai();
            printbox();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ee = 1;
            button5.Visible = false;
            myList.Remove(5);
            enemyai();
            printbox();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ff = 1;
            button6.Visible = false;
            myList.Remove(6);
            enemyai();
            printbox();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            gg = 1;
            button7.Visible = false;
            myList.Remove(7);
            enemyai();
            printbox();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            hh = 1;
            button8.Visible = false;
            myList.Remove(8);
            enemyai();
            printbox();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            jj = 1;
            button9.Visible = false;
            myList.Remove(9);
            enemyai();
            printbox();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
           
        }
        public void reset()
        {
            myList.Clear();
            win = false;
            aa = 0;
            bb = 0;
            cc = 0;
            dd = 0;
            ee = 0;
            ff = 0;
            gg = 0;
            hh = 0;
            jj = 0;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            for (int i = 1; i < 10; i++)
            {
                myList.Add(i);
            }
            printbox();
        }

        private void checkWin()
        {
            if ((aa == 1 && dd == 1 && gg == 1) || (bb == 1 && ee == 1 && hh == 1) || (cc == 1 && ff == 1 && jj == 1)) //downs
            {
                win = true;
            }

            if ((aa == 1 && bb == 1 && cc == 1) || (dd == 1 && ee == 1 && ff == 1) || (gg == 1 && hh == 1 && jj == 1)) //accros
            {
                win = true;
            }

            if ((aa == 1 && ee == 1 && jj == 1) || (cc == 1 && ee == 1 && gg == 1)) //diag
            {
                win = true;
            }
            checkFalse();
        }

        private void checkFalse()
        {
            if ((aa == -1 && dd == -1 && gg == -1) || (bb == -1 && ee == -1 && hh == -1) || (cc == -1 && ff == -1 && jj == -1)) //downs
            {
                loose = true;
            }

            if ((aa == -1 && bb == -1 && cc == -1) || (dd == -1 && ee == -1 && ff == -1) || (gg == -1 && hh == -1 && jj == -1)) //accros
            {
                loose = true;
            }

            if ((aa == -1 && ee == -1 && jj == -1) || (cc == -1 && ee == -1 && gg == -1)) //diag
            {
                loose = true;
            }
        }

        private void printbox()
        {
            checkWin();
            

            for (int i = 0; i < 10; i++)
            {

            }


            textBox1.Text = checkX(gg) + "|" + checkX(hh) + "|" + checkX(jj);
            textBox1.Text += Environment.NewLine;
            textBox1.Text += checkX(dd) + "|" + checkX(ee) + "|" + checkX(ff);
            textBox1.Text += Environment.NewLine;
            textBox1.Text += checkX(aa) + "|" + checkX(bb) + "|" + checkX(cc);
            textBox1.Text += Environment.NewLine;
            if (win)
            {
                textBox1.Text += "You WON";
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
            }
            if (loose)
            {
                textBox1.Text += "You lost";
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
            }




        }

        private void enemyai()
        {

            textBox1.Text = "" + myList.Count;
            int rando = 1;
            int rand=1;
            try
            {
                rando =wow.Next(1, myList.Count);
                rand = (int)myList[rando];
            }
            catch(ArgumentOutOfRangeException e)
            {
                reset();
            }

            switch (rand)
            {
                case 1:
                    button1.Visible = false; myList.Remove(1); aa = -1;
                    break;
                case 2:
                    button2.Visible = false; myList.Remove(2); bb = -1;
                    break;
                case 3:
                    button3.Visible = false; myList.Remove(3); cc = -1;
                    break;
                case 4:
                    button4.Visible = false; myList.Remove(4); dd = -1;
                    break;
                case 5:
                    button5.Visible = false; myList.Remove(5); ee = -1;
                    break;
                case 6:
                    button6.Visible = false; myList.Remove(6); ff = -1;
                    break;
                case 7:
                    button7.Visible = false; myList.Remove(7); gg = -1;
                    break;
                case 8:
                    button8.Visible = false; myList.Remove(8); hh = -1;
                    break;
                case 9:
                    button9.Visible = false; myList.Remove(9); jj = -1;
                    break;
                default:
                    break;

            }
        }
        public string checkX(int x)
        {
            string xoro = "  ";
            if (x == 1)
            {
                xoro = "x";
            }
            if (x == -1)
            {
                xoro = "o";
            }

            return xoro;
        }



    }
}
