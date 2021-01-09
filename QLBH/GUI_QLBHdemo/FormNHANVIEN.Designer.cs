namespace GUI_QLBHdemo
{
    partial class FormNHANVIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNHANVIEN));
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDIENTHOAI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtbNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.bttTHOAT = new System.Windows.Forms.Button();
            this.bindingNavigatorNV = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bttLUU = new System.Windows.Forms.ToolStripButton();
            this.bttSUA = new System.Windows.Forms.ToolStripButton();
            this.bttXOA = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorNV)).BeginInit();
            this.bindingNavigatorNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewNV.Location = new System.Drawing.Point(15, 161);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.ReadOnly = true;
            this.dataGridViewNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNV.Size = new System.Drawing.Size(444, 241);
            this.dataGridViewNV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoDienThoai";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(95, 16);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 20);
            this.txtMANV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã NV:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(273, 23);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(42, 13);
            this.Label.TabIndex = 4;
            this.Label.Text = "Họ tên:";
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Location = new System.Drawing.Point(356, 20);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(100, 20);
            this.txtHOTEN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sô điện thoại:";
            // 
            // txtDIENTHOAI
            // 
            this.txtDIENTHOAI.Location = new System.Drawing.Point(356, 70);
            this.txtDIENTHOAI.Name = "txtDIENTHOAI";
            this.txtDIENTHOAI.Size = new System.Drawing.Size(100, 20);
            this.txtDIENTHOAI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh:";
            // 
            // dtbNGAYSINH
            // 
            this.dtbNGAYSINH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNGAYSINH.Location = new System.Drawing.Point(95, 71);
            this.dtbNGAYSINH.Name = "dtbNGAYSINH";
            this.dtbNGAYSINH.Size = new System.Drawing.Size(100, 20);
            this.dtbNGAYSINH.TabIndex = 9;
            // 
            // bttTHOAT
            // 
            this.bttTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTHOAT.ForeColor = System.Drawing.Color.Red;
            this.bttTHOAT.Location = new System.Drawing.Point(373, 427);
            this.bttTHOAT.Name = "bttTHOAT";
            this.bttTHOAT.Size = new System.Drawing.Size(86, 28);
            this.bttTHOAT.TabIndex = 10;
            this.bttTHOAT.Text = "THOÁT";
            this.bttTHOAT.UseVisualStyleBackColor = true;
            this.bttTHOAT.Click += new System.EventHandler(this.bttTHOAT_Click);
            // 
            // bindingNavigatorNV
            // 
            this.bindingNavigatorNV.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorNV.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorNV.DeleteItem = null;
            this.bindingNavigatorNV.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorNV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bttXOA});
            this.bindingNavigatorNV.Location = new System.Drawing.Point(75, 133);
            this.bindingNavigatorNV.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorNV.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorNV.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorNV.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorNV.Name = "bindingNavigatorNV";
            this.bindingNavigatorNV.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorNV.Size = new System.Drawing.Size(301, 25);
            this.bindingNavigatorNV.TabIndex = 11;
            this.bindingNavigatorNV.Text = "bindingNavigator1";
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
            this.bttSUA.Click += new System.EventHandler(this.bttSUA_Click);
            // 
            // bttXOA
            // 
            this.bttXOA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttXOA.Image = global::GUI_QLBHdemo.Properties.Resources.delete;
            this.bttXOA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttXOA.Name = "bttXOA";
            this.bttXOA.Size = new System.Drawing.Size(23, 22);
            this.bttXOA.Text = "toolStripButton3";
            this.bttXOA.Click += new System.EventHandler(this.bttXOA_Click);
            // 
            // FormNHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 467);
            this.Controls.Add(this.bindingNavigatorNV);
            this.Controls.Add(this.bttTHOAT);
            this.Controls.Add(this.dtbNGAYSINH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDIENTHOAI);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.txtHOTEN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.dataGridViewNV);
            this.Name = "FormNHANVIEN";
            this.Text = "FormNHANVIEN";
            this.Load += new System.EventHandler(this.FormNHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorNV)).EndInit();
            this.bindingNavigatorNV.ResumeLayout(false);
            this.bindingNavigatorNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDIENTHOAI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtbNGAYSINH;
        private System.Windows.Forms.Button bttTHOAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.BindingNavigator bindingNavigatorNV;
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
    }
}