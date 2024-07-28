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
            txtPlate = new TextBox();
            txtModel = new TextBox();
            txtMileage = new TextBox();
            txtFuelConsumption = new TextBox();
            dtpManufacturingDate = new DateTimePicker();
            btnRegisterVehicle = new Button();
            SuspendLayout();
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(132, 59);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(100, 23);
            txtPlate.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(132, 105);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 1;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(132, 149);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(100, 23);
            txtMileage.TabIndex = 2;
            // 
            // txtFuelConsumption
            // 
            txtFuelConsumption.Location = new Point(132, 198);
            txtFuelConsumption.Name = "txtFuelConsumption";
            txtFuelConsumption.Size = new Size(100, 23);
            txtFuelConsumption.TabIndex = 3;
            // 
            // dtpManufacturingDate
            // 
            dtpManufacturingDate.Location = new Point(132, 254);
            dtpManufacturingDate.Name = "dtpManufacturingDate";
            dtpManufacturingDate.Size = new Size(200, 23);
            dtpManufacturingDate.TabIndex = 4;
            // 
            // btnRegisterVehicle
            // 
            btnRegisterVehicle.Location = new Point(438, 159);
            btnRegisterVehicle.Name = "btnRegisterVehicle";
            btnRegisterVehicle.Size = new Size(104, 23);
            btnRegisterVehicle.TabIndex = 5;
            btnRegisterVehicle.Text = "Register Vehicle";
            btnRegisterVehicle.UseVisualStyleBackColor = true;
            btnRegisterVehicle.Click += btnRegisterVehicle_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegisterVehicle);
            Controls.Add(dtpManufacturingDate);
            Controls.Add(txtFuelConsumption);
            Controls.Add(txtMileage);
            Controls.Add(txtModel);
            Controls.Add(txtPlate);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
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
    }
}