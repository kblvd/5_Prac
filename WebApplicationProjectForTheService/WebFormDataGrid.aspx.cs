using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplicationProjectForTheService
{
    public partial class WebFormDataGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet Source;
            Source = (DataSet)Cache["MyCache"];            
        }

        
    protected void Button1_Click(object sender, EventArgs e)
            {
                DataSet Source;
                Source = (DataSet)Cache["MyCache"];
                if (Source == null)
                {                       
                    ServiceReferenceSecond.WebService4DataSoapClient client = new ServiceReferenceSecond.WebService4DataSoapClient();
                    Source = client.GetCustomers();
                    GridView1.DataSource = Source;
                    Cache["MyCache"] = Source;
                    GridView1.DataBind();
                    Label1.Text = "Данные загруженны из таблицы";
                }
                else
                {
                    GridView1.DataSource = Source;
                    GridView1.DataBind();
                    Label1.Text = "Данные загруженны из Кэша";
                }
            }

        }
}