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
    }
}
