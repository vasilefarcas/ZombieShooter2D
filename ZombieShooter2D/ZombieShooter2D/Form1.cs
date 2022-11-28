using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter2D
{
    public partial class Form1 : Form
    {
        public Player player;
        public List<Enemy> enemy = new List<Enemy>();

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
            for (int i = 0; i < 5; i++)
            {
                enemy.Add(new Enemy());
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Thread.Sleep(100);
                stopWatch.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                player.isMovingLeft = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                player.isMovingRight = true;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                player.isMovingUp = true;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                player.isMovingDown = true;
            if (e.KeyCode == Keys.Space)
                player.isShooting = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Move();
            foreach (Enemy item in enemy)
            {
                if (item.isAlive)
                    item.Move();
            }
            foreach (Bullet item in player.bullets)
            {
                if (item.targetHit == false)
                    item.Move();
            }
            healthBar.Value = player.health;
            if (!player.CheckIfAlive())
            {
                timer1.Enabled = false;
                MessageBox.Show("You died!");
                this.Close();
            }
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
            if (e.KeyCode == Keys.Space)
                player.isShooting = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (Enemy item in enemy)
            {
                item.VerifyDirection(player);
                item.isAttacking = Engine.isCollisionPlayerEnemy(player, item);
                foreach (Bullet item1 in player.bullets)
                    if (Engine.isCollisionBulletEnemy(item1, item))
                    {
                        item1.DeleteBullet();
                        item.DeleteEnemy();
                        player.killCount++;
                    }
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            foreach (Enemy item in enemy)
                if (item.isAttacking)
                    player.health -= item.damage;
            if (player.isShooting)
                player.Shot();
        }
    }
}
