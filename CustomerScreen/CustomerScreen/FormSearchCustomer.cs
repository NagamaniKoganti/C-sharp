using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerMiddleTier;

namespace CustomerScreen
{
    public partial class FormSearchCustomer : Form
    {
        public FormSearchCustomer()
        {
            InitializeComponent();
        }

        private void BtnSearchCustomer_Click(object sender, EventArgs e)

        {

            
            Customer Customerdetails = new Customer();
            Customerdetails.CustomerName=TxtSearchCustomer.Text;

            dataGridView1.DataSource = Customerdetails.LoadCustomer(Customerdetails.CustomerName);
            

            

 

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
