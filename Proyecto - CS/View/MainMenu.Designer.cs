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
            txtPlate.Location = new Point(153, 65);
            txtPlate.Margin = new Padding(4, 5, 4, 5);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(220, 31);
            txtPlate.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(153, 121);
            txtModel.Margin = new Padding(4, 5, 4, 5);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(220, 31);
            txtModel.TabIndex = 1;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(153, 176);
            txtMileage.Margin = new Padding(4, 5, 4, 5);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(220, 31);
            txtMileage.TabIndex = 2;
            // 
            // txtFuelConsumption
            // 
            txtFuelConsumption.Location = new Point(232, 229);
            txtFuelConsumption.Margin = new Padding(4, 5, 4, 5);
            txtFuelConsumption.Name = "txtFuelConsumption";
            txtFuelConsumption.Size = new Size(141, 31);
            txtFuelConsumption.TabIndex = 3;
            // 
            // dtpManufacturingDate
            // 
            dtpManufacturingDate.CustomFormat = "dd-MM-yyyy";
            dtpManufacturingDate.Location = new Point(232, 288);
            dtpManufacturingDate.Margin = new Padding(4, 5, 4, 5);
            dtpManufacturingDate.Name = "dtpManufacturingDate";
            dtpManufacturingDate.Size = new Size(141, 31);
            dtpManufacturingDate.TabIndex = 4;
            // 
            // btnRegisterVehicle
            // 
            btnRegisterVehicle.Image = Properties.Resources.Save;
            btnRegisterVehicle.Location = new Point(56, 363);
            btnRegisterVehicle.Margin = new Padding(4, 5, 4, 5);
            btnRegisterVehicle.Name = "btnRegisterVehicle";
            btnRegisterVehicle.Size = new Size(140, 65);
            btnRegisterVehicle.TabIndex = 5;
            btnRegisterVehicle.UseVisualStyleBackColor = true;
            btnRegisterVehicle.Click += btnRegisterVehicle_Click;
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(56, 71);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(50, 25);
            lblPlate.TabIndex = 6;
            lblPlate.Text = "Plate";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(56, 127);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(63, 25);
            lblModel.TabIndex = 7;
            lblModel.Text = "Model";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(56, 182);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(74, 25);
            lblMileage.TabIndex = 8;
            lblMileage.Text = "Mileage";
            // 
            // lblFuelConsumption
            // 
            lblFuelConsumption.AutoSize = true;
            lblFuelConsumption.Location = new Point(56, 235);
            lblFuelConsumption.Name = "lblFuelConsumption";
            lblFuelConsumption.Size = new Size(157, 25);
            lblFuelConsumption.TabIndex = 9;
            lblFuelConsumption.Text = "Fuel Consumption";
            // 
            // lblManufacturingDate
            // 
            lblManufacturingDate.AutoSize = true;
            lblManufacturingDate.Location = new Point(56, 293);
            lblManufacturingDate.Name = "lblManufacturingDate";
            lblManufacturingDate.Size = new Size(169, 25);
            lblManufacturingDate.TabIndex = 10;
            lblManufacturingDate.Text = "Manufacturing Date";
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.Update;
            btnUpdate.Location = new Point(233, 364);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 64);
            btnUpdate.TabIndex = 11;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.Delete;
            btnDelete.Location = new Point(56, 438);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 64);
            btnDelete.TabIndex = 12;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.Image = Properties.Resources.View;
            btnView.Location = new Point(233, 438);
            btnView.Margin = new Padding(4, 5, 4, 5);
            btnView.Name = "btnView";
            btnView.Size = new Size(140, 64);
            btnView.TabIndex = 13;
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // dgvVehicle
            // 
            dgvVehicle.BackgroundColor = SystemColors.ButtonFace;
            dgvVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicle.Location = new Point(403, 65);
            dgvVehicle.Name = "dgvVehicle";
            dgvVehicle.RowHeadersWidth = 62;
            dgvVehicle.Size = new Size(604, 437);
            dgvVehicle.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(677, 46);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 15;
            label1.Text = "Vehicle";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 556);
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
            Margin = new Padding(4, 5, 4, 5);
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