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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            TestButton.statusBarLabel = this.statusBarLabel;
        }

        private void debugSwitch_CheckedChanged(object sender, EventArgs e)
        {
            TestButton.printLog = debugSwitch.Checked;
        }     
    }
}
