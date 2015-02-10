using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CustomerMiddleTier;

namespace CustomerScreen
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void radioButtonMarried_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer CustObj = new Customer();
            CustObj.CountryCode = Convert.ToInt16(textBox1.Text);
            
            if (radioButtonMale.Checked)
                CustObj.Gender = "Male";
            else
                CustObj.Gender = "Female";
           
            if (radioButtonMarried.Checked)
                CustObj.Ismarried = true;
            else
                CustObj.Ismarried = false;

            string hobby="";
            if(checkBoxPainting.Checked)
                hobby="Painting";
            else if(checkBoxRead.Checked)
                hobby="Reading";
            else
                hobby="Writing";
            CustObj.Hobbies = hobby;
           /* CustomerPreview Customer = new CustomerPreview();
            Customer.setValues(textBox1.Text, domainUpDowncountry.SelectedItem.ToString(), gender, hobby, status);
            Customer.ShowDialog();*/


            bool Result = CustObj.saveCustomer();
            if (Result)
            {
                MessageBox.Show( " 1 Inserted into database");
            }
            else
                MessageBox.Show("There was aproblem in Adding data");
        }

        private void BtnDeleteCust_Click(object sender, EventArgs e)
        {
            

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            Customer CS = new Customer();
            DataSet DS=CS.LoadCustomer();
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void  DisplayCustomer(string Customername)
        {
            Customer cs = new Customer();
            DataSet DS = new DataSet();
            DS = cs.LoadCustomer(Customername);

            textBox1.Text = DS.Tables[0].Rows[0]["name"].ToString();
            domainUpDowncountry.SelectedItem = DS.Tables[0].Rows[0]["country"].ToString();

            if (DS.Tables[0].Rows[0]["Gender"].ToString() == "Male")
                radioButtonMale.Checked = true;
            else
                radioButtonFemale.Checked = true;

            if (DS.Tables[0].Rows[0]["hobbies"].ToString() == "Reading")
                checkBoxRead.Checked = true;
            else if (DS.Tables[0].Rows[0]["hobbies"].ToString() == "Writing")
            {
                checkBoxRead.Checked = false;
                checkBoxWriting.Checked = true;
            }
            else
            {
                checkBoxRead.Checked = false;
                checkBoxWriting.Checked = false;
                checkBoxPainting.Checked = true;
            }
            bool ss=Convert.ToBoolean(DS.Tables[0].Rows[0]["status"]);
            if(ss)
                radioButtonMarried.Checked=true;
            else
                radioButtonUnmarried.Checked=true;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string custname = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            //DisplayCustomer(custname);
            DataSet ds = new DataSet();
            Customer cs = new Customer();
            ds = cs.LoadCustomer(custname);
            textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
            domainUpDowncountry.SelectedItem = ds.Tables[0].Rows[0][1].ToString();
            string gen = ds.Tables[0].Rows[0][2].ToString();
            if (gen == "Male")
            {
                radioButtonMale.Checked = true;

            }
            else
                radioButtonFemale.Checked = true;
            if (ds.Tables[0].Rows[0]["hobbies"].ToString() == "Reading")
                checkBoxRead.Checked = true;
            else if (ds.Tables[0].Rows[0]["hobbies"].ToString() == "Writing")
            {
                checkBoxRead.Checked = false;
                checkBoxWriting.Checked = true;
            }
            else
            {
                checkBoxRead.Checked = false;
                checkBoxWriting.Checked = false;
                checkBoxPainting.Checked = true;
            }
            bool ss = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
            if (ss)
                radioButtonMarried.Checked = true;
            else
                radioButtonUnmarried.Checked = true;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
