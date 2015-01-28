using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomerDATA;
using System.Data;

namespace CustomerEntrycreen
{
    public partial class CustmorScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerDataAccess Cust = new CustomerDataAccess();

            GridViewCustomerDetails.DataSource = Cust.GetCustomerDetails();
            GridViewCustomerDetails.DataBind();
            

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {

        }

        protected void GridViewCustomerDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}