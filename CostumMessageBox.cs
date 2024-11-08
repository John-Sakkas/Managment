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
        public CostumMessageBox(bool isSuccessufl, string errorInfoText = "")
        {
            InitializeComponent();
            if (isSuccessufl)
            {
                pictureBox1.Image = Properties.Resources.success;
                Text = "Successulfy";
                messageBox.Text = "Successulfy";
                errorInfo.Visible = false;
            }
            else 
            {
                pictureBox1.Image = Properties.Resources.failed;
                Text = "Failed";
                messageBox.Text = "Failed";
                toolTip1.SetToolTip(errorInfo, CustomeErrorMessage(errorInfoText));
            }
        }

        private string CustomeErrorMessage(String errorMessage)
        {
            if (errorMessage.Contains("String or binary data would be truncated in table"))
            {
                return "Name must be max 10 characters";
            }
            return "";
        }
    }
}
