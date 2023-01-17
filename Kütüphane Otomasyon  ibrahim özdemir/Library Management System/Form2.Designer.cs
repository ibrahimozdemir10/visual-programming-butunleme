
namespace Library_Management_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_checkStatus = new System.Windows.Forms.Button();
            this.btn_returnBook = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_issueBook = new System.Windows.Forms.Button();
            this.btn_stdReg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uc_StdReg1 = new Library_Management_System.Uc_StdReg();
            this.uc_issueBook1 = new Library_Management_System.Uc_issueBook();
            this.uc_StatusCheck1 = new Library_Management_System.Uc_StatusCheck();
            this.uc_returnBook1 = new Library_Management_System.Uc_returnBook();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 118);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(275, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_checkStatus);
            this.panel2.Controls.Add(this.btn_returnBook);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_issueBook);
            this.panel2.Controls.Add(this.btn_stdReg);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 674);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_checkStatus
            // 
            this.btn_checkStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_checkStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_checkStatus.ForeColor = System.Drawing.Color.Transparent;
            this.btn_checkStatus.Location = new System.Drawing.Point(6, 370);
            this.btn_checkStatus.Name = "btn_checkStatus";
            this.btn_checkStatus.Size = new System.Drawing.Size(186, 45);
            this.btn_checkStatus.TabIndex = 5;
            this.btn_checkStatus.Text = "Öğrenci Kontrol";
            this.btn_checkStatus.UseVisualStyleBackColor = false;
            this.btn_checkStatus.Click += new System.EventHandler(this.btn_checkStatus_Click);
            // 
            // btn_returnBook
            // 
            this.btn_returnBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_returnBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_returnBook.ForeColor = System.Drawing.Color.Transparent;
            this.btn_returnBook.Location = new System.Drawing.Point(6, 450);
            this.btn_returnBook.Name = "btn_returnBook";
            this.btn_returnBook.Size = new System.Drawing.Size(186, 45);
            this.btn_returnBook.TabIndex = 4;
            this.btn_returnBook.Text = "Kitap İade";
            this.btn_returnBook.UseVisualStyleBackColor = false;
            this.btn_returnBook.Click += new System.EventHandler(this.btn_returnBook_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(6, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_issueBook
            // 
            this.btn_issueBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_issueBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_issueBook.ForeColor = System.Drawing.Color.Transparent;
            this.btn_issueBook.Location = new System.Drawing.Point(6, 293);
            this.btn_issueBook.Name = "btn_issueBook";
            this.btn_issueBook.Size = new System.Drawing.Size(186, 45);
            this.btn_issueBook.TabIndex = 2;
            this.btn_issueBook.Text = "Kitap Ödünç Al";
            this.btn_issueBook.UseVisualStyleBackColor = false;
            this.btn_issueBook.Click += new System.EventHandler(this.btn_issueBook_Click);
            // 
            // btn_stdReg
            // 
            this.btn_stdReg.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_stdReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stdReg.ForeColor = System.Drawing.Color.Transparent;
            this.btn_stdReg.Location = new System.Drawing.Point(6, 222);
            this.btn_stdReg.Name = "btn_stdReg";
            this.btn_stdReg.Size = new System.Drawing.Size(186, 45);
            this.btn_stdReg.TabIndex = 1;
            this.btn_stdReg.Text = "Öğrenci Kayıt";
            this.btn_stdReg.UseVisualStyleBackColor = false;
            this.btn_stdReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uc_StdReg1
            // 
            this.uc_StdReg1.BackColor = System.Drawing.Color.Gray;
            this.uc_StdReg1.Location = new System.Drawing.Point(198, 0);
            this.uc_StdReg1.Name = "uc_StdReg1";
            this.uc_StdReg1.Size = new System.Drawing.Size(1067, 674);
            this.uc_StdReg1.TabIndex = 2;
            // 
            // uc_issueBook1
            // 
            this.uc_issueBook1.BackColor = System.Drawing.Color.Gray;
            this.uc_issueBook1.Location = new System.Drawing.Point(198, 0);
            this.uc_issueBook1.Name = "uc_issueBook1";
            this.uc_issueBook1.Size = new System.Drawing.Size(1067, 674);
            this.uc_issueBook1.TabIndex = 3;
            // 
            // uc_StatusCheck1
            // 
            this.uc_StatusCheck1.BackColor = System.Drawing.Color.Gray;
            this.uc_StatusCheck1.Location = new System.Drawing.Point(196, 1);
            this.uc_StatusCheck1.Name = "uc_StatusCheck1";
            this.uc_StatusCheck1.Size = new System.Drawing.Size(1067, 674);
            this.uc_StatusCheck1.TabIndex = 7;
            // 
            // uc_returnBook1
            // 
            this.uc_returnBook1.BackColor = System.Drawing.Color.Gray;
            this.uc_returnBook1.Location = new System.Drawing.Point(196, 2);
            this.uc_returnBook1.Name = "uc_returnBook1";
            this.uc_returnBook1.Size = new System.Drawing.Size(1067, 674);
            this.uc_returnBook1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(6, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hakkımızda";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1267, 674);
            this.Controls.Add(this.uc_returnBook1);
            this.Controls.Add(this.uc_StatusCheck1);
            this.Controls.Add(this.uc_issueBook1);
            this.Controls.Add(this.uc_StdReg1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_checkStatus;
        private System.Windows.Forms.Button btn_returnBook;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_issueBook;
        private System.Windows.Forms.Button btn_stdReg;
        private Uc_StdReg uc_StdReg1;
        private Uc_issueBook uc_issueBook1;
        private Uc_StatusCheck uc_StatusCheck1;
        private Uc_returnBook uc_returnBook1;
        private System.Windows.Forms.Button button1;
    }
}