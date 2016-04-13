namespace Ax2012LicenseGen
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCertificatePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLicenseCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerExpiry = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxLicenseExpiry = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUserCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenerateLicense = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOutputPathDialog = new System.Windows.Forms.Button();
            this.btnChooseCertificate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAxUtilFolder = new System.Windows.Forms.TextBox();
            this.btnAxUtilFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelCertificate = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUserCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelCertificate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output Path";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(127, 187);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(465, 20);
            this.txtOutputPath.TabIndex = 3;
            this.txtOutputPath.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Certificate Path";
            // 
            // txtCertificatePath
            // 
            this.txtCertificatePath.Location = new System.Drawing.Point(99, 9);
            this.txtCertificatePath.Name = "txtCertificatePath";
            this.txtCertificatePath.ReadOnly = true;
            this.txtCertificatePath.Size = new System.Drawing.Size(465, 20);
            this.txtCertificatePath.TabIndex = 5;
            this.txtCertificatePath.UseSystemPasswordChar = true;
            this.txtCertificatePath.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "License Code";
            // 
            // txtLicenseCode
            // 
            this.txtLicenseCode.Location = new System.Drawing.Point(127, 148);
            this.txtLicenseCode.Name = "txtLicenseCode";
            this.txtLicenseCode.Size = new System.Drawing.Size(465, 20);
            this.txtLicenseCode.TabIndex = 2;
            this.txtLicenseCode.TextChanged += new System.EventHandler(this.txtFileNameHandler_TextChanged);
            this.txtLicenseCode.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(127, 70);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(465, 20);
            this.txtCustomer.TabIndex = 0;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtFileNameHandler_TextChanged);
            this.txtCustomer.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Serial #";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(127, 109);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(465, 20);
            this.txtSerialNo.TabIndex = 1;
            this.txtSerialNo.TextChanged += new System.EventHandler(this.txtFileNameHandler_TextChanged);
            this.txtSerialNo.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(99, 48);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(465, 20);
            this.txtPwd.TabIndex = 7;
            this.txtPwd.Text = "<NOT REQUIRED>";
            this.txtPwd.UseSystemPasswordChar = true;
            this.txtPwd.Enter += new System.EventHandler(this.Focus_Enter);
            this.txtPwd.Validated += new System.EventHandler(this.txtPwd_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Expiry Date";
            // 
            // dateTimePickerExpiry
            // 
            this.dateTimePickerExpiry.CustomFormat = "";
            this.dateTimePickerExpiry.Enabled = false;
            this.dateTimePickerExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExpiry.Location = new System.Drawing.Point(109, 55);
            this.dateTimePickerExpiry.MinDate = new System.DateTime(2012, 6, 1, 0, 0, 0, 0);
            this.dateTimePickerExpiry.Name = "dateTimePickerExpiry";
            this.dateTimePickerExpiry.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerExpiry.TabIndex = 1;
            this.dateTimePickerExpiry.Value = new System.DateTime(2012, 6, 4, 12, 3, 44, 0);
            this.dateTimePickerExpiry.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxLicenseExpiry);
            this.groupBox1.Controls.Add(this.dateTimePickerExpiry);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(18, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 96);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "License Expiry";
            // 
            // chkBoxLicenseExpiry
            // 
            this.chkBoxLicenseExpiry.AutoSize = true;
            this.chkBoxLicenseExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkBoxLicenseExpiry.Location = new System.Drawing.Point(16, 32);
            this.chkBoxLicenseExpiry.Name = "chkBoxLicenseExpiry";
            this.chkBoxLicenseExpiry.Size = new System.Drawing.Size(103, 17);
            this.chkBoxLicenseExpiry.TabIndex = 0;
            this.chkBoxLicenseExpiry.Text = "License expires?";
            this.chkBoxLicenseExpiry.UseVisualStyleBackColor = true;
            this.chkBoxLicenseExpiry.CheckedChanged += new System.EventHandler(this.chkBoxLicenseExpiry_CheckedChanged);
            this.chkBoxLicenseExpiry.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "User Count";
            // 
            // numericUserCount
            // 
            this.numericUserCount.Location = new System.Drawing.Point(127, 470);
            this.numericUserCount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUserCount.Name = "numericUserCount";
            this.numericUserCount.Size = new System.Drawing.Size(120, 20);
            this.numericUserCount.TabIndex = 11;
            this.numericUserCount.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(500, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dynamics AX License Generator v1.1";
            // 
            // btnGenerateLicense
            // 
            this.btnGenerateLicense.Location = new System.Drawing.Point(683, 456);
            this.btnGenerateLicense.Name = "btnGenerateLicense";
            this.btnGenerateLicense.Size = new System.Drawing.Size(133, 45);
            this.btnGenerateLicense.TabIndex = 12;
            this.btnGenerateLicense.Text = "Generate License";
            this.btnGenerateLicense.UseVisualStyleBackColor = true;
            this.btnGenerateLicense.Click += new System.EventHandler(this.btnGenerateLicense_Click);
            this.btnGenerateLicense.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(683, 514);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.bntCancel_Click);
            this.btnCancel.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text file|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogCertificate";
            this.openFileDialog1.Filter = "Certificates|*.pfx";
            // 
            // btnOutputPathDialog
            // 
            this.btnOutputPathDialog.Location = new System.Drawing.Point(598, 188);
            this.btnOutputPathDialog.Name = "btnOutputPathDialog";
            this.btnOutputPathDialog.Size = new System.Drawing.Size(31, 20);
            this.btnOutputPathDialog.TabIndex = 4;
            this.btnOutputPathDialog.Text = "...";
            this.btnOutputPathDialog.UseVisualStyleBackColor = true;
            this.btnOutputPathDialog.Click += new System.EventHandler(this.btnOutputPathDialog_Click);
            this.btnOutputPathDialog.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // btnChooseCertificate
            // 
            this.btnChooseCertificate.Location = new System.Drawing.Point(570, 9);
            this.btnChooseCertificate.Name = "btnChooseCertificate";
            this.btnChooseCertificate.Size = new System.Drawing.Size(31, 20);
            this.btnChooseCertificate.TabIndex = 6;
            this.btnChooseCertificate.Text = "...";
            this.btnChooseCertificate.UseVisualStyleBackColor = true;
            this.btnChooseCertificate.Click += new System.EventHandler(this.btnChooseCertificate_Click);
            this.btnChooseCertificate.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // txtHelp
            // 
            this.txtHelp.Location = new System.Drawing.Point(27, 504);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHelp.Size = new System.Drawing.Size(625, 55);
            this.txtHelp.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "AxUtil Location";
            // 
            // txtAxUtilFolder
            // 
            this.txtAxUtilFolder.Location = new System.Drawing.Point(128, 304);
            this.txtAxUtilFolder.Name = "txtAxUtilFolder";
            this.txtAxUtilFolder.ReadOnly = true;
            this.txtAxUtilFolder.Size = new System.Drawing.Size(465, 20);
            this.txtAxUtilFolder.TabIndex = 8;
            this.txtAxUtilFolder.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // btnAxUtilFolder
            // 
            this.btnAxUtilFolder.Location = new System.Drawing.Point(598, 303);
            this.btnAxUtilFolder.Name = "btnAxUtilFolder";
            this.btnAxUtilFolder.Size = new System.Drawing.Size(31, 20);
            this.btnAxUtilFolder.TabIndex = 9;
            this.btnAxUtilFolder.Text = "...";
            this.btnAxUtilFolder.UseVisualStyleBackColor = true;
            this.btnAxUtilFolder.Click += new System.EventHandler(this.btnAxUtilFolder_Click);
            this.btnAxUtilFolder.Enter += new System.EventHandler(this.Focus_Enter);
            // 
            // panelCertificate
            // 
            this.panelCertificate.Controls.Add(this.label2);
            this.panelCertificate.Controls.Add(this.txtCertificatePath);
            this.panelCertificate.Controls.Add(this.label6);
            this.panelCertificate.Controls.Add(this.txtPwd);
            this.panelCertificate.Controls.Add(this.btnChooseCertificate);
            this.panelCertificate.Location = new System.Drawing.Point(27, 213);
            this.panelCertificate.Name = "panelCertificate";
            this.panelCertificate.Size = new System.Drawing.Size(625, 84);
            this.panelCertificate.TabIndex = 24;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 571);
            this.Controls.Add(this.btnAxUtilFolder);
            this.Controls.Add(this.txtAxUtilFolder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.btnOutputPathDialog);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerateLicense);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUserCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLicenseCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCertificate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Dynamics Ax 2012 License generator v1.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUserCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelCertificate.ResumeLayout(false);
            this.panelCertificate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCertificatePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLicenseCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBoxLicenseExpiry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUserCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGenerateLicense;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOutputPathDialog;
        private System.Windows.Forms.Button btnChooseCertificate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.TextBox txtAxUtilFolder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAxUtilFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panelCertificate;
    }
}

