namespace Final
{
    partial class FormResult
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLink = new System.Windows.Forms.LinkLabel();
            this.lbText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbLaptop = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLaptop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbLink);
            this.panel1.Controls.Add(this.lbText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ptbLaptop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 420);
            this.panel1.TabIndex = 1;
            // 
            // lbLink
            // 
            this.lbLink.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLink.Location = new System.Drawing.Point(15, 360);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(615, 40);
            this.lbLink.TabIndex = 3;
            this.lbLink.TabStop = true;
            this.lbLink.Text = "linkLabel1";
            this.lbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_LinkClicked);
            // 
            // lbText
            // 
            this.lbText.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(15, 85);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(400, 200);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "label2";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recommend for you";
            // 
            // ptbLaptop
            // 
            this.ptbLaptop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbLaptop.Location = new System.Drawing.Point(430, 85);
            this.ptbLaptop.Name = "ptbLaptop";
            this.ptbLaptop.Size = new System.Drawing.Size(200, 200);
            this.ptbLaptop.TabIndex = 0;
            this.ptbLaptop.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Related Products";
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 420);
            this.Controls.Add(this.panel1);
            this.Name = "FormResult";
            this.Text = "FormResult";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLaptop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbLaptop;
        private System.Windows.Forms.LinkLabel lbLink;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}