using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Tree lastTree;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            lastTree = tree3;
        }

        private int speed = -6;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                timer_bird.Enabled = true;
                timer_tree.Enabled = true;
                timer_IsCrash.Enabled = true;
                timer_score.Enabled = true;
                BirdHelper.Jump(out speed);
                button1.Text = "Jump";
            }
            else
            {
                BirdHelper.Jump(out speed);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Location = new Point(bird.Location.X, bird.Location.Y + speed);
            speed++;
        }

        private void timer_tree_Tick(object sender, EventArgs e)
        {
            tree1.Location = new Point(tree1.Location.X - 2, tree1.Location.Y);
            tree2.Location = new Point(tree2.Location.X - 2, tree2.Location.Y);
            tree3.Location = new Point(tree3.Location.X - 2, tree3.Location.Y);

            if (tree1.Location.X + tree1.Width <= 0)
            {
                tree1.Location = new Point(lastTree.Location.X + 200, random.Next(-164, -17));
                lastTree = tree1;
            }
            if (tree2.Location.X + tree2.Width <= 0)
            {
                tree2.Location = new Point(lastTree.Location.X + 200, random.Next(-164, -17));
                lastTree = tree2;
            }
            if (tree3.Location.X + tree3.Width <= 0)
            {
                tree3.Location = new Point(lastTree.Location.X + 200, random.Next(-164, -17));
                lastTree = tree3;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer_IsCrash_Tick(object sender, EventArgs e)
        {
            if (BirdHelper.IsBirdCrashTree(bird, tree1) || BirdHelper.IsBirdCrashTree(bird, tree2) || BirdHelper.IsBirdCrashTree(bird, tree3)||bird.Location.Y<=-bird.Height||bird.Location.Y>=panel1.Height+bird.Height)
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            timer_bird.Enabled = false;
            timer_IsCrash.Enabled = false;
            timer_score.Enabled = false;
            timer_tree.Enabled = false;

            
            int _score = int.Parse(score.Text);

            Form2 form2 = new Form2(_score,InitialForm);
            this.Hide();
            form2.Show();


        }

        private void InitialForm()
        {
            bird.Location = new Point(297, 175);
            button1.Text = "Start";
            tree1.Location = new Point(500, -17);
            tree2.Location = new Point(700, -17);
            tree3.Location = new Point(900, -17);
            score.Text = "0";
            lastTree = tree3;
            this.Show();
        }

        private void timer_score_Tick(object sender, EventArgs e)
        {
            if (bird.Location.X==tree1.Location.X+tree1.Width|| bird.Location.X == tree2.Location.X + tree2.Width|| bird.Location.X == tree3.Location.X + tree3.Width)
            {
                int _score = int.Parse(score.Text) + 1;
                score.Text = _score.ToString();
            }
        }
    }
}
