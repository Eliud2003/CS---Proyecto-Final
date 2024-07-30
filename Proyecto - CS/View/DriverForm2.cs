using ConstruccionProyecto.Model.Entitys;
using Proyecto___CS.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___CS.View
{
    public partial class DriverForm2 : Form
    {
        private readonly DriverController _driverController;
        private readonly VehicleController _vehicleController;
        private int DriverId;
        ErrorProvider errorP = new ErrorProvider();

        public DriverForm2(DriverController driverController, VehicleController vehicleController)
        {
            _driverController = driverController;
            _vehicleController = vehicleController;
            InitializeComponent();

            // cmbVehicle
            cmbVehicle.DisplayMember = "Plate"; 
            cmbVehicle.ValueMember = "VehicleId";
            cmbVehicle.DataSource = _vehicleController.GetAllVehicles();
        }

        private void DriverForm2_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
            btnView.Enabled = true;
        }

        private void Load_Driver()
        {
            try
            {
                dgvDriver.DataSource = _driverController.GetAllDrivers();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CleanData()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDni.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtTypeOfLicense.Clear();
            dtpBirthDate.Value = DateTime.Now;
            cmbVehicle.SelectedIndex = 0;
        }

        private void dgvDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDriver.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = dgvDriver.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvDriver.Rows[SelectedRowIndex];
                // Take Data
                DriverId = Convert.ToInt16(selectedRow.Cells["VehicleId"].Value.ToString());
                txtFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtDni.Text = selectedRow.Cells["Dni"].Value.ToString();
                txtPhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtTypeOfLicense.Text = selectedRow.Cells["TypeOfLicense"].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(selectedRow.Cells["BirthDate"].Value.ToString());
                cmbVehicle.SelectedValue = selectedRow.Cells["Vehicle"].Value;
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnRegister.Enabled = false;
            btnView.Enabled = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get the data from the form controls
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string dni = txtDni.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string typeOfLicense = txtTypeOfLicense.Text;
            DateTime birthDate = dtpBirthDate.Value;
            int vehicle = Convert.ToInt16(cmbVehicle.SelectedValue.ToString());

            // Validate the data
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Please complete all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use the driver to add the Driver
            bool success = _driverController.AddDriver(firstName, lastName, dni, phoneNumber, address, typeOfLicense, birthDate, vehicle);

            if (success)
            {
                MessageBox.Show("Driver saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear the form fields
                CleanData();
                Load_Driver();
            }
            else
            {
                MessageBox.Show("Error saving driver. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Obtener los datos de los controles del formulario
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string dni = txtDni.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string typeOfLicense = txtTypeOfLicense.Text;
            DateTime birthDate = dtpBirthDate.Value;
            int vehicle = Convert.ToInt16(cmbVehicle.SelectedValue.ToString());

            // Validar los datos
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Please complete all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use the driver to add the Driver
            bool success = _driverController.UpdateDriver(DriverId,firstName, lastName, dni, phoneNumber, address, typeOfLicense, birthDate, vehicle);

            if (success)
            {
                MessageBox.Show("Driver update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear the form fields
                CleanData();
                Load_Driver();
            }
            else
            {
                MessageBox.Show("Error update driver. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this item?", "Deleted"
                , botones, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {

                    if (_vehicleController.RemoveVehicle(DriverId))
                    {
                        MessageBox.Show("Successfully Deleted");
                        Load_Driver();
                        CleanData();
                    }
                    else
                        MessageBox.Show("Could Not Delete");


                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnView.Enabled = false;
                    btnRegister.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Load_Driver() ;
        }
    }
}
