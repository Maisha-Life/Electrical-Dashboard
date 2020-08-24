using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using sD = System.Drawing;
using sF = System.Windows.Forms;
using Microsoft.Win32;

namespace WpfStyleableWindow.StyleableWindow
{
    public class WindowMaximizeCommand : ICommand
    {
        private double scale, storedHeight, storedWidth, storedTop, storedLeft;
        private bool state;

        public WindowMaximizeCommand()
        {
            state = false;

            var currentDPI = (int)Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\WindowMetrics", "AppliedDPI", 96);
            scale = 96 / (float)currentDPI;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var window = parameter as Window;

            if (window != null)
                if (window.ResizeMode.ToString() != "NoResize")
                    if (state)
                    {
                        window.Height = storedHeight;
                        window.Width = storedWidth;
                        window.Top = storedTop;
                        window.Left = storedLeft;

                        state = false;
                    }
                    else
                    {
                        var posX = sF.Cursor.Position.X;
                        var posY = sF.Cursor.Position.Y;
                        sF.Screen selectedScreen = sF.Screen.FromPoint(new sD.Point(posX, posY));

                        storedHeight = window.Height;
                        storedWidth = window.Width;
                        storedTop = window.Top;
                        storedLeft = window.Left;

                        window.Height = selectedScreen.WorkingArea.Height * scale;
                        window.Width = selectedScreen.WorkingArea.Width * scale;

                        window.Top = selectedScreen.WorkingArea.Top * scale;
                        window.Left = selectedScreen.WorkingArea.Left * scale;
                        state = true;
                    }
        }
    }
}
