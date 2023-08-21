using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catchy;
using ReadPositionOfCoursor;
namespace MotionCapture
{
    public partial class Form1 : Form
    {

        public int startX;
        public int startY;
        public int endX;
        public int endY;
        public Form1()
        {
            InitializeComponent();
            Task.Factory.StartNew(() =>
            {
                Catcher.Main();
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoursorPosition.begin = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoursorPosition.begin = false;
            //MessageBox.Show(CoursorPosition.xBegin + " " + CoursorPosition.yBegin);
            //MessageBox.Show(CoursorPosition.xEnd + " " + CoursorPosition.yEnd);
        }
    }
}
