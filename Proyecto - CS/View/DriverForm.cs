using Proyecto___CS.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___CS.View
{
    public class DriverForm : Form
    {
        private readonly DriverController _driverController;
        private Label lblFirstName;
        private Label lblLastName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label1;
        private DataGridView dgvVehicle;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRegisterVehicle;
        private TextBox txtTypeOfLicense;
        private Label label2;
        private readonly VehicleController _vehicleController;

        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtDni = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            dtpBirthDate = new DateTimePicker();
            cmbVehicle = new ComboBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label1 = new Label();
            dgvVehicle = new DataGridView();
            btnView = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRegisterVehicle = new Button();
            txtTypeOfLicense = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(153, 54);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(215, 31);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(153, 104);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(215, 31);
            txtLastName.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(99, 155);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(104, 31);
            txtDni.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(191, 205);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(177, 31);
            txtPhoneNumber.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(308, 155);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(60, 31);
            txtAddress.TabIndex = 5;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(153, 364);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(215, 31);
            dtpBirthDate.TabIndex = 6;
            // 
            // cmbVehicle
            // 
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(153, 309);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(215, 33);
            cmbVehicle.TabIndex = 7;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(46, 60);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(101, 25);
            lblFirstName.TabIndex = 10;
            lblFirstName.Text = "First Name:";
            lblFirstName.Click += lblFirstName_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(46, 110);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 161);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 12;
            label4.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 211);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 13;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 161);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 14;
            label6.Text = "Address:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 370);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 15;
            label7.Text = "Birth Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 262);
            label8.Name = "label8";
            label8.Size = new Size(139, 25);
            label8.TabIndex = 16;
            label8.Text = "Type Of Licence:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(704, 27);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 18;
            label1.Text = "Driver";
            // 
            // dgvVehicle
            // 
            dgvVehicle.BackgroundColor = SystemColors.ButtonFace;
            dgvVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicle.Location = new Point(407, 54);
            dgvVehicle.Margin = new Padding(2);
            dgvVehicle.Name = "dgvVehicle";
            dgvVehicle.RowHeadersWidth = 62;
            dgvVehicle.Size = new Size(629, 531);
            dgvVehicle.TabIndex = 23;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ButtonFace;
            btnView.Image = Properties.Resources.view;
            btnView.Location = new Point(239, 506);
            btnView.Margin = new Padding(4, 5, 4, 5);
            btnView.Name = "btnView";
            btnView.Size = new Size(140, 79);
            btnView.TabIndex = 22;
            btnView.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(63, 506);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 79);
            btnDelete.TabIndex = 21;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.Image = Properties.Resources.Update;
            btnUpdate.Location = new Point(239, 416);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 80);
            btnUpdate.TabIndex = 20;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRegisterVehicle
            // 
            btnRegisterVehicle.BackColor = SystemColors.ButtonFace;
            btnRegisterVehicle.Image = Properties.Resources.save;
            btnRegisterVehicle.Location = new Point(63, 416);
            btnRegisterVehicle.Margin = new Padding(4, 5, 4, 5);
            btnRegisterVehicle.Name = "btnRegisterVehicle";
            btnRegisterVehicle.Size = new Size(140, 80);
            btnRegisterVehicle.TabIndex = 19;
            btnRegisterVehicle.UseVisualStyleBackColor = false;
            // 
            // txtTypeOfLicense
            // 
            txtTypeOfLicense.Location = new Point(191, 256);
            txtTypeOfLicense.Name = "txtTypeOfLicense";
            txtTypeOfLicense.Size = new Size(177, 31);
            txtTypeOfLicense.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 317);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 25;
            label2.Text = "Vehicle:";
            // 
            // DriverForm
            // 
            ClientSize = new Size(1080, 612);
            Controls.Add(label2);
            Controls.Add(txtTypeOfLicense);
            Controls.Add(dgvVehicle);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegisterVehicle);
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
            Name = "DriverForm";
            Load += DriverForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public DriverForm(DriverController driverController, VehicleController vehicleController)
        {
            _driverController = driverController;
            _vehicleController = vehicleController;
            InitializeComponent();
            LoadVehicles();
        }
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDni;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private DateTimePicker dtpBirthDate;
        private ComboBox cmbVehicle;

        private void LoadVehicles()
        {
            var vehicles = _vehicleController.GetAllVehicles();
            cmbVehicle.DataSource = vehicles;
            cmbVehicle.DisplayMember = "Plate";
            cmbVehicle.ValueMember = "VehicleId";
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            dgvDriver.AllowUserToAddRows = true;
            dgvDriver.DataSource = _driverController.GetAllDrivers();
        }

        private void btnRegisterDriver_Click(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text;
            var lastName = txtFirstName.Text;
            var dni = txtLastName.Text;
            var phoneNumber = txtDni.Text;
            var address = txtPhoneNumber.Text;
            var typeOfLicense = txtAddress.Text;
            var birthDate = dtpBirthDate.Value;
            var vehicleId = (int)cmbVehicle.SelectedValue;

            var result = _driverController.AddDriver(firstName, lastName, dni, phoneNumber, address, typeOfLicense, birthDate, vehicleId);

            if (result)
            {
                MessageBox.Show("Driver registered successfully!");
            }
            else
            {
                MessageBox.Show("Error registering driver.");
            }
        }

        private void dgvDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
