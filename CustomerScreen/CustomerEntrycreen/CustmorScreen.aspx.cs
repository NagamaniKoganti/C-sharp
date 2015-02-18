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
                //ListItem li = new ListItem("Choose", "0");
                //DdlCountry.Items.Add(li);
                //DdlCountry.SelectedValue = "0";

                LoadCustomers();
                DisplayHobbies();
                //Panel1.DataBind();
            
        }
        private void LoadCustomers()
        {
               Customer ObjCust = new Customer();
               GridView1.DataSource = ObjCust.LoadCustomer().Tables[0];
               GridView1.DataBind();
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
                
                catch (Exception ex)
                {
                    Response.Write("This customer already available");
                }
           
            Cleardata();
            LoadCustomers();
            
        
        }
        
        private void Cleardata()
        {
            TxtCustName.Text = "";
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
            RadioMarried.Checked = false;
            RadioUnmarried.Checked = false;
            foreach (object obj in Panel1.Controls)
            {
                if (obj.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)obj).Checked = false;
                }
            }
        }

        public void LoadHobbies(int CustomerID)
        {
            Hobbies Objhobby = new Hobbies();
            DataSet ds = Objhobby.LoadHobbies();
            foreach (DataRow  objrow in ds.Tables[0].Rows)
            {
                foreach (object Controlobj in Panel1.Controls)
                {
                    if (Controlobj.GetType() == typeof(CheckBox))
                    {
                        if (((CheckBox)Controlobj).ID == objrow["HobbyID"].ToString())   
                        {
                            ((CheckBox)Controlobj).Checked = true;
                        }
                    }

                }


            }
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
             
             bool Result= cs.Updatecustomer();
             if (Result)
             {
                 Response.Write("Customer record Updated Succesfully");
                 updatehobbies(Convert.ToInt32(TextBox1.Text));
             }
             else
                 Response.Write("Unbale to update");
             
             Cleardata();
        }
        private void updatehobbies(int customerID)
        {
            foreach (object obj in Panel1.Controls)
            {
                if (obj.GetType() == typeof(CheckBox))
                {
                    
                        int hobbyID = Convert.ToInt32(((CheckBox)obj).ID);
                        Hobbies hobby = new Hobbies();
                        hobby.UpdateHobbies(customerID, hobbyID,((CheckBox)obj).Checked);
                    
                }
            }

        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            Hobbies hobby = new Hobbies();
            hobby.deleteHobbies(Convert.ToInt32(TextBox1.Text));
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
            Cleardata();
            
        }

       
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cleardata();
            string custname = GridView1.SelectedRow.Cells[2].Text;

            DataSet ds = new DataSet();
            Customer cus = new Customer();
            ds = cus.LoadCustomer(custname);
            TxtCustName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            string index = ds.Tables[0].Rows[0]["CountryID"].ToString();
            DdlCountry.SelectedIndex = Convert.ToInt16(index);
            string gen = ds.Tables[0].Rows[0]["Gender"].ToString();
            if (gen == "Male")
            {
                RadioMale.Checked = true;

            }
            else
                RadioFemale.Checked = true;
            bool ss = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
            if (ss)
                RadioMarried.Checked = true;
            else
                RadioUnmarried.Checked = true;
            LoadHobbies(Convert.ToInt16(ds.Tables[0].Rows[0]["ID"]));
            TextBox1.Text = ds.Tables[0].Rows[0]["ID"].ToString();
        }

        protected void DdlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}