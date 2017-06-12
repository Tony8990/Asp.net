using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Azienda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connString = @"Data Source=TONY-HP;Initial Catalog=ConsorzioVinicolo;Integrated Security=True";

        using (SqlConnection conn = new SqlConnection())
        {
            SqlCommand objCmd = new SqlCommand();
            string strConnString = string.Empty;
            string strSQL = string.Empty;


            conn.ConnectionString = connString;
            conn.Open();

            if (text_Cerca.Text == string.Empty)
            {
                strSQL = "SELECT * FROM [dbo].[Azienda] ";
                SqlDataAdapter sda = new SqlDataAdapter(strSQL, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                GridView.DataSource = ds;
                GridView.DataBind();
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter(Query(text_Cerca.Text), conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                GridView.DataSource = ds;
                GridView.DataBind();

            }
            conn.Close();
        }
    }
    public string Query(string c)
    {
        return "SELECT * FROM [dbo].[Azienda] where Id like '%" + c + "%'or Nome like '%" + c + "%'or Indirizzo like '%" + c + "%'or LatitudineLongitudine like '%" + c + "%'or Titolare like '%" + c + "%'or Telefono like '%" + c + "%'or Email like '%" + c + "%'or IdComune like '%" + c + "%'";


    }
}