﻿
namespace Library_Management_System
{
    partial class Uc_StdReg
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stdId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stdSem = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stdDept = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.stdContact = new System.Windows.Forms.TextBox();
            this.std_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 118);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(352, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Kayıt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(139, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Adı Soyadı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stdName);
            this.groupBox1.Location = new System.Drawing.Point(364, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // stdName
            // 
            this.stdName.BackColor = System.Drawing.Color.White;
            this.stdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stdName.ForeColor = System.Drawing.Color.Black;
            this.stdName.Location = new System.Drawing.Point(6, 26);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(379, 27);
            this.stdName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(139, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci NO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stdId);
            this.groupBox2.Location = new System.Drawing.Point(364, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // stdId
            // 
            this.stdId.BackColor = System.Drawing.Color.White;
            this.stdId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stdId.ForeColor = System.Drawing.Color.Black;
            this.stdId.Location = new System.Drawing.Point(6, 26);
            this.stdId.Name = "stdId";
            this.stdId.Size = new System.Drawing.Size(379, 27);
            this.stdId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(139, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dönem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(139, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bölüm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(139, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "İletişim Numarası";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stdSem);
            this.groupBox3.Location = new System.Drawing.Point(364, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 72);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // stdSem
            // 
            this.stdSem.BackColor = System.Drawing.Color.White;
            this.stdSem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdSem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stdSem.ForeColor = System.Drawing.Color.Black;
            this.stdSem.Location = new System.Drawing.Point(6, 26);
            this.stdSem.Name = "stdSem";
            this.stdSem.Size = new System.Drawing.Size(379, 27);
            this.stdSem.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stdDept);
            this.groupBox4.Location = new System.Drawing.Point(364, 411);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(391, 72);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // stdDept
            // 
            this.stdDept.BackColor = System.Drawing.Color.White;
            this.stdDept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdDept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stdDept.ForeColor = System.Drawing.Color.Black;
            this.stdDept.Location = new System.Drawing.Point(6, 26);
            this.stdDept.Name = "stdDept";
            this.stdDept.Size = new System.Drawing.Size(379, 27);
            this.stdDept.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.stdContact);
            this.groupBox5.Location = new System.Drawing.Point(364, 508);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(391, 72);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // stdContact
            // 
            this.stdContact.BackColor = System.Drawing.Color.White;
            this.stdContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stdContact.ForeColor = System.Drawing.Color.Black;
            this.stdContact.Location = new System.Drawing.Point(6, 26);
            this.stdContact.Name = "stdContact";
            this.stdContact.Size = new System.Drawing.Size(379, 27);
            this.stdContact.TabIndex = 4;
            // 
            // std_save
            // 
            this.std_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.std_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.std_save.ForeColor = System.Drawing.Color.Transparent;
            this.std_save.Location = new System.Drawing.Point(422, 599);
            this.std_save.Name = "std_save";
            this.std_save.Size = new System.Drawing.Size(277, 52);
            this.std_save.TabIndex = 9;
            this.std_save.Text = "Kaydet";
            this.std_save.UseVisualStyleBackColor = false;
            this.std_save.Click += new System.EventHandler(this.std_save_Click);
            // 
            // Uc_StdReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.std_save);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_StdReg";
            this.Size = new System.Drawing.Size(952, 665);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox stdId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox stdSem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox stdDept;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox stdContact;
        private System.Windows.Forms.Button std_save;
    }
}
