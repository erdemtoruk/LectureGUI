using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlanner
{
    public partial class MainDashboard : Form
    {
        string profileName;
        int profileIndex;
        Form1 form1;

        private Form currentChildForm;

        public MainDashboard(Form1 form1, string profileName)
        {
            InitializeComponent();

            this.form1 = form1;
            this.profileName = profileName;
            this.profileIndex = Find_User();
        }
        /****************************************************************** Find User *****************************************************************************/
        private int Find_User()
        {
            string profilesCsv = Path.Combine(Form1.dataFolder, "profiles.csv");
            if (File.Exists(profilesCsv))
            {
                var lines = new List<string>(File.ReadAllLines(profilesCsv));

                for (int i = 1; i < lines.Count; i++)
                {
                    if (lines[i].Split(";")[1] == profileName)
                        return i;
                }
            }
            return -1;
        }
        /****************************************************************** Responsive *****************************************************************************/
        private void Size_Change()
        {
            int width = this.ClientSize.Width > 0 ? this.ClientSize.Width : 1000;
            int height = this.ClientSize.Height > 0 ? this.ClientSize.Height : 700;

            tableLayoutPanel.Height = Convert.ToInt32(height / 10);
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            Size_Change();
            Home_btn_Click(this, EventArgs.Empty);
        }

        private void MainDashboard_Resize(object sender, EventArgs e)
        {
            Size_Change();
        }
        /***************************************************************** Form Close ******************************************************************************/

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
        /***************************************************************** Form Change ******************************************************************************/

        /*
         *  Opens child form and binds into MainDashboard
         */
        private void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
                currentChildForm.Close();       // Close old child form

            currentChildForm = childform;

            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            page_panel.Controls.Add(childform); // Open child form inside the Form1
            page_panel.Tag = childform;
            childform.BringToFront();
            currentChildForm.Show();            // Show child form
        }

        /*
         *  Open home page
         */
        private void Home_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home(profileIndex));
        }



        /************************************************************************************************************************************************************/
    }
}
