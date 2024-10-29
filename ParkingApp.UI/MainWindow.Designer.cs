namespace ParkingApp.UI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabCarOwners = new TabPage();
            dgCarOwners = new DataGridView();
            toolStrip1 = new ToolStrip();
            tsbNewCarOwner = new ToolStripButton();
            tsbUpdateCarOwner = new ToolStripButton();
            tsbDeleteCarOwner = new ToolStripButton();
            tsbRefreshCarOwners = new ToolStripButton();
            tabCars = new TabPage();
            dgCars = new DataGridView();
            toolStrip2 = new ToolStrip();
            tsbNewCar = new ToolStripButton();
            tsbUpdateCar = new ToolStripButton();
            tsbDeleteCar = new ToolStripButton();
            tsbRefreshCars = new ToolStripButton();
            tsbLicensePlate = new ToolStripButton();
            tabControl1.SuspendLayout();
            tabCarOwners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCarOwners).BeginInit();
            toolStrip1.SuspendLayout();
            tabCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCars).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabCarOwners);
            tabControl1.Controls.Add(tabCars);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(720, 455);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabCarOwners
            // 
            tabCarOwners.Controls.Add(dgCarOwners);
            tabCarOwners.Controls.Add(toolStrip1);
            tabCarOwners.Location = new Point(4, 24);
            tabCarOwners.Name = "tabCarOwners";
            tabCarOwners.Padding = new Padding(3);
            tabCarOwners.Size = new Size(712, 427);
            tabCarOwners.TabIndex = 0;
            tabCarOwners.Text = "Car Owners";
            tabCarOwners.UseVisualStyleBackColor = true;
            tabCarOwners.Enter += tabCarOwners_Enter;
            // 
            // dgCarOwners
            // 
            dgCarOwners.AllowUserToAddRows = false;
            dgCarOwners.AllowUserToDeleteRows = false;
            dgCarOwners.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgCarOwners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCarOwners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCarOwners.Location = new Point(6, 31);
            dgCarOwners.MultiSelect = false;
            dgCarOwners.Name = "dgCarOwners";
            dgCarOwners.ReadOnly = true;
            dgCarOwners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCarOwners.Size = new Size(700, 390);
            dgCarOwners.TabIndex = 1;
            dgCarOwners.SelectionChanged += dgCarOwners_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNewCarOwner, tsbUpdateCarOwner, tsbDeleteCarOwner, tsbRefreshCarOwners });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(706, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewCarOwner
            // 
            tsbNewCarOwner.Image = Properties.Resources.Add;
            tsbNewCarOwner.ImageTransparentColor = Color.Magenta;
            tsbNewCarOwner.Name = "tsbNewCarOwner";
            tsbNewCarOwner.Size = new Size(110, 22);
            tsbNewCarOwner.Text = "New Car Owner";
            tsbNewCarOwner.Click += tsbNewCarOwner_Click;
            // 
            // tsbUpdateCarOwner
            // 
            tsbUpdateCarOwner.CheckOnClick = true;
            tsbUpdateCarOwner.Enabled = false;
            tsbUpdateCarOwner.Image = Properties.Resources.Edit;
            tsbUpdateCarOwner.ImageTransparentColor = Color.Magenta;
            tsbUpdateCarOwner.Name = "tsbUpdateCarOwner";
            tsbUpdateCarOwner.Size = new Size(65, 22);
            tsbUpdateCarOwner.Text = "Update";
            tsbUpdateCarOwner.Click += tsbUpdateCarOwner_Click;
            // 
            // tsbDeleteCarOwner
            // 
            tsbDeleteCarOwner.Enabled = false;
            tsbDeleteCarOwner.Image = Properties.Resources.Delete;
            tsbDeleteCarOwner.ImageTransparentColor = Color.Magenta;
            tsbDeleteCarOwner.Name = "tsbDeleteCarOwner";
            tsbDeleteCarOwner.Size = new Size(60, 22);
            tsbDeleteCarOwner.Text = "Delete";
            tsbDeleteCarOwner.Click += tsbDeleteCarOwner_Click;
            // 
            // tsbRefreshCarOwners
            // 
            tsbRefreshCarOwners.Image = Properties.Resources.Refresh;
            tsbRefreshCarOwners.ImageTransparentColor = Color.Magenta;
            tsbRefreshCarOwners.Name = "tsbRefreshCarOwners";
            tsbRefreshCarOwners.Size = new Size(66, 22);
            tsbRefreshCarOwners.Text = "Refresh";
            tsbRefreshCarOwners.Click += tsbRefreshCarOwners_Click;
            // 
            // tabCars
            // 
            tabCars.Controls.Add(dgCars);
            tabCars.Controls.Add(toolStrip2);
            tabCars.Location = new Point(4, 24);
            tabCars.Name = "tabCars";
            tabCars.Padding = new Padding(3);
            tabCars.Size = new Size(712, 427);
            tabCars.TabIndex = 1;
            tabCars.Text = "Cars";
            tabCars.UseVisualStyleBackColor = true;
            // 
            // dgCars
            // 
            dgCars.AllowUserToAddRows = false;
            dgCars.AllowUserToDeleteRows = false;
            dgCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCars.Location = new Point(6, 31);
            dgCars.MultiSelect = false;
            dgCars.Name = "dgCars";
            dgCars.ReadOnly = true;
            dgCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCars.Size = new Size(700, 385);
            dgCars.TabIndex = 1;
            dgCars.SelectionChanged += dgCars_SelectionChanged;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { tsbNewCar, tsbUpdateCar, tsbDeleteCar, tsbRefreshCars, tsbLicensePlate });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(706, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // tsbNewCar
            // 
            tsbNewCar.Image = Properties.Resources.Add;
            tsbNewCar.ImageTransparentColor = Color.Magenta;
            tsbNewCar.Name = "tsbNewCar";
            tsbNewCar.Size = new Size(69, 22);
            tsbNewCar.Text = "NewCar";
            tsbNewCar.Click += tsbNewCar_Click;
            // 
            // tsbUpdateCar
            // 
            tsbUpdateCar.Enabled = false;
            tsbUpdateCar.Image = Properties.Resources.Edit;
            tsbUpdateCar.ImageTransparentColor = Color.Magenta;
            tsbUpdateCar.Name = "tsbUpdateCar";
            tsbUpdateCar.Size = new Size(65, 22);
            tsbUpdateCar.Text = "Update";
            tsbUpdateCar.Click += tsbUpdateCar_Click;
            // 
            // tsbDeleteCar
            // 
            tsbDeleteCar.Enabled = false;
            tsbDeleteCar.Image = Properties.Resources.Delete;
            tsbDeleteCar.ImageTransparentColor = Color.Magenta;
            tsbDeleteCar.Name = "tsbDeleteCar";
            tsbDeleteCar.Size = new Size(60, 22);
            tsbDeleteCar.Text = "Delete";
            tsbDeleteCar.Click += tsbDeleteCar_Click;
            // 
            // tsbRefreshCars
            // 
            tsbRefreshCars.Image = Properties.Resources.Refresh;
            tsbRefreshCars.ImageTransparentColor = Color.Magenta;
            tsbRefreshCars.Name = "tsbRefreshCars";
            tsbRefreshCars.Size = new Size(66, 22);
            tsbRefreshCars.Text = "Refresh";
            tsbRefreshCars.Click += tsbRefreshCars_Click;
            // 
            // tsbLicensePlate
            // 
            tsbLicensePlate.Enabled = false;
            tsbLicensePlate.Image = Properties.Resources.Link;
            tsbLicensePlate.ImageTransparentColor = Color.Magenta;
            tsbLicensePlate.Name = "tsbLicensePlate";
            tsbLicensePlate.Size = new Size(132, 22);
            tsbLicensePlate.Text = "Define License Plate";
            tsbLicensePlate.Click += tsbLicensePlate_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 479);
            Controls.Add(tabControl1);
            Name = "MainWindow";
            Text = "ParkingApp";
            tabControl1.ResumeLayout(false);
            tabCarOwners.ResumeLayout(false);
            tabCarOwners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCarOwners).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabCars.ResumeLayout(false);
            tabCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCars).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCarOwners;
        private TabPage tabCars;
        private ToolStrip toolStrip1;
        private DataGridView dgCarOwners;
        private ToolStripButton tsbNewCarOwner;
        private ToolStripButton tsbRefreshCarOwners;
        private ToolStripButton tsbUpdateCarOwner;
        private DataGridView dgCars;
        private ToolStrip toolStrip2;
        private ToolStripButton tsbNewCar;
        private ToolStripButton tsbUpdateCar;
        private ToolStripButton tsbDeleteCar;
        private ToolStripButton tsbRefreshCars;
        private ToolStripButton tsbDeleteCarOwner;
        private ToolStripButton tsbLicensePlate;
    }
}
