namespace SQLRW01
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
            this.lbSelect = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.cboProd = new System.Windows.Forms.ComboBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.lbMax = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Location = new System.Drawing.Point(12, 40);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(41, 12);
            this.lbSelect.TabIndex = 0;
            this.lbSelect.Text = "select";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(152, 40);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(47, 12);
            this.lbMin.TabIndex = 1;
            this.lbMin.Text = "between";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(554, 329);
            this.dataGridView1.TabIndex = 4;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(209, 36);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 21);
            this.tbMin.TabIndex = 5;
            // 
            // cboProd
            // 
            this.cboProd.FormattingEnabled = true;
            this.cboProd.Items.AddRange(new object[] {
            "Hour",
            "Run",
            "Down",
            "Idle"});
            this.cboProd.Location = new System.Drawing.Point(52, 37);
            this.cboProd.Name = "cboProd";
            this.cboProd.Size = new System.Drawing.Size(94, 20);
            this.cboProd.TabIndex = 6;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(350, 37);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 21);
            this.tbMax.TabIndex = 7;
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(315, 40);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(23, 12);
            this.lbMax.TabIndex = 8;
            this.lbMax.Text = "and";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(477, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "筛选";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 416);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.cboProd);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSelect;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.ComboBox cboProd;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Button btnSearch;
    }
}

