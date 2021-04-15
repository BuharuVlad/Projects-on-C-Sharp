
namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces
{
    partial class InterfaceDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceDriver));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.txtIdDriver = new System.Windows.Forms.ToolStripTextBox();
            this.txtFirstNameDriver = new System.Windows.Forms.ToolStripTextBox();
            this.txtSecondNameDriver = new System.Windows.Forms.ToolStripTextBox();
            this.btnUpdateDriver = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDriver = new System.Windows.Forms.ToolStripButton();
            this.btnAddCar = new System.Windows.Forms.ToolStripButton();
            this.dtGridList = new System.Windows.Forms.DataGridView();
            this.txtBirthDayDriver = new System.Windows.Forms.ToolStripTextBox();
            this.txtSalaryDriver = new System.Windows.Forms.ToolStripTextBox();
            this.txtAdressDriver = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.txtIdDriver,
            this.txtFirstNameDriver,
            this.txtSecondNameDriver,
            this.txtBirthDayDriver,
            this.txtSalaryDriver,
            this.txtAdressDriver,
            this.btnUpdateDriver,
            this.btnDeleteDriver,
            this.btnAddCar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "AddCar";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtIdDriver
            // 
            this.txtIdDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdDriver.Name = "txtIdDriver";
            this.txtIdDriver.Size = new System.Drawing.Size(25, 25);
            // 
            // txtFirstNameDriver
            // 
            this.txtFirstNameDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstNameDriver.Name = "txtFirstNameDriver";
            this.txtFirstNameDriver.Size = new System.Drawing.Size(100, 25);
            // 
            // txtSecondNameDriver
            // 
            this.txtSecondNameDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSecondNameDriver.Name = "txtSecondNameDriver";
            this.txtSecondNameDriver.Size = new System.Drawing.Size(100, 25);
            // 
            // btnUpdateDriver
            // 
            this.btnUpdateDriver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdateDriver.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDriver.Image")));
            this.btnUpdateDriver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(23, 22);
            this.btnUpdateDriver.Text = "UpdateDriver";
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteDriver.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDriver.Image")));
            this.btnDeleteDriver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteDriver.Text = "Delete Driver";
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCar.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCar.Image")));
            this.btnAddCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(23, 22);
            this.btnAddCar.Text = "AddCar";
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // dtGridList
            // 
            this.dtGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridList.Location = new System.Drawing.Point(12, 28);
            this.dtGridList.Name = "dtGridList";
            this.dtGridList.Size = new System.Drawing.Size(776, 322);
            this.dtGridList.TabIndex = 6;
            this.dtGridList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridList_CellClick);
            // 
            // txtBirthDayDriver
            // 
            this.txtBirthDayDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBirthDayDriver.Name = "txtBirthDayDriver";
            this.txtBirthDayDriver.Size = new System.Drawing.Size(100, 25);
            // 
            // txtSalaryDriver
            // 
            this.txtSalaryDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalaryDriver.Name = "txtSalaryDriver";
            this.txtSalaryDriver.Size = new System.Drawing.Size(70, 25);
            // 
            // txtAdressDriver
            // 
            this.txtAdressDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdressDriver.Name = "txtAdressDriver";
            this.txtAdressDriver.Size = new System.Drawing.Size(150, 25);
            // 
            // InterfaceDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "InterfaceDriver";
            this.Text = "InterfaceDriver";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripTextBox txtFirstNameDriver;
        private System.Windows.Forms.ToolStripTextBox txtSecondNameDriver;
        private System.Windows.Forms.ToolStripTextBox txtIdDriver;
        private System.Windows.Forms.ToolStripButton btnUpdateDriver;
        private System.Windows.Forms.ToolStripButton btnDeleteDriver;
        private System.Windows.Forms.ToolStripButton btnAddCar;
        private System.Windows.Forms.DataGridView dtGridList;
        private System.Windows.Forms.ToolStripTextBox txtBirthDayDriver;
        private System.Windows.Forms.ToolStripTextBox txtSalaryDriver;
        private System.Windows.Forms.ToolStripTextBox txtAdressDriver;
    }
}