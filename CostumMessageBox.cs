using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managment
{
    public partial class CostumMessageBox : Form
    {
        public CostumMessageBox(bool isSuccessufl = false)
        {
            InitializeComponent();
            if (isSuccessufl)
            {
                pictureBox1.Image = Properties.Resources.success;
                Text = "Successulfy";
                messageBox.Text = "Successulfy";
            }
            else 
            {
                pictureBox1.Image = Properties.Resources.failed;
                Text = "Failed";
                messageBox.Text = "Failed";
            }

        }
    }
}
