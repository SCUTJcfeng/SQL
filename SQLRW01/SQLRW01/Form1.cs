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
using System.IO;

namespace SQLRW01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenSQL openSQL = new OpenSQL();
            openSQL.SQLConn("production");

            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter;

            sqlDataAdapter = new SqlDataAdapter("select * from dbo.info", openSQL.sqlConnection);

            sqlDataAdapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenSQL openSQL = new OpenSQL();
            openSQL.SQLConn("production");

            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter;

            if (cboProd.Text == "" || tbMin.Text == "" || tbMax.Text == "")
                sqlDataAdapter = new SqlDataAdapter("select * from dbo.info", openSQL.sqlConnection);
            else
                sqlDataAdapter = new SqlDataAdapter("select * from dbo.info where " + cboProd.Text + " between " + tbMin.Text + " and " + tbMax.Text, openSQL.sqlConnection);

            sqlDataAdapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }

    public class OpenSQL
    {
        public SqlConnection sqlConnection;
        public SqlCommand SqlCommand;

        public void SQLConn(string initialCatalog)
        {
            string connectionString = "server = jc;initial catalog =" + initialCatalog + "; user id = sa;password = ss123";

            sqlConnection = new SqlConnection(connectionString);

            bool canConn = false;
            try
            {
                sqlConnection.Open();
                canConn = true;
            }
            catch
            {

            }
            if (canConn)
            {
                //MessageBox.Show("Connection OK~");
            }
            else MessageBox.Show("NO Connection~");
        }

        public void SQLComm(string cmdText)
        {
            SqlCommand = new SqlCommand(cmdText, sqlConnection);
            //SqlCommand.Connection.Open();
            SqlDataReader dataReader = SqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                //Form1 form1 = new Form1();
                //form1.label1.Text = dataReader["Run"].ToString();
            }
        }
    }
}
