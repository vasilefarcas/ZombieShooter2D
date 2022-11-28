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
        public PictureBox image;
        public int speed, damage;
        public bool isAlive, isMovingLeft, isMovingRight, isMovingUp, isMovingDown, isAttacking;

        public Enemy(int speed = 2, int damage = 5)
        {
            isAlive = true;
            this.speed = speed;
            this.damage = damage;
            image = new PictureBox();
            image.Parent = Engine.form;
            Random rnd = new Random();
            image.Location = new Point(rnd.Next(25, 1180), rnd.Next(50, 600));
            image.Size = new Size(55, 65);
            image.BackColor = Color.Transparent;
            image.Image = Image.FromFile("../../bin/Images/enemy_up.png");
            image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void VerifyDirectionX(Player player)
        {
            isMovingLeft = false;
            isMovingRight = false;
            if (player.image.Location.X > image.Location.X)
                isMovingRight = true;
            else
            if (player.image.Location.X < image.Location.X)
                isMovingLeft = true;
        }
        private void VerifyDirectionY(Player player)
        {
            isMovingUp = false;
            isMovingDown = false;
            if (player.image.Location.Y > image.Location.Y)
                isMovingUp = true;
            else
            if (player.image.Location.Y < image.Location.Y)
                isMovingDown = true;
        }
        public void VerifyDirection(Player player)
        {
            VerifyDirectionY(player);
            VerifyDirectionX(player);
        }
        public void Move()
        {

            if (isMovingUp)
            {
                if (image.Top > 50)
                    image.Top += speed;
                image.Size = new Size(55, 65);
                image.Image = Image.FromFile("../../bin/Images/enemy_up.png");
            }
            else
            if (isMovingDown)
            {
                if (image.Top < 600)
                    image.Top -= speed;
                image.Size = new Size(55, 65);
                image.Image = Image.FromFile("../../bin/Images/enemy_down.png");
            }
            if (isMovingLeft)
            {
                if (image.Left > 25)
                    image.Left -= speed;
                image.Size = new Size(65, 55);
                image.Image = Image.FromFile("../../bin/Images/enemy_left.png");
            }
            else if (isMovingRight)
            {
                if (image.Left < 1180)
                    image.Left += speed;
                image.Size = new Size(65, 55);
                image.Image = Image.FromFile("../../bin/Images/enemy_right.png");

            }
        }
        public void DeleteEnemy()
        {
            
            isAlive = false;
            image.Size = new Size(0, 0);
            image.Location = new Point(0, 0);
            image.Dispose();
        }
    }
}
