using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A3
{
    class TestButton : Button
    {
        public static bool printLog = true;
        public static ToolStripStatusLabel statusBarLabel;

        public TestButton()
        {
            this.ForeColor = System.Drawing.Color.Red;
        }

        protected void WriteLine(string message)
        {
            if (TestButton.printLog == true)
            {
                message = this.Text + ": " + message;

                Console.WriteLine(message);
                TestButton.statusBarLabel.Text = message;
            }
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            this.WriteLine("Mouse entered");
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            this.WriteLine("Mouse left");
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            this.WriteLine("Mouse clicked");
        }
    }
}
