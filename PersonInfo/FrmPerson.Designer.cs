namespace PersonInfo
{
    partial class FrmPerson
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblIsActive = new Label();
            chkActive = new CheckBox();
            lblAddresses = new Label();
            lbxAddresses = new ListBox();
            btnAdd = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 9);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(85, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 38);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(85, 35);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 3;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(12, 65);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(43, 15);
            lblIsActive.TabIndex = 4;
            lblIsActive.Text = "Active:";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(85, 65);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(15, 14);
            chkActive.TabIndex = 5;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // lblAddresses
            // 
            lblAddresses.AutoSize = true;
            lblAddresses.Location = new Point(12, 91);
            lblAddresses.Name = "lblAddresses";
            lblAddresses.Size = new Size(63, 15);
            lblAddresses.TabIndex = 7;
            lblAddresses.Text = "Addresses:";
            // 
            // lbxAddresses
            // 
            lbxAddresses.FormattingEnabled = true;
            lbxAddresses.ItemHeight = 15;
            lbxAddresses.Location = new Point(85, 91);
            lbxAddresses.Name = "lbxAddresses";
            lbxAddresses.Size = new Size(160, 199);
            lbxAddresses.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(170, 62);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(170, 305);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // FrmPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 352);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lbxAddresses);
            Controls.Add(chkActive);
            Controls.Add(txtLastName);
            Controls.Add(lblAddresses);
            Controls.Add(lblIsActive);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "FrmPerson";
            Text = "Person Entry";
            Load += FrmPerson_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblIsActive;
        private CheckBox chkActive;
        private Label lblAddresses;
        private ListBox lbxAddresses;
        private Button btnAdd;
        private Button btnSave;
    }
}