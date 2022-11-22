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
    public partial class ug : System.Web.UI.Page
    {
        
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            ug_internals ug_Internals = new ug_internals();
            protected void Page_Load(object sender, EventArgs e)
            {

            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                string user_input = TextBox1.Text;
                try
                {

                    sqlConnection = new SqlConnection("Data Source=DESKTOP-RTHB91U;Initial Catalog=midsem;Integrated Security=True");
                    sqlCommand = new SqlCommand("select * from UG where reg_no =" + "'" + user_input + "'", sqlConnection);
                    sqlConnection.Open();
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        ug_Internals.reg_no = sqlDataReader.GetString(0);
                        ug_Internals.name = sqlDataReader.GetString(1);
                        ug_Internals.year = sqlDataReader.GetInt32(2);
                        ug_Internals.course = sqlDataReader.GetString(3);
                        ug_Internals.sub_name = sqlDataReader.GetString(4);
                        ug_Internals.test1 = sqlDataReader.GetInt32(5);
                        ug_Internals.test2 = sqlDataReader.GetInt32(6);
                        ug_Internals.test3 = sqlDataReader.GetInt32(7);
                        ug_Internals.assignment = sqlDataReader.GetInt32(8);
                        ug_Internals.attendance = sqlDataReader.GetInt32(9);
                    }
                    Label11.Text = ug_Internals.reg_no;
                    Label12.Text = ug_Internals.name;
                    Label13.Text = ug_Internals.year.ToString();
                    Label14.Text = ug_Internals.course;
                    Label15.Text = ug_Internals.sub_name;
                    Label16.Text = ug_Internals.test1.ToString();
                    Label17.Text = ug_Internals.test2.ToString();
                    Label18.Text = ug_Internals.test3.ToString();
                    Label19.Text = ug_Internals.assignment.ToString();
                    Label21.Text = ug_Internals.attendance.ToString();
                }
                catch (Exception ex)
                {

                }
            }

            protected void Button2_Click(object sender, EventArgs e)
            {
                int value = ug_Internals.calculate(int.Parse(Label16.Text), int.Parse(Label17.Text), int.Parse(Label18.Text), int.Parse(Label19.Text), int.Parse(Label21.Text));
                Label22.Text = value.ToString();
            }
        }
    
}