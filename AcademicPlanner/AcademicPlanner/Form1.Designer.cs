namespace AcademicPlanner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fill_panel = new TableLayoutPanel();
            createNew_btn = new FontAwesome.Sharp.IconButton();
            flowProfiles = new FlowLayoutPanel();
            fill_panel.SuspendLayout();
            SuspendLayout();
            // 
            // fill_panel
            // 
            fill_panel.ColumnCount = 2;
            fill_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            fill_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.571434F));
            fill_panel.Controls.Add(createNew_btn, 1, 0);
            fill_panel.Controls.Add(flowProfiles, 0, 0);
            fill_panel.Dock = DockStyle.Fill;
            fill_panel.Location = new Point(0, 0);
            fill_panel.Name = "fill_panel";
            fill_panel.RowCount = 1;
            fill_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            fill_panel.Size = new Size(982, 553);
            fill_panel.TabIndex = 0;
            // 
            // createNew_btn
            // 
            createNew_btn.Dock = DockStyle.Fill;
            createNew_btn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            createNew_btn.IconColor = Color.Black;
            createNew_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createNew_btn.IconSize = 108;
            createNew_btn.Location = new Point(731, 100);
            createNew_btn.Margin = new Padding(30, 100, 30, 100);
            createNew_btn.Name = "createNew_btn";
            createNew_btn.Size = new Size(221, 353);
            createNew_btn.TabIndex = 0;
            createNew_btn.Text = "Create New Profile";
            createNew_btn.TextAlign = ContentAlignment.BottomCenter;
            createNew_btn.UseVisualStyleBackColor = true;
            createNew_btn.Click += createNew_btn_Click;
            // 
            // flowProfiles
            // 
            flowProfiles.AutoScroll = true;
            flowProfiles.Dock = DockStyle.Fill;
            flowProfiles.FlowDirection = FlowDirection.TopDown;
            flowProfiles.Location = new Point(3, 3);
            flowProfiles.Name = "flowProfiles";
            flowProfiles.Size = new Size(695, 547);
            flowProfiles.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(2, 52, 64);
            ClientSize = new Size(982, 553);
            Controls.Add(fill_panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Academic Planner";
            fill_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel fill_panel;
        private FontAwesome.Sharp.IconButton createNew_btn;
        private FlowLayoutPanel flowProfiles;
    }
}
