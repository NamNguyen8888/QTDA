namespace QuanLyChungCu
{
    partial class timkiemkhachhang
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rdten = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdma = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvkh = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonButton2);
            this.panel1.Controls.Add(this.kryptonButton1);
            this.panel1.Controls.Add(this.rdten);
            this.panel1.Controls.Add(this.rdma);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 450);
            this.panel1.TabIndex = 0;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(22, 295);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(247, 44);
            this.kryptonButton2.TabIndex = 36;
            this.kryptonButton2.Values.Text = "Quay lại nhập thông tin";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(22, 236);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(247, 44);
            this.kryptonButton1.TabIndex = 35;
            this.kryptonButton1.Values.Text = "Tìm kiếm";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // rdten
            // 
            this.rdten.Location = new System.Drawing.Point(12, 160);
            this.rdten.Name = "rdten";
            this.rdten.Size = new System.Drawing.Size(230, 24);
            this.rdten.TabIndex = 3;
            this.rdten.Values.Text = "Tìm kiếm theo tên khách hàng";
            // 
            // rdma
            // 
            this.rdma.Checked = true;
            this.rdma.Location = new System.Drawing.Point(12, 121);
            this.rdma.Name = "rdma";
            this.rdma.Size = new System.Drawing.Size(230, 24);
            this.rdma.TabIndex = 2;
            this.rdma.Values.Text = "Tìm kiếm theo mã khách hàng";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(12, 66);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(247, 30);
            this.txtsearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvkh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(294, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 450);
            this.panel2.TabIndex = 1;
            // 
            // dgvkh
            // 
            this.dgvkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.sdt,
            this.cmnd});
            this.dgvkh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkh.Location = new System.Drawing.Point(0, 0);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.RowHeadersVisible = false;
            this.dgvkh.RowTemplate.Height = 24;
            this.dgvkh.Size = new System.Drawing.Size(506, 450);
            this.dgvkh.TabIndex = 1;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.Name = "makh";
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.Name = "tenkh";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SDT";
            this.sdt.Name = "sdt";
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            // 
            // timkiemkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "timkiemkhachhang";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "timkiemkhachhang";
            this.Load += new System.EventHandler(this.timkiemkhachhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdten;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdma;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
    }
}