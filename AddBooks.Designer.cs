namespace Project_Library
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            this.BName = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Publication = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.Dobpurchase = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.TextBox();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.GenreName = new System.Windows.Forms.TextBox();
            this.PublicationName = new System.Windows.Forms.TextBox();
            this.Dateofpurchase = new System.Windows.Forms.DateTimePicker();
            this.Addbookbtn = new System.Windows.Forms.Button();
            this.Cancelbookbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bookid = new System.Windows.Forms.TextBox();
            this.BookPrice = new System.Windows.Forms.NumericUpDown();
            this.Bookquantity = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BookPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bookquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // BName
            // 
            this.BName.AutoSize = true;
            this.BName.Location = new System.Drawing.Point(486, 100);
            this.BName.Name = "BName";
            this.BName.Size = new System.Drawing.Size(105, 16);
            this.BName.TabIndex = 1;
            this.BName.Text = "Computer Name";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(483, 143);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(84, 16);
            this.Author.TabIndex = 2;
            this.Author.Text = "Manufacturer";
            // 
            // Publication
            // 
            this.Publication.AutoSize = true;
            this.Publication.Location = new System.Drawing.Point(483, 255);
            this.Publication.Name = "Publication";
            this.Publication.Size = new System.Drawing.Size(85, 16);
            this.Publication.TabIndex = 3;
            this.Publication.Text = "Storage (GB)";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(484, 407);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(55, 16);
            this.Quantity.TabIndex = 4;
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(484, 359);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(38, 16);
            this.Price.TabIndex = 5;
            this.Price.Text = "Price";
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(483, 199);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(69, 16);
            this.Genre.TabIndex = 6;
            this.Genre.Text = "Processor";
            // 
            // Dobpurchase
            // 
            this.Dobpurchase.AutoSize = true;
            this.Dobpurchase.Location = new System.Drawing.Point(484, 308);
            this.Dobpurchase.Name = "Dobpurchase";
            this.Dobpurchase.Size = new System.Drawing.Size(110, 16);
            this.Dobpurchase.TabIndex = 7;
            this.Dobpurchase.Text = "Date of Purchase";
            this.Dobpurchase.Click += new System.EventHandler(this.label2_Click);
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(652, 94);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(215, 22);
            this.BookName.TabIndex = 8;
            // 
            // AuthorName
            // 
            this.AuthorName.Location = new System.Drawing.Point(652, 143);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(215, 22);
            this.AuthorName.TabIndex = 9;
            // 
            // GenreName
            // 
            this.GenreName.Location = new System.Drawing.Point(652, 193);
            this.GenreName.Name = "GenreName";
            this.GenreName.Size = new System.Drawing.Size(215, 22);
            this.GenreName.TabIndex = 10;
            // 
            // PublicationName
            // 
            this.PublicationName.Location = new System.Drawing.Point(652, 249);
            this.PublicationName.Name = "PublicationName";
            this.PublicationName.Size = new System.Drawing.Size(215, 22);
            this.PublicationName.TabIndex = 11;
            this.PublicationName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Dateofpurchase
            // 
            this.Dateofpurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dateofpurchase.Location = new System.Drawing.Point(652, 308);
            this.Dateofpurchase.Name = "Dateofpurchase";
            this.Dateofpurchase.Size = new System.Drawing.Size(215, 22);
            this.Dateofpurchase.TabIndex = 14;
            // 
            // Addbookbtn
            // 
            this.Addbookbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Addbookbtn.Location = new System.Drawing.Point(792, 509);
            this.Addbookbtn.Name = "Addbookbtn";
            this.Addbookbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbookbtn.TabIndex = 15;
            this.Addbookbtn.Text = "Add";
            this.Addbookbtn.UseVisualStyleBackColor = true;
            this.Addbookbtn.Click += new System.EventHandler(this.Addbookbtn_Click);
            // 
            // Cancelbookbtn
            // 
            this.Cancelbookbtn.Location = new System.Drawing.Point(652, 509);
            this.Cancelbookbtn.Name = "Cancelbookbtn";
            this.Cancelbookbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbookbtn.TabIndex = 16;
            this.Cancelbookbtn.Text = "Cancel";
            this.Cancelbookbtn.UseVisualStyleBackColor = true;
            this.Cancelbookbtn.Click += new System.EventHandler(this.Cancelbookbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Computer Id";
            // 
            // Bookid
            // 
            this.Bookid.Location = new System.Drawing.Point(652, 45);
            this.Bookid.Name = "Bookid";
            this.Bookid.Size = new System.Drawing.Size(215, 22);
            this.Bookid.TabIndex = 18;
            // 
            // BookPrice
            // 
            this.BookPrice.Location = new System.Drawing.Point(652, 357);
            this.BookPrice.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(215, 22);
            this.BookPrice.TabIndex = 19;
            // 
            // Bookquantity
            // 
            this.Bookquantity.Location = new System.Drawing.Point(652, 407);
            this.Bookquantity.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.Bookquantity.Name = "Bookquantity";
            this.Bookquantity.Size = new System.Drawing.Size(215, 22);
            this.Bookquantity.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(416, 468);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 574);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Bookquantity);
            this.Controls.Add(this.BookPrice);
            this.Controls.Add(this.Bookid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelbookbtn);
            this.Controls.Add(this.Addbookbtn);
            this.Controls.Add(this.Dateofpurchase);
            this.Controls.Add(this.PublicationName);
            this.Controls.Add(this.GenreName);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Dobpurchase);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Publication);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bookquantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BName;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Publication;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Dobpurchase;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.TextBox GenreName;
        private System.Windows.Forms.TextBox PublicationName;
        private System.Windows.Forms.DateTimePicker Dateofpurchase;
        private System.Windows.Forms.Button Addbookbtn;
        private System.Windows.Forms.Button Cancelbookbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Bookid;
        private System.Windows.Forms.NumericUpDown BookPrice;
        private System.Windows.Forms.NumericUpDown Bookquantity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}