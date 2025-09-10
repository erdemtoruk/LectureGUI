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
            year_textBox = new TextBox();
            department_textBox = new TextBox();
            name_textBox = new TextBox();
            create_btn = new FontAwesome.Sharp.IconButton();
            fill_panel.SuspendLayout();
            SuspendLayout();
            // 
            // fill_panel
            // 
            fill_panel.Controls.Add(create_btn);
            fill_panel.Controls.Add(year_textBox);
            fill_panel.Controls.Add(department_textBox);
            fill_panel.Controls.Add(name_textBox);
            fill_panel.Dock = DockStyle.Fill;
            fill_panel.Location = new Point(0, 0);
            fill_panel.Name = "fill_panel";
            fill_panel.Size = new Size(582, 453);
            fill_panel.TabIndex = 0;
            // 
            // year_textBox
            // 
            year_textBox.Location = new Point(210, 188);
            year_textBox.Name = "year_textBox";
            year_textBox.Size = new Size(125, 27);
            year_textBox.TabIndex = 3;
            // 
            // department_textBox
            // 
            department_textBox.Location = new Point(211, 154);
            department_textBox.Name = "department_textBox";
            department_textBox.Size = new Size(125, 27);
            department_textBox.TabIndex = 2;
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(212, 112);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(125, 27);
            name_textBox.TabIndex = 0;
            // 
            // create_btn
            // 
            create_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            create_btn.IconColor = Color.Black;
            create_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            create_btn.Location = new Point(210, 246);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(125, 29);
            create_btn.TabIndex = 4;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // SignUp
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(2, 52, 64);
            ClientSize = new Size(582, 453);
            Controls.Add(fill_panel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Profile";
            fill_panel.ResumeLayout(false);
            fill_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel fill_panel;
        private TextBox name_textBox;
        private TextBox year_textBox;
        private TextBox department_textBox;
        private FontAwesome.Sharp.IconButton create_btn;
    }
}