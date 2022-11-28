using System;
using System.Collections.Generic;
using System.Linq;
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
            if (player.image.Bounds.IntersectsWith(enemy.image.Bounds))
                return true;
            return false;
        }
        public static bool isCollisionBulletEnemy(Bullet bullet, Enemy enemy)
        {
            if (bullet.image.Bounds.IntersectsWith(enemy.image.Bounds)==true)
                return true;
            return false;
        }
    }
}
