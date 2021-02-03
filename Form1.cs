using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whatevermaroc
{
    public partial class Form1 : Form
    {
        bool Box = false;
        int Score = 0;
        bool Check = false;
        int Level = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the//");
            System.Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Box == true)
            {
                MessageBox.Show("This guy holds the minecraft speedrun world record 5 times!");
            }
            else
            {
                MessageBox.Show("Korbanoes");
            }

        }

        private void Box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Box == false)
            {
                Box = true;
            }
            else
            {
                Box = false;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uhh.Text = Score.ToString();
            agika.Text = Level.ToString();
            if (Level == 0)
            {
                Score++;
            }
            if (Level == 1)
            {
                Score += 4;
            }
            if (Level == 2)
            {
                Score += 7;
            }
            if (Level == 3)
            {
                Score += 12;
            }
            if (Level == 4)
            {
                Score += 15;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            uhh.Text = Score.ToString();
            agika.Text = Level.ToString();
            if (Level == 0)
            {
                if (Score >= 100)
                {
                    Level = 1;
                    MessageBox.Show("You have been upgraded to level 1!");
                    Score -= 100;
                }
                if (Score <= 100)
                {
                    MessageBox.Show("You dont have enough money!, you need 100 cash to upgrade.");
                }

            }
            if (Level == 1)
            {
                if (Score >= 200)
                {
                    Level = 2;
                    MessageBox.Show("You have been upgraded to level 2!");
                    Score -= 200;
                }
                if (Score <= 200)
                {
                    MessageBox.Show("You dont have enough money!, you need 200 cash to upgrade.");
                }

            }
            if (Level == 2)
            {
                if (Score >= 300)
                {
                    Level = 3;
                    MessageBox.Show("You have been upgraded to level 3!");
                    Score -= 300;
                }
                if (Score <= 300)
                {
                    MessageBox.Show("You dont have enough money!, you need 300 cash to upgrade.");
                }

            }
            if (Level == 3)
            {
                if (Score >= 400)
                {
                    Level = 4;
                    MessageBox.Show("You have been upgraded to level 4!");
                    Score -= 400;
                }
                if (Score <= 400)
                {
                    MessageBox.Show("You dont have enough money!, you need 400 cash to upgrade.");
                }

            }
            if (Level == 4)
            {
                MessageBox.Show("You are at the max level!, click the rebirth button to rebith and reset all of your stats");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Level == 4)
            {
                if (Score >= 1000)
                {
                    Check = true;
                    Level = 0;
                    Score = 0;
                    uhh.Text = Score.ToString();
                    agika.Text = Level.ToString();

                }
                else
                {
                    MessageBox.Show("Inssuficcient cash!, you need 1000 cash to do so.");
                }
            }
            else
            {
                MessageBox.Show("Tour level is too low!, you need level 5 to do so.");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void agika_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Check == true)
            {
                MessageBox.Show("This player has rebirthed before");
            }
            else
            {
                MessageBox.Show("This player hasnt rebirthed before");
            }
        }
    }
}
