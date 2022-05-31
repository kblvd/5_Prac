using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Prac5
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod]
        public double Add(double a, double b)
        {
            return a + b; 
        }

        [WebMethod]
        public double Subst(double a, double b)
        {
            return a - b;
        }

        [WebMethod]
        public double Div(double a, double b)
        {
            return a / b;
        }

        [WebMethod]
        public double Mult(double a, double b)
        {
            return a * b;
        }
    }
}
