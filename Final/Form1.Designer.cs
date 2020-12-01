namespace Final
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lbHome = new System.Windows.Forms.Label();
            this.ptbHome = new System.Windows.Forms.PictureBox();
            this.pnlSlogan = new System.Windows.Forms.Panel();
            this.lbSlogan = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).BeginInit();
            this.pnlSlogan.SuspendLayout();
            this.pnlChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnHistory);
            this.pnlMenu.Controls.Add(this.btnAnswer);
            this.pnlMenu.Controls.Add(this.btnQuestion);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 500);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = global::Final.Properties.Resources.exit_30px;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnHistory
            // 
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHistory.Image = global::Final.Properties.Resources.adventure_30px;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(0, 200);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(220, 60);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click_1);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnswer.FlatAppearance.BorderSize = 0;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnswer.Image = global::Final.Properties.Resources.list_30px;
            this.btnAnswer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswer.Location = new System.Drawing.Point(0, 140);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(220, 60);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Result";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click_1);
            // 
            // btnQuestion
            // 
            this.btnQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuestion.FlatAppearance.BorderSize = 0;
            this.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuestion.Image = global::Final.Properties.Resources.faq_30px;
            this.btnQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestion.Location = new System.Drawing.Point(0, 80);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(220, 60);
            this.btnQuestion.TabIndex = 1;
            this.btnQuestion.Text = "Question";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click_1);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Controls.Add(this.lbHome);
            this.pnlLogo.Controls.Add(this.ptbHome);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 80);
            this.pnlLogo.TabIndex = 0;
            // 
            // lbHome
            // 
            this.lbHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHome.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHome.Location = new System.Drawing.Point(90, 5);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(120, 70);
            this.lbHome.TabIndex = 2;
            this.lbHome.Text = "Laptop Advisory";
            this.lbHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbHome
            // 
            this.ptbHome.BackgroundImage = global::Final.Properties.Resources.laptop_100px;
            this.ptbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbHome.Location = new System.Drawing.Point(10, 5);
            this.ptbHome.Name = "ptbHome";
            this.ptbHome.Size = new System.Drawing.Size(70, 70);
            this.ptbHome.TabIndex = 1;
            this.ptbHome.TabStop = false;
            // 
            // pnlSlogan
            // 
            this.pnlSlogan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.pnlSlogan.Controls.Add(this.lbSlogan);
            this.pnlSlogan.Controls.Add(this.btnHome);
            this.pnlSlogan.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlSlogan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSlogan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSlogan.Location = new System.Drawing.Point(220, 0);
            this.pnlSlogan.Name = "pnlSlogan";
            this.pnlSlogan.Size = new System.Drawing.Size(645, 80);
            this.pnlSlogan.TabIndex = 4;
            // 
            // lbSlogan
            // 
            this.lbSlogan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lbSlogan.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlogan.ForeColor = System.Drawing.Color.White;
            this.lbSlogan.Location = new System.Drawing.Point(200, 20);
            this.lbSlogan.Name = "lbSlogan";
            this.lbSlogan.Size = new System.Drawing.Size(245, 40);
            this.lbSlogan.TabIndex = 3;
            this.lbSlogan.Text = "Home";
            this.lbSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Image = global::Final.Properties.Resources.multiply_50px;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 80);
            this.btnHome.TabIndex = 2;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Controls.Add(this.label1);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(220, 80);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(645, 420);
            this.pnlChildForm.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright(c) by - 18521536_Lê Anh Triều - 18521591_Đặng Nguyễn Anh Tuấn - 1852142" +
    "7_Nguyễn Hoàng Thiên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 500);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSlogan);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Laptop Advisory";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).EndInit();
            this.pnlSlogan.ResumeLayout(false);
            this.pnlChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.PictureBox ptbHome;
        private System.Windows.Forms.Panel pnlSlogan;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Label lbSlogan;
        private System.Windows.Forms.Label label1;
    }
}

