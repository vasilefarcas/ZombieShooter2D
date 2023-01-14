using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter2D
{
    public class Engine
    {
        public static Form1 form;
        public static void Initialize(Form1 f)
        {
            form = f;
        }
        public static bool isCollisionPlayerEnemy(Player player, Enemy enemy)
        {
            return player.image.Bounds.IntersectsWith(enemy.image.Bounds);
        }
        public static bool isCollisionBulletEnemy(Bullet bullet, Enemy enemy)
        {
            //  if (bullet.image.Location.X > enemy.image.Location.X && bullet.image.Right < enemy.image.Right && bullet.image.Location.Y > enemy.image.Location.Y && bullet.image.Y+bullet.image.Height)
            if ((bullet.image.Left < enemy.image.Right) && (bullet.image.Right > enemy.image.Left) && (bullet.image.Top < enemy.image.Bottom) && (bullet.image.Bottom > enemy.image.Top))
                return true;
            return false;

            //    return bullet.image.Bounds.IntersectsWith(enemy.image.Bounds);
        }
    }
}
