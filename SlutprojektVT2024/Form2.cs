using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlutprojektVT2024
{
    public partial class Form2 : Form
    {
        private int slumpknapp;
        private int score = 0;
        public static int highscore;
        private int slumptal2;
        List<Button> buttons = new List<Button>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            score = 0;
            Game();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (slumpknapp == 0)
            {
                score++;
                label3.Text = "Poäng: " + score;
                Game();
            }
            else
            {
                MessageBox.Show("Fel svar!", "Bra försök", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
                Highscore();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (slumpknapp == 1)
            {
                score++;
                label3.Text = "Poäng: " + score;
                Game();
            }
            else
            {
                MessageBox.Show("Fel svar!", "Bra försök", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
                Highscore();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (slumpknapp == 2)
            {
                score++;
                label3.Text = "Poäng: " + score;
                Game();
            }
            else
            {
                MessageBox.Show("Fel svar!", "Bra försök", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
                Highscore();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (slumpknapp == 3)
            {
                score++;
                label3.Text = "Poäng: " + score;
                Game();
            }
            else
            {
                MessageBox.Show("Fel svar!", "Bra försök", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
                Highscore();
            }
        }

        void Game()
        {
            label3.Text = "Poäng: " + score;
            Random color = new Random();
            int slumptal = color.Next(0, 11);

            Random knapprandom = new Random();
            slumpknapp = knapprandom.Next(0, 4);
            List<Button> buttons = new List<Button>();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);

            switch (slumptal)
            {
                case 0:
                    {
                        BackColor = Color.Red;
                        buttons[slumpknapp].Text = "Röd";
                        break;
                    }
                case 1:
                    {
                        BackColor = Color.Black;
                        buttons[slumpknapp].Text = "Svart";
                        break;
                    }
                case 2:
                    {
                        BackColor = Color.White;
                        buttons[slumpknapp].Text = "Vit";
                        break;
                    }
                case 3:
                    {
                        BackColor = Color.Blue;
                        buttons[slumpknapp].Text = "Blå";
                        break;
                    }
                case 4:
                    {
                        BackColor = Color.Green;
                        buttons[slumpknapp].Text = "Grön";
                        break;
                    }
                case 5:
                    {
                        BackColor = Color.Yellow;
                        buttons[slumpknapp].Text = "Gul";
                        break;
                    }
                case 6:
                    {
                        BackColor = Color.Pink;
                        buttons[slumpknapp].Text = "Rosa";
                        break;
                    }
                case 7:
                    {
                        BackColor = Color.Orange;
                        buttons[slumpknapp].Text = "Orange";
                        break;
                    }
                case 8:
                    {
                        BackColor = Color.Purple;
                        buttons[slumpknapp].Text = "Lila";
                        break;
                    }
                case 9:
                    {
                        BackColor = Color.Brown;
                        buttons[slumpknapp].Text = "Brun";
                        break;
                    }
                case 10:
                    {
                        BackColor = Color.Gray;
                        buttons[slumpknapp].Text = "Grå";
                        break;
                    }
            }

            for (int i = 0; i < 4; i++)
            {
                if (i != slumpknapp)
                {
                    slumptal2 = color.Next(0, 11);
                    while (slumptal2 == slumptal)
                    {
                        slumptal2 = color.Next(0, 11);
                    }
                    Slumpknapp(i);
                }
            }
            for (int k = 0; k < 4; k++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (k != slumpknapp && i != slumpknapp)
                    {
                        while (buttons[i].Text == buttons[k].Text && i != k)
                        {
                            slumptal2 = color.Next(0, 11);
                            while (slumptal2 == slumptal)
                            {
                                slumptal2 = color.Next(0, 11);
                            }
                            Slumpknapp(i);
                        }

                    }
                }
            }
        }

        void Highscore()
        {
            if (score > highscore)
            {
                highscore = score;
            }
        }

        void Slumpknapp(int i)
        {
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            switch (slumptal2)
            {
                case 0:
                    {
                        buttons[i].Text = "Röd";
                        break;
                    }
                case 1:
                    {
                        buttons[i].Text = "Svart";
                        break;
                    }
                case 2:
                    {
                        buttons[i].Text = "Vit";
                        break;
                    }
                case 3:
                    {
                        buttons[i].Text = "Blå";
                        break;
                    }
                case 4:
                    {
                        buttons[i].Text = "Grön";
                        break;
                    }
                case 5:
                    {
                        buttons[i].Text = "Gul";
                        break;
                    }
                case 6:
                    {
                        buttons[i].Text = "Rosa";
                        break;
                    }
                case 7:
                    {
                        buttons[i].Text = "Orange";
                        break;
                    }
                case 8:
                    {
                        buttons[i].Text = "Lila";
                        break;
                    }
                case 9:
                    {
                        buttons[i].Text = "Brun";
                        break;
                    }
                case 10:
                    {
                        buttons[i].Text = "Grå";
                        break;
                    }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
