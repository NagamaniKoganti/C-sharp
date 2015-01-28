using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
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
            Commonode cObj = new Commonode();
            if (cObj.CheckValidation(textBox1.Text) == false)
            {
                MessageBox.Show("Customer name is Compulsary");
            }
            string gender = "";
            if (radioButtonMale.Checked)
                gender = "Male";
            else
                gender = "Female";
            string status = "";
            if (radioButtonMarried.Checked)
                status = "Married";
            else
                status = "Unmarried";

            string hobby="";
            if(checkBoxPainting.Checked)
                hobby="Painting";
            else if(checkBoxRead.Checked)
                hobby="Reading";
            else
                hobby="Writing";

           /* CustomerPreview Customer = new CustomerPreview();
            Customer.setValues(textBox1.Text, domainUpDowncountry.SelectedItem.ToString(), gender, hobby, status);
            Customer.ShowDialog();*/

            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "Insert into Customer values('" + textBox1.Text + "','" 
                                                           + domainUpDowncountry.SelectedItem.ToString() + "','" 
                                                           + gender +"','"
                                                           +hobby+"','"
                                                           + radioButtonMarried.Checked+ "')";
            SqlCommand command = new SqlCommand(query, connection);
            int Result =command.ExecuteNonQuery();
            connection.Close();
            if (Result > 0)
            {
                MessageBox.Show(Result + "Records Inserted into database");
            }
            else
                MessageBox.Show("There was aproblem in Adding data");
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
           

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            Commonode CommonObj = new Commonode();

            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select *from Customer";
            SqlCommand command = new SqlCommand(query, connection);

            DataSet DS = new DataSet();

            SqlDataAdapter Dataadopter = new SqlDataAdapter(command);

            Dataadopter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            connection.Close();
        }

        private void  DisplayCustomer(string Customername)
        {
            Commonode CommonObj = new Commonode();

            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select *from Customer where name="+"'"+Customername+"'";
            SqlCommand command = new SqlCommand(query, connection);

            DataSet DS = new DataSet();

            SqlDataAdapter Dataadopter = new SqlDataAdapter(command);

            Dataadopter.Fill(DS);

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

            
            connection.Close();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string custname = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            DisplayCustomer(custname);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
