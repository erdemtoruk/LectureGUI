namespace AcademicPlanner
{
    partial class SignUp
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
            fill_panel = new Panel();
            create_btn = new FontAwesome.Sharp.IconButton();
            grade_textBox = new TextBox();
            department_textBox = new TextBox();
            name_textBox = new TextBox();
            fill_panel.SuspendLayout();
            SuspendLayout();
            // 
            // fill_panel
            // 
            fill_panel.BackColor = Color.DarkSlateGray;
            fill_panel.Controls.Add(create_btn);
            fill_panel.Controls.Add(grade_textBox);
            fill_panel.Controls.Add(department_textBox);
            fill_panel.Controls.Add(name_textBox);
            fill_panel.Dock = DockStyle.Fill;
            fill_panel.Location = new Point(0, 0);
            fill_panel.Name = "fill_panel";
            fill_panel.Size = new Size(582, 453);
            fill_panel.TabIndex = 0;
            // 
            // create_btn
            // 
            create_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            create_btn.IconColor = Color.Black;
            create_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            create_btn.Location = new Point(210, 350);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(125, 40);
            create_btn.TabIndex = 0;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // grade_textBox
            // 
            grade_textBox.BackColor = Color.MediumSeaGreen;
            grade_textBox.Location = new Point(10, 210);
            grade_textBox.Name = "grade_textBox";
            grade_textBox.Size = new Size(225, 27);
            grade_textBox.TabIndex = 3;
            grade_textBox.Enter += grade_textBox_Enter;
            grade_textBox.Leave += grade_textBox_Leave;
            // 
            // department_textBox
            // 
            department_textBox.BackColor = Color.MediumAquamarine;
            department_textBox.Location = new Point(10, 150);
            department_textBox.Name = "department_textBox";
            department_textBox.Size = new Size(225, 27);
            department_textBox.TabIndex = 2;
            department_textBox.Enter += department_textBox_Enter;
            department_textBox.Leave += department_textBox_Leave;
            // 
            // name_textBox
            // 
            name_textBox.BackColor = Color.DarkSeaGreen;
            name_textBox.ForeColor = Color.Gray;
            name_textBox.Location = new Point(10, 90);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(225, 27);
            name_textBox.TabIndex = 1;
            name_textBox.Enter += name_textBox_Enter;
            name_textBox.Leave += name_textBox_Leave;
            // 
            // SignUp
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(124, 154, 146);
            ClientSize = new Size(582, 453);
            Controls.Add(fill_panel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Profile";
            Load += SignUp_Load;
            fill_panel.ResumeLayout(false);
            fill_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel fill_panel;
        private TextBox name_textBox;
        private TextBox grade_textBox;
        private TextBox department_textBox;
        private FontAwesome.Sharp.IconButton create_btn;
    }
}