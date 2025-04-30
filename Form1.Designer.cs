namespace Arrays_Shua
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.chkOG = new System.Windows.Forms.CheckBox();
            this.chkVolleyball = new System.Windows.Forms.CheckBox();
            this.chkBasketball = new System.Windows.Forms.CheckBox();
            this.cmbFavcolor = new System.Windows.Forms.ComboBox();
            this.txtSaying = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtProfilePic = new System.Windows.Forms.TextBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 18);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Label";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(381, 210);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(90, 40);
            this.btnDisplay.TabIndex = 32;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(381, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 40);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 20);
            this.txtName.TabIndex = 30;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(209, 121);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 29;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(138, 121);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 28;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // chkOG
            // 
            this.chkOG.AutoSize = true;
            this.chkOG.Location = new System.Drawing.Point(138, 210);
            this.chkOG.Name = "chkOG";
            this.chkOG.Size = new System.Drawing.Size(92, 17);
            this.chkOG.TabIndex = 26;
            this.chkOG.Text = "Online Games";
            this.chkOG.UseVisualStyleBackColor = true;
            // 
            // chkVolleyball
            // 
            this.chkVolleyball.AutoSize = true;
            this.chkVolleyball.Location = new System.Drawing.Point(138, 187);
            this.chkVolleyball.Name = "chkVolleyball";
            this.chkVolleyball.Size = new System.Drawing.Size(70, 17);
            this.chkVolleyball.TabIndex = 25;
            this.chkVolleyball.Text = "Volleyball";
            this.chkVolleyball.UseVisualStyleBackColor = true;
            // 
            // chkBasketball
            // 
            this.chkBasketball.AutoSize = true;
            this.chkBasketball.Location = new System.Drawing.Point(138, 164);
            this.chkBasketball.Name = "chkBasketball";
            this.chkBasketball.Size = new System.Drawing.Size(75, 17);
            this.chkBasketball.TabIndex = 24;
            this.chkBasketball.Text = "Basketball";
            this.chkBasketball.UseVisualStyleBackColor = true;
            // 
            // cmbFavcolor
            // 
            this.cmbFavcolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFavcolor.FormattingEnabled = true;
            this.cmbFavcolor.Items.AddRange(new object[] {
            "Blue",
            "Yellow",
            "Black",
            "Brown",
            "White",
            "Pink",
            "Red",
            "Orange"});
            this.cmbFavcolor.Location = new System.Drawing.Point(138, 233);
            this.cmbFavcolor.Name = "cmbFavcolor";
            this.cmbFavcolor.Size = new System.Drawing.Size(218, 21);
            this.cmbFavcolor.TabIndex = 23;
            // 
            // txtSaying
            // 
            this.txtSaying.Location = new System.Drawing.Point(138, 281);
            this.txtSaying.Multiline = true;
            this.txtSaying.Name = "txtSaying";
            this.txtSaying.Size = new System.Drawing.Size(218, 25);
            this.txtSaying.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Saying";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fav. Color";
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobbies.Location = new System.Drawing.Point(41, 162);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(67, 18);
            this.lblHobbies.TabIndex = 19;
            this.lblHobbies.Text = "Hobbies";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(41, 120);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 18);
            this.lblGender.TabIndex = 18;
            this.lblGender.Text = "Gender";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(381, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 40);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(138, 390);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 29);
            this.btnBrowse.TabIndex = 36;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtProfilePic
            // 
            this.txtProfilePic.Location = new System.Drawing.Point(238, 396);
            this.txtProfilePic.Name = "txtProfilePic";
            this.txtProfilePic.Size = new System.Drawing.Size(218, 20);
            this.txtProfilePic.TabIndex = 37;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(41, 396);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(52, 18);
            this.lblProfile.TabIndex = 38;
            this.lblProfile.Text = "Profile";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(41, 322);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 18);
            this.lblUsername.TabIndex = 41;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(41, 353);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 18);
            this.lblPassword.TabIndex = 42;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(138, 322);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 20);
            this.txtUsername.TabIndex = 43;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 353);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 20);
            this.txtPassword.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 479);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.txtProfilePic);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.chkOG);
            this.Controls.Add(this.chkVolleyball);
            this.Controls.Add(this.chkBasketball);
            this.Controls.Add(this.cmbFavcolor);
            this.Controls.Add(this.txtSaying);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.RadioButton radFemale;
        public System.Windows.Forms.RadioButton radMale;
        public System.Windows.Forms.CheckBox chkOG;
        public System.Windows.Forms.CheckBox chkVolleyball;
        public System.Windows.Forms.CheckBox chkBasketball;
        public System.Windows.Forms.ComboBox cmbFavcolor;
        public System.Windows.Forms.TextBox txtSaying;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.TextBox txtProfilePic;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
    }
}

