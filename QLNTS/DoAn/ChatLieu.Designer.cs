namespace DoAn
{
    partial class ChatLieu
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
            this.textLP1 = new System.Windows.Forms.TextBox();
            this.textCL1 = new System.Windows.Forms.TextBox();
            this.textMCL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCN = new System.Windows.Forms.Button();
            this.btL = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.btT1 = new System.Windows.Forms.Button();
            this.textPic = new System.Windows.Forms.TextBox();
            this.PICTURELINK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCHATLIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACHATLIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cHATLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHATLIEUBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLP1
            // 
            this.textLP1.Enabled = false;
            this.textLP1.Location = new System.Drawing.Point(136, 371);
            this.textLP1.Name = "textLP1";
            this.textLP1.Size = new System.Drawing.Size(185, 22);
            this.textLP1.TabIndex = 21;
            this.textLP1.TextChanged += new System.EventHandler(this.textLP1_TextChanged);
            // 
            // textCL1
            // 
            this.textCL1.Enabled = false;
            this.textCL1.Location = new System.Drawing.Point(136, 292);
            this.textCL1.Name = "textCL1";
            this.textCL1.Size = new System.Drawing.Size(185, 22);
            this.textCL1.TabIndex = 22;
            // 
            // textMCL
            // 
            this.textMCL.Enabled = false;
            this.textMCL.Location = new System.Drawing.Point(136, 216);
            this.textMCL.Name = "textMCL";
            this.textMCL.Size = new System.Drawing.Size(185, 22);
            this.textMCL.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "LinkPicture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên Chất Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Chất Liệu";
            // 
            // btCN
            // 
            this.btCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCN.Location = new System.Drawing.Point(697, 371);
            this.btCN.Name = "btCN";
            this.btCN.Size = new System.Drawing.Size(93, 58);
            this.btCN.TabIndex = 5;
            this.btCN.Text = "Cập Nhật";
            this.btCN.UseVisualStyleBackColor = true;
            this.btCN.Click += new System.EventHandler(this.btCN_Click);
            // 
            // btL
            // 
            this.btL.Enabled = false;
            this.btL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btL.Location = new System.Drawing.Point(574, 371);
            this.btL.Name = "btL";
            this.btL.Size = new System.Drawing.Size(83, 58);
            this.btL.TabIndex = 6;
            this.btL.Text = "Lưu";
            this.btL.UseVisualStyleBackColor = true;
            this.btL.Click += new System.EventHandler(this.btL_Click);
            // 
            // btX
            // 
            this.btX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.Location = new System.Drawing.Point(445, 371);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(80, 58);
            this.btX.TabIndex = 8;
            this.btX.Text = "Xóa";
            this.btX.UseVisualStyleBackColor = true;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // btT1
            // 
            this.btT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btT1.Location = new System.Drawing.Point(327, 371);
            this.btT1.Name = "btT1";
            this.btT1.Size = new System.Drawing.Size(75, 58);
            this.btT1.TabIndex = 9;
            this.btT1.Text = "Thêm";
            this.btT1.UseVisualStyleBackColor = true;
            this.btT1.Click += new System.EventHandler(this.btT1_Click);
            // 
            // textPic
            // 
            this.textPic.Location = new System.Drawing.Point(41, 77);
            this.textPic.Multiline = true;
            this.textPic.Name = "textPic";
            this.textPic.Size = new System.Drawing.Size(259, 123);
            this.textPic.TabIndex = 16;
            // 
            // PICTURELINK
            // 
            this.PICTURELINK.HeaderText = "PICTURELINK";
            this.PICTURELINK.Name = "PICTURELINK";
            // 
            // TENCHATLIEU
            // 
            this.TENCHATLIEU.HeaderText = "TENCHATLIEU";
            this.TENCHATLIEU.Name = "TENCHATLIEU";
            // 
            // MACHATLIEU
            // 
            this.MACHATLIEU.HeaderText = "MACHATLIEU";
            this.MACHATLIEU.Name = "MACHATLIEU";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACHATLIEU,
            this.TENCHATLIEU,
            this.PICTURELINK});
            this.dataGridView1.Location = new System.Drawing.Point(327, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 280);
            this.dataGridView1.TabIndex = 15;
            // 
            // cHATLIEUBindingSource
            // 
            this.cHATLIEUBindingSource.DataMember = "CHATLIEU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 71);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(788, 66);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Sách Chất Liệu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(790, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCN);
            this.Controls.Add(this.textLP1);
            this.Controls.Add(this.btL);
            this.Controls.Add(this.textCL1);
            this.Controls.Add(this.textMCL);
            this.Controls.Add(this.btX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btT1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPic);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ChatLieu";
            this.Text = "ChatLieu";
            this.Load += new System.EventHandler(this.ChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHATLIEUBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLP1;
        private System.Windows.Forms.TextBox textCL1;
        private System.Windows.Forms.TextBox textMCL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCN;
        private System.Windows.Forms.Button btL;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btT1;
        private System.Windows.Forms.TextBox textPic;
        private System.Windows.Forms.BindingSource cHATLIEUBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICTURELINK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENCHATLIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACHATLIEU;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}