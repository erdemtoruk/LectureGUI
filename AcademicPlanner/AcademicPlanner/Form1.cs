using System.Xml.Linq;

namespace AcademicPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ListUser();
        }

        // User records folder name
        public static string dataFolder = Path.Combine(Application.StartupPath, "Users");

        private void ListUser()
        {
            flowProfiles.Controls.Clear();

            if (!Directory.Exists(dataFolder))
                return;

            string profilesCsv = Path.Combine(dataFolder, "profiles.csv");
            if (File.Exists(profilesCsv))
            {
                var lines = new List<string>(File.ReadAllLines(profilesCsv));

                for (int i = 1; i < lines.Count; i++)
                {
                    AddProfileCard(lines[i].Split(";")[1]);
                }
            }
        }

        /*
         *  Open new profile creation page
         */
        private void createNew_btn_Click(object sender, EventArgs e)
        {
            SignUp form2 = new SignUp(this);
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
        }

        /*
         *  Creates new profile
         */
        public void Create_Profile(string name, string department, string startYear)
        {
            if (Directory.Exists(Path.Combine(dataFolder, name)))
            {
                // This name already taken error message
                return;
            }   
            
            // Create folder for new profile
            Directory.CreateDirectory(Path.Combine(dataFolder, name));

            // Initialize CSV files
            InitCsv("", "profiles.csv", "ProfileId;Name;Department;Year");
            InitCsv(name, "courses.csv", "CourseCode;CourseName;Credit;Semester;Grade;Status");
            InitCsv(name, "prerequisites.csv", "CourseCode;PrerequisiteCode");
            InitCsv(name, "internships.csv", "InternshipName;RequiredDays;CompletedDays;Status");
            InitCsv(name, "settings.csv", "Theme;LastOpenedPage");

            // New profile ID
            int newProfileId = GetNextProfileId();

            // Add to profile.csv
            string profileLine = $"{newProfileId};{name};{department};{startYear}";
            File.AppendAllText(Path.Combine(dataFolder, "profiles.csv"), profileLine + Environment.NewLine);

            ListUser();
        }

        /*
         *  Open profile
         */ 
        private void Open_Profile(string profileName)
        {
            // Delete profile folder
            string profileFolder = Path.Combine(dataFolder, profileName);
            if (Directory.Exists(profileFolder))
            {
                MainDashboard MainMenu = new MainDashboard(this, profileName);

                MainMenu.StartPosition = FormStartPosition.CenterScreen;

                // Show main menu
                this.Hide();
                MainMenu.Show();
            }
        }

        /*
         *  Delete profile informations
         */
        private void Delete_Profile(string profileName)
        {
            // Delete profile folder
            string profileFolder = Path.Combine(dataFolder, profileName);
            if (Directory.Exists(profileFolder))
            {
                try
                {
                    Directory.Delete(profileFolder, true);  // Delete subfolders
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting folder: " + ex.Message);
                    return;
                }
            }

            // Delete from profiles.csv
            string profilesCsv = Path.Combine(dataFolder, "profiles.csv");
            if (File.Exists(profilesCsv))
            {
                var lines = new List<string>(File.ReadAllLines(profilesCsv));
                var header = lines.First(); 
                lines.RemoveAt(0);

                lines.RemoveAll(line =>
                {
                    var parts = line.Split(';');
                    return parts.Length > 1 && parts[1] == profileName;
                });

                lines.Insert(0, header);
                File.WriteAllLines(profilesCsv, lines);
            }
        }

        /*
         *  Initialize CSV files
         */
        private void InitCsv(string folderName, string fileName, string header)
        {
            string path = Path.Combine(dataFolder, fileName);

            if (folderName != "")
                path = Path.Combine(dataFolder, folderName, fileName);

            if (!File.Exists(path))
                File.WriteAllText(path, header + Environment.NewLine);
        }

        /*
         *  Generate next profile ID
         */
        private int GetNextProfileId()
        {
            string profilePath = Path.Combine(dataFolder, "profiles.csv");
            if (!File.Exists(profilePath))
                return 1;

            string[] lines = File.ReadAllLines(profilePath);
            if (lines.Length <= 1) return 1;

            string lastLine = lines[lines.Length - 1];
            string[] parts = lastLine.Split(';');
            return int.Parse(parts[0]) + 1;
        }

        private void AddProfileCard(string profileName)
        {
            // Panel
            Panel card = new Panel();
            card.Size = new Size(250, 80);
            card.BackColor = Color.FromArgb(100,200,150);
            card.Margin = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;

            // Profile Name
            Label lblName = new Label();
            lblName.Text = profileName;
            lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblName.Location = new Point(15, 15);
            lblName.AutoSize = true;

            // Created date
            // Label lblDate = new Label();
            // lblDate.Text = "Created: " + createdAt.ToShortDateString();
            // lblDate.Font = new Font("Segoe UI", 9);
            // lblDate.Location = new Point(10, 40);
            // lblDate.AutoSize = true;

            // Delete Button
            Button btnDelete = new Button();
            btnDelete.Text = "X";
            btnDelete.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Size = new Size(30, 30);
            btnDelete.Location = new Point(210, 5);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += (s, e) =>
            {
                var result = MessageBox.Show($"Are you sure you want to delete the profile '{profileName}'? This action cannot be undone.",
                                              "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                flowProfiles.Controls.Remove(card); card.Dispose(); Delete_Profile(profileName);
            };

            // Open Profile
            card.Click += (s, e) => Open_Profile(profileName);

            // Add everything to panel
            card.Controls.Add(lblName);
            // card.Controls.Add(lblDate);
            card.Controls.Add(btnDelete);

            // Add panel to Form
            flowProfiles.Controls.Add(card);
        }
    }
}
