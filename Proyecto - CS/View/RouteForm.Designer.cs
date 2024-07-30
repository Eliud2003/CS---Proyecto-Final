namespace Proyecto___CS.View
{
    partial class RouteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteForm));
            lblRoute = new Label();
            dgvRoute = new DataGridView();
            btnView = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblTravelPrice = new Label();
            lblTravelDurationTime = new Label();
            lblDistance = new Label();
            lblDestination = new Label();
            lbOrigin = new Label();
            btnRegisterVehicle = new Button();
            txtTravelDurationTime = new TextBox();
            txtDistance = new TextBox();
            txtDestination = new TextBox();
            txtOrigin = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRoute).BeginInit();
            SuspendLayout();
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Location = new Point(679, 25);
            lblRoute.Margin = new Padding(2, 0, 2, 0);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(58, 25);
            lblRoute.TabIndex = 31;
            lblRoute.Text = "Route";
            // 
            // dgvRoute
            // 
            dgvRoute.BackgroundColor = SystemColors.ButtonFace;
            dgvRoute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoute.Location = new Point(400, 52);
            dgvRoute.Margin = new Padding(2);
            dgvRoute.Name = "dgvRoute";
            dgvRoute.RowHeadersWidth = 62;
            dgvRoute.Size = new Size(604, 479);
            dgvRoute.TabIndex = 30;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ButtonFace;
            btnView.Image = Properties.Resources.view;
            btnView.Location = new Point(230, 452);
            btnView.Margin = new Padding(4, 5, 4, 5);
            btnView.Name = "btnView";
            btnView.Size = new Size(140, 79);
            btnView.TabIndex = 29;
            btnView.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(54, 452);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 79);
            btnDelete.TabIndex = 28;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.Image = Properties.Resources.Update;
            btnUpdate.Location = new Point(230, 349);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 80);
            btnUpdate.TabIndex = 27;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lblTravelPrice
            // 
            lblTravelPrice.AutoSize = true;
            lblTravelPrice.Location = new Point(43, 279);
            lblTravelPrice.Margin = new Padding(2, 0, 2, 0);
            lblTravelPrice.Name = "lblTravelPrice";
            lblTravelPrice.Size = new Size(98, 25);
            lblTravelPrice.TabIndex = 26;
            lblTravelPrice.Text = "Travel Price";
            // 
            // lblTravelDurationTime
            // 
            lblTravelDurationTime.AutoSize = true;
            lblTravelDurationTime.Location = new Point(43, 222);
            lblTravelDurationTime.Margin = new Padding(2, 0, 2, 0);
            lblTravelDurationTime.Name = "lblTravelDurationTime";
            lblTravelDurationTime.Size = new Size(173, 25);
            lblTravelDurationTime.TabIndex = 25;
            lblTravelDurationTime.Text = "Travel Duration Time";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(43, 169);
            lblDistance.Margin = new Padding(2, 0, 2, 0);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(79, 25);
            lblDistance.TabIndex = 24;
            lblDistance.Text = "Distance";
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(43, 115);
            lblDestination.Margin = new Padding(2, 0, 2, 0);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(102, 25);
            lblDestination.TabIndex = 23;
            lblDestination.Text = "Destination";
            // 
            // lbOrigin
            // 
            lbOrigin.AutoSize = true;
            lbOrigin.Location = new Point(43, 58);
            lbOrigin.Margin = new Padding(2, 0, 2, 0);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new Size(61, 25);
            lbOrigin.TabIndex = 22;
            lbOrigin.Text = "Origin";
            // 
            // btnRegisterVehicle
            // 
            btnRegisterVehicle.BackColor = SystemColors.ButtonFace;
            btnRegisterVehicle.Image = Properties.Resources.save;
            btnRegisterVehicle.Location = new Point(54, 349);
            btnRegisterVehicle.Margin = new Padding(4, 5, 4, 5);
            btnRegisterVehicle.Name = "btnRegisterVehicle";
            btnRegisterVehicle.Size = new Size(140, 80);
            btnRegisterVehicle.TabIndex = 21;
            btnRegisterVehicle.UseVisualStyleBackColor = false;
            // 
            // txtTravelDurationTime
            // 
            txtTravelDurationTime.Location = new Point(230, 216);
            txtTravelDurationTime.Margin = new Padding(4, 5, 4, 5);
            txtTravelDurationTime.Name = "txtTravelDurationTime";
            txtTravelDurationTime.Size = new Size(142, 31);
            txtTravelDurationTime.TabIndex = 19;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(158, 163);
            txtDistance.Margin = new Padding(4, 5, 4, 5);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(212, 31);
            txtDistance.TabIndex = 18;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(158, 108);
            txtDestination.Margin = new Padding(4, 5, 4, 5);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(212, 31);
            txtDestination.TabIndex = 17;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(158, 52);
            txtOrigin.Margin = new Padding(4, 5, 4, 5);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(212, 31);
            txtOrigin.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 273);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 31);
            textBox1.TabIndex = 32;
            // 
            // RouteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 556);
            Controls.Add(textBox1);
            Controls.Add(lblRoute);
            Controls.Add(dgvRoute);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblTravelPrice);
            Controls.Add(lblTravelDurationTime);
            Controls.Add(lblDistance);
            Controls.Add(lblDestination);
            Controls.Add(lbOrigin);
            Controls.Add(btnRegisterVehicle);
            Controls.Add(txtTravelDurationTime);
            Controls.Add(txtDistance);
            Controls.Add(txtDestination);
            Controls.Add(txtOrigin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RouteForm";
            Text = "RouteForm";
            ((System.ComponentModel.ISupportInitialize)dgvRoute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoute;
        private DataGridView dgvRoute;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblTravelPrice;
        private Label lblTravelDurationTime;
        private Label lblDistance;
        private Label lblDestination;
        private Label lbOrigin;
        private Button btnRegisterVehicle;
        private TextBox txtTravelDurationTime;
        private TextBox txtDistance;
        private TextBox txtDestination;
        private TextBox txtOrigin;
        private TextBox textBox1;
    }
}