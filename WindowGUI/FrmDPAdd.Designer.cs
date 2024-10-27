namespace WindowGUI
{
    partial class FrmDPAdd
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
            btnCancel = new Button();
            btnAdd = new Button();
            tbName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phòng ban";
            // 
            // tbID
            // 
            tbID.Location = new Point(139, 27);
            tbID.Name = "tbID";
            tbID.Size = new Size(258, 27);
            tbID.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(186, 117);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(305, 117);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(139, 73);
            tbName.Name = "tbName";
            tbName.Size = new Size(258, 27);
            tbName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên phòng ban";
            // 
            // FrmDPAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 179);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(tbID);
            Controls.Add(label1);
            Name = "FrmDPAdd";
            Text = "FrmDPAdd";
            Load += FrmDPAdd_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbID;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox tbName;
        private Label label2;
    }
}