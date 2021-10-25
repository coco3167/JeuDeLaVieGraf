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
        private int nbAliveCell = 40*20;
        public int n;
        public Form1()
        {
            n = 40;
            InitializeComponent(n);
            game = new Game(n,nbAliveCell);
            Timer MyTimer = new Timer();
            MyTimer.Interval = (500);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
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
    }
}