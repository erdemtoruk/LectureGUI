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
        public MainDashboard()
        {
            InitializeComponent();
        }


        /****************************************************************** Responsive *****************************************************************************/
        private void Size_Change()
        {
            int width = this.ClientSize.Width > 0 ? this.ClientSize.Width : 1000;
            int height = this.ClientSize.Height > 0 ? this.ClientSize.Height : 700;

            tableLayoutPanel1.Height = Convert.ToInt32(height / 10);
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            Size_Change();
        }

        private void MainDashboard_Resize(object sender, EventArgs e)
        {
            Size_Change();
        }

        /***************************************************************** Form Change ******************************************************************************/

        private void MainMenu_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
