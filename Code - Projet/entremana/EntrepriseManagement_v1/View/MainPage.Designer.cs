namespace EntrepriseManagement_v1.View
{
    partial class MainPage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.butEditEmployee = new System.Windows.Forms.Button();
            this.butShowEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1362, 692);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.butEditEmployee);
            this.flowLayoutPanel1.Controls.Add(this.butShowEmployee);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1362, 70);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // butEditEmployee
            // 
            this.butEditEmployee.Location = new System.Drawing.Point(4, 5);
            this.butEditEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butEditEmployee.Name = "butEditEmployee";
            this.butEditEmployee.Size = new System.Drawing.Size(150, 60);
            this.butEditEmployee.TabIndex = 0;
            this.butEditEmployee.Text = "Quản lý Nhân viên";
            this.butEditEmployee.UseVisualStyleBackColor = true;
            this.butEditEmployee.Click += new System.EventHandler(this.butEditEmployee_Click);
            // 
            // butShowEmployee
            // 
            this.butShowEmployee.Location = new System.Drawing.Point(162, 5);
            this.butShowEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butShowEmployee.Name = "butShowEmployee";
            this.butShowEmployee.Size = new System.Drawing.Size(150, 60);
            this.butShowEmployee.TabIndex = 1;
            this.butShowEmployee.Text = "Danh sách Nhân viên";
            this.butShowEmployee.UseVisualStyleBackColor = true;
            this.butShowEmployee.Click += new System.EventHandler(this.butShowEmployee_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 692);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPage";
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butEditEmployee;
        private System.Windows.Forms.Button butShowEmployee;
    }
}