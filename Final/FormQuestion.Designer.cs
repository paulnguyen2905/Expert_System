namespace Final
{
    partial class FormQuestion
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
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.rd7 = new System.Windows.Forms.RadioButton();
            this.rd8 = new System.Windows.Forms.RadioButton();
            this.rd6 = new System.Windows.Forms.RadioButton();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(133)))));
            this.pnlControl.Controls.Add(this.btnStart);
            this.pnlControl.Controls.Add(this.btnNext);
            this.pnlControl.Controls.Add(this.btnBack);
            this.pnlControl.Controls.Add(this.btnReset);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 340);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(645, 80);
            this.pnlControl.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(645, 80);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(430, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(215, 80);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(215, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(215, 80);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(0, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(215, 80);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbLogo.BackgroundImage = global::Final.Properties.Resources.laptop100px;
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbLogo.Location = new System.Drawing.Point(250, 40);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(145, 145);
            this.ptbLogo.TabIndex = 1;
            this.ptbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(50, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Let\'s figuire out the best laptop for you!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuestion.Controls.Add(this.pnlLeft);
            this.pnlQuestion.Controls.Add(this.lbQuestion);
            this.pnlQuestion.Controls.Add(this.rd7);
            this.pnlQuestion.Controls.Add(this.rd8);
            this.pnlQuestion.Controls.Add(this.rd6);
            this.pnlQuestion.Controls.Add(this.rd5);
            this.pnlQuestion.Controls.Add(this.rd4);
            this.pnlQuestion.Controls.Add(this.rd3);
            this.pnlQuestion.Controls.Add(this.rd2);
            this.pnlQuestion.Controls.Add(this.rd1);
            this.pnlQuestion.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(645, 340);
            this.pnlQuestion.TabIndex = 3;
            this.pnlQuestion.Visible = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(133)))));
            this.pnlLeft.Location = new System.Drawing.Point(85, 90);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(7, 29);
            this.pnlLeft.TabIndex = 47;
            // 
            // lbQuestion
            // 
            this.lbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbQuestion.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(70, 15);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(505, 63);
            this.lbQuestion.TabIndex = 46;
            this.lbQuestion.Text = "label1";
            this.lbQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rd7
            // 
            this.rd7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rd7.AutoSize = true;
            this.rd7.BackColor = System.Drawing.Color.Transparent;
            this.rd7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd7.Location = new System.Drawing.Point(100, 267);
            this.rd7.Name = "rd7";
            this.rd7.Size = new System.Drawing.Size(52, 24);
            this.rd7.TabIndex = 44;
            this.rd7.TabStop = true;
            this.rd7.Text = "rd7";
            this.rd7.UseVisualStyleBackColor = false;
            this.rd7.CheckedChanged += new System.EventHandler(this.rd7_CheckedChanged);
            // 
            // rd8
            // 
            this.rd8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rd8.AutoSize = true;
            this.rd8.BackColor = System.Drawing.Color.Transparent;
            this.rd8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd8.Location = new System.Drawing.Point(100, 296);
            this.rd8.Name = "rd8";
            this.rd8.Size = new System.Drawing.Size(52, 24);
            this.rd8.TabIndex = 43;
            this.rd8.TabStop = true;
            this.rd8.Text = "rd8";
            this.rd8.UseVisualStyleBackColor = false;
            this.rd8.CheckedChanged += new System.EventHandler(this.rd8_CheckedChanged);
            // 
            // rd6
            // 
            this.rd6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rd6.AutoSize = true;
            this.rd6.BackColor = System.Drawing.Color.Transparent;
            this.rd6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd6.Location = new System.Drawing.Point(100, 238);
            this.rd6.Name = "rd6";
            this.rd6.Size = new System.Drawing.Size(52, 24);
            this.rd6.TabIndex = 42;
            this.rd6.TabStop = true;
            this.rd6.Text = "rd6";
            this.rd6.UseVisualStyleBackColor = false;
            this.rd6.CheckedChanged += new System.EventHandler(this.rd6_CheckedChanged);
            // 
            // rd5
            // 
            this.rd5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rd5.AutoSize = true;
            this.rd5.BackColor = System.Drawing.Color.Transparent;
            this.rd5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd5.Location = new System.Drawing.Point(100, 209);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(52, 24);
            this.rd5.TabIndex = 41;
            this.rd5.TabStop = true;
            this.rd5.Text = "rd5";
            this.rd5.UseVisualStyleBackColor = false;
            this.rd5.CheckedChanged += new System.EventHandler(this.rd5_CheckedChanged);
            // 
            // rd4
            // 
            this.rd4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rd4.AutoSize = true;
            this.rd4.BackColor = System.Drawing.Color.Transparent;
            this.rd4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd4.Location = new System.Drawing.Point(100, 180);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(52, 24);
            this.rd4.TabIndex = 40;
            this.rd4.TabStop = true;
            this.rd4.Text = "rd4";
            this.rd4.UseVisualStyleBackColor = false;
            this.rd4.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
            // 
            // rd3
            // 
            this.rd3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rd3.AutoSize = true;
            this.rd3.BackColor = System.Drawing.Color.Transparent;
            this.rd3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3.Location = new System.Drawing.Point(100, 151);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(52, 24);
            this.rd3.TabIndex = 39;
            this.rd3.TabStop = true;
            this.rd3.Text = "rd3";
            this.rd3.UseVisualStyleBackColor = false;
            this.rd3.CheckedChanged += new System.EventHandler(this.rd3_CheckedChanged);
            // 
            // rd2
            // 
            this.rd2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rd2.AutoSize = true;
            this.rd2.BackColor = System.Drawing.Color.Transparent;
            this.rd2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2.Location = new System.Drawing.Point(100, 122);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(52, 24);
            this.rd2.TabIndex = 38;
            this.rd2.TabStop = true;
            this.rd2.Text = "rd2";
            this.rd2.UseVisualStyleBackColor = false;
            this.rd2.CheckedChanged += new System.EventHandler(this.rd2_CheckedChanged);
            // 
            // rd1
            // 
            this.rd1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rd1.AutoSize = true;
            this.rd1.BackColor = System.Drawing.Color.Transparent;
            this.rd1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1.Location = new System.Drawing.Point(100, 93);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(52, 24);
            this.rd1.TabIndex = 37;
            this.rd1.TabStop = true;
            this.rd1.Text = "rd1";
            this.rd1.UseVisualStyleBackColor = false;
            this.rd1.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 420);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.pnlControl);
            this.Name = "FormQuestion";
            this.Text = "FormQuestion";
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.RadioButton rd7;
        private System.Windows.Forms.RadioButton rd8;
        private System.Windows.Forms.RadioButton rd6;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Panel pnlLeft;
    }
}