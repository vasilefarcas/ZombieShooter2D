using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter2D
{
    public class Bullet
    {
        public PictureBox image;
        public int speed;
        public int orientation;
        public bool targetHit;
        public Bullet(int speed = 6)
        {
            this.speed = speed;
            image = new PictureBox();
            image.Parent = Engine.form;
        }
        public void setDirection(Player player)
        {
            this.orientation = player.orientation;
            switch (orientation)
            {
                case 1:
                    image.Location = new Point(player.image.Location.X, player.image.Location.Y);
                    image.Size = new Size(12, 16);
                    image.BackColor = Color.Transparent;
                    image.Image = Image.FromFile("../../bin/Images/bullet_up.png");
                    image.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    image.Location = new Point(player.image.Location.X, player.image.Location.Y);
                    image.Size = new Size(12, 16);
                    image.BackColor = Color.Transparent;
                    image.Image = Image.FromFile("../../bin/Images/bullet_down.png");
                    image.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    image.Location = new Point(player.image.Location.X, player.image.Location.Y);
                    image.Size = new Size(16, 12);
                    image.BackColor = Color.Transparent;
                    image.Image = Image.FromFile("../../bin/Images/bullet_left.png");
                    image.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    image.Location = new Point(player.image.Location.X, player.image.Location.Y);
                    image.Size = new Size(16, 12);
                    image.BackColor = Color.Transparent;
                    image.Image = Image.FromFile("../../bin/Images/bullet_right.png");
                    image.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    break;
            }
        }
        public void Move()
        {
            switch (orientation)
            {
                case 1:
                    image.Top -= speed;
                    if (image.Top < 0)
                        this.DeleteBullet();
                    break;
                case 2:
                    image.Top += speed;
                    if (image.Top > 720)
                        this.DeleteBullet();
                    break;
                case 3:
                    image.Left -= speed;
                    if (image.Left < 0)
                        this.DeleteBullet();
                    break;
                case 4:
                    image.Left += speed;
                    if (image.Left > 1300)
                        this.DeleteBullet();
                    break;
                default:
                    break;
            }
        }
        public void DeleteBullet()
        {
            this.targetHit = true;
            this.image.Size = new Size(0, 0);
            this.image.Location = new Point(0, 0);
            this.speed = 0;
            this.image.Dispose();
        }
    }
}
