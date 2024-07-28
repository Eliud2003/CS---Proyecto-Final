namespace Proyecto___CS.View
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            txtPlate = new TextBox();
            txtModel = new TextBox();
            txtMileage = new TextBox();
            txtFuelConsumption = new TextBox();
            dtpManufacturingDate = new DateTimePicker();
            btnRegisterVehicle = new Button();
            lblPlate = new Label();
            lblModel = new Label();
            lblMileage = new Label();
            lblFuelConsumption = new Label();
            lblManufacturingDate = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnView = new Button();
            dgvVehicle = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).BeginInit();
            SuspendLayout();
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(122, 52);
            txtPlate.Margin = new Padding(3, 4, 3, 4);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(177, 27);
            txtPlate.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(122, 97);
            txtModel.Margin = new Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(177, 27);
            txtModel.TabIndex = 1;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(122, 141);
            txtMileage.Margin = new Padding(3, 4, 3, 4);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(177, 27);
            txtMileage.TabIndex = 2;
            // 
            // txtFuelConsumption
            // 
            txtFuelConsumption.Location = new Point(186, 183);
            txtFuelConsumption.Margin = new Padding(3, 4, 3, 4);
            txtFuelConsumption.Name = "txtFuelConsumption";
            txtFuelConsumption.Size = new Size(114, 27);
            txtFuelConsumption.TabIndex = 3;
            // 
            // dtpManufacturingDate
            // 
            dtpManufacturingDate.CustomFormat = "dd-MM-yyyy";
            dtpManufacturingDate.Location = new Point(186, 230);
            dtpManufacturingDate.Margin = new Padding(3, 4, 3, 4);
            dtpManufacturingDate.Name = "dtpManufacturingDate";
            dtpManufacturingDate.Size = new Size(114, 27);
            dtpManufacturingDate.TabIndex = 4;
            // 
            // btnRegisterVehicle
            // 
            btnRegisterVehicle.BackColor = Color.FromArgb(192, 255, 192);
            btnRegisterVehicle.Image = Properties.Resources.save;
            btnRegisterVehicle.Location = new Point(45, 290);
            btnRegisterVehicle.Margin = new Padding(3, 4, 3, 4);
            btnRegisterVehicle.Name = "btnRegisterVehicle";
            btnRegisterVehicle.Size = new Size(112, 64);
            btnRegisterVehicle.TabIndex = 5;
            btnRegisterVehicle.UseVisualStyleBackColor = false;
            btnRegisterVehicle.Click += btnRegisterVehicle_Click;
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(45, 57);
            lblPlate.Margin = new Padding(2, 0, 2, 0);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(42, 20);
            lblPlate.TabIndex = 6;
            lblPlate.Text = "Plate";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(45, 102);
            lblModel.Margin = new Padding(2, 0, 2, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 7;
            lblModel.Text = "Model";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(45, 146);
            lblMileage.Margin = new Padding(2, 0, 2, 0);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(63, 20);
            lblMileage.TabIndex = 8;
            lblMileage.Text = "Mileage";
            // 
            // lblFuelConsumption
            // 
            lblFuelConsumption.AutoSize = true;
            lblFuelConsumption.Location = new Point(45, 188);
            lblFuelConsumption.Margin = new Padding(2, 0, 2, 0);
            lblFuelConsumption.Name = "lblFuelConsumption";
            lblFuelConsumption.Size = new Size(128, 20);
            lblFuelConsumption.TabIndex = 9;
            lblFuelConsumption.Text = "Fuel Consumption";
            // 
            // lblManufacturingDate
            // 
            lblManufacturingDate.AutoSize = true;
            lblManufacturingDate.Location = new Point(45, 234);
            lblManufacturingDate.Margin = new Padding(2, 0, 2, 0);
            lblManufacturingDate.Name = "lblManufacturingDate";
            lblManufacturingDate.Size = new Size(141, 20);
            lblManufacturingDate.TabIndex = 10;
            lblManufacturingDate.Text = "Manufacturing Date";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Image = Properties.Resources.Update;
            btnUpdate.Location = new Point(186, 290);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 64);
            btnUpdate.TabIndex = 11;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(45, 372);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 63);
            btnDelete.TabIndex = 12;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ButtonShadow;
            btnView.Image = Properties.Resources.view;
            btnView.Location = new Point(186, 372);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(112, 63);
            btnView.TabIndex = 13;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // dgvVehicle
            // 
            dgvVehicle.BackgroundColor = SystemColors.ButtonFace;
            dgvVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicle.Location = new Point(322, 52);
            dgvVehicle.Margin = new Padding(2);
            dgvVehicle.Name = "dgvVehicle";
            dgvVehicle.RowHeadersWidth = 62;
            dgvVehicle.Size = new Size(483, 383);
            dgvVehicle.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(545, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 15;
            label1.Text = "Vehicle";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 445);
            Controls.Add(label1);
            Controls.Add(dgvVehicle);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblManufacturingDate);
            Controls.Add(lblFuelConsumption);
            Controls.Add(lblMileage);
            Controls.Add(lblModel);
            Controls.Add(lblPlate);
            Controls.Add(btnRegisterVehicle);
            Controls.Add(dtpManufacturingDate);
            Controls.Add(txtFuelConsumption);
            Controls.Add(txtMileage);
            Controls.Add(txtModel);
            Controls.Add(txtPlate);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlate;
        private TextBox txtModel;
        private TextBox txtMileage;
        private TextBox txtFuelConsumption;
        private DateTimePicker dtpManufacturingDate;
        private Button btnRegisterVehicle;
        private Label lblPlate;
        private Label lblModel;
        private Label lblMileage;
        private Label lblFuelConsumption;
        private Label lblManufacturingDate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnView;
        private DataGridView dgvVehicle;
        private Label label1;
    }
}