namespace SqlProduction
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productionDataSet = new SqlProduction.ProductionDataSet();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableAdapter = new SqlProduction.ProductionDataSetTableAdapters.infoTableAdapter();
            this.hourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chtInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hourDataGridViewTextBoxColumn,
            this.runDataGridViewTextBoxColumn,
            this.downDataGridViewTextBoxColumn,
            this.idleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(402, 562);
            this.dataGridView1.TabIndex = 0;
            // 
            // productionDataSet
            // 
            this.productionDataSet.DataSetName = "ProductionDataSet";
            this.productionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "info";
            this.infoBindingSource.DataSource = this.productionDataSet;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // hourDataGridViewTextBoxColumn
            // 
            this.hourDataGridViewTextBoxColumn.DataPropertyName = "Hour";
            this.hourDataGridViewTextBoxColumn.HeaderText = "Hour";
            this.hourDataGridViewTextBoxColumn.Name = "hourDataGridViewTextBoxColumn";
            // 
            // runDataGridViewTextBoxColumn
            // 
            this.runDataGridViewTextBoxColumn.DataPropertyName = "Run";
            this.runDataGridViewTextBoxColumn.HeaderText = "Run";
            this.runDataGridViewTextBoxColumn.Name = "runDataGridViewTextBoxColumn";
            // 
            // downDataGridViewTextBoxColumn
            // 
            this.downDataGridViewTextBoxColumn.DataPropertyName = "Down";
            this.downDataGridViewTextBoxColumn.HeaderText = "Down";
            this.downDataGridViewTextBoxColumn.Name = "downDataGridViewTextBoxColumn";
            // 
            // idleDataGridViewTextBoxColumn
            // 
            this.idleDataGridViewTextBoxColumn.DataPropertyName = "Idle";
            this.idleDataGridViewTextBoxColumn.HeaderText = "Idle";
            this.idleDataGridViewTextBoxColumn.Name = "idleDataGridViewTextBoxColumn";
            // 
            // chtInfo
            // 
            chartArea1.Name = "ChartArea1";
            this.chtInfo.ChartAreas.Add(chartArea1);
            this.chtInfo.DataSource = this.infoBindingSource;
            legend1.Name = "Legend1";
            legend1.Title = "稼动率";
            this.chtInfo.Legends.Add(legend1);
            this.chtInfo.Location = new System.Drawing.Point(420, 12);
            this.chtInfo.Name = "chtInfo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtInfo.Series.Add(series1);
            this.chtInfo.Size = new System.Drawing.Size(966, 557);
            this.chtInfo.TabIndex = 1;
            this.chtInfo.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 581);
            this.Controls.Add(this.chtInfo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProductionDataSet productionDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private ProductionDataSetTableAdapters.infoTableAdapter infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn downDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtInfo;
    }
}

