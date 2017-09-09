namespace SQLPanelInfo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cboSel = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dtpMin = new System.Windows.Forms.DateTimePicker();
            this.dtpMax = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPanelInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanelInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSel
            // 
            this.cboSel.FormattingEnabled = true;
            this.cboSel.Items.AddRange(new object[] {
            "Panel ID",
            "Module ID",
            "PCB ID 1",
            "PCB ID 2",
            "Box ID",
            "Panel In Box Time"});
            this.cboSel.Location = new System.Drawing.Point(12, 46);
            this.cboSel.Name = "cboSel";
            this.cboSel.Size = new System.Drawing.Size(121, 20);
            this.cboSel.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(156, 44);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 21);
            this.tbSearch.TabIndex = 1;
            // 
            // dtpMin
            // 
            this.dtpMin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMin.Location = new System.Drawing.Point(283, 44);
            this.dtpMin.Name = "dtpMin";
            this.dtpMin.Size = new System.Drawing.Size(152, 21);
            this.dtpMin.TabIndex = 2;
            this.dtpMin.Value = new System.DateTime(2017, 9, 7, 12, 44, 15, 0);
            // 
            // dtpMax
            // 
            this.dtpMax.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMax.Location = new System.Drawing.Point(464, 45);
            this.dtpMax.Name = "dtpMax";
            this.dtpMax.Size = new System.Drawing.Size(154, 21);
            this.dtpMax.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "—";
            // 
            // btnInquiry
            // 
            this.btnInquiry.Location = new System.Drawing.Point(13, 17);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(75, 23);
            this.btnInquiry.TabIndex = 5;
            this.btnInquiry.Text = "查询";
            this.btnInquiry.UseVisualStyleBackColor = true;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(94, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "筛选";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPanelInfo
            // 
            this.dgvPanelInfo.AllowUserToAddRows = false;
            this.dgvPanelInfo.AllowUserToDeleteRows = false;
            this.dgvPanelInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPanelInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPanelInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanelInfo.Location = new System.Drawing.Point(12, 73);
            this.dgvPanelInfo.Name = "dgvPanelInfo";
            this.dgvPanelInfo.RowTemplate.Height = 23;
            this.dgvPanelInfo.Size = new System.Drawing.Size(733, 375);
            this.dgvPanelInfo.TabIndex = 7;
            this.dgvPanelInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPanelInfo_RowPostPaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 460);
            this.Controls.Add(this.dgvPanelInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMax);
            this.Controls.Add(this.dtpMin);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cboSel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanelInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSel;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DateTimePicker dtpMin;
        private System.Windows.Forms.DateTimePicker dtpMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPanelInfo;
    }
}

