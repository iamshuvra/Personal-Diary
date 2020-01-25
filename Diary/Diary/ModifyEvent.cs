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
    public partial class ModifyEvent : Form
    {
        CreateEvent ce= new CreateEvent();
        public ModifyEvent()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Search();
           // Update();
           // Delete();
           // Insert();


            //this.Close();
           // new MainPage().Show();

        }
        public void Search()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[CreateEventTable] where Eid='" + txtmodi.Text + "'";
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            //  DataTable dt = new DataTable();
            SqlDataReader dr = sqlcmd.ExecuteReader();
            //    sda.Fill(dr);
            //       sqlcmd.ExecuteNonQuery();
            while (dr.Read())
            {
                txtmodiname.Text = (dr["Ename"].ToString());
                txtmodidescription.Text = (dr["Description"].ToString());
                dtmodidate.Text = (dr["Edate"].ToString());
                cbmodiimportantevent.Text = (dr["Priyority"].ToString());
            }
            sqlconn.Close();
        }
        public void Update()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            SqlCommand sqlcmd = new SqlCommand("Update CreateEventTable SET Ename='" + txtmodiname.Text + "',Edate='" + dtmodidate.Value.ToShortDateString() + "' ,Priyority='" + cbmodiimportantevent.Text + "' ,Description='"+txtmodidescription.Text+"',ModifyDate='"+ DateTime.Now.ToString()+"' where Eid=" + txtmodi.Text + "", sqlconn); 
            sqlconn.Open();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.ExecuteNonQuery();
            /*
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
            sqlcmd.Parameters.AddWithValue("@Ename", txtmodiname.Text);
            //sqlcmd.Parameters.AddWithValue("@name", txtename.Text);
            sqlcmd.Parameters.AddWithValue("@Edate", dtmodidate.Value.ToShortDateString());
            sqlcmd.Parameters.AddWithValue("@Priyority", cbmodiimportantevent.Text);
            sqlcmd.Parameters.AddWithValue("@Description", txtmodidescription.Text);
       //     sqlconn.Open();
       */
          //  SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
       //     sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
        }

        private void Modibtn_Click(object sender, EventArgs e)
        {
            if (txtmodiname.Text == "" || cbmodiimportantevent.SelectedIndex == -1)
            {
                MessageBox.Show("Insert Correctly");
            }
            else
            {
                string dateNow = DateTime.Now.ToString();
                // MessageBox.Show(dateNow);
                Update();
                this.Hide();
                new MainPage().Show();
            }
        }

        private void Txtmodi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        /*
public void Delete()
{
string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
SqlConnection sqlconn = new SqlConnection(mainconn);
string sqlquery = "Delete from [dbo].[CreateEventTable] where Eid='" + this.txtmodi.Text + "'";
sqlconn.Open();
SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
sqlcmd.ExecuteNonQuery();
sqlconn.Close();

}
public void Insert()
{
string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
SqlConnection sqlconn = new SqlConnection(mainconn);
string sqlquery = "insert into [dbo].[CreateEventTable] values (@Ename,@Edate,@Priyority,@Description)";
sqlconn.Open();
SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
sqlcmd.Parameters.AddWithValue("@Ename", txtmodiname.Text);
//sqlcmd.Parameters.AddWithValue("@name", txtename.Text);
sqlcmd.Parameters.AddWithValue("@Edate", dtmodidate.Value.ToShortDateString());
sqlcmd.Parameters.AddWithValue("@Priyority", cbmodiimportantevent.Text);
sqlcmd.Parameters.AddWithValue("@Description", txtmodidescription.Text);
sqlcmd.ExecuteNonQuery();
sqlconn.Close();
}
*/
    }
}
