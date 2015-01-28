using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerScreen
{
    public partial class CustomerPreview : Form
    {
        public CustomerPreview()
        {
            InitializeComponent();
        }

        private void CustomerPreview_Load(object sender, EventArgs e)
        {

        }

        public void setValues(string Customername,
                              string Countryname,
                              string Gender, string Hobbies, string Status)
        {
            LblCustnameOutput.Text = Customername;
            LblCountryOutput.Text = Countryname;
            LblGenderOutput.Text = Gender;
            LblHobbyOut.Text = Hobbies;
            LblStatusOut.Text = Status;
        }
    }
}
