using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter2D
{
    public class Enemy
    {
        PictureBox image;
        public int speed, damage;
        public bool isAlive, isMovingLeft, isMovingRight, isMovingUp, isMovingDown;

        public Enemy(int speed = 6, int damage = 5)
        {
            isAlive = true;
            this.speed = speed;
            this.damage = damage;
            image = new PictureBox();
            image.Parent = Engine.form;
            Random rnd = new Random();
            image.Location = new Point(rnd.Next(25, 1180), rnd.Next(50, 700));
            image.Size = new Size(55, 65);
            image.BackColor = Color.Transparent;
            image.Image = Image.FromFile("../../bin/Images/enemy_up.png");
            image.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void Move()
        {
            if (isMovingDown)
            {
                if (image.Top < 600)
                    image.Top += speed;
                image.Size = new Size(54, 72);
                image.Image = Image.FromFile("../../bin/Images/enemy_down.png");
            }
            else if (isMovingLeft)
            {
                if (image.Left > 25)
                    image.Left -= speed;
                image.Size = new Size(72, 54);
                image.Image = Image.FromFile("../../bin/Images/enemy_left.png");
            }
            else if (isMovingUp)
            {
                if (image.Top > 50)
                    image.Top -= speed;
                image.Size = new Size(54, 72);
                image.Image = Image.FromFile("../../bin/Images/enemy_up.png");
            }
            else if (isMovingRight)
            {
                if (image.Left < 1180)
                    image.Left += speed;
                image.Size = new Size(72, 54);
                image.Image = Image.FromFile("../../bin/Images/enemy_right.png");
            }
        }
    }
}
