namespace AcademicPlanner
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fill_panel = new TableLayoutPanel();
            department_label = new Label();
            name_label = new Label();
            fill_panel.SuspendLayout();
            SuspendLayout();
            // 
            // fill_panel
            // 
            fill_panel.ColumnCount = 5;
            fill_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            fill_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            fill_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            fill_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            fill_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            fill_panel.Controls.Add(department_label, 0, 2);
            fill_panel.Controls.Add(name_label, 0, 0);
            fill_panel.Dock = DockStyle.Fill;
            fill_panel.ForeColor = Color.White;
            fill_panel.Location = new Point(0, 0);
            fill_panel.Name = "fill_panel";
            fill_panel.RowCount = 5;
            fill_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            fill_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            fill_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            fill_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            fill_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            fill_panel.Size = new Size(800, 450);
            fill_panel.TabIndex = 0;
            // 
            // department_label
            // 
            fill_panel.SetColumnSpan(department_label, 2);
            department_label.Dock = DockStyle.Fill;
            department_label.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            department_label.Location = new Point(3, 180);
            department_label.Name = "department_label";
            department_label.Size = new Size(314, 90);
            department_label.TabIndex = 1;
            department_label.Text = "Bilgisayar Mühendisliği";
            department_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // name_label
            // 
            fill_panel.SetColumnSpan(name_label, 2);
            name_label.Dock = DockStyle.Fill;
            name_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            name_label.Location = new Point(3, 0);
            name_label.Name = "name_label";
            fill_panel.SetRowSpan(name_label, 2);
            name_label.Size = new Size(314, 180);
            name_label.TabIndex = 0;
            name_label.Text = "Erdem Toruk";
            name_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(fill_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            fill_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel fill_panel;
        private Label name_label;
        private Label department_label;
    }
}