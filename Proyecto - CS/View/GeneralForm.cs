using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;
using Proyecto___CS.Controller;
using Proyecto___CS.View;
using static System.Formats.Asn1.AsnWriter;

namespace Proyecto___CS.View
{
    public partial class GeneralForm : Form
    {
        private readonly VehicleController vehicleController;
        public GeneralForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.serviceProvider = serviceProvider;
        }
        //Para Poder Arrastra El Frame
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void OpenForm(object formhija)
        {

            if (this.pnlContent.Controls.Count > 0)
                this.pnlContent.Controls.RemoveAt(0);
            Form? fh = formhija as Form;
            #pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            fh.TopLevel = false;
            #pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            fh.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(fh);
            this.pnlContent.Tag = fh;
            fh.Update();
            fh.Show();

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
            this.Close();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            OpenForm<MainMenu>();
        }
    }
}
