using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac5
{
    public partial class WebUserControl : System.Web.UI.UserControl
    {

        public double Result
        {
            get;
            set;
        }

        public string MyText
        {
            get { return TextBoxVarA.Text; }
            set { TextBoxVarA.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCalcAdd_Click(object sender, EventArgs e)
        {
            Check();
            Result = Convert.ToDouble(TextBoxVarA.Text) + Convert.ToDouble(TextBoxVarB.Text);
            LabelAnswer.Text = Result.ToString();            
        }

        protected void ButtonCalcSubst_Click(object sender, EventArgs e)
        {
            Check();
            Result = Convert.ToDouble(TextBoxVarA.Text) - Convert.ToDouble(TextBoxVarB.Text);
            LabelAnswer.Text = Result.ToString();
        }

        protected void ButtonCalcDiv_Click(object sender, EventArgs e)
        {
            Check();
            if (TextBoxVarB.Text == "0")
            {
                Response.Redirect("ZeroCheck.aspx");
            }
            Result = Convert.ToDouble(TextBoxVarA.Text) / Convert.ToDouble(TextBoxVarB.Text);
            LabelAnswer.Text = Result.ToString();
        }

        protected void ButtonCalcMult_Click(object sender, EventArgs e)
        {
            Check();
            Result = Convert.ToDouble(TextBoxVarA.Text) * Convert.ToDouble(TextBoxVarB.Text);
            LabelAnswer.Text = Result.ToString();
        }

        protected void Check()
        {
            if (String.IsNullOrEmpty(TextBoxVarA.Text) || String.IsNullOrEmpty(TextBoxVarB.Text))
            {
                Response.Redirect("NullOrEmptyOrNaN.aspx");
            }
            else
            {
                double Num;
                bool isNum1 = double.TryParse(TextBoxVarA.Text.Trim(), out Num);
                bool isNum2 = double.TryParse(TextBoxVarB.Text.Trim(), out Num);
                if (!isNum1||isNum2)
                {
                    Response.Redirect("NullOrEmptyOrNaN.aspx");
                }
            }

        }
    }
}