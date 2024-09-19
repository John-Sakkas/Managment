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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(String username)
        {
            InitializeComponent();
            label2.Text = username;
        }

        bool menuExpand = false;
        private void itemMenuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                itemMenu.Height += 10;
                if (itemMenu.Height >= 232)
                {
                    itemMenuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                itemMenu.Height -= 10;
                if (itemMenu.Height <= 50)
                {
                    itemMenuTransition.Stop();
                    menuExpand = false;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemMenuTransition.Start();
        }
    }
}
