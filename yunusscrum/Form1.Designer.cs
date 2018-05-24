namespace yunusscrum
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.liststory = new System.Windows.Forms.ListBox();
            this.listnotstarted = new System.Windows.Forms.ListBox();
            this.listinprogress = new System.Windows.Forms.ListBox();
            this.listdone = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttask = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liststory
            // 
            this.liststory.AllowDrop = true;
            this.liststory.FormattingEnabled = true;
            this.liststory.ItemHeight = 16;
            this.liststory.Location = new System.Drawing.Point(15, 171);
            this.liststory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.liststory.Name = "liststory";
            this.liststory.Size = new System.Drawing.Size(257, 276);
            this.liststory.TabIndex = 0;
            this.liststory.DragDrop += new System.Windows.Forms.DragEventHandler(this.liststory_DragDrop);
            this.liststory.DragOver += new System.Windows.Forms.DragEventHandler(this.liststory_DragOver);
            this.liststory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.liststory_MouseDown);
            // 
            // listnotstarted
            // 
            this.listnotstarted.AllowDrop = true;
            this.listnotstarted.FormattingEnabled = true;
            this.listnotstarted.ItemHeight = 16;
            this.listnotstarted.Location = new System.Drawing.Point(278, 171);
            this.listnotstarted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listnotstarted.Name = "listnotstarted";
            this.listnotstarted.Size = new System.Drawing.Size(268, 276);
            this.listnotstarted.TabIndex = 1;
            this.listnotstarted.DragDrop += new System.Windows.Forms.DragEventHandler(this.listnotstarted_DragDrop);
            this.listnotstarted.DragOver += new System.Windows.Forms.DragEventHandler(this.listnotstarted_DragOver);
            this.listnotstarted.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listnotstarted_MouseDown);
            // 
            // listinprogress
            // 
            this.listinprogress.AllowDrop = true;
            this.listinprogress.FormattingEnabled = true;
            this.listinprogress.ItemHeight = 16;
            this.listinprogress.Location = new System.Drawing.Point(552, 171);
            this.listinprogress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listinprogress.Name = "listinprogress";
            this.listinprogress.Size = new System.Drawing.Size(274, 276);
            this.listinprogress.TabIndex = 2;
            this.listinprogress.DragDrop += new System.Windows.Forms.DragEventHandler(this.listinprogress_DragDrop);
            this.listinprogress.DragOver += new System.Windows.Forms.DragEventHandler(this.listinprogress_DragOver);
            this.listinprogress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listinprogress_MouseDown);
            // 
            // listdone
            // 
            this.listdone.AllowDrop = true;
            this.listdone.FormattingEnabled = true;
            this.listdone.ItemHeight = 16;
            this.listdone.Location = new System.Drawing.Point(842, 171);
            this.listdone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listdone.Name = "listdone";
            this.listdone.Size = new System.Drawing.Size(300, 276);
            this.listdone.TabIndex = 3;
            this.listdone.DragDrop += new System.Windows.Forms.DragEventHandler(this.listdone_DragDrop);
            this.listdone.DragOver += new System.Windows.Forms.DragEventHandler(this.listdone_DragOver);
            this.listdone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listdone_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "TASK";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(255, 95);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(153, 22);
            this.txtDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "NOT STARTED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "IN PROGRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(940, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "DONE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "STORY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "NAME AND STORY";
            // 
            // txtstory
            // 
            this.txtstory.AllowDrop = true;
            this.txtstory.Location = new System.Drawing.Point(255, 31);
            this.txtstory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstory.Name = "txtstory";
            this.txtstory.Size = new System.Drawing.Size(351, 22);
            this.txtstory.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "DATE";
            // 
            // txttask
            // 
            this.txttask.AllowDrop = true;
            this.txttask.Location = new System.Drawing.Point(255, 63);
            this.txttask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttask.Name = "txttask";
            this.txttask.Size = new System.Drawing.Size(351, 22);
            this.txttask.TabIndex = 18;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(774, 62);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 525);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txttask);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstory);
            this.Controls.Add(this.listdone);
            this.Controls.Add(this.listinprogress);
            this.Controls.Add(this.listnotstarted);
            this.Controls.Add(this.liststory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liststory;
        private System.Windows.Forms.ListBox listnotstarted;
        private System.Windows.Forms.ListBox listinprogress;
        private System.Windows.Forms.ListBox listdone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtstory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttask;
        private System.Windows.Forms.Button btnadd;
    }
}

