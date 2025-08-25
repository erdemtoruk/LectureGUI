namespace AcademicPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Example
            AddProfileCard("Erdem", DateTime.Now.AddDays(-5));
            
        }

        // User records folder name
        private string dataFolder = "Users";

        /*
         *  Creates new profile
         */
        public void Create_Profile(string name, string department, string startYear)
        {
            if (!Directory.Exists(dataFolder))
                Directory.CreateDirectory(dataFolder);

            // Initialize CSV files
            InitCsv("", "profiles.csv", "ProfileId;Name;Department;StartYear");
            InitCsv(name, "courses.csv", "CourseCode;CourseName;Credit;Semester;Grade;Status");
            InitCsv(name, "prerequisites.csv", "CourseCode;PrerequisiteCode");
            InitCsv(name, "internships.csv", "InternshipName;RequiredDays;CompletedDays;Status");
            InitCsv(name, "settings.csv", "Theme;LastOpenedPage");

            // New Profile ID
            int newProfileId = GetNextProfileId();

            // Create Profile
            string profileLine = $"{newProfileId},{name},{department},{startYear}";
            File.AppendAllText(Path.Combine(dataFolder, "profiles.csv"), profileLine + Environment.NewLine);
        }

        private void Open_Profile()
        {

        }

        /*
         *  Delete Profile informations
         */
        private void Delete_Profile(string profileName)
        {
            // Delete profile folder
            string profileFolder = Path.Combine(dataFolder, profileName);
            if (Directory.Exists(profileFolder))
            {
                try
                {
                    Directory.Delete(profileFolder, true);
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
                lines.RemoveAll(line => line.Contains(profileName));
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
            if (lines.Length <= 1) return 1; // sadece baþlýk varsa

            string lastLine = lines[lines.Length - 1];
            string[] parts = lastLine.Split(';');
            return int.Parse(parts[0]) + 1;
        }

        private void AddProfileCard(string profileName, DateTime createdAt)
        {
            // Panel
            Panel card = new Panel();
            card.Size = new Size(250, 80);
            card.BackColor = Color.LightGray;
            card.Margin = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;

            // Profile Name
            Label lblName = new Label();
            lblName.Text = profileName;
            lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblName.Location = new Point(10, 10);
            lblName.AutoSize = true;

            // Created date
            Label lblDate = new Label();
            lblDate.Text = "Created: " + createdAt.ToShortDateString();
            lblDate.Font = new Font("Segoe UI", 9);
            lblDate.Location = new Point(10, 40);
            lblDate.AutoSize = true;

            // Delete Button
            Button btnDelete = new Button();
            btnDelete.Text = "X";
            btnDelete.ForeColor = Color.White;
            btnDelete.BackColor = Color.Red;
            btnDelete.Size = new Size(30, 30);
            btnDelete.Location = new Point(200, 10);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Click += (s, e) => {
                var result = MessageBox.Show($"Are you sure you want to delete the profile '{profileName}'? This action cannot be undone.",
                                              "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                flowProfiles.Controls.Remove(card); card.Dispose(); Delete_Profile(profileName);
            };

            // Open Profile
            card.Click += (s, e) => Open_Profile();

            // Add everything to panel
            card.Controls.Add(lblName);
            card.Controls.Add(lblDate);
            card.Controls.Add(btnDelete);

            // Add panel to Form
            flowProfiles.Controls.Add(card);
        }
    }
}
