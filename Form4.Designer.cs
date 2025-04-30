namespace Arrays_Shua
{
    partial class Form4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnInActive = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNgalan = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnActive
            // 
            this.btnActive.Location = new System.Drawing.Point(48, 213);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(158, 54);
            this.btnActive.TabIndex = 1;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = true;
            // 
            // btnInActive
            // 
            this.btnInActive.Location = new System.Drawing.Point(48, 284);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(158, 54);
            this.btnInActive.TabIndex = 2;
            this.btnInActive.Text = "InActive";
            this.btnInActive.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(48, 357);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(158, 54);
            this.btnLogs.TabIndex = 3;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(48, 431);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 54);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblNgalan
            // 
            this.lblNgalan.AutoSize = true;
            this.lblNgalan.Location = new System.Drawing.Point(61, 192);
            this.lblNgalan.Name = "lblNgalan";
            this.lblNgalan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNgalan.Size = new System.Drawing.Size(42, 13);
            this.lblNgalan.TabIndex = 5;
            this.lblNgalan.Text = "Mwuah";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(833, 453);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(114, 32);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add student";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 516);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblNgalan);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnInActive);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnInActive;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Label lblNgalan;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnadd;
    }
}