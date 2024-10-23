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
        public CostumMessageBox()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"bin/Images/icons8-cancel-48.png");
        }
    }
}
