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
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtename.Text == "" ||cbimportantevent.SelectedIndex == -1)
            {
                MessageBox.Show("Input Correctly");
                

            }
            else
            {
                string dateNow = DateTime.Now.ToString();

                string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "insert into [dbo].[CreateEventTable] values (@Ename,@Edate,@Priyority,@Description,@ModifyDate)";
                sqlconn.Open();
                SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
                sqlcmd.Parameters.AddWithValue("@Ename", txtename.Text);
                //sqlcmd.Parameters.AddWithValue("@name", txtename.Text);
                sqlcmd.Parameters.AddWithValue("@Edate", dtedate.Value.ToShortDateString());
                sqlcmd.Parameters.AddWithValue("@Priyority", cbimportantevent.Items[cbimportantevent.SelectedIndex].ToString());
                sqlcmd.Parameters.AddWithValue("@Description", txtdescription.Text);
                sqlcmd.Parameters.AddWithValue("@ModifyDate", dateNow);

                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
                this.Close();
                new MainPage().Show();
            }
            
        }

        public void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void Txtename_TextChanged(object sender, EventArgs e)
        {

        }
        public string getTxtName()
        {
            return txtename.Text;
        }
        public string getDes()
        {
            return txtdescription.Text;
        }
        public string getDate()
        {
            return dtedate.Value.ToShortDateString();
        }
        public string getPrio()
        {
            return cbimportantevent.SelectedText;
        }


        private void Dtedate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
