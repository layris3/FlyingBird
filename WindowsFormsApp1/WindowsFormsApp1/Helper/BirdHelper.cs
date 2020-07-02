using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApp1.Helper
{
    public class BirdHelper
    {
        public static void Jump(out int speed)
        {
            speed = -10;
        }

        public static bool IsBirdCrashTree(PictureBox bird,Tree tree)
        {
            
            if (bird.Location.X+bird.Width>=tree.Location.X&& bird.Location.X + bird.Width<=tree.Location.X+tree.Width||bird.Location.X>=tree.Location.X&&bird.Location.X<=tree.Location.X+tree.Width)
            {
                //判断和upTree是否相撞
                if (bird.Location.Y<=tree.UptreeLeftDownPoint)
                {
                    return true;
                }
                if (bird.Location.Y+bird.Height>=tree.DowntreeLeftUpPoint)
                {
                    return true;
                }
            }
            return false;
        }
 
    }
}
