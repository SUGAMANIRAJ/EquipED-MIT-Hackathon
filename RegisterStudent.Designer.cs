namespace Project_Library
{
    partial class RegisterStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SName = new System.Windows.Forms.TextBox();
            this.SRegisterNo = new System.Windows.Forms.TextBox();
            this.SSem = new System.Windows.Forms.ComboBox();
            this.SCont = new System.Windows.Forms.TextBox();
            this.SEmail = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SDept = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Register Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email Id";
            // 
            // SName
            // 
            this.SName.Location = new System.Drawing.Point(673, 47);
            this.SName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(256, 22);
            this.SName.TabIndex = 7;
            // 
            // SRegisterNo
            // 
            this.SRegisterNo.Location = new System.Drawing.Point(673, 121);
            this.SRegisterNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SRegisterNo.Name = "SRegisterNo";
            this.SRegisterNo.Size = new System.Drawing.Size(256, 22);
            this.SRegisterNo.TabIndex = 8;
            // 
            // SSem
            // 
            this.SSem.FormattingEnabled = true;
            this.SSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SSem.Location = new System.Drawing.Point(673, 274);
            this.SSem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSem.Name = "SSem";
            this.SSem.Size = new System.Drawing.Size(100, 24);
            this.SSem.TabIndex = 11;
            // 
            // SCont
            // 
            this.SCont.Location = new System.Drawing.Point(673, 347);
            this.SCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SCont.Name = "SCont";
            this.SCont.Size = new System.Drawing.Size(193, 22);
            this.SCont.TabIndex = 12;
            this.SCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SCont_KeyPress);
            // 
            // SEmail
            // 
            this.SEmail.Location = new System.Drawing.Point(673, 417);
            this.SEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SEmail.Name = "SEmail";
            this.SEmail.Size = new System.Drawing.Size(193, 22);
            this.SEmail.TabIndex = 13;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(854, 503);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 36);
            this.RegisterBtn.TabIndex = 14;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(673, 503);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 36);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SDept
            // 
            this.SDept.FormattingEnabled = true;
            this.SDept.Items.AddRange(new object[] {
            "CIVIL",
            "CSE",
            "EEE",
            "ECE",
            "MECH",
            "METT"});
            this.SDept.Location = new System.Drawing.Point(673, 199);
            this.SDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SDept.Name = "SDept";
            this.SDept.Size = new System.Drawing.Size(256, 24);
            this.SDept.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 555);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(425, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 555);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // RegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1038, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SDept);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.SEmail);
            this.Controls.Add(this.SCont);
            this.Controls.Add(this.SSem);
            this.Controls.Add(this.SRegisterNo);
            this.Controls.Add(this.SName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterStudent";
            this.Load += new System.EventHandler(this.RegisterStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SName;
        private System.Windows.Forms.TextBox SRegisterNo;
        private System.Windows.Forms.ComboBox SSem;
        private System.Windows.Forms.TextBox SCont;
        private System.Windows.Forms.TextBox SEmail;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox SDept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}