using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_framework_Ödev_2
{
    public partial class windows_framework_Ödev_2 : Form
    {
        public windows_framework_Ödev_2()
        {
            InitializeComponent();
        }

        private void TimerOdev_Click(object sender, EventArgs e)
        {
            TimerOdev from = new TimerOdev();
            from.Show();

        }
    }
}
