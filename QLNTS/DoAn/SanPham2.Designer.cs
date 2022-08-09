namespace DoAn
{
    partial class SanPham2
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
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOANVANGDataSet = new DoAn.DOANVANGDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textGSP = new System.Windows.Forms.TextBox();
            this.sANPHAMTableAdapter = new DoAn.DOANVANGDataSetTableAdapters.SANPHAMTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSL = new System.Windows.Forms.TextBox();
            this.textMSP = new System.Windows.Forms.TextBox();
            this.textTS = new System.Windows.Forms.TextBox();
            this.textCL = new System.Windows.Forms.TextBox();
            this.textSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sANPHAMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textLP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dOANVANGDataSet1 = new DoAn.DOANVANGDataSet();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new DoAn.DOANVANGDataSetTableAdapters.NHANVIENTableAdapter();
            this.dOANVANGDataSet2 = new DoAn.DOANVANGDataSet();
            this.sANPHAMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter1 = new DoAn.DOANVANGDataSetTableAdapters.SANPHAMTableAdapter();
            this.mACHATLIEUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATRANGSUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIASANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGCOSANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hINHANHSANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANVANGDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOANVANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANVANGDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource2)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(340, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 598);
            this.panel2.TabIndex = 63;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mACHATLIEUDataGridViewTextBoxColumn,
            this.mATRANGSUCDataGridViewTextBoxColumn,
            this.mASANPHAMDataGridViewTextBoxColumn,
            this.tENSANPHAMDataGridViewTextBoxColumn,
            this.gIASANPHAMDataGridViewTextBoxColumn,
            this.sOLUONGCOSANDataGridViewTextBoxColumn,
            this.hINHANHSANPHAMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sANPHAMBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(956, 477);
            this.dataGridView1.TabIndex = 44;
            // 
            // textGSP
            // 
            this.textGSP.Location = new System.Drawing.Point(114, 300);
            this.textGSP.Name = "textGSP";
            this.textGSP.Size = new System.Drawing.Size(187, 22);
            this.textGSP.TabIndex = 50;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Số Lượng";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Link Picture";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textSL
            // 
            this.textSL.Location = new System.Drawing.Point(114, 374);
            this.textSL.Name = "textSL";
            this.textSL.Size = new System.Drawing.Size(187, 22);
            this.textSL.TabIndex = 45;
            // 
            // textMSP
            // 
            this.textMSP.Location = new System.Drawing.Point(115, 161);
            this.textMSP.Name = "textMSP";
            this.textMSP.Size = new System.Drawing.Size(187, 22);
            this.textMSP.TabIndex = 46;
            this.textMSP.TextChanged += new System.EventHandler(this.textMSP_TextChanged);
            // 
            // textTS
            // 
            this.textTS.Location = new System.Drawing.Point(115, 98);
            this.textTS.Name = "textTS";
            this.textTS.Size = new System.Drawing.Size(187, 22);
            this.textTS.TabIndex = 46;
            this.textTS.TextChanged += new System.EventHandler(this.textTS_TextChanged);
            // 
            // textCL
            // 
            this.textCL.Location = new System.Drawing.Point(114, 37);
            this.textCL.Name = "textCL";
            this.textCL.Size = new System.Drawing.Size(187, 22);
            this.textCL.TabIndex = 46;
            this.textCL.TextChanged += new System.EventHandler(this.textCL_TextChanged);
            // 
            // textSP
            // 
            this.textSP.Location = new System.Drawing.Point(114, 234);
            this.textSP.Name = "textSP";
            this.textSP.Size = new System.Drawing.Size(187, 22);
            this.textSP.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Giá Sản Phẩm";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sANPHAMBindingSource1
            // 
            this.sANPHAMBindingSource1.DataMember = "SANPHAM";
            // 
            // textLP
            // 
            this.textLP.Location = new System.Drawing.Point(114, 452);
            this.textLP.Name = "textLP";
            this.textLP.Size = new System.Drawing.Size(187, 22);
            this.textLP.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Tên Sản Phẩm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mã Sản Phẩm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mã Trang Sức ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btRT
            // 
            this.btRT.Location = new System.Drawing.Point(1369, 490);
            this.btRT.Name = "btRT";
            this.btRT.Size = new System.Drawing.Size(266, 71);
            this.btRT.TabIndex = 62;
            this.btRT.Text = "Return";
            this.btRT.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.textGSP);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textSL);
            this.panel1.Controls.Add(this.textMSP);
            this.panel1.Controls.Add(this.textTS);
            this.panel1.Controls.Add(this.textCL);
            this.panel1.Controls.Add(this.textSP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textLP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(11, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 480);
            this.panel1.TabIndex = 61;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mã Chất Liệu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dOANVANGDataSet1
            // 
            this.dOANVANGDataSet1.DataSetName = "DOANVANGDataSet1";
            this.dOANVANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dOANVANGDataSet1;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // dOANVANGDataSet2
            // 
            this.dOANVANGDataSet2.DataSetName = "DOANVANGDataSet2";
            this.dOANVANGDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMBindingSource2
            // 
            this.sANPHAMBindingSource2.DataMember = "SANPHAM";
            this.sANPHAMBindingSource2.DataSource = this.dOANVANGDataSet2;
            // 
            // sANPHAMTableAdapter1
            // 
            this.sANPHAMTableAdapter1.ClearBeforeFill = true;
            // 
            // mACHATLIEUDataGridViewTextBoxColumn
            // 
            this.mACHATLIEUDataGridViewTextBoxColumn.DataPropertyName = "MACHATLIEU";
            this.mACHATLIEUDataGridViewTextBoxColumn.HeaderText = "MACHATLIEU";
            this.mACHATLIEUDataGridViewTextBoxColumn.Name = "mACHATLIEUDataGridViewTextBoxColumn";
            this.mACHATLIEUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mATRANGSUCDataGridViewTextBoxColumn
            // 
            this.mATRANGSUCDataGridViewTextBoxColumn.DataPropertyName = "MATRANGSUC";
            this.mATRANGSUCDataGridViewTextBoxColumn.HeaderText = "MATRANGSUC";
            this.mATRANGSUCDataGridViewTextBoxColumn.Name = "mATRANGSUCDataGridViewTextBoxColumn";
            this.mATRANGSUCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mASANPHAMDataGridViewTextBoxColumn
            // 
            this.mASANPHAMDataGridViewTextBoxColumn.DataPropertyName = "MASANPHAM";
            this.mASANPHAMDataGridViewTextBoxColumn.HeaderText = "MASANPHAM";
            this.mASANPHAMDataGridViewTextBoxColumn.Name = "mASANPHAMDataGridViewTextBoxColumn";
            this.mASANPHAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENSANPHAMDataGridViewTextBoxColumn
            // 
            this.tENSANPHAMDataGridViewTextBoxColumn.DataPropertyName = "TENSANPHAM";
            this.tENSANPHAMDataGridViewTextBoxColumn.HeaderText = "TENSANPHAM";
            this.tENSANPHAMDataGridViewTextBoxColumn.Name = "tENSANPHAMDataGridViewTextBoxColumn";
            this.tENSANPHAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIASANPHAMDataGridViewTextBoxColumn
            // 
            this.gIASANPHAMDataGridViewTextBoxColumn.DataPropertyName = "GIASANPHAM";
            this.gIASANPHAMDataGridViewTextBoxColumn.HeaderText = "GIASANPHAM";
            this.gIASANPHAMDataGridViewTextBoxColumn.Name = "gIASANPHAMDataGridViewTextBoxColumn";
            this.gIASANPHAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sOLUONGCOSANDataGridViewTextBoxColumn
            // 
            this.sOLUONGCOSANDataGridViewTextBoxColumn.DataPropertyName = "SOLUONGCOSAN";
            this.sOLUONGCOSANDataGridViewTextBoxColumn.HeaderText = "SOLUONGCOSAN";
            this.sOLUONGCOSANDataGridViewTextBoxColumn.Name = "sOLUONGCOSANDataGridViewTextBoxColumn";
            this.sOLUONGCOSANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hINHANHSANPHAMDataGridViewTextBoxColumn
            // 
            this.hINHANHSANPHAMDataGridViewTextBoxColumn.DataPropertyName = "HINHANHSANPHAM";
            this.hINHANHSANPHAMDataGridViewTextBoxColumn.HeaderText = "HINHANHSANPHAM";
            this.hINHANHSANPHAMDataGridViewTextBoxColumn.Name = "hINHANHSANPHAMDataGridViewTextBoxColumn";
            this.hINHANHSANPHAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SanPham2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btRT);
            this.Controls.Add(this.panel1);
            this.Name = "SanPham2";
            this.Text = "SanPham2";
            this.Load += new System.EventHandler(this.SanPham2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANVANGDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOANVANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANVANGDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private DOANVANGDataSet dOANVANGDataSet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textGSP;
        private DOANVANGDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSL;
        private System.Windows.Forms.TextBox textMSP;
        private System.Windows.Forms.TextBox textTS;
        private System.Windows.Forms.TextBox textCL;
        private System.Windows.Forms.TextBox textSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource1;
        private System.Windows.Forms.TextBox textLP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private DOANVANGDataSet dOANVANGDataSet1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DOANVANGDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DOANVANGDataSet dOANVANGDataSet2;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource2;
        private DOANVANGDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACHATLIEUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATRANGSUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIASANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGCOSANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hINHANHSANPHAMDataGridViewTextBoxColumn;

    }
}