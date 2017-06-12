using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produzione : System.Web.UI.Page
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


            if (text_Cerca.Text.Length != 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter(Query(text_Cerca.Text), conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                GridView.DataSource = ds;
                GridView.DataBind();
            }
            else if (text_Cerca.Text.Length != 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter(Query(text_Cerca.Text), conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                GridView.DataSource = ds;
                GridView.DataBind();

            }
            else
            {

                strSQL = "SELECT * FROM [dbo].[Produzione] ";
                SqlDataAdapter sda = new SqlDataAdapter(strSQL, conn);
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
        return  "SELECT * FROM [dbo].[Produzione] where Id like '%"+ c +"%'or UvaUtilizzata like '%"+ c +"%'or UvaLavorata like '%"+ c +"%'or TipologiaVino like '%"+ c +"%'or DataProduzione like '%"+ c +"%'or LitriProdotti like '%"+ c +"%'or BottiglieProdotte like '%"+ c +"%'or IdAzienda like '%"+ c+"%'" ;
    }
 

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

}