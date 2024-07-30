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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto___CS.View
{
    public partial class VehicleForm : Form
    {
        private readonly VehicleController _vehicleController;
        private int VehicleId;
        ErrorProvider errorP = new ErrorProvider();


        public VehicleForm(VehicleController vehicleController)
        {
            _vehicleController = vehicleController;
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnRegisterVehicle.Enabled = false;
            btnUpdate.Enabled = false;
            btnView.Enabled = true;

        }

        private void Load_Vehicle()
        {
            try
            {
                dgvVehicle.DataSource = _vehicleController.GetAllVehicles();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CleanData()
        {
            txtPlate.Clear();
            txtModel.Clear();
            txtMileage.Clear();
            txtFuelConsumption.Clear();
            dtpManufacturingDate.Value = DateTime.Now;
        }

        private void btnRegisterVehicle_Click(object sender, EventArgs e)
        {
            // Obtener los datos de los controles del formulario
            string plate = txtPlate.Text;
            string model = txtModel.Text;
            double mileage = Convert.ToDouble(txtMileage.Text);
            double fuelConsumption = double.Parse(txtFuelConsumption.Text);
            DateTime manufacturingDate = dtpManufacturingDate.Value;

            // Validar los datos
            if (string.IsNullOrEmpty(plate) || string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                btnRegisterVehicle.Enabled=true;




            // Usar el controlador para agregar el vehículo
            bool success = _vehicleController.AddVehicle(plate, model, mileage, fuelConsumption, manufacturingDate);

            if (success)
            {
                MessageBox.Show("Vehículo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos del formulario
                CleanData();
            }
            else
            {
                MessageBox.Show("Error al guardar el vehículo. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Are you sure you want to update this item?", "Update"
                , botones, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {

                    if (true)
                    {
                        MessageBox.Show("Successfully Update");
                        Load_Vehicle();
                        CleanData();
                    }
                    else
                        MessageBox.Show("Could Not Update");

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnView.Enabled = false;
                    btnRegisterVehicle.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

                    if (_vehicleController.RemoveVehicle(VehicleId))
                    {
                        MessageBox.Show("Successfully Deleted");
                        Load_Vehicle();
                        CleanData();
                    }
                    else
                        MessageBox.Show("Could Not Delete");


                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnView.Enabled = false;
                    btnRegisterVehicle.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Load_Vehicle();
        }

        private void dgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehicle.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = dgvVehicle.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVehicle.Rows[SelectedRowIndex];
                // Take Data
                VehicleId = Convert.ToInt16(selectedRow.Cells["VehicleId"].Value.ToString());
                txtPlate.Text = selectedRow.Cells["Plate"].Value.ToString();
                txtModel.Text = selectedRow.Cells["Model"].Value.ToString();
                txtMileage.Text = selectedRow.Cells["Mileage"].Value.ToString();
                txtFuelConsumption.Text = selectedRow.Cells["FuelConsumption"].Value.ToString();
                dtpManufacturingDate.Value = Convert.ToDateTime(selectedRow.Cells["ManufacturingDate"].Value.ToString());
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnRegisterVehicle.Enabled = false;
            btnView.Enabled = false;
        }

        private void btnRegisterVehicle_MouseHover(object sender, EventArgs e)
        {
            var tt = new System.Windows.Forms.ToolTip();
            tt.SetToolTip(btnRegisterVehicle, "Save");
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            var tt = new System.Windows.Forms.ToolTip();
            tt.SetToolTip(btnUpdate, "Update");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            var tt = new System.Windows.Forms.ToolTip();
            tt.SetToolTip(btnDelete, "Delete");
        }

        private void btnView_MouseHover(object sender, EventArgs e)
        {
            var tt = new System.Windows.Forms.ToolTip();
            tt.SetToolTip(btnView, "View List");
        }
        public void NoEmpty(System.Windows.Forms.TextBox txt)
        {
            if (ValidateInputData.TxtEmpty(txt))
                errorP.SetError(txt, "No puede dejar el campo Vacio");
            else errorP.Clear();
        }


        public void OnlyNumber(KeyPressEventArgs e, System.Windows.Forms.TextBox txt)
        {
            bool valida = ValidateInputData.OnlyNumber(e, txt);
            if (!valida)
                errorP.SetError(txt, "Al menos 3 numeros");
            else
                errorP.Clear();
        }
    }
}
