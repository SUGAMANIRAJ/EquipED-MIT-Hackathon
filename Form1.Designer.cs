namespace Project_Library
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
            this.user = new System.Windows.Forms.TextBox();
            this.passcode = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.loginexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Black;
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.ForeColor = System.Drawing.SystemColors.Window;
            this.user.Location = new System.Drawing.Point(144, 274);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(160, 15);
            this.user.TabIndex = 0;
            // 
            // passcode
            // 
            this.passcode.BackColor = System.Drawing.Color.Black;
            this.passcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passcode.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.passcode.Location = new System.Drawing.Point(147, 390);
            this.passcode.Name = "passcode";
            this.passcode.PasswordChar = '*';
            this.passcode.Size = new System.Drawing.Size(160, 15);
            this.passcode.TabIndex = 1;
            this.passcode.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.BlueViolet;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Login.Location = new System.Drawing.Point(-16, 495);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(461, 44);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // loginexit
            // 
            this.loginexit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginexit.ForeColor = System.Drawing.Color.Red;
            this.loginexit.Location = new System.Drawing.Point(418, -1);
            this.loginexit.Name = "loginexit";
            this.loginexit.Size = new System.Drawing.Size(27, 26);
            this.loginexit.TabIndex = 6;
            this.loginexit.Text = "X";
            this.loginexit.UseVisualStyleBackColor = false;
            this.loginexit.Click += new System.EventHandler(this.loginexit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BlueViolet;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(143, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 1);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(146, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 1);
            this.label2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 606);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginexit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passcode);
            this.Controls.Add(this.user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox passcode;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button loginexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

