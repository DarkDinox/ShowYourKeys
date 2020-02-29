using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShowKeyboard
{
    public partial class frmMain : Form
    {

        [DllImport("user32.dll")]
        static extern bool GetAsyncKeyState(Keys vKey);
        private int keysPerSec;
        private bool leftTop; bool leftDown; bool center; bool rightTop; bool rightDown;

        public frmMain()
        {
            InitializeComponent();
        }

        private void tmrLoop_Tick(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.NumLock) ? GetAsyncKeyState(Keys.NumPad7) : GetAsyncKeyState(Keys.Home))
            {
                picLeftTop.Visible = true;
                if (!leftTop) keysPerSec++; leftTop = true;
            }
            else
            {
                picLeftTop.Visible = false;
                leftTop = false;
            }

            if (Control.IsKeyLocked(Keys.NumLock) ? GetAsyncKeyState(Keys.NumPad9) : GetAsyncKeyState(Keys.PageUp))
            {
                picRightTop.Visible = true;
                if (!rightTop) keysPerSec++; rightTop = true;
            }
            else
            {
                picRightTop.Visible = false;
                rightTop = false;
            }

            if (Control.IsKeyLocked(Keys.NumLock) ? GetAsyncKeyState(Keys.NumPad5) : GetAsyncKeyState(Keys.Clear))
            {
                picCenter.Visible = true;
                if(!center) keysPerSec++; center = true;
            }
            else {
                picCenter.Visible = false;
                center = false;
            }

            if (Control.IsKeyLocked(Keys.NumLock) ? GetAsyncKeyState(Keys.NumPad3) : GetAsyncKeyState(Keys.PageDown))
            {
                picRightDown.Visible = true;
                if (!rightDown) keysPerSec++; rightDown = true;
            }
            else
            {
                picRightDown.Visible = false;
                rightDown = false;
            }

            if (Control.IsKeyLocked(Keys.NumLock) ? GetAsyncKeyState(Keys.NumPad1) : GetAsyncKeyState(Keys.End))
            {
                picLeftDown.Visible = true;
                if (!leftDown) keysPerSec++; leftDown = true;
            }
            else
            {
                picLeftDown.Visible = false;
                leftDown = false;
            }

            lblKeysPerMinute.Text = "Keys per Sec: " + keysPerSec;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picLeftTop.Top = picOffLeftTop.Top;
            picLeftTop.Left = picOffLeftTop.Left;
            picLeftDown.Top = picOffLeftDown.Top;
            picLeftDown.Left = picOffLeftDown.Left;

            picCenter.Top = picOffCenter.Top;
            picCenter.Left = picOffCenter.Left;

            picRightTop.Top = picOffRightTop.Top;
            picRightTop.Left = picOffRightTop.Left;
            picRightDown.Top = picOffRightDown.Top;
            picRightDown.Left = picOffRightDown.Left;
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            keysPerSec = 0;
        }
    }
}
