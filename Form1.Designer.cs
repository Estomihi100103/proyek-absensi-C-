namespace Project_Absensi_Kelompok_1
{
    partial class FormArray
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblJenisKelamin = new System.Windows.Forms.Label();
            this.lblProgramStudi = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.cbProgramStudi = new System.Windows.Forms.ComboBox();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.lstKonfirmasi = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Absensi Mahasiswa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIM.Location = new System.Drawing.Point(66, 120);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(52, 23);
            this.lblNIM.TabIndex = 1;
            this.lblNIM.Text = "NIM :";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(66, 167);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(65, 23);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama :";
            // 
            // lblJenisKelamin
            // 
            this.lblJenisKelamin.AutoSize = true;
            this.lblJenisKelamin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisKelamin.Location = new System.Drawing.Point(66, 217);
            this.lblJenisKelamin.Name = "lblJenisKelamin";
            this.lblJenisKelamin.Size = new System.Drawing.Size(121, 23);
            this.lblJenisKelamin.TabIndex = 3;
            this.lblJenisKelamin.Text = "Jenis Kelamin :";
            // 
            // lblProgramStudi
            // 
            this.lblProgramStudi.AutoSize = true;
            this.lblProgramStudi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramStudi.Location = new System.Drawing.Point(66, 266);
            this.lblProgramStudi.Name = "lblProgramStudi";
            this.lblProgramStudi.Size = new System.Drawing.Size(128, 23);
            this.lblProgramStudi.TabIndex = 4;
            this.lblProgramStudi.Text = "Program Studi :";
            // 
            // txtNIM
            // 
            this.txtNIM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIM.Location = new System.Drawing.Point(210, 117);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(314, 30);
            this.txtNIM.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(210, 164);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(314, 30);
            this.txtNama.TabIndex = 6;
            // 
            // cbJenisKelamin
            // 
            this.cbJenisKelamin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJenisKelamin.FormattingEnabled = true;
            this.cbJenisKelamin.Location = new System.Drawing.Point(210, 214);
            this.cbJenisKelamin.Name = "cbJenisKelamin";
            this.cbJenisKelamin.Size = new System.Drawing.Size(314, 31);
            this.cbJenisKelamin.TabIndex = 7;
            // 
            // cbProgramStudi
            // 
            this.cbProgramStudi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProgramStudi.FormattingEnabled = true;
            this.cbProgramStudi.Location = new System.Drawing.Point(210, 263);
            this.cbProgramStudi.Name = "cbProgramStudi";
            this.cbProgramStudi.Size = new System.Drawing.Size(314, 31);
            this.cbProgramStudi.TabIndex = 8;
            // 
            // btnKonfirmasi
            // 
            this.btnKonfirmasi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKonfirmasi.Location = new System.Drawing.Point(552, 299);
            this.btnKonfirmasi.Name = "btnKonfirmasi";
            this.btnKonfirmasi.Size = new System.Drawing.Size(112, 35);
            this.btnKonfirmasi.TabIndex = 9;
            this.btnKonfirmasi.Text = "Konfirmasi";
            this.btnKonfirmasi.UseVisualStyleBackColor = true;
            this.btnKonfirmasi.Click += new System.EventHandler(this.btnKonfirmasi_Click);
            // 
            // lstKonfirmasi
            // 
            this.lstKonfirmasi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKonfirmasi.HideSelection = false;
            this.lstKonfirmasi.Location = new System.Drawing.Point(552, 340);
            this.lstKonfirmasi.Name = "lstKonfirmasi";
            this.lstKonfirmasi.Size = new System.Drawing.Size(353, 181);
            this.lstKonfirmasi.TabIndex = 10;
            this.lstKonfirmasi.UseCompatibleStateImageBehavior = false;
            // 
            // FormArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 550);
            this.Controls.Add(this.lstKonfirmasi);
            this.Controls.Add(this.btnKonfirmasi);
            this.Controls.Add(this.cbProgramStudi);
            this.Controls.Add(this.cbJenisKelamin);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.lblProgramStudi);
            this.Controls.Add(this.lblJenisKelamin);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNIM);
            this.Controls.Add(this.label1);
            this.Name = "FormArray";
            this.Text = "Project Absensi - Kelompok 1 MR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJenisKelamin;
        private System.Windows.Forms.Label lblProgramStudi;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cbJenisKelamin;
        private System.Windows.Forms.ComboBox cbProgramStudi;
        private System.Windows.Forms.Button btnKonfirmasi;
        private System.Windows.Forms.ListView lstKonfirmasi;
    }
}

