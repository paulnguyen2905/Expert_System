using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class FormHistory : Form
    {
        public FormHistory(String s)
        {
            InitializeComponent();
            this.lbText.Text = s;
        }

        private void lbText_Click(object sender, EventArgs e)
        {

        }
    }
}
