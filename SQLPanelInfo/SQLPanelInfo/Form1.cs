using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLPanelInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSel.Text = "Panel ID";
            dtpMin.Text = DateTime.Now.AddDays(-2).ToString();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            string connectionString = "server =jc;initial catalog = production;user id = sa;password = ss123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from dbo.panelInfo where [Panel In Box Time] between '" +dtpMin.Text + "' and '" + dtpMax.Text + "'", sqlConnection);
            sqlDataAdapter.Fill(dataSet);
            dgvPanelInfo.DataSource = dataSet.Tables[0];
            dgvPanelInfo.Columns["Panel In Box Time"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            sqlConnection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "server =jc;initial catalog = production;user id = sa;password = ss123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM DBO.panelInfo WHERE [" + cboSel.Text + "] like '%" + tbSearch.Text + "%'" + " and [Panel In Box Time] between '" + dtpMin.Text +"' and '" +dtpMax.Text + "'", sqlConnection);
            sqlDataAdapter.Fill(dataSet);
            dgvPanelInfo.DataSource = dataSet.Tables[0];
            dgvPanelInfo.Columns["Panel In Box Time"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            sqlConnection.Close();
        }

        //固定列添加序号
        private void dgvPanelInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvPanelInfo.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
