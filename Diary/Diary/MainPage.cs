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
using System.Configuration;
namespace Diary
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select Eid from [dbo].[CreateEventTable]";
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            sqlcmd.ExecuteNonQuery();
            //   txteid.Text = sqlcmd.ExecuteScalar();
            sqlconn.Close();
            CreateEvent ce = new CreateEvent();
            ce.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            new ModifyEvent().Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new RemoveEvent().Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[CreateEventTable]";
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            datagridview.DataSource = ds.Tables[0];
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewEvent().Show();
        }

        private void Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /* private void DiaryDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
         {

         }*/
    }
}
