using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Prac5
{
    /// <summary>
    /// Сводное описание для WebService4Data
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService4Data : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod]
        public DataSet GetCustomers()
        {
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            SqlConnection connect = new SqlConnection(str);
            SqlDataAdapter myDataAdapter = new SqlDataAdapter("SELECT * FROM Customers", connect);
            DataSet dataSet = new DataSet();
            myDataAdapter.Fill(dataSet, "Customers");
            return dataSet;
        }
    }
}
