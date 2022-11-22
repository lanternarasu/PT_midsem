using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication3
{
    public partial class pg : System.Web.UI.Page
    {
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;
        SqlDataReader sqlDataReader = null;
        pg_internals pg_Internals = new pg_internals();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int value = pg_Internals.calculate(int.Parse(Label16.Text), int.Parse(Label17.Text), 0, 0, 0);
            Label22.Text = value.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user_input = TextBox1.Text;
            try
            {

                sqlConnection = new SqlConnection("Data Source=DESKTOP-RTHB91U;Initial Catalog=midsem;Integrated Security=True");
                sqlCommand = new SqlCommand("select * from PG where reg_no =" + "'" + user_input + "'", sqlConnection);
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    pg_Internals.reg_no = sqlDataReader.GetString(0);
                    pg_Internals.name = sqlDataReader.GetString(1);
                    pg_Internals.year = sqlDataReader.GetInt32(2);
                    pg_Internals.course = sqlDataReader.GetString(3);
                    pg_Internals.sub_name = sqlDataReader.GetString(4);
                    pg_Internals.test1 = sqlDataReader.GetInt32(5);
                    pg_Internals.test2 = sqlDataReader.GetInt32(6);
                    pg_Internals.assignment = sqlDataReader.GetInt32(7);

                }
                Label11.Text = pg_Internals.reg_no;
                Label12.Text = pg_Internals.name;
                Label13.Text = pg_Internals.year.ToString();
                Label14.Text = pg_Internals.course;
                Label15.Text = pg_Internals.sub_name;
                Label16.Text = pg_Internals.test1.ToString();
                Label17.Text = pg_Internals.test2.ToString();
                Label19.Text = pg_Internals.assignment.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
    
}