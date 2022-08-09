namespace DoAn
{
    partial class SanPham1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btTS = new System.Windows.Forms.Button();
            this.btCL = new System.Windows.Forms.Button();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOANVANGDataSet = new DoAn.DOANVANGDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MACHATLIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATRANGSUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIASANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGCOSAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANHSANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btL = new System.Windows.Forms.Button();
            this.btS = new System.Windows.Forms.Button();
            this.btD = new System.Windows.Forms.Button();
            this.btT = new System.Windows.Forms.Button();
            this.sANPHAMTableAdapter = new DoAn.DOANVANGDataSetTableAdapters.SANPHAMTableAdapter();
            this.textGSP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textSL = new System.Windows.Forms.TextBox();
            this.textMSP = new System.Windows.Forms.TextBox();
            this.textTS = new System.Windows.Forms.TextBox();
            this.textCL = new System.Windows.Forms.TextBox();
            this.textSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textLP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCN = new System.Windows.Forms.Button();
            this.sANPHAMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANVANGDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btTS
            // 
            this.btTS.Location = new System.Drawing.Point(745, 534);
            this.btTS.Name = "btTS";
            this.btTS.Size = new System.Drawing.Size(194, 60);
            this.btTS.TabIndex = 52;
            this.btTS.Text = "Loại Trang Sức";
            this.btTS.UseVisualStyleBackColor = true;
            this.btTS.Click += new System.EventHandler(this.btTS_Click);
            // 
            // btCL
            // 
            this.btCL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCL.Location = new System.Drawing.Point(745, 600);
            this.btCL.Name = "btCL";
            this.btCL.Size = new System.Drawing.Size(194, 56);
            this.btCL.TabIndex = 53;
            this.btCL.Text = "Loại Chât Liệu";
            this.btCL.UseVisualStyleBackColor = true;
            this.btCL.Click += new System.EventHandler(this.btCL_Click);
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.dOANVANGDataSet;
            // 
            // dOANVANGDataSet
            // 
            this.dOANVANGDataSet.DataSetName = "DOANVANGDataSet";
            this.dOANVANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btL);
            this.panel2.Controls.Add(this.btS);
            this.panel2.Controls.Add(this.btD);
            this.panel2.Controls.Add(this.btT);
            this.panel2.Controls.Add(this.btTS);
            this.panel2.Controls.Add(this.btCL);
            this.panel2.Location = new System.Drawing.Point(258, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 673);
            this.panel2.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(746, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 85);
            this.label1.TabIndex = 56;
            this.label1.Text = "Dif Option";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACHATLIEU,
            this.MATRANGSUC,
            this.MASANPHAM,
            this.TENSANPHAM,
            this.GIASANPHAM,
            this.SOLUONGCOSAN,
            this.HINHANHSANPHAM});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 670);
            this.dataGridView1.TabIndex = 44;
            // 
            // MACHATLIEU
            // 
            this.MACHATLIEU.HeaderText = "MACHATLIEU";
            this.MACHATLIEU.Name = "MACHATLIEU";
            this.MACHATLIEU.ReadOnly = true;
            this.MACHATLIEU.Width = 50;
            // 
            // MATRANGSUC
            // 
            this.MATRANGSUC.HeaderText = "MATRANGSUC";
            this.MATRANGSUC.Name = "MATRANGSUC";
            this.MATRANGSUC.ReadOnly = true;
            this.MATRANGSUC.Width = 50;
            // 
            // MASANPHAM
            // 
            this.MASANPHAM.HeaderText = "MASANPHAM";
            this.MASANPHAM.Name = "MASANPHAM";
            this.MASANPHAM.ReadOnly = true;
            this.MASANPHAM.Width = 50;
            // 
            // TENSANPHAM
            // 
            this.TENSANPHAM.HeaderText = "TENSANPHAM";
            this.TENSANPHAM.Name = "TENSANPHAM";
            this.TENSANPHAM.ReadOnly = true;
            // 
            // GIASANPHAM
            // 
            this.GIASANPHAM.HeaderText = "GIASANPHAM";
            this.GIASANPHAM.Name = "GIASANPHAM";
            this.GIASANPHAM.ReadOnly = true;
            // 
            // SOLUONGCOSAN
            // 
            this.SOLUONGCOSAN.HeaderText = "SOLUONGCOSAN";
            this.SOLUONGCOSAN.Name = "SOLUONGCOSAN";
            this.SOLUONGCOSAN.ReadOnly = true;
            // 
            // HINHANHSANPHAM
            // 
            this.HINHANHSANPHAM.HeaderText = "HINHANHSANPHAM";
            this.HINHANHSANPHAM.Name = "HINHANHSANPHAM";
            this.HINHANHSANPHAM.ReadOnly = true;
            // 
            // btL
            // 
            this.btL.Image = global::DoAn.Properties.Resources.Save;
            this.btL.Location = new System.Drawing.Point(745, 216);
            this.btL.Name = "btL";
            this.btL.Size = new System.Drawing.Size(194, 71);
            this.btL.TabIndex = 48;
            this.btL.Text = "Lưu";
            this.btL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btL.UseVisualStyleBackColor = true;
            this.btL.Click += new System.EventHandler(this.btL_Click_1);
            // 
            // btS
            // 
            this.btS.Image = global::DoAn.Properties.Resources.Info1;
            this.btS.Location = new System.Drawing.Point(745, 323);
            this.btS.Name = "btS";
            this.btS.Size = new System.Drawing.Size(194, 71);
            this.btS.TabIndex = 41;
            this.btS.Text = "Sửa";
            this.btS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btS.UseVisualStyleBackColor = true;
            this.btS.Click += new System.EventHandler(this.btS_Click_1);
            // 
            // btD
            // 
            this.btD.Image = global::DoAn.Properties.Resources.Delete;
            this.btD.Location = new System.Drawing.Point(745, 108);
            this.btD.Name = "btD";
            this.btD.Size = new System.Drawing.Size(194, 71);
            this.btD.TabIndex = 42;
            this.btD.Text = "Xóa";
            this.btD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btD.UseVisualStyleBackColor = true;
            this.btD.Click += new System.EventHandler(this.btD_Click_1);
            // 
            // btT
            // 
            this.btT.BackgroundImage = global::DoAn.Properties.Resources.Add;
            this.btT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btT.Location = new System.Drawing.Point(745, 3);
            this.btT.Name = "btT";
            this.btT.Size = new System.Drawing.Size(194, 71);
            this.btT.TabIndex = 43;
            this.btT.Text = "Thêm";
            this.btT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btT.UseVisualStyleBackColor = true;
            this.btT.Click += new System.EventHandler(this.btT_Click_1);
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // textGSP
            // 
            this.textGSP.Enabled = false;
            this.textGSP.Location = new System.Drawing.Point(27, 338);
            this.textGSP.Name = "textGSP";
            this.textGSP.Size = new System.Drawing.Size(187, 22);
            this.textGSP.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(80, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 69;
            this.label9.Text = "Số Lượng";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textSL
            // 
            this.textSL.Enabled = false;
            this.textSL.Location = new System.Drawing.Point(27, 414);
            this.textSL.Name = "textSL";
            this.textSL.Size = new System.Drawing.Size(187, 22);
            this.textSL.TabIndex = 62;
            // 
            // textMSP
            // 
            this.textMSP.Enabled = false;
            this.textMSP.Location = new System.Drawing.Point(27, 200);
            this.textMSP.Name = "textMSP";
            this.textMSP.Size = new System.Drawing.Size(187, 22);
            this.textMSP.TabIndex = 63;
            // 
            // textTS
            // 
            this.textTS.Enabled = false;
            this.textTS.Location = new System.Drawing.Point(27, 124);
            this.textTS.Name = "textTS";
            this.textTS.Size = new System.Drawing.Size(187, 22);
            this.textTS.TabIndex = 64;
            this.textTS.TextChanged += new System.EventHandler(this.textTS_TextChanged);
            // 
            // textCL
            // 
            this.textCL.Enabled = false;
            this.textCL.Location = new System.Drawing.Point(27, 52);
            this.textCL.Name = "textCL";
            this.textCL.Size = new System.Drawing.Size(187, 22);
            this.textCL.TabIndex = 65;
            // 
            // textSP
            // 
            this.textSP.Enabled = false;
            this.textSP.Location = new System.Drawing.Point(27, 266);
            this.textSP.Name = "textSP";
            this.textSP.Size = new System.Drawing.Size(187, 22);
            this.textSP.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(80, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Giá Sản Phẩm";
            // 
            // textLP
            // 
            this.textLP.Enabled = false;
            this.textLP.Location = new System.Drawing.Point(27, 462);
            this.textLP.Multiline = true;
            this.textLP.Name = "textLP";
            this.textLP.Size = new System.Drawing.Size(187, 110);
            this.textLP.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(80, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Tên Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(80, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Mã Sản Phẩm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(80, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Mã Trang Sức ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(80, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Mã Chất Liệu";
            // 
            // btCN
            // 
            this.btCN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCN.Image = global::DoAn.Properties.Resources.Load;
            this.btCN.Location = new System.Drawing.Point(27, 591);
            this.btCN.Name = "btCN";
            this.btCN.Size = new System.Drawing.Size(194, 71);
            this.btCN.TabIndex = 50;
            this.btCN.Text = "Cập Nhật";
            this.btCN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCN.UseVisualStyleBackColor = true;
            this.btCN.Click += new System.EventHandler(this.btCN_Click_1);
            // 
            // sANPHAMBindingSource1
            // 
            this.sANPHAMBindingSource1.DataMember = "SANPHAM";
            // 
            // SanPham1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1204, 674);
            this.Controls.Add(this.textGSP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textSL);
            this.Controls.Add(this.textMSP);
            this.Controls.Add(this.textTS);
            this.Controls.Add(this.textCL);
            this.Controls.Add(this.textSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCN);
            this.Controls.Add(this.textLP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "SanPham1";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANVANGDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCN;
        private System.Windows.Forms.Button btTS;
        private System.Windows.Forms.Button btCL;
        private System.Windows.Forms.Button btS;
        private System.Windows.Forms.Button btD;
        private System.Windows.Forms.Button btT;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private DOANVANGDataSet dOANVANGDataSet;
        private System.Windows.Forms.Button btL;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DOANVANGDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private System.Windows.Forms.TextBox textGSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSL;
        private System.Windows.Forms.TextBox textMSP;
        private System.Windows.Forms.TextBox textTS;
        private System.Windows.Forms.TextBox textCL;
        private System.Windows.Forms.TextBox textSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textLP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACHATLIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATRANGSUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIASANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGCOSAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANHSANPHAM;
        private System.Windows.Forms.Label label1;
    }
}