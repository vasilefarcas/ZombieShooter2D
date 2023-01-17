using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter2D
{
    public class Player
    {
        public PictureBox image;
        public int health, speed, ammo, killCount;
        public const int maxAmmo = 10;
        public bool isMovingLeft, isMovingRight, isMovingUp, isMovingDown;
        public int orientation; // 1 means up, 2 means down, 3 means left, 4 means right
        public List<Bullet> bullets = new List<Bullet>();
        public Player(int health = 100, int speed = 5, int ammo = 10)
        {
            image = new PictureBox();
            image.Parent = Engine.form;
            image.Location = new Point(620, 420);
            image.Size = new Size(54, 72);
            image.BackColor = Color.Transparent;
            image.Image = Image.FromFile("../../bin/Images/player_up.png");
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            orientation = 1;
            if (health < 100)
                this.health = health;
            else this.health = 100;
            this.speed = speed;
            this.ammo = ammo;
        }
        public void Move()
        {
            if (isMovingDown)
            {
                if (image.Top < 580)
                    image.Top += speed;
                image.Size = new Size(54, 72);
                image.Image = Image.FromFile("../../bin/Images/player_down.png");
                orientation = 2;
            }
            else if (isMovingLeft)
            {
                if (image.Left > 25)
                    image.Left -= speed;
                image.Size = new Size(72, 54);
                image.Image = Image.FromFile("../../bin/Images/player_left.png");
                orientation = 3;
            }
            else if (isMovingUp)
            {
                if (image.Top > 70)
                    image.Top -= speed;
                image.Size = new Size(54, 72);
                image.Image = Image.FromFile("../../bin/Images/player_up.png");
                orientation = 1;
            }
            else if (isMovingRight)
            {
                if (image.Left < 1180)
                    image.Left += speed;
                image.Size = new Size(72, 54);
                image.Image = Image.FromFile("../../bin/Images/player_right.png");
                orientation = 4;
            }
        }
        public bool CheckIfAlive()
        {
            if (health <= 0)
            {
                return false;
            }
                return true;

        }

        public bool Shot()
        {
            if (ammo > 0)
            {
                bullets.Add(new Bullet());
                bullets[bullets.Count - 1].setDirection(this);
                ammo--;
                return true;
            }
            return false;
        }
        public void Reload()
        {
            ammo = maxAmmo;
        }
    }
}
