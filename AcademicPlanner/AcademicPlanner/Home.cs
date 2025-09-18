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
    public partial class Home : Form
    {
        private readonly int userIndex;

        public Home(int userIndex)
        {
            InitializeComponent();
            this.userIndex = userIndex;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string profilesCsv = Path.Combine(Form1.dataFolder, "profiles.csv");
            if (File.Exists(profilesCsv))
            {
                var lines = new List<string>(File.ReadAllLines(profilesCsv));

                name_label.Text = lines[userIndex].Split(";")[1];
                department_label.Text = $"{lines[userIndex].Split(";")[2]}{Environment.NewLine}{lines[userIndex].Split(";")[3]}. Grade";
            }
        }
    }
}
