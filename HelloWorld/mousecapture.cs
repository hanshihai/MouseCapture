using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class MouseCapture : Form
    {
        public MouseCapture()
        {
            InitializeComponent();
        }

        private void GetMouse_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            this.xBox.Text = Cursor.Position.X.ToString();
            this.ybox.Text = Cursor.Position.Y.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoveMouse_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(Int32.Parse(this.xBox.Text), Int32.Parse(this.ybox.Text));
        }
    }
}
