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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPhone.Text == "" || txtPass.Text == "" || txtName.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Insert Correctly!");
            }
            else {
                string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "insert into [dbo].[SignUpTable] values (@Name,@Username,@Phone,@Email,@Password)";
                sqlconn.Open();
                SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
                sqlcmd.Parameters.AddWithValue("@Name", txtName.Text);
                sqlcmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                sqlcmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                sqlcmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                sqlcmd.Parameters.AddWithValue("@Password", txtPass.Text);
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
                MessageBox.Show("Registration Completed!!\n Thank You");
                new Login().Show();
                this.Hide();
            }
        }
    }
}
