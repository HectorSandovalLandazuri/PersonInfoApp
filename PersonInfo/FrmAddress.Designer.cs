namespace PersonInfo
{
    partial class FrmAddress
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
            txtCity = new TextBox();
            lblCity = new Label();
            txtStreetAddress = new TextBox();
            lblStreetAddress = new Label();
            lblState = new Label();
            txtState = new TextBox();
            lblCode = new Label();
            txtCode = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Location = new Point(103, 38);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 2;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(12, 38);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 6;
            lblCity.Text = "City:";
            // 
            // txtStreetAddress
            // 
            txtStreetAddress.Location = new Point(103, 6);
            txtStreetAddress.Name = "txtStreetAddress";
            txtStreetAddress.Size = new Size(100, 23);
            txtStreetAddress.TabIndex = 1;
            // 
            // lblStreetAddress
            // 
            lblStreetAddress.AutoSize = true;
            lblStreetAddress.Location = new Point(12, 9);
            lblStreetAddress.Name = "lblStreetAddress";
            lblStreetAddress.Size = new Size(85, 15);
            lblStreetAddress.TabIndex = 0;
            lblStreetAddress.Text = "Street Address:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(12, 72);
            lblState.Name = "lblState";
            lblState.Size = new Size(36, 15);
            lblState.TabIndex = 6;
            lblState.Text = "State:";
            // 
            // txtState
            // 
            txtState.Location = new Point(103, 69);
            txtState.Name = "txtState";
            txtState.Size = new Size(100, 23);
            txtState.TabIndex = 3;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(12, 101);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(38, 15);
            lblCode.TabIndex = 6;
            lblCode.Text = "Code:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(103, 98);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(103, 127);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // FrmAddress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 169);
            Controls.Add(btnSave);
            Controls.Add(txtCode);
            Controls.Add(txtState);
            Controls.Add(lblCode);
            Controls.Add(txtCity);
            Controls.Add(lblState);
            Controls.Add(lblCity);
            Controls.Add(txtStreetAddress);
            Controls.Add(lblStreetAddress);
            Name = "FrmAddress";
            Text = "Address";
            Load += FrmAddress_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtStreetAddress;
        private Label lblStreetAddress;
        private Label lblState;
        private TextBox txtState;
        private Label lblCode;
        private TextBox txtCode;
        private Button btnSave;
    }
}