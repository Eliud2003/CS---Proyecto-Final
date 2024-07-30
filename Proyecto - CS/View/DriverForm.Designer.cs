namespace Proyecto___CS.View
{
    partial class DriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverForm));
            label2 = new Label();
            txtTypeOfLicense = new TextBox();
            dgvDriver = new DataGridView();
            btnView = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRegister = new Button();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            cmbVehicle = new ComboBox();
            dtpBirthDate = new DateTimePicker();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtDni = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDriver).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 312);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 47;
            label2.Text = "Vehicle:";
            // 
            // txtTypeOfLicense
            // 
            txtTypeOfLicense.Location = new Point(307, 150);
            txtTypeOfLicense.Name = "txtTypeOfLicense";
            txtTypeOfLicense.Size = new Size(62, 31);
            txtTypeOfLicense.TabIndex = 46;
            // 
            // dgvDriver
            // 
            dgvDriver.BackgroundColor = SystemColors.ButtonFace;
            dgvDriver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDriver.Location = new Point(408, 49);
            dgvDriver.Margin = new Padding(2);
            dgvDriver.Name = "dgvDriver";
            dgvDriver.RowHeadersWidth = 62;
            dgvDriver.Size = new Size(629, 531);
            dgvDriver.TabIndex = 45;
            dgvDriver.CellClick += dgvDriver_CellClick;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ButtonFace;
            btnView.Image = Properties.Resources.view;
            btnView.Location = new Point(229, 501);
            btnView.Margin = new Padding(4, 5, 4, 5);
            btnView.Name = "btnView";
            btnView.Size = new Size(140, 79);
            btnView.TabIndex = 44;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(47, 501);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 79);
            btnDelete.TabIndex = 43;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.Image = Properties.Resources.Update;
            btnUpdate.Location = new Point(229, 411);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 80);
            btnUpdate.TabIndex = 42;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ButtonFace;
            btnRegister.Image = Properties.Resources.save;
            btnRegister.Location = new Point(47, 411);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 80);
            btnRegister.TabIndex = 41;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(705, 22);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 40;
            label1.Text = "Driver";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(229, 156);
            label8.Name = "label8";
            label8.Size = new Size(72, 25);
            label8.TabIndex = 39;
            label8.Text = "Licence:";            
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 365);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 38;
            label7.Text = "Birth Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 257);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 37;
            label6.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 206);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 36;
            label5.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 156);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 35;
            label4.Text = "DNI:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(47, 105);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 34;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(47, 55);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(101, 25);
            lblFirstName.TabIndex = 33;
            lblFirstName.Text = "First Name:";
            // 
            // cmbVehicle
            // 
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(154, 304);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(215, 33);
            cmbVehicle.TabIndex = 32;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(154, 359);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(215, 31);
            dtpBirthDate.TabIndex = 31;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(154, 251);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(215, 31);
            txtAddress.TabIndex = 30;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(192, 200);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(177, 31);
            txtPhoneNumber.TabIndex = 29;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(100, 150);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(104, 31);
            txtDni.TabIndex = 28;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(154, 99);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(215, 31);
            txtLastName.TabIndex = 27;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(154, 49);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(215, 31);
            txtFirstName.TabIndex = 26;
            // 
            // DriverForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 612);
            Controls.Add(label2);
            Controls.Add(txtTypeOfLicense);
            Controls.Add(dgvDriver);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(cmbVehicle);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtDni);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DriverForm";
            Text = "DriverForm2";
            Load += DriverForm2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDriver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtTypeOfLicense;
        private DataGridView dgvDriver;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRegister;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblLastName;
        private Label lblFirstName;
        private ComboBox cmbVehicle;
        private DateTimePicker dtpBirthDate;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtDni;
        private TextBox txtLastName;
        private TextBox txtFirstName;
    }
}