namespace GUI_QLBHdemo
{
    partial class SANPHAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SANPHAM));
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaThanh = new System.Windows.Forms.TextBox();
            this.cboNSX = new System.Windows.Forms.ComboBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.bindingNavigatorSP = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bttTHOAT = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bttLUU = new System.Windows.Forms.ToolStripButton();
            this.bttSUA = new System.Windows.Forms.ToolStripButton();
            this.bttXOA = new System.Windows.Forms.ToolStripButton();
            this.bttTIM = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSP)).BeginInit();
            this.bindingNavigatorSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewSP.Location = new System.Drawing.Point(16, 158);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSP.Size = new System.Drawing.Size(603, 167);
            this.dataGridViewSP.TabIndex = 0;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(112, 16);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 26);
            this.txtMaSP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên SP";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(112, 52);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(134, 26);
            this.txtTenSP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhà sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loại SP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giá thành";
            // 
            // txtGiaThanh
            // 
            this.txtGiaThanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThanh.Location = new System.Drawing.Point(374, 88);
            this.txtGiaThanh.Name = "txtGiaThanh";
            this.txtGiaThanh.Size = new System.Drawing.Size(100, 26);
            this.txtGiaThanh.TabIndex = 11;
            // 
            // cboNSX
            // 
            this.cboNSX.Location = new System.Drawing.Point(112, 91);
            this.cboNSX.Name = "cboNSX";
            this.cboNSX.Size = new System.Drawing.Size(157, 21);
            this.cboNSX.TabIndex = 0;
            // 
            // cboNCC
            // 
            this.cboNCC.Location = new System.Drawing.Point(374, 21);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(151, 21);
            this.cboNCC.TabIndex = 13;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.Location = new System.Drawing.Point(374, 55);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(151, 21);
            this.cboLoaiSP.TabIndex = 14;
            // 
            // bindingNavigatorSP
            // 
            this.bindingNavigatorSP.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorSP.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorSP.DeleteItem = null;
            this.bindingNavigatorSP.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorSP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bttLUU,
            this.bttSUA,
            this.bttXOA,
            this.bttTIM});
            this.bindingNavigatorSP.Location = new System.Drawing.Point(137, 130);
            this.bindingNavigatorSP.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorSP.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorSP.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorSP.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorSP.Name = "bindingNavigatorSP";
            this.bindingNavigatorSP.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorSP.Size = new System.Drawing.Size(324, 25);
            this.bindingNavigatorSP.TabIndex = 15;
            this.bindingNavigatorSP.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bttTHOAT
            // 
            this.bttTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTHOAT.ForeColor = System.Drawing.Color.Red;
            this.bttTHOAT.Location = new System.Drawing.Point(531, 55);
            this.bttTHOAT.Name = "bttTHOAT";
            this.bttTHOAT.Size = new System.Drawing.Size(86, 28);
            this.bttTHOAT.TabIndex = 16;
            this.bttTHOAT.Text = "THOÁT";
            this.bttTHOAT.UseVisualStyleBackColor = true;
            this.bttTHOAT.Click += new System.EventHandler(this.bttTHOAT_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bttLUU
            // 
            this.bttLUU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttLUU.Image = global::GUI_QLBHdemo.Properties.Resources.save;
            this.bttLUU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttLUU.Name = "bttLUU";
            this.bttLUU.Size = new System.Drawing.Size(23, 22);
            this.bttLUU.Text = "toolStripButton1";
            this.bttLUU.Click += new System.EventHandler(this.bttLUU_Click);
            // 
            // bttSUA
            // 
            this.bttSUA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttSUA.Image = global::GUI_QLBHdemo.Properties.Resources.edit;
            this.bttSUA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttSUA.Name = "bttSUA";
            this.bttSUA.Size = new System.Drawing.Size(23, 22);
            this.bttSUA.Text = "toolStripButton2";
            // 
            // bttXOA
            // 
            this.bttXOA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttXOA.Image = global::GUI_QLBHdemo.Properties.Resources.delete;
            this.bttXOA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttXOA.Name = "bttXOA";
            this.bttXOA.Size = new System.Drawing.Size(23, 22);
            this.bttXOA.Text = "toolStripButton3";
            // 
            // bttTIM
            // 
            this.bttTIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttTIM.Image = global::GUI_QLBHdemo.Properties.Resources.search;
            this.bttTIM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttTIM.Name = "bttTIM";
            this.bttTIM.Size = new System.Drawing.Size(23, 22);
            this.bttTIM.Text = "toolStripButton1";
            this.bttTIM.Click += new System.EventHandler(this.bttTIM_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSP";
            this.Column2.HeaderText = "Tên SP";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenNSX";
            this.Column3.HeaderText = "Nhà sản xuất";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenNCC";
            this.Column4.HeaderText = "Nhà cung cấp";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenLoaiSP";
            this.Column5.HeaderText = "Loại SP";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaThanh";
            this.Column6.HeaderText = "Giá thành";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaNCC";
            this.Column7.HeaderText = "MaNCC";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaNSX";
            this.Column8.HeaderText = "MaNSX";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaLoaiSP";
            this.Column9.HeaderText = "MaLoaiSP";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // SANPHAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 337);
            this.Controls.Add(this.bttTHOAT);
            this.Controls.Add(this.bindingNavigatorSP);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.cboNSX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaThanh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.dataGridViewSP);
            this.Name = "SANPHAM";
            this.Text = "SANPHAM";
            this.Load += new System.EventHandler(this.SANPHAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSP)).EndInit();
            this.bindingNavigatorSP.ResumeLayout(false);
            this.bindingNavigatorSP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaThanh;
        private System.Windows.Forms.ComboBox cboNSX;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.BindingNavigator bindingNavigatorSP;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bttLUU;
        private System.Windows.Forms.ToolStripButton bttSUA;
        private System.Windows.Forms.ToolStripButton bttXOA;
        private System.Windows.Forms.Button bttTHOAT;
        private System.Windows.Forms.ToolStripButton bttTIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}