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
            btnRegisterDriver = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(135, 42);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(135, 88);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(135, 135);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(135, 182);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(135, 232);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(100, 23);
            txtAdress.TabIndex = 4;
            // 
            // txtTypeOfLicense
            // 
            txtTypeOfLicense.Location = new Point(135, 276);
            txtTypeOfLicense.Name = "txtTypeOfLicense";
            txtTypeOfLicense.Size = new Size(100, 23);
            txtTypeOfLicense.TabIndex = 5;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(135, 324);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(200, 23);
            dtpBirth.TabIndex = 6;
            // 
            // cmbVehicle
            // 
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(135, 362);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(121, 23);
            cmbVehicle.TabIndex = 7;
            // 
            // btnRegisterDriver
            // 
            btnRegisterDriver.Location = new Point(448, 157);
            btnRegisterDriver.Name = "btnRegisterDriver";
            btnRegisterDriver.Size = new Size(98, 23);
            btnRegisterDriver.TabIndex = 8;
            btnRegisterDriver.Text = "Register Driver";
            btnRegisterDriver.UseVisualStyleBackColor = true;
            btnRegisterDriver.Click += btnRegisterDriver_Click;
            // 
            // DriverForm
            // 
            ClientSize = new Size(745, 407);
            Controls.Add(btnRegisterDriver);
            Controls.Add(cmbVehicle);
            Controls.Add(dtpBirth);
            Controls.Add(txtTypeOfLicense);
            Controls.Add(txtAdress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtDNI);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "DriverForm";
            Load += DriverForm_Load;
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
        private Button btnRegisterDriver;

        private void LoadVehicles()
        {
            var vehicles = _vehicleController.GetAllVehicles();
            cmbVehicle.DataSource = vehicles;
            cmbVehicle.DisplayMember = "Plate";
            cmbVehicle.ValueMember = "VehicleId";
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {

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
    }
}
