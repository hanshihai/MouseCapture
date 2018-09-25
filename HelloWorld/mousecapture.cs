using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseCapture
{
    public partial class MouseCapture : Form
    {

        System.Threading.Thread _backendThread = null;

        int X = 0;
        int Y = 0;
        int duration = 60;
        int maxTime = 1000;

        int timer = 1000;

        [System.Runtime.InteropServices.DllImport("User32")]
        public extern static void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);
        [System.Runtime.InteropServices.DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);
        [System.Runtime.InteropServices.DllImport("User32")]
        public extern static bool GetCursorPos(out POINT p);
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }
        public enum MouseEventFlags
        {
            Move = 0x0001, //移动鼠标
            LeftDown = 0x0002,//模拟鼠标左键按下
            LeftUp = 0x0004,//模拟鼠标左键抬起
            RightDown = 0x0008,//鼠标右键按下
            RightUp = 0x0010,//鼠标右键抬起
            MiddleDown = 0x0020,//鼠标中键按下 
            MiddleUp = 0x0040,//中键抬起
            Wheel = 0x0800,
            Absolute = 0x8000//标示是否采用绝对坐标
        }

        public MouseCapture()
        {
            InitializeComponent();
        }

        void go(String x, String y)
        {
            X = Int32.Parse(x);
            Y = Int32.Parse(y);
            SetCursorPos(X, Y);
        }

        void click()
        {
            mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), X, Y, 0, IntPtr.Zero);
            mouse_event((int)(MouseEventFlags.LeftUp | MouseEventFlags.Absolute), X, Y, 0, IntPtr.Zero);
        }

        void sleep(int t)
        {
            System.Threading.Thread.Sleep(t);
        }

        void threadExecute() {
            int run = 0;
            while (run < maxTime) {
                sleep(1000);
                click();
                run++;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F12)
            {
                if (_backendThread != null)
                {
                    _backendThread.Abort();
                    _backendThread = null;
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void GetMouse_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                this.xBox.Text = Cursor.Position.X.ToString();
                this.ybox.Text = Cursor.Position.Y.ToString();
            }
            catch (Exception ex){
                MessageBox.Show("eror when catch mouse site: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoveMouse_Click(object sender, EventArgs e)
        {
            try {
                go(this.xBox.Text, this.ybox.Text);
                X = Int32.Parse(this.xBox.Text);
                Y = Int32.Parse(this.ybox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("eror when move mouse site: " + ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.maxTime = Int32.Parse(this.timeInput.Text);
        }

        private void GO_Click(object sender, EventArgs e)
        {
            if (_backendThread == null)
            {
                _backendThread = new System.Threading.Thread(new System.Threading.ThreadStart(threadExecute));
                _backendThread.IsBackground = true;
                _backendThread.Start();
            }
        }
    }
}
