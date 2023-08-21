using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionCapture
{
    internal class CoursorPosition
    {
        public static int xBegin = default(int);
        public static int xEnd = default(int);
        public static int yBegin = default(int);
        public static int yEnd = default(int);
        public static bool begin = true;
        public static int SavedPositionX { get { return xBegin; }
                    internal set {
                    if (begin == true) {
                        xBegin = value; } 
                            else {
                             xEnd = value;
                    //showTherectangle();
                }
            }
        }

      

        public static int SavedPositionY { get { return yBegin; }
                    internal set {
                    if (begin == true) {
                        yBegin = value; }
                            else {
                             yEnd = value;
                    showTherectangle();
                } 
            }
        }
        private static void showTherectangle()
        {
            MessageBox.Show($"xBegin:{xBegin}, yBegin:{yBegin},xEnd:{xEnd},yEnd:{yEnd}");
        }
    }
}
