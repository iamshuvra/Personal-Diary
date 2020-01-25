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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[SignUpTable] where Username= @Username and Password=@Password";
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
            sqlcmd.Parameters.AddWithValue("@Username",txtloginuname.Text);
            sqlcmd.Parameters.AddWithValue("@Password", txtloginpass.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                MainPage mp = new MainPage();
                mp.Show();

                this.Hide();
            }
            else
                MessageBox.Show("Invalid username or password");
            txtloginpass.Text = "";
            txtloginuname.Text = "";
            sqlconn.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}
