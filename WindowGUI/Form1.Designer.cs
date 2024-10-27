namespace WindowGUI
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
            menuStrip1 = new MenuStrip();
            mnuMenu = new ToolStripMenuItem();
            mnuMenuEmploy = new ToolStripMenuItem();
            mnuMenuDepartment = new ToolStripMenuItem();
            mnuMenuPosition = new ToolStripMenuItem();
            pnlForm = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(805, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            mnuMenu.DropDownItems.AddRange(new ToolStripItem[] { mnuMenuEmploy, mnuMenuDepartment, mnuMenuPosition });
            mnuMenu.Name = "mnuMenu";
            mnuMenu.Size = new Size(60, 24);
            mnuMenu.Text = "menu";
            // 
            // mnuMenuEmploy
            // 
            mnuMenuEmploy.Name = "mnuMenuEmploy";
            mnuMenuEmploy.Size = new Size(163, 26);
            mnuMenuEmploy.Text = "Nhân Viên";
            mnuMenuEmploy.Click += mnuMenuEmploy_Click;
            // 
            // mnuMenuDepartment
            // 
            mnuMenuDepartment.Name = "mnuMenuDepartment";
            mnuMenuDepartment.Size = new Size(163, 26);
            mnuMenuDepartment.Text = "Phòng Ban";
            mnuMenuDepartment.Click += mnuMenuDepartment_Click;
            // 
            // mnuMenuPosition
            // 
            mnuMenuPosition.Name = "mnuMenuPosition";
            mnuMenuPosition.Size = new Size(163, 26);
            mnuMenuPosition.Text = "Chức Vụ";
            mnuMenuPosition.Click += mnuMenuPosition_Click;
            // 
            // pnlForm
            // 
            pnlForm.Location = new Point(0, 31);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(805, 474);
            pnlForm.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 520);
            Controls.Add(pnlForm);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuMenu;
        private ToolStripMenuItem mnuMenuEmploy;
        private ToolStripMenuItem mnuMenuDepartment;
        private ToolStripMenuItem mnuMenuPosition;
        private Panel pnlForm;
    }
}
