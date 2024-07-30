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
            txtTravelPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRoute).BeginInit();
            SuspendLayout();
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Location = new Point(543, 20);
            lblRoute.Margin = new Padding(2, 0, 2, 0);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(48, 20);
            lblRoute.TabIndex = 31;
            lblRoute.Text = "Route";
            // 
            // dgvRoute
            // 
            dgvRoute.BackgroundColor = SystemColors.ButtonFace;
            dgvRoute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoute.Location = new Point(320, 42);
            dgvRoute.Margin = new Padding(2);
            dgvRoute.Name = "dgvRoute";
            dgvRoute.RowHeadersWidth = 62;
            dgvRoute.Size = new Size(502, 383);
            dgvRoute.TabIndex = 30;
            dgvRoute.CellClick += dgvRoute_CellClick;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ButtonFace;
            btnView.Image = Properties.Resources.view;
            btnView.Location = new Point(184, 362);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(112, 63);
            btnView.TabIndex = 29;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            btnView.MouseHover += btnView_MouseHover;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(43, 362);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 63);
            btnDelete.TabIndex = 28;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseHover += btnDelete_MouseHover;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.Image = Properties.Resources.Update;
            btnUpdate.Location = new Point(184, 279);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 64);
            btnUpdate.TabIndex = 27;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseHover += btnUpdate_MouseHover;
            // 
            // lblTravelPrice
            // 
            lblTravelPrice.AutoSize = true;
            lblTravelPrice.Location = new Point(29, 223);
            lblTravelPrice.Margin = new Padding(2, 0, 2, 0);
            lblTravelPrice.Name = "lblTravelPrice";
            lblTravelPrice.Size = new Size(84, 20);
            lblTravelPrice.TabIndex = 26;
            lblTravelPrice.Text = "Travel Price";
            // 
            // lblTravelDurationTime
            // 
            lblTravelDurationTime.AutoSize = true;
            lblTravelDurationTime.Location = new Point(29, 178);
            lblTravelDurationTime.Margin = new Padding(2, 0, 2, 0);
            lblTravelDurationTime.Name = "lblTravelDurationTime";
            lblTravelDurationTime.Size = new Size(183, 20);
            lblTravelDurationTime.TabIndex = 25;
            lblTravelDurationTime.Text = "Travel Duration Time (H:S)";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(29, 135);
            lblDistance.Margin = new Padding(2, 0, 2, 0);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(66, 20);
            lblDistance.TabIndex = 24;
            lblDistance.Text = "Distance";
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(29, 92);
            lblDestination.Margin = new Padding(2, 0, 2, 0);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(85, 20);
            lblDestination.TabIndex = 23;
            lblDestination.Text = "Destination";
            // 
            // lbOrigin
            // 
            lbOrigin.AutoSize = true;
            lbOrigin.Location = new Point(30, 46);
            lbOrigin.Margin = new Padding(2, 0, 2, 0);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new Size(50, 20);
            lbOrigin.TabIndex = 22;
            lbOrigin.Text = "Origin";
            // 
            // btnRegisterVehicle
            // 
            btnRegisterVehicle.BackColor = SystemColors.ButtonFace;
            btnRegisterVehicle.Image = Properties.Resources.save;
            btnRegisterVehicle.Location = new Point(43, 279);
            btnRegisterVehicle.Margin = new Padding(3, 4, 3, 4);
            btnRegisterVehicle.Name = "btnRegisterVehicle";
            btnRegisterVehicle.Size = new Size(112, 64);
            btnRegisterVehicle.TabIndex = 21;
            btnRegisterVehicle.UseVisualStyleBackColor = false;
            btnRegisterVehicle.Click += btnRegisterVehicle_Click;
            btnRegisterVehicle.MouseHover += btnRegisterVehicle_MouseHover;
            // 
            // txtTravelDurationTime
            // 
            txtTravelDurationTime.Location = new Point(210, 173);
            txtTravelDurationTime.Margin = new Padding(3, 4, 3, 4);
            txtTravelDurationTime.Name = "txtTravelDurationTime";
            txtTravelDurationTime.Size = new Size(88, 27);
            txtTravelDurationTime.TabIndex = 19;
            txtTravelDurationTime.Leave += TxtTravelDurationTime_Leave;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(126, 130);
            txtDistance.Margin = new Padding(3, 4, 3, 4);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(170, 27);
            txtDistance.TabIndex = 18;
            txtDistance.Leave += TxtDistance_Leave;
            txtDistance.KeyPress += TxtDistance_KeyPress;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(126, 86);
            txtDestination.Margin = new Padding(3, 4, 3, 4);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(170, 27);
            txtDestination.TabIndex = 17;
            txtDestination.Leave += TxtDestination_Leave;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(126, 42);
            txtOrigin.Margin = new Padding(3, 4, 3, 4);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(170, 27);
            txtOrigin.TabIndex = 16;
            txtOrigin.Leave += TxtOrigin_Leave;
            // 
            // txtTravelPrice
            // 
            txtTravelPrice.Location = new Point(126, 218);
            txtTravelPrice.Margin = new Padding(3, 4, 3, 4);
            txtTravelPrice.Name = "txtTravelPrice";
            txtTravelPrice.Size = new Size(172, 27);
            txtTravelPrice.TabIndex = 32;
            txtTravelPrice.Leave += TxtTravelPrice_Leave;
            txtTravelPrice.KeyPress += TxtTravelPrice_KeyPress;
            // 
            // RouteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 490);
            Controls.Add(txtTravelPrice);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "RouteForm";
            Text = "RouteForm";
            Load += RouteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TxtDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e,txtDistance);
        }

        private void TxtTravelPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e,txtTravelPrice);
        }

        private void TxtTravelPrice_Leave(object sender, EventArgs e)
        {
            NoEmpty(txtTravelPrice);
        }

        private void TxtOrigin_Leave(object sender, EventArgs e)
        {
            NoEmpty(txtOrigin);
        }

        private void TxtDestination_Leave(object sender, EventArgs e)
        {
            NoEmpty(txtDestination);
        }

        private void TxtDistance_Leave(object sender, EventArgs e)
        {
            NoEmpty(txtDistance);
        }

        private void TxtTravelDurationTime_Leave(object sender, EventArgs e)
        {
            NoEmpty(txtTravelDurationTime);
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
        private TextBox txtTravelPrice;
    }
}