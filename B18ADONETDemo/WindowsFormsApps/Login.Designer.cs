
namespace WindowsFormsApps
{
    partial class Login
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
            this.linkLoginUser = new System.Windows.Forms.LinkLabel();
            this.btnLoginPage = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkBackToHome = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLoginUser
            // 
            this.linkLoginUser.AutoSize = true;
            this.linkLoginUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLoginUser.Location = new System.Drawing.Point(145, 292);
            this.linkLoginUser.Name = "linkLoginUser";
            this.linkLoginUser.Size = new System.Drawing.Size(230, 20);
            this.linkLoginUser.TabIndex = 17;
            this.linkLoginUser.TabStop = true;
            this.linkLoginUser.Text = "New User? click to Register";
            this.linkLoginUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLoginUser_LinkClicked);
            // 
            // btnLoginPage
            // 
            this.btnLoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginPage.ForeColor = System.Drawing.Color.White;
            this.btnLoginPage.Location = new System.Drawing.Point(232, 212);
            this.btnLoginPage.Name = "btnLoginPage";
            this.btnLoginPage.Size = new System.Drawing.Size(171, 41);
            this.btnLoginPage.TabIndex = 16;
            this.btnLoginPage.Text = "Log In";
            this.btnLoginPage.UseVisualStyleBackColor = false;
            this.btnLoginPage.Click += new System.EventHandler(this.btnLoginPage_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(232, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(232, 106);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 20);
            this.txtUsername.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(107, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Name or Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // linkBackToHome
            // 
            this.linkBackToHome.AutoSize = true;
            this.linkBackToHome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkBackToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBackToHome.Location = new System.Drawing.Point(430, 33);
            this.linkBackToHome.Name = "linkBackToHome";
            this.linkBackToHome.Size = new System.Drawing.Size(139, 20);
            this.linkBackToHome.TabIndex = 18;
            this.linkBackToHome.TabStop = true;
            this.linkBackToHome.Text = "<<Back to home";
            this.linkBackToHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackToHome_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 353);
            this.Controls.Add(this.linkBackToHome);
            this.Controls.Add(this.linkLoginUser);
            this.Controls.Add(this.btnLoginPage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLoginUser;
        private System.Windows.Forms.Button btnLoginPage;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkBackToHome;
    }
}