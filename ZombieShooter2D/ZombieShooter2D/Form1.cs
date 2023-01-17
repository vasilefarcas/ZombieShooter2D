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
        private int time = 0;

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
            for (int i = 0; i < 4; i++)
            {
                enemy.Add(new Enemy());
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Thread.Sleep(100);
                stopWatch.Stop();
            }
        }

        #region KeyUpDown

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
            {
                if (time >= 30)
                {
                    player.Shot();
                    time = 0;
                }
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
            if (e.KeyCode == Keys.R)
                player.Reload();
        }
        #endregion

        #region Timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
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
            foreach (Enemy item in enemy)
            {
                item.VerifyDirection(player);
                item.isAttacking = Engine.isCollisionPlayerEnemy(player, item);
                foreach (Bullet item1 in player.bullets)
                    if (Engine.isCollisionBulletEnemy(item1, item))
                    {
                        killsCount.Text = (int.Parse(killsCount.Text) + 1).ToString();
                        item1.DeleteBullet();
                        item.DeleteEnemy();
                        player.killCount++;
                    }
            }
            ammoCount.Text = player.ammo.ToString();
            healthBar.Value = Math.Max(player.health, 0);
            if (!player.CheckIfAlive())
            {
                timer1.Enabled = false;
                timer1.Enabled = false;
                timer4.Enabled = false;
                MessageBox.Show("You died!");
                this.Close();
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            enemy.Add(new Enemy());
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            foreach (Enemy item in enemy)
                if (item.isAttacking)
                    player.health -= item.damage;
        }
        #endregion


    }
}
