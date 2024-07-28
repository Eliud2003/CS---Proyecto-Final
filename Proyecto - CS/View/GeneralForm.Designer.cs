namespace Proyecto___CS.View
{
    partial class GeneralForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            pnlTitle = new Panel();
            lblRol = new Label();
            btnRestore = new PictureBox();
            btnMinimize = new PictureBox();
            btnMaximize = new PictureBox();
            btnClose = new PictureBox();
            pnlVerticalMenu = new Panel();
            lblLogo = new Label();
            panel4 = new Panel();
            btnExit = new Button();
            panel3 = new Panel();
            btnRoute = new Button();
            panel2 = new Panel();
            btnDriver = new Button();
            panel1 = new Panel();
            btnVehicle = new Button();
            pbLogo = new PictureBox();
            pnlContent = new Panel();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            pnlVerticalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(0, 80, 200);
            pnlTitle.Controls.Add(lblRol);
            pnlTitle.Controls.Add(btnRestore);
            pnlTitle.Controls.Add(btnMinimize);
            pnlTitle.Controls.Add(btnMaximize);
            pnlTitle.Controls.Add(btnClose);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1300, 38);
            pnlTitle.TabIndex = 0;
            pnlTitle.MouseDown += panelTitulo_MouseDown;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = SystemColors.Control;
            lblRol.Location = new Point(12, 7);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(228, 25);
            lblRol.TabIndex = 4;
            lblRol.Text = "ADMIN - CAMIONCITO S.A";
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.Image = Properties.Resources.res;
            btnRestore.Location = new Point(1204, 7);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(25, 25);
            btnRestore.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestore.TabIndex = 3;
            btnRestore.TabStop = false;
            btnRestore.Visible = false;
            btnRestore.Click += bntRestaurar_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = Properties.Resources.minimazar;
            btnMinimize.Location = new Point(1164, 7);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimizar_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Image = Properties.Resources.maxi;
            btnMaximize.Location = new Point(1204, 7);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(25, 25);
            btnMaximize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximize.TabIndex = 1;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximizar_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1245, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnCerrar_Click;
            // 
            // pnlVerticalMenu
            // 
            pnlVerticalMenu.BackColor = Color.FromArgb(26, 32, 40);
            pnlVerticalMenu.Controls.Add(lblLogo);
            pnlVerticalMenu.Controls.Add(panel4);
            pnlVerticalMenu.Controls.Add(btnExit);
            pnlVerticalMenu.Controls.Add(panel3);
            pnlVerticalMenu.Controls.Add(btnRoute);
            pnlVerticalMenu.Controls.Add(panel2);
            pnlVerticalMenu.Controls.Add(btnDriver);
            pnlVerticalMenu.Controls.Add(panel1);
            pnlVerticalMenu.Controls.Add(btnVehicle);
            pnlVerticalMenu.Controls.Add(pbLogo);
            pnlVerticalMenu.Dock = DockStyle.Left;
            pnlVerticalMenu.Location = new Point(0, 38);
            pnlVerticalMenu.Name = "pnlVerticalMenu";
            pnlVerticalMenu.Size = new Size(220, 612);
            pnlVerticalMenu.TabIndex = 1;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BorderStyle = BorderStyle.FixedSingle;
            lblLogo.ForeColor = SystemColors.Control;
            lblLogo.Location = new Point(34, 178);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(154, 27);
            lblLogo.TabIndex = 5;
            lblLogo.Text = "CAMIONCITO S.A";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 523);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 77);
            panel4.TabIndex = 8;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Image = Properties.Resources.exit;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(12, 523);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(205, 77);
            btnExit.TabIndex = 7;
            btnExit.Text = "     Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 440);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 77);
            panel3.TabIndex = 6;
            // 
            // btnRoute
            // 
            btnRoute.FlatAppearance.BorderSize = 0;
            btnRoute.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnRoute.FlatStyle = FlatStyle.Flat;
            btnRoute.ForeColor = SystemColors.ButtonFace;
            btnRoute.Image = Properties.Resources.travel;
            btnRoute.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoute.Location = new Point(12, 440);
            btnRoute.Name = "btnRoute";
            btnRoute.Size = new Size(205, 77);
            btnRoute.TabIndex = 5;
            btnRoute.Text = "     Route";
            btnRoute.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(0, 357);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 77);
            panel2.TabIndex = 4;
            // 
            // btnDriver
            // 
            btnDriver.FlatAppearance.BorderSize = 0;
            btnDriver.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnDriver.FlatStyle = FlatStyle.Flat;
            btnDriver.ForeColor = SystemColors.ButtonFace;
            btnDriver.Image = Properties.Resources.Volante;
            btnDriver.ImageAlign = ContentAlignment.MiddleLeft;
            btnDriver.Location = new Point(12, 357);
            btnDriver.Name = "btnDriver";
            btnDriver.Size = new Size(205, 77);
            btnDriver.TabIndex = 3;
            btnDriver.Text = "     Driver";
            btnDriver.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(0, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 77);
            panel1.TabIndex = 2;
            // 
            // btnVehicle
            // 
            btnVehicle.FlatAppearance.BorderSize = 0;
            btnVehicle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnVehicle.FlatStyle = FlatStyle.Flat;
            btnVehicle.ForeColor = SystemColors.ButtonFace;
            btnVehicle.Image = Properties.Resources.vehiculo;
            btnVehicle.ImageAlign = ContentAlignment.TopLeft;
            btnVehicle.Location = new Point(12, 274);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Size = new Size(205, 77);
            btnVehicle.TabIndex = 1;
            btnVehicle.Text = "     Vehiculos";
            btnVehicle.UseVisualStyleBackColor = true;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Logo;
            pbLogo.Location = new Point(12, -31);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(199, 260);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(49, 66, 82);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 38);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1080, 612);
            pnlContent.TabIndex = 2;
            // 
            // GeneralForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(pnlContent);
            Controls.Add(pnlVerticalMenu);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GeneralForm";
            Text = "GeneralForm";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestore).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            pnlVerticalMenu.ResumeLayout(false);
            pnlVerticalMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Panel pnlVerticalMenu;
        private Panel pnlContent;
        private PictureBox btnClose;
        private PictureBox btnRestore;
        private PictureBox btnMinimize;
        private PictureBox btnMaximize;
        private PictureBox pbLogo;
        private Button btnVehicle;
        private Panel panel1;
        private Panel panel4;
        private Button btnExit;
        private Panel panel3;
        private Button btnRoute;
        private Panel panel2;
        private Button btnDriver;
        private Label lblRol;
        private Label lblLogo;
    }
}