namespace DoAn
{
    partial class TrangSuc
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btCN1 = new System.Windows.Forms.Button();
            this.btL1 = new System.Windows.Forms.Button();
            this.btX1 = new System.Windows.Forms.Button();
            this.btT1 = new System.Windows.Forms.Button();
            this.textLP1 = new System.Windows.Forms.TextBox();
            this.textTS1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPIC = new System.Windows.Forms.TextBox();
            this.textMTS = new System.Windows.Forms.TextBox();
            this.tRANGSUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MATRANGSUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAITRANGSUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINKPICTURE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGSUCBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATRANGSUC,
            this.LOAITRANGSUC,
            this.LINKPICTURE});
            this.dataGridView1.Location = new System.Drawing.Point(267, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(335, 281);
            this.dataGridView1.TabIndex = 58;
            // 
            // btCN1
            // 
            this.btCN1.Location = new System.Drawing.Point(456, 22);
            this.btCN1.Name = "btCN1";
            this.btCN1.Size = new System.Drawing.Size(91, 63);
            this.btCN1.TabIndex = 53;
            this.btCN1.Text = "Cập Nhật";
            this.btCN1.UseVisualStyleBackColor = true;
            this.btCN1.Click += new System.EventHandler(this.btCN1_Click_1);
            // 
            // btL1
            // 
            this.btL1.Location = new System.Drawing.Point(315, 22);
            this.btL1.Name = "btL1";
            this.btL1.Size = new System.Drawing.Size(91, 63);
            this.btL1.TabIndex = 54;
            this.btL1.Text = "Lưu";
            this.btL1.UseVisualStyleBackColor = true;
            this.btL1.Click += new System.EventHandler(this.btL1_Click_1);
            // 
            // btX1
            // 
            this.btX1.Location = new System.Drawing.Point(182, 22);
            this.btX1.Name = "btX1";
            this.btX1.Size = new System.Drawing.Size(91, 63);
            this.btX1.TabIndex = 56;
            this.btX1.Text = "Xóa";
            this.btX1.UseVisualStyleBackColor = true;
            this.btX1.Click += new System.EventHandler(this.btX1_Click_1);
            // 
            // btT1
            // 
            this.btT1.Location = new System.Drawing.Point(40, 22);
            this.btT1.Name = "btT1";
            this.btT1.Size = new System.Drawing.Size(91, 63);
            this.btT1.TabIndex = 57;
            this.btT1.Text = "Thêm";
            this.btT1.UseVisualStyleBackColor = true;
            this.btT1.Click += new System.EventHandler(this.btT1_Click_1);
            // 
            // textLP1
            // 
            this.textLP1.Enabled = false;
            this.textLP1.Location = new System.Drawing.Point(119, 332);
            this.textLP1.Name = "textLP1";
            this.textLP1.Size = new System.Drawing.Size(142, 24);
            this.textLP1.TabIndex = 51;
            // 
            // textTS1
            // 
            this.textTS1.Enabled = false;
            this.textTS1.Location = new System.Drawing.Point(119, 280);
            this.textTS1.Name = "textTS1";
            this.textTS1.Size = new System.Drawing.Size(142, 24);
            this.textTS1.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "LinkPicture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tên Trang Sức";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã Trang Sức";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textPIC
            // 
            this.textPIC.Location = new System.Drawing.Point(25, 87);
            this.textPIC.Multiline = true;
            this.textPIC.Name = "textPIC";
            this.textPIC.Size = new System.Drawing.Size(216, 114);
            this.textPIC.TabIndex = 52;
            // 
            // textMTS
            // 
            this.textMTS.Enabled = false;
            this.textMTS.Location = new System.Drawing.Point(119, 225);
            this.textMTS.Name = "textMTS";
            this.textMTS.Size = new System.Drawing.Size(142, 24);
            this.textMTS.TabIndex = 49;
            // 
            // tRANGSUCBindingSource
            // 
            this.tRANGSUCBindingSource.DataMember = "TRANGSUC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btT1);
            this.panel1.Controls.Add(this.btX1);
            this.panel1.Controls.Add(this.btL1);
            this.panel1.Controls.Add(this.btCN1);
            this.panel1.Location = new System.Drawing.Point(-1, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 97);
            this.panel1.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 70);
            this.panel2.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(603, 72);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Sách Trang Sức";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MATRANGSUC
            // 
            this.MATRANGSUC.HeaderText = "MATRANGSUC";
            this.MATRANGSUC.Name = "MATRANGSUC";
            this.MATRANGSUC.Width = 80;
            // 
            // LOAITRANGSUC
            // 
            this.LOAITRANGSUC.HeaderText = "LOAITRANGSUC";
            this.LOAITRANGSUC.Name = "LOAITRANGSUC";
            this.LOAITRANGSUC.Width = 110;
            // 
            // LINKPICTURE
            // 
            this.LINKPICTURE.HeaderText = "LINKPICTURE";
            this.LINKPICTURE.Name = "LINKPICTURE";
            this.LINKPICTURE.Width = 80;
            // 
            // TrangSuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 458);
            this.Controls.Add(this.textPIC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textLP1);
            this.Controls.Add(this.textTS1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMTS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TrangSuc";
            this.Text = "TrangSuc";
            this.Load += new System.EventHandler(this.TrangSuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGSUCBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btCN1;
        private System.Windows.Forms.Button btL1;
        private System.Windows.Forms.Button btX1;
        private System.Windows.Forms.Button btT1;
        private System.Windows.Forms.TextBox textLP1;
        private System.Windows.Forms.TextBox textTS1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tRANGSUCBindingSource;
        private System.Windows.Forms.TextBox textPIC;
        private System.Windows.Forms.TextBox textMTS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATRANGSUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAITRANGSUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINKPICTURE;
    }
}