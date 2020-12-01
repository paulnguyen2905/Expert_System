using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Final
{
    public partial class FormResult : Form
    {
        public FormResult(String text, String Image, String Link)
        {
            InitializeComponent();
            lbText.Text = text;
            ptbLaptop.BackgroundImage = new Bitmap(Image.ToString());
            lbLink.Text = Link;
            
        }

        private void linklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.lbLink.Text);
        }
    }

}
