using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter2D
{
    public partial class Form1 : Form
    {
        public Player player;
        public Enemy enemy;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            Engine.Initialize(this);
            player = new Player();
            ammoCount.Text = player.ammo.ToString();
            killsCount.Text = "0";
            healthBar.Value = player.health;
            enemy = new Enemy();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                player.isMovingLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                player.isMovingRight = true;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                player.isMovingUp = true;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                player.isMovingDown = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Move();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                player.isMovingLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                player.isMovingRight = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                player.isMovingUp = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                player.isMovingDown = false;
            }
        }
    }
}
