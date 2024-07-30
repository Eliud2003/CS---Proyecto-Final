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
    public partial class RouteForm : Form
    {
        private readonly RouteController _routeController;
        private int RouteId;
        ErrorProvider errorP = new ErrorProvider();
        public RouteForm(RouteController routeController)
        {
            _routeController = routeController;
            InitializeComponent();
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnRegisterVehicle.Enabled = true;
            btnUpdate.Enabled = false;
            btnView.Enabled = true;
        }

        private void Load_Route()
        {
            try
            {
                dgvRoute.DataSource = _routeController.GetAllRoutes();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CleanData()
        {
            txtOrigin.Clear();
            txtDestination.Clear();
            txtDistance.Clear();
            txtTravelDurationTime.Clear();
            txtTravelPrice.Clear();
        }

        private void dgvRoute_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRoute.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = dgvRoute.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvRoute.Rows[SelectedRowIndex];
                // Take Data
                RouteId = Convert.ToInt16(selectedRow.Cells["VehicleId"].Value.ToString());
                txtOrigin.Text = selectedRow.Cells["Plate"].Value.ToString();
                txtDestination.Text = selectedRow.Cells["Model"].Value.ToString();
                txtDistance.Text = selectedRow.Cells["Mileage"].Value.ToString();
                txtTravelDurationTime.Text = selectedRow.Cells["FuelConsumption"].Value.ToString();
                txtTravelPrice.Text = selectedRow.Cells["ManufacturingDate"].Value.ToString();
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnRegisterVehicle.Enabled = false;
            btnView.Enabled = false;
        }

        private void btnRegisterVehicle_Click(object sender, EventArgs e)
        {
            // Obtener los datos de los controles del formulario
            string origin = txtOrigin.Text;
            string destination = txtDestination.Text;
            double distance = Convert.ToDouble(txtDistance.Text);
            TimeSpan travelDurationTime = TimeSpan.Parse(txtTravelDurationTime.Text);
            double travelPrice = double.Parse(txtTravelPrice.Text);

            // Validar los datos
            if (string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Usar el controlador para agregar el vehículo
            bool success = _routeController.AddRoute(origin, destination, distance, travelDurationTime, travelPrice);
            if (success)
            {
                MessageBox.Show("Ruta guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos del formulario
                CleanData();
                Load_Route();


            }
            else
            {
                MessageBox.Show("Error al guardar la Ruta. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Obtener los datos de los controles del formulario
            string origin = txtOrigin.Text;
            string destination = txtDestination.Text;
            double distance = Convert.ToDouble(txtDistance.Text);
            TimeSpan travelDurationTime = TimeSpan.Parse(txtTravelDurationTime.Text);
            double travelPrice = double.Parse(txtTravelPrice.Text);

            // Validar los datos
            if (string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Usar el controlador para agregar el vehículo
            bool success = _routeController.UpdateRoute(RouteId, origin, destination, distance, travelDurationTime, travelPrice);
            if (success)
            {
                MessageBox.Show("Ruta actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos del formulario
                CleanData();
                Load_Route();


            }
            else
            {
                MessageBox.Show("Error al actualizar la Ruta. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    if (_routeController.RemoveRoute(RouteId))
                    {
                        MessageBox.Show("Successfully Deleted");
                        Load_Route();
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
            Load_Route();
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
    }
}
