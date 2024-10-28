namespace WindowGUI
{
    partial class FrmPSAdd
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
            label1 = new Label();
            tbID = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã chức vụ ";
            // 
            // tbID
            // 
            tbID.Location = new Point(115, 24);
            tbID.Name = "tbID";
            tbID.Size = new Size(241, 27);
            tbID.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(115, 72);
            tbName.Name = "tbName";
            tbName.Size = new Size(241, 27);
            tbName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên chức vụ ";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(262, 123);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(144, 123);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmPSAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 204);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbID);
            Controls.Add(label1);
            Name = "FrmPSAdd";
            Text = "FrmPSAdd";
            Load += FrmPSAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbID;
        private TextBox tbName;
        private Label label2;
        private Button btnAdd;
        private Button button2;
    }
}