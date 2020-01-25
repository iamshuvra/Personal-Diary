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
    public partial class RemoveEvent : Form
    {
        public RemoveEvent()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Delete from [dbo].[CreateEventTable] where Eid='"+this.txtremove.Text+"'";
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
            new MainPage().Show();
            this.Hide();
        }

        private void RemoveEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
