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
    public partial class MainMenu : Form
    {
        private readonly VehicleController _vehicleController;


        public MainMenu(VehicleController vehicleController)
        {
            _vehicleController = vehicleController;
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {

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




            // Usar el controlador para agregar el vehículo
            bool success = _vehicleController.AddVehicle(plate, model, mileage, fuelConsumption, manufacturingDate);

            if (success)
            {
                MessageBox.Show("Vehículo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos del formulario
                txtPlate.Clear();
                txtModel.Clear();
                txtMileage.Clear();
                txtFuelConsumption.Clear();
                dtpManufacturingDate.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Error al guardar el vehículo. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

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
                    //obj_chofer.IdCHF = indiceCHF;
                    int id = 5;//falta obtener el id del datagridview
                    if (_vehicleController.RemoveVehicle(id))
                    {
                        MessageBox.Show("Successfully Deleted");
                        Load_Vehicle();
                    }
                    else
                        MessageBox.Show("Could Not Delete");

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
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

        private void dgvVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
