using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CustomerMiddleTier;

namespace CustomerEntrycreen
{
    public partial class CustmorScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                            
                Customer cs = new Customer();
                DdlCountry.DataSource = cs.LoadCountries();
                DdlCountry.DataTextField = "CountryName";
                DdlCountry.DataValueField = "ID";
                DdlCountry.DataBind();
                ListItem li = new ListItem("Choose", "0");
                DdlCountry.Items.Add(li);
                DdlCountry.SelectedValue = "0";
                

                DataSet DT = cs.LoadCustomer();
                GridViewCustomerDetails.DataSource = DT.Tables[0];
                GridViewCustomerDetails.DataBind();
                                

                DisplayHobbies();
                Panel1.DataBind();
            
        }

        private void DisplayHobbies()
        {
            Hobbies hb = new Hobbies();
            DataSet DS=hb.LoadHobbies();
            foreach (DataRow Dr in DS.Tables[0].Rows)
            {
                CheckBox ObjCheckbox = new CheckBox();
                ObjCheckbox.ID = Dr["HobbyID"].ToString();
                ObjCheckbox.Text = Dr["HobbyName"].ToString();
                Panel1.Controls.Add(ObjCheckbox);
            }
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            try{
                    Customer newcustomer = new Customer();
                newcustomer.CustomerName = TxtCustName.Text;
                newcustomer.CountryCode = Convert.ToInt16(DdlCountry.SelectedItem.Value);
                    if (RadioMale.Checked)
                    {
                        newcustomer.Gender = "Male";
                    }
                    else
                    {
                        newcustomer.Gender = "Female";
                    }
                    if (RadioMarried.Checked)
                    {
                        newcustomer.Ismarried = true;
                    }
                    else
                    {
                        newcustomer.Ismarried = false;
                    }
                    newcustomer.saveCustomer();
                    foreach (object obj in Panel1.Controls)
                    {
                        if (obj is CheckBox)
                        {
                            CheckBox oCheckbox = (CheckBox)obj;
                            // if checkboxes are checked
                            if (oCheckbox.Checked)
                            {
                                Hobbies objHob = new Hobbies();
                                objHob.InsertHobby(newcustomer.CustomerId, Convert.ToInt16(oCheckbox.ID));
                                // insert
                            }
                        }
                    }
            }         
                //else
                //    Response.Write("There was a problem in adding data... please try after some time");
            
               
                catch (Exception ex)
                {
                    Response.Write("This customer already available");
                }
           
            Cleardata();
            
        
        }
        
        private void Cleardata()
        {
            TxtCustName.Text = "";
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
            RadioMarried.Checked = false;
            RadioUnmarried.Checked = false;
        }
        protected void GridViewCustomerDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cleardata();
            string custname = GridViewCustomerDetails.SelectedRow.Cells[1].Text;
                         
            DataSet ds = new DataSet();
            Customer cus = new Customer();
            ds = cus.LoadCustomer(custname);
            TxtCustName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            string index= ds.Tables[0].Rows[0]["CountryID"].ToString();
            DdlCountry.SelectedIndex =Convert.ToInt16(index);
            string gen = ds.Tables[0].Rows[0]["Gender"].ToString();
            if (gen == "Male")
            {
                RadioMale.Checked = true;

            }
            else
                RadioFemale.Checked = true;
         /*   if (ds.Tables[0].Rows[0]["hobbies"].ToString() == "Reading")
                CheckBoxRead.Checked=true;
                
            else if (ds.Tables[0].Rows[0]["hobbies"].ToString() == "Writing")
            {
                CheckBoxRead.Checked = false;
                CheckBoxWrite.Checked = false;
                
            }
            else
            {
                CheckBoxRead.Checked = false;
                CheckBoxWrite.Checked = false; ;
                CheckBoxPaint.Checked = true;
            }*/
            bool ss = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
            if (ss)
                RadioMarried.Checked = true;
            else
                RadioUnmarried.Checked = true;
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
             cs.CustomerName=TxtCustName.Text;
             cs.CountryCode = Convert.ToInt16(DdlCountry.SelectedItem.Value);
             if(RadioMale.Checked)
             {
                 cs.Gender="Male";
             }
             else
                 cs.Gender="Female";
             
             if(RadioMarried.Checked)
             {
                 cs.Ismarried = true;
             }
             else
             { cs.Ismarried=false;}
             string hobby;
             /*if(CheckBoxPaint.Checked)
            
                 hobby="Painting";
             else if(CheckBoxRead.Checked)
                 hobby="Reading";
             else
                 hobby="Writing";
             cs.Hobbies=hobby;*/
           
             bool Result= cs.Updatecustomer();
             if (Result)
             {
                 Response.Write("Customer record Updated Succesfully");
             }
             else
                 Response.Write("Unbale to update");
             Cleardata();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            Customer CsObj = new Customer();
            CsObj.CustomerName = TxtCustName.Text;
            bool Result = CsObj.DeleteCustomer();
            if (Result)
            {
                Response.Write("Record Deleted Succesfully");

            }
            else
            {
                Response.Write("UNable to delete record");
            }
        }

        protected void DdlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}