﻿using System.Runtime.InteropServices;
using Proyecto___CS.Controller;
using Proyecto___CS.View;
using Microsoft.Extensions.DependencyInjection;
using ConstruccionProyecto.Model.Entitys;

namespace Proyecto___CS.View
{
    public partial class GeneralForm : Form
    {
        private readonly VehicleController vehicleController;
        private readonly IServiceProvider serviceProvider;

        public GeneralForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.serviceProvider = serviceProvider;
        }

        // Para Poder Arrastrar El Frame
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void OpenForm<TForm>() where TForm : Form
        {
            if (this.pnlContent.Controls.Count > 0)
                this.pnlContent.Controls.RemoveAt(0);

            Form form = serviceProvider.GetRequiredService<TForm>();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(form);
            this.pnlContent.Tag = form;
            form.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bntRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Are you sure you want to shut down the system?", "shut down"
                , botones, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            OpenForm<VehicleForm>();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            OpenForm<DriverForm>();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            OpenForm<RouteForm>();
        }
    }
}
