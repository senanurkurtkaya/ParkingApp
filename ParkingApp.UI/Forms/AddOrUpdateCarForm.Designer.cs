namespace ParkingApp.UI.Forms
{
    partial class AddOrUpdateCarForm
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
            txtBrand = new TextBox();
            txtModel = new TextBox();
            label2 = new Label();
            txtColor = new TextBox();
            label3 = new Label();
            txtOwnerIdentityNumber = new TextBox();
            label4 = new Label();
            btnCancel = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 74);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Brand";
            // 
            // txtBrand
            // 
            txtBrand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBrand.Location = new Point(11, 92);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(270, 23);
            txtBrand.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtModel.Location = new Point(11, 151);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(270, 23);
            txtModel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 133);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // txtColor
            // 
            txtColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtColor.Location = new Point(12, 210);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(270, 23);
            txtColor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 192);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Color";
            // 
            // txtOwnerIdentityNumber
            // 
            txtOwnerIdentityNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOwnerIdentityNumber.Location = new Point(12, 37);
            txtOwnerIdentityNumber.MaxLength = 11;
            txtOwnerIdentityNumber.Name = "txtOwnerIdentityNumber";
            txtOwnerIdentityNumber.Size = new Size(270, 23);
            txtOwnerIdentityNumber.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 19);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 6;
            label4.Text = "Owner Identity Number";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(102, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(206, 290);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddOrUpdateCarForm
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(295, 335);
            ControlBox = false;
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(txtOwnerIdentityNumber);
            Controls.Add(label4);
            Controls.Add(txtColor);
            Controls.Add(label3);
            Controls.Add(txtModel);
            Controls.Add(label2);
            Controls.Add(txtBrand);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AddOrUpdateCarForm";
            Text = "Add Or Update Car";
            Load += AddOrUpdateCarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBrand;
        private TextBox txtModel;
        private Label label2;
        private TextBox txtColor;
        private Label label3;
        private TextBox txtOwnerIdentityNumber;
        private Label label4;
        private Button btnCancel;
        private Button btnSubmit;
    }
}