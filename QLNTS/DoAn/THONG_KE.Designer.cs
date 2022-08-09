namespace DoAn
{
    partial class THONG_KE
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmHDDV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmCTDH = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbmIN = new System.Windows.Forms.ComboBox();
            this.btnprintDV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 40);
            this.label2.TabIndex = 42;
            this.label2.Text = "THỐNG KÊ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Dịch vụ:";
            // 
            // cbmHDDV
            // 
            this.cbmHDDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmHDDV.FormattingEnabled = true;
            this.cbmHDDV.Location = new System.Drawing.Point(367, 59);
            this.cbmHDDV.Name = "cbmHDDV";
            this.cbmHDDV.Size = new System.Drawing.Size(207, 24);
            this.cbmHDDV.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Hóa đơn:";
            // 
            // cbmCTDH
            // 
            this.cbmCTDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmCTDH.FormattingEnabled = true;
            this.cbmCTDH.Location = new System.Drawing.Point(367, 284);
            this.cbmCTDH.Name = "cbmCTDH";
            this.cbmCTDH.Size = new System.Drawing.Size(207, 24);
            this.cbmCTDH.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 185);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(43, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(777, 185);
            this.dataGridView2.TabIndex = 49;
            // 
            // cbmIN
            // 
            this.cbmIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmIN.FormattingEnabled = true;
            this.cbmIN.Location = new System.Drawing.Point(837, 89);
            this.cbmIN.Name = "cbmIN";
            this.cbmIN.Size = new System.Drawing.Size(146, 24);
            this.cbmIN.TabIndex = 55;
            this.cbmIN.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnprintDV
            // 
            this.btnprintDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintDV.Image = global::DoAn.Properties.Resources.Print;
            this.btnprintDV.Location = new System.Drawing.Point(1000, 89);
            this.btnprintDV.Name = "btnprintDV";
            this.btnprintDV.Size = new System.Drawing.Size(66, 58);
            this.btnprintDV.TabIndex = 44;
            this.btnprintDV.UseVisualStyleBackColor = true;
            this.btnprintDV.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // THONG_KE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 590);
            this.Controls.Add(this.cbmIN);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbmCTDH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnprintDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbmHDDV);
            this.Name = "THONG_KE";
            this.Text = "THONG_KE";
            this.Load += new System.EventHandler(this.THONG_KE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprintDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmHDDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmCTDH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbmIN;
    }
}