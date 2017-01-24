namespace MIS677_Team4_LoginScreen_V1
{
    partial class Main
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
            this.pwordTB = new System.Windows.Forms.TextBox();
            this.unameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.accessButton = new System.Windows.Forms.Button();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // pwordTB
            // 
            this.pwordTB.Location = new System.Drawing.Point(230, 12);
            this.pwordTB.Name = "pwordTB";
            this.pwordTB.Size = new System.Drawing.Size(100, 20);
            this.pwordTB.TabIndex = 0;
            // 
            // unameTB
            // 
            this.unameTB.Location = new System.Drawing.Point(83, 12);
            this.unameTB.Name = "unameTB";
            this.unameTB.Size = new System.Drawing.Size(100, 20);
            this.unameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pass:";
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.Location = new System.Drawing.Point(227, 35);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(33, 13);
            this.loginLink.TabIndex = 4;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Login";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // accessButton
            // 
            this.accessButton.Location = new System.Drawing.Point(90, 83);
            this.accessButton.Name = "accessButton";
            this.accessButton.Size = new System.Drawing.Size(149, 32);
            this.accessButton.TabIndex = 5;
            this.accessButton.Text = "Press Me For Access";
            this.accessButton.UseVisualStyleBackColor = true;
            this.accessButton.Click += new System.EventHandler(this.accessButton_Click);
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.Enabled = false;
            this.logoutLink.Location = new System.Drawing.Point(290, 35);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(40, 13);
            this.logoutLink.TabIndex = 6;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLink_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 148);
            this.Controls.Add(this.logoutLink);
            this.Controls.Add(this.accessButton);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unameTB);
            this.Controls.Add(this.pwordTB);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwordTB;
        private System.Windows.Forms.TextBox unameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.Button accessButton;
        private System.Windows.Forms.LinkLabel logoutLink;
    }
}

