using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace andyCalcApp
{
    public partial class andyCalc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumber1.Text);
            int num2 = int.Parse(txtNumber2.Text);
            var oprtr = ddlOperator.SelectedValue;
            
            int res = 0;

            if (oprtr == "+")
            {
                res = add(num1,num2);
            }
            else if (oprtr == "-")
            {
                res = sub(num1,num2);
            }
            else if (oprtr == "*")
            {
                res = mult(num1,num2);
            }
            else
            {
                res = num1 / num2;
            }

            txtResult.Text = res.ToString();

        }
        public int add(int n1, int n2)
        {
            int r = n1 + n2;
            return r;
        }
        public int sub(int n1, int n2)
        {
            int r = n1 - n2;
            return r;
        }
        public int mult(int n1, int n2)
        {
            int r = n1 * n2;
            return r;
        }



    }

    
}