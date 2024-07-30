﻿namespace Proyecto___CS.View
{
    partial class VehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleForm));
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
            txtPlate.Location = new Point(152, 65);
            txtPlate.Margin = new Padding(4, 5, 4, 5);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(220, 31);
            txtPlate.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(152, 121);
            txtModel.Margin = new Padding(4, 5, 4, 5);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(220, 31);
            txtModel.TabIndex = 1;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(152, 176);
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
            txtFuelConsumption.Size = new Size(142, 31);
            txtFuelConsumption.TabIndex = 3;
            // 
            // dtpManufacturingDate
            // 
            dtpManufacturingDate.CustomFormat = "dd-MM-yyyy";
            dtpManufacturingDate.Location = new Point(232, 288);
            dtpManufacturingDate.Margin = new Padding(4, 5, 4, 5);
            dtpManufacturingDate.Name = "dtpManufacturingDate";
            dtpManufacturingDate.Size = new Size(142, 31);
            dtpManufacturingDate.TabIndex = 4;
            // 
            // btnRegisterVehicle
            // 
            btnRegisterVehicle.BackColor = SystemColors.ButtonFace;
            btnRegisterVehicle.Image = Properties.Resources.save;
            btnRegisterVehicle.Location = new Point(56, 362);
            btnRegisterVehicle.Margin = new Padding(4, 5, 4, 5);
            btnRegisterVehicle.Name = "btnRegisterVehicle";
            btnRegisterVehicle.Size = new Size(140, 80);
            btnRegisterVehicle.TabIndex = 5;
            btnRegisterVehicle.UseVisualStyleBackColor = false;
            btnRegisterVehicle.Click += btnRegisterVehicle_Click;
            btnRegisterVehicle.MouseHover += btnRegisterVehicle_MouseHover;
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(56, 71);
            lblPlate.Margin = new Padding(2, 0, 2, 0);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(50, 25);
            lblPlate.TabIndex = 6;
            lblPlate.Text = "Plate";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(56, 128);
            lblModel.Margin = new Padding(2, 0, 2, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(63, 25);
            lblModel.TabIndex = 7;
            lblModel.Text = "Model";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(56, 182);
            lblMileage.Margin = new Padding(2, 0, 2, 0);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(74, 25);
            lblMileage.TabIndex = 8;
            lblMileage.Text = "Mileage";
            // 
            // lblFuelConsumption
            // 
            lblFuelConsumption.AutoSize = true;
            lblFuelConsumption.Location = new Point(56, 235);
            lblFuelConsumption.Margin = new Padding(2, 0, 2, 0);
            lblFuelConsumption.Name = "lblFuelConsumption";
            lblFuelConsumption.Size = new Size(157, 25);
            lblFuelConsumption.TabIndex = 9;
            lblFuelConsumption.Text = "Fuel Consumption";
            // 
            // lblManufacturingDate
            // 
            lblManufacturingDate.AutoSize = true;
            lblManufacturingDate.Location = new Point(56, 292);
            lblManufacturingDate.Margin = new Padding(2, 0, 2, 0);
            lblManufacturingDate.Name = "lblManufacturingDate";
            lblManufacturingDate.Size = new Size(169, 25);
            lblManufacturingDate.TabIndex = 10;
            lblManufacturingDate.Text = "Manufacturing Date";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.Image = Properties.Resources.Update;
            btnUpdate.Location = new Point(232, 362);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 80);
            btnUpdate.TabIndex = 11;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseHover += btnUpdate_MouseHover;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(56, 465);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 79);
            btnDelete.TabIndex = 12;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseHover += btnDelete_MouseHover;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ButtonFace;
            btnView.Image = Properties.Resources.view;
            btnView.Location = new Point(232, 465);
            btnView.Margin = new Padding(4, 5, 4, 5);
            btnView.Name = "btnView";
            btnView.Size = new Size(140, 79);
            btnView.TabIndex = 13;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            btnView.MouseHover += btnView_MouseHover;
            // 
            // dgvVehicle
            // 
            dgvVehicle.BackgroundColor = SystemColors.ButtonFace;
            dgvVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicle.Location = new Point(402, 65);
            dgvVehicle.Margin = new Padding(2);
            dgvVehicle.Name = "dgvVehicle";
            dgvVehicle.RowHeadersWidth = 62;
            dgvVehicle.Size = new Size(604, 479);
            dgvVehicle.TabIndex = 14;
            dgvVehicle.CellClick += dgvVehicle_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(681, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
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