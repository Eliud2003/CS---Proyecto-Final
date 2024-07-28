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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblManufacturingDate = new Label();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(189, 44);
            txtPlate.Margin = new Padding(4, 5, 4, 5);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(220, 31);
            txtPlate.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(189, 100);
            txtModel.Margin = new Padding(4, 5, 4, 5);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(220, 31);
            txtModel.TabIndex = 1;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(189, 155);
            txtMileage.Margin = new Padding(4, 5, 4, 5);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(220, 31);
            txtMileage.TabIndex = 2;
            // 
            // txtFuelConsumption
            // 
            txtFuelConsumption.Location = new Point(189, 208);
            txtFuelConsumption.Margin = new Padding(4, 5, 4, 5);
            txtFuelConsumption.Name = "txtFuelConsumption";
            txtFuelConsumption.Size = new Size(220, 31);
            txtFuelConsumption.TabIndex = 3;
            // 
            // dtpManufacturingDate
            // 
            dtpManufacturingDate.CustomFormat = "dd-MM-yyyy";
            dtpManufacturingDate.Location = new Point(268, 267);
            dtpManufacturingDate.Margin = new Padding(4, 5, 4, 5);
            dtpManufacturingDate.Name = "dtpManufacturingDate";
            dtpManufacturingDate.Size = new Size(141, 31);
            dtpManufacturingDate.TabIndex = 4;
            // 
            // btnRegisterVehicle
            // 
            btnRegisterVehicle.Image = Properties.Resources.Save;
            btnRegisterVehicle.Location = new Point(92, 324);
            btnRegisterVehicle.Margin = new Padding(4, 5, 4, 5);
            btnRegisterVehicle.Name = "btnRegisterVehicle";
            btnRegisterVehicle.Size = new Size(69, 65);
            btnRegisterVehicle.TabIndex = 5;
            btnRegisterVehicle.UseVisualStyleBackColor = true;
            btnRegisterVehicle.Click += btnRegisterVehicle_Click;
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(92, 50);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(50, 25);
            lblPlate.TabIndex = 6;
            lblPlate.Text = "Plate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 106);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 7;
            label1.Text = "Plate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 161);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 8;
            label2.Text = "Plate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 214);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 9;
            label3.Text = "Plate";
            // 
            // lblManufacturingDate
            // 
            lblManufacturingDate.AutoSize = true;
            lblManufacturingDate.Location = new Point(92, 272);
            lblManufacturingDate.Name = "lblManufacturingDate";
            lblManufacturingDate.Size = new Size(169, 25);
            lblManufacturingDate.TabIndex = 10;
            lblManufacturingDate.Text = "Manufacturing Date";
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.Update;
            btnUpdate.Location = new Point(189, 324);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(69, 64);
            btnUpdate.TabIndex = 11;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 556);
            Controls.Add(btnUpdate);
            Controls.Add(lblManufacturingDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblManufacturingDate;
        private Button btnUpdate;
    }
}