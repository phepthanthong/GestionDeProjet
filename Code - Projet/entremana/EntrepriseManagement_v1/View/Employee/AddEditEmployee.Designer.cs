namespace EntrepriseManagement_v1.View.Employee
{
    partial class AddEditEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMST = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.lbLName = new System.Windows.Forms.Label();
            this.lbFName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.butSave);
            this.groupBox1.Controls.Add(this.cbRole);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbMST);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCMND);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbWage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMobile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbLName);
            this.groupBox1.Controls.Add(this.tbFName);
            this.groupBox1.Controls.Add(this.lbLName);
            this.groupBox1.Controls.Add(this.lbFName);
            this.groupBox1.Location = new System.Drawing.Point(38, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm nhân viên";
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(264, 220);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(100, 30);
            this.butCancel.TabIndex = 21;
            this.butCancel.Text = "Không lưu";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(420, 220);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(100, 30);
            this.butSave.TabIndex = 20;
            this.butSave.Text = "Lưu";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(420, 170);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(165, 21);
            this.cbRole.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chức vụ";
            // 
            // tbMST
            // 
            this.tbMST.Location = new System.Drawing.Point(420, 130);
            this.tbMST.Name = "tbMST";
            this.tbMST.Size = new System.Drawing.Size(165, 20);
            this.tbMST.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã số thuế";
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(420, 90);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(165, 20);
            this.tbCMND.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CMND";
            // 
            // tbWage
            // 
            this.tbWage.Location = new System.Drawing.Point(130, 170);
            this.tbWage.MaxLength = 7;
            this.tbWage.Name = "tbWage";
            this.tbWage.Size = new System.Drawing.Size(165, 20);
            this.tbWage.TabIndex = 7;
            this.tbWage.TextChanged += new System.EventHandler(this.tbWage_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lương tuần";
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(130, 130);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(165, 20);
            this.tbMobile.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số điện thoại";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(130, 90);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(165, 20);
            this.tbAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Địa chỉ";
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(130, 50);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(165, 20);
            this.tbLName.TabIndex = 1;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(420, 50);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(165, 20);
            this.tbFName.TabIndex = 2;
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Location = new System.Drawing.Point(30, 53);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(21, 13);
            this.lbLName.TabIndex = 1;
            this.lbLName.Text = "Họ";
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Location = new System.Drawing.Point(320, 53);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(26, 13);
            this.lbFName.TabIndex = 0;
            this.lbFName.Text = "Tên";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEditEmployee";
            this.Size = new System.Drawing.Size(695, 424);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbWage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label lbLName;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
