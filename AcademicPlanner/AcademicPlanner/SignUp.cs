using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlanner
{
    public partial class SignUp : Form
    {
        Form1 form1;

        public SignUp(Form1 form)
        {
            InitializeComponent();
            this.form1 = form;
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text == "" || department_textBox.Text == "" || year_textBox.Text == "")
            {
                // Error message
                return;
            }


            // Create profile
            form1.Create_Profile(name_textBox.Text, department_textBox.Text, year_textBox.Text);

            // Close creation form
            this.Close();
        }
    }
}
