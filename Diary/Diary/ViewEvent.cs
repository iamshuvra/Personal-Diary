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
    public partial class ViewEvent : Form
    {
        public ViewEvent()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[CreateEventTable] where Eid='" + vesearch.Text + "'";
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            //  DataTable dt = new DataTable();
            SqlDataReader dr = sqlcmd.ExecuteReader();
            //    sda.Fill(dr);
            //       sqlcmd.ExecuteNonQuery();
            while (dr.Read())
            {
                velblname.Text = (dr["Ename"].ToString());
                vetb.Text = (dr["Description"].ToString());
               velbldate.Text = (dr["Edate"].ToString());
                velblimportance.Text = (dr["Priyority"].ToString());
            }
            sqlconn.Close();
        }

        private void Modibtn_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            this.Hide();
        }

        private void Velblname_Click(object sender, EventArgs e)
        {

        }
    }
}
