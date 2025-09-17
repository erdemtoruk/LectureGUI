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

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            name_textBox_Leave(this, EventArgs.Empty);
            department_textBox_Leave(this, EventArgs.Empty);
            grade_textBox_Leave(this, EventArgs.Empty);
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text == "" || department_textBox.Text == "" || grade_textBox.Text == "")
            {
                // Error message
                return;
            }


            // Create profile
            form1.Create_Profile(name_textBox.Text, department_textBox.Text, grade_textBox.Text);

            // Close creation form
            this.Close();
        }

        /********************************************************************************** Placeholder **************************************************************************/

        private void name_textBox_Enter(object sender, EventArgs e)
        {
            if(name_textBox.Text == "Full Name")
            {
                name_textBox.Text = "";
                name_textBox.ForeColor = Color.Black;
            }
        }

        private void name_textBox_Leave(object sender, EventArgs e)
        {
            if (name_textBox.Text == "")
            {
                name_textBox.Text = "Full Name";
                name_textBox.ForeColor = Color.Gray;
            }
        }

        private void department_textBox_Enter(object sender, EventArgs e)
        {
            if(department_textBox.Text == "Department")
            {
                department_textBox.Text = "";
                department_textBox.ForeColor = Color.Black;
            }            
        }

        private void department_textBox_Leave(object sender, EventArgs e)
        {
            if (department_textBox.Text == "")
            {
                department_textBox.Text = "Department";
                department_textBox.ForeColor = Color.Gray;
            }
        }

        private void grade_textBox_Enter(object sender, EventArgs e)
        {
            if(grade_textBox.Text == "Grade")
            {
                grade_textBox.Text = "";
                grade_textBox.ForeColor = Color.Black;
            }            
        }

        private void grade_textBox_Leave(object sender, EventArgs e)
        {
            if (grade_textBox.Text == "")
            {
                grade_textBox.Text = "Grade";
                grade_textBox.ForeColor = Color.Gray;
            }
        }

        /************************************************************************************************************************************************************/
    }
}
