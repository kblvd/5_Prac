using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationProjectForTheService
{
    public partial class WebFormCalc : System.Web.UI.Page
    {
        double Result;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCalcAdd_Click(object sender, EventArgs e)
        {
            Check();
            ServiceReferenceFirst.WebServiceSoapClient client = new ServiceReferenceFirst.WebServiceSoapClient();
            Result = client.Add(Convert.ToDouble(TextBoxArgA.Text), Convert.ToDouble(TextBoxArgB.Text));
            Label4Answer.Text = Result.ToString();
        }
        protected void ButtonCalcSubst_Click(object sender, EventArgs e)
        {
            Check();
            ServiceReferenceFirst.WebServiceSoapClient client = new ServiceReferenceFirst.WebServiceSoapClient();
            Result = client.Subst(Convert.ToDouble(TextBoxArgA.Text), Convert.ToDouble(TextBoxArgB.Text));
            Label4Answer.Text = Result.ToString();
        }

        protected void ButtonCalcDiv_Click(object sender, EventArgs e)
        {
            Check();
            if (TextBoxArgB.Text == "0")
            {
                Response.Redirect("ZeroCheck.aspx");
            }
            ServiceReferenceFirst.WebServiceSoapClient client = new ServiceReferenceFirst.WebServiceSoapClient();
            Result = client.Div(Convert.ToDouble(TextBoxArgA.Text), Convert.ToDouble(TextBoxArgB.Text));
            Label4Answer.Text = Result.ToString();
        }

        protected void ButtonCalcMult_Click(object sender, EventArgs e)
        {
            Check();
            ServiceReferenceFirst.WebServiceSoapClient client = new ServiceReferenceFirst.WebServiceSoapClient();
            Result = client.Mult(Convert.ToDouble(TextBoxArgA.Text), Convert.ToDouble(TextBoxArgB.Text));
            Label4Answer.Text = Result.ToString();
        }

        protected void Check()
        {
            if (String.IsNullOrEmpty(TextBoxArgA.Text) || String.IsNullOrEmpty(TextBoxArgB.Text))
            {
                Response.Redirect("NullOrEmptyOrNaN.aspx");
            }
            else
            {
                double Num;
                bool isNum1 = double.TryParse(TextBoxArgA.Text.Trim(), out Num);
                bool isNum2 = double.TryParse(TextBoxArgB.Text.Trim(), out Num);
                if (!isNum1 || !isNum2)
                {
                    Response.Redirect("NullOrEmptyOrNaN.aspx");
                }
            }

        }
    }

    
}