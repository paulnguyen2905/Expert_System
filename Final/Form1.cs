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
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CloseChildForm(Form childForm)
        {
            childForm.Close();
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnQuestion_Click_1(object sender, EventArgs e)
        {
            if (currentButton != (Button)sender)
            {
                DisableButton();
                Color color = Color.FromArgb(11, 97, 133);
                currentButton = (Button)sender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Century", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnlLogo.BackColor = Color.FromArgb(7, 67, 93);
                pnlSlogan.BackColor = Color.FromArgb(11, 97, 133);
                btnHome.Visible = true;
                btnHome.BackColor = Color.FromArgb(11, 97, 133);
                lbSlogan.Text = btnQuestion.Text;
                //panelTitleBar.BackColor = color;
                //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                //ThemeColor.PrimaryColor = color;
                //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                //btnCloseChildForm.Visible = true;

            }
            OpenChildForm(new FormQuestion());
        }

        public void btnAnswer_Click_1(object sender, EventArgs e)
        {
            if (currentButton != (Button)sender)
            {
                DisableButton();
                Color color = Color.FromArgb(0, 159, 179);
                currentButton = (Button)sender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Century", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnlLogo.BackColor = Color.FromArgb(0, 110, 123);
                pnlSlogan.BackColor = Color.FromArgb(0, 159, 179);
                btnHome.Visible = true;
                btnHome.BackColor = Color.FromArgb(0, 159, 179);
                lbSlogan.Text = btnAnswer.Text;
                
            }
            OpenChildForm(new FormResult(GlobalVariable.result, GlobalVariable.Image, GlobalVariable.Link));
        }

        private void btnHistory_Click_1(object sender, EventArgs e)
        {
            if (currentButton != (Button)sender)
            {
                DisableButton();
                Color color = Color.FromArgb(0, 135, 196);
                currentButton = (Button)sender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Century", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnlLogo.BackColor = Color.FromArgb(0, 94, 136);
                pnlSlogan.BackColor = Color.FromArgb(0, 135, 196);
                btnHome.Visible = true;
                btnHome.BackColor = Color.FromArgb(0, 135, 196);
                lbSlogan.Text = btnHistory.Text;
                
            }

            OpenChildForm(new FormHistory(GlobalVariable.history));
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            if (currentButton != (Button)sender)
            {
                DisableButton();
                pnlSlogan.BackColor = Color.FromArgb(0, 134, 138);
                pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
                btnHome.Visible = false;
                btnHome.BackColor = Color.FromArgb(0, 134, 138);
                lbSlogan.Text = "Home";
                
            }
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
