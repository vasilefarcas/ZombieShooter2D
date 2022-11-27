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
        public int health, speed, ammo;
        public const int maxAmmo = 10;
        public bool isMovingLeft, isMovingRight, isMovingUp, isMovingDown;
        public Player(int health = 1000, int speed = 5, int ammo = 10)
        {
            image = new PictureBox();
            image.Parent = Engine.form;
            image.Location = new Point(620, 420);
            image.Size = new Size(54, 72);
            image.BackColor = Color.Transparent;
            image.Image = Image.FromFile("../../bin/Images/player_up.png");
            image.SizeMode = PictureBoxSizeMode.StretchImage;
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
                if (image.Top < 600)
                    image.Top += speed;
                image.Size = new Size(54, 72);
                image.Image = Image.FromFile("../../bin/Images/player_down.png");
            }
            else if (isMovingLeft)
            {
                if (image.Left > 25)
                    image.Left -= speed;
                image.Size = new Size(72, 54);
                image.Image = Image.FromFile("../../bin/Images/player_left.png");
            }
            else if (isMovingUp)
            {
                if (image.Top > 50)
                    image.Top -= speed;
                image.Size = new Size(54, 72);
                image.Image = Image.FromFile("../../bin/Images/player_up.png");
            }
            else if (isMovingRight)
            {
                if (image.Left < 1180)
                    image.Left += speed;
                image.Size = new Size(72, 54);
                image.Image = Image.FromFile("../../bin/Images/player_right.png");
            }
        }
    }
}
