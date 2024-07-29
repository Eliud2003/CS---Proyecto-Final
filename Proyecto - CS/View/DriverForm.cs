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
        private Label lblDriverId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dgvDriver;
        private Label label1;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRegisterVehicle;
        private readonly VehicleController _vehicleController;

        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtDNI = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAdress = new TextBox();
            txtTypeOfLicense = new TextBox();
            dtpBirth = new DateTimePicker();
            cmbVehicle = new ComboBox();
            lblDriverId = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgvDriver = new DataGridView();
            label1 = new Label();
            btnView = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRegisterVehicle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDriver).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(139, 19);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 31);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(171, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(168, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(485, 62);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(168, 31);
            txtDNI.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(139, 111);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 31);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(488, 105);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(168, 31);
            txtAdress.TabIndex = 4;
            // 
            // txtTypeOfLicense
            // 
            txtTypeOfLicense.Location = new Point(139, 165);
            txtTypeOfLicense.Name = "txtTypeOfLicense";
            txtTypeOfLicense.Size = new Size(200, 31);
            txtTypeOfLicense.TabIndex = 5;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(453, 160);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(200, 31);
            dtpBirth.TabIndex = 6;
            // 
            // cmbVehicle
            // 
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(190, 221);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(149, 33);
            cmbVehicle.TabIndex = 7;
            // 
            // lblDriverId
            // 
            lblDriverId.AutoSize = true;
            lblDriverId.Location = new Point(42, 22);
            lblDriverId.Name = "lblDriverId";
            lblDriverId.Size = new Size(86, 25);
            lblDriverId.TabIndex = 9;
            lblDriverId.Text = "Driver ID:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(45, 62);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(101, 25);
            lblFirstName.TabIndex = 10;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(359, 62);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 117);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 12;
            label4.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 111);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 13;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 165);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 14;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(359, 166);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 15;
            label7.Text = "Birth Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 224);
            label8.Name = "label8";
            label8.Size = new Size(139, 25);
            label8.TabIndex = 16;
            label8.Text = "Type Of Licence:";
            // 
            // dgvDriver
            // 
            dgvDriver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDriver.Location = new Point(686, 62);
            dgvDriver.Name = "dgvDriver";
            dgvDriver.RowHeadersWidth = 62;
            dgvDriver.Size = new Size(322, 399);
            dgvDriver.TabIndex = 17;
            dgvDriver.CellContentClick += dgvDriver_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(812, 22);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 18;
            label1.Text = "Driver";
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ButtonShadow;
            btnView.Image = Properties.Resources.view;
            btnView.Location = new Point(239, 395);
            btnView.Margin = new Padding(4, 5, 4, 5);
            btnView.Name = "btnView";
            btnView.Size = new Size(140, 79);
            btnView.TabIndex = 22;
            btnView.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(63, 395);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 79);
            btnDelete.TabIndex = 21;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Image = Properties.Resources.Update;
            btnUpdate.Location = new Point(239, 292);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 80);
            btnUpdate.TabIndex = 20;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRegisterVehicle
            // 
            btnRegisterVehicle.BackColor = Color.FromArgb(192, 255, 192);
            btnRegisterVehicle.Image = Properties.Resources.save;
            btnRegisterVehicle.Location = new Point(63, 292);
            btnRegisterVehicle.Margin = new Padding(4, 5, 4, 5);
            btnRegisterVehicle.Name = "btnRegisterVehicle";
            btnRegisterVehicle.Size = new Size(140, 80);
            btnRegisterVehicle.TabIndex = 19;
            btnRegisterVehicle.UseVisualStyleBackColor = false;
            // 
            // DriverForm
            // 
            ClientSize = new Size(1058, 556);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegisterVehicle);
            Controls.Add(label1);
            Controls.Add(dgvDriver);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblDriverId);
            Controls.Add(cmbVehicle);
            Controls.Add(dtpBirth);
            Controls.Add(txtTypeOfLicense);
            Controls.Add(txtAdress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtDNI);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DriverForm";
            Load += DriverForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDriver).EndInit();
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
        private TextBox txtDNI;
        private TextBox txtPhoneNumber;
        private TextBox txtAdress;
        private TextBox txtTypeOfLicense;
        private DateTimePicker dtpBirth;
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
            var lastName = txtLastName.Text;
            var dni = txtDNI.Text;
            var phoneNumber = txtPhoneNumber.Text;
            var address = txtAdress.Text;
            var typeOfLicense = txtTypeOfLicense.Text;
            var birthDate = dtpBirth.Value;
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
    }
}
