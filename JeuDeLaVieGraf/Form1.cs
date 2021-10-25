using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDeLaVieGraf
{
    public partial class Form1 : Form
    {
        private Game game;
        public int n = 0;
        private int nbAliveCell = 0;
        Timer MyTimer = new Timer();
        
        public Form1()
        {
            InitializeComponent();
            game = new Game(n, nbAliveCell);
            MyTimer.Interval = (500);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            game.grid.UpdateGrid();
            Refresh();
        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            game.Paint(e.Graphics);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LengthText.Text, out n))
            {
                pictureBox1.Size = new Size(5*n, 5*n);
                pictureBox1.Top = (Screen.PrimaryScreen.WorkingArea.Height - pictureBox1.Height) / 2;
                pictureBox1.Left = (Screen.PrimaryScreen.WorkingArea.Width - pictureBox1.Width) / 2;
                nbAliveCell = n * n / 2;
                game = new Game(n,nbAliveCell);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            return;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MyTimer.Start();
        }
    }
}