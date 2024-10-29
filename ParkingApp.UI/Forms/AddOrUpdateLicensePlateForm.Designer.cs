namespace ParkingApp.UI.Forms
{
    partial class AddOrUpdateLicensePlateForm
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
            label1 = new Label();
            label2 = new Label();
            txtCityCode = new TextBox();
            txtProvienceCode = new TextBox();
            btnCancel = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "City Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Provience Code";
            // 
            // txtCityCode
            // 
            txtCityCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCityCode.Location = new Point(12, 27);
            txtCityCode.Name = "txtCityCode";
            txtCityCode.Size = new Size(217, 23);
            txtCityCode.TabIndex = 2;
            // 
            // txtProvienceCode
            // 
            txtProvienceCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProvienceCode.Location = new Point(12, 82);
            txtProvienceCode.Name = "txtProvienceCode";
            txtProvienceCode.Size = new Size(217, 23);
            txtProvienceCode.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(101, 125);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(182, 125);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddOrUpdateLicensePlateForm
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(279, 188);
            ControlBox = false;
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(txtProvienceCode);
            Controls.Add(txtCityCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddOrUpdateLicensePlateForm";
            Text = "AddOrUpdateLicensePlateForm";
            Load += AddOrUpdateLicensePlateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCityCode;
        private TextBox txtProvienceCode;
        private Button btnCancel;
        private Button btnSubmit;
    }
}