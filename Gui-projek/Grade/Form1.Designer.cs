namespace Grade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtgrade = new TextBox();
            txtrerata = new TextBox();
            label7 = new Label();
            txttotal = new TextBox();
            label6 = new Label();
            txtipa = new TextBox();
            txtbindo = new TextBox();
            txtmtk = new TextBox();
            txtname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Btn_hitung = new Button();
            btn_keluar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 22);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 0;
            label1.Text = "Student Grade";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtgrade);
            groupBox1.Controls.Add(txtrerata);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txttotal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtipa);
            groupBox1.Controls.Add(txtbindo);
            groupBox1.Controls.Add(txtmtk);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(150, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 349);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "STUDENT GRADE";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 313);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 14;
            label8.Text = "Grade";
            // 
            // txtgrade
            // 
            txtgrade.Location = new Point(126, 305);
            txtgrade.Name = "txtgrade";
            txtgrade.Size = new Size(183, 23);
            txtgrade.TabIndex = 13;
            // 
            // txtrerata
            // 
            txtrerata.Location = new Point(126, 266);
            txtrerata.Name = "txtrerata";
            txtrerata.Size = new Size(183, 23);
            txtrerata.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 274);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 10;
            label7.Text = "Rerata";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(126, 229);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(183, 23);
            txttotal.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 237);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 8;
            label6.Text = "Total";
            // 
            // txtipa
            // 
            txtipa.Location = new Point(126, 184);
            txtipa.Name = "txtipa";
            txtipa.Size = new Size(183, 23);
            txtipa.TabIndex = 7;
            // 
            // txtbindo
            // 
            txtbindo.Location = new Point(126, 142);
            txtbindo.Name = "txtbindo";
            txtbindo.Size = new Size(183, 23);
            txtbindo.TabIndex = 6;
            // 
            // txtmtk
            // 
            txtmtk.Location = new Point(126, 95);
            txtmtk.Name = "txtmtk";
            txtmtk.Size = new Size(183, 23);
            txtmtk.TabIndex = 5;
            // 
            // txtname
            // 
            txtname.Location = new Point(126, 52);
            txtname.Name = "txtname";
            txtname.Size = new Size(183, 23);
            txtname.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 187);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 3;
            label5.Text = "IPA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 145);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 2;
            label4.Text = "Bahasa Indonesia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 103);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 1;
            label3.Text = "Matematika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 60);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 0;
            label2.Text = "Nama Mahasiswa";
            // 
            // Btn_hitung
            // 
            Btn_hitung.Location = new Point(276, 490);
            Btn_hitung.Name = "Btn_hitung";
            Btn_hitung.Size = new Size(75, 23);
            Btn_hitung.TabIndex = 2;
            Btn_hitung.Text = "Hitung";
            Btn_hitung.UseVisualStyleBackColor = true;
            Btn_hitung.Click += Btn_hitung_Click;
            // 
            // btn_keluar
            // 
            btn_keluar.Location = new Point(368, 490);
            btn_keluar.Name = "btn_keluar";
            btn_keluar.Size = new Size(75, 23);
            btn_keluar.TabIndex = 3;
            btn_keluar.Text = "Keluar";
            btn_keluar.UseVisualStyleBackColor = true;
            btn_keluar.Click += btn_keluar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 580);
            Controls.Add(btn_keluar);
            Controls.Add(Btn_hitung);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hitung Grade";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtrerata;
        private Label label7;
        private TextBox txttotal;
        private Label label6;
        private TextBox txtipa;
        private TextBox txtbindo;
        private TextBox txtmtk;
        private TextBox txtname;
        private Label label5;
        private Label label4;
        private Label label8;
        private TextBox txtgrade;
        private Button Btn_hitung;
        private Button btn_keluar;
    }
}