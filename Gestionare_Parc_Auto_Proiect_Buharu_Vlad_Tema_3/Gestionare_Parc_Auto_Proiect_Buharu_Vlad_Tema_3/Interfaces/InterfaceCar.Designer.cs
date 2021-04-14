
namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces
{
    partial class InterfaceCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceCar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.txtUpdateIdCar = new System.Windows.Forms.ToolStripTextBox();
            this.txtUpdateNameCar = new System.Windows.Forms.ToolStripTextBox();
            this.txtUpdateModelCar = new System.Windows.Forms.ToolStripTextBox();
            this.btnUpdateCar = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCar = new System.Windows.Forms.ToolStripButton();
            this.btnAddCar = new System.Windows.Forms.ToolStripButton();
            this.dtGridList = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.txtUpdateIdCar,
            this.txtUpdateNameCar,
            this.txtUpdateModelCar,
            this.btnUpdateCar,
            this.btnDeleteCar,
            this.btnAddCar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
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
            // txtUpdateIdCar
            // 
            this.txtUpdateIdCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpdateIdCar.Name = "txtUpdateIdCar";
            this.txtUpdateIdCar.Size = new System.Drawing.Size(100, 25);
            // 
            // txtUpdateNameCar
            // 
            this.txtUpdateNameCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpdateNameCar.Name = "txtUpdateNameCar";
            this.txtUpdateNameCar.Size = new System.Drawing.Size(100, 25);
            // 
            // txtUpdateModelCar
            // 
            this.txtUpdateModelCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpdateModelCar.Name = "txtUpdateModelCar";
            this.txtUpdateModelCar.Size = new System.Drawing.Size(100, 25);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdateCar.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCar.Image")));
            this.btnUpdateCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(23, 22);
            this.btnUpdateCar.Text = "UpdateCar";
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCar.Image")));
            this.btnDeleteCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteCar.Text = "Delete";
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
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
            this.dtGridList.Size = new System.Drawing.Size(776, 281);
            this.dtGridList.TabIndex = 5;
            this.dtGridList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridList_CellClick);
            // 
            // InterfaceCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.dtGridList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "InterfaceCar";
            this.Text = "InterfaceCar";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripTextBox txtUpdateIdCar;
        private System.Windows.Forms.ToolStripTextBox txtUpdateNameCar;
        private System.Windows.Forms.ToolStripTextBox txtUpdateModelCar;
        private System.Windows.Forms.ToolStripButton btnUpdateCar;
        private System.Windows.Forms.ToolStripButton btnDeleteCar;
        private System.Windows.Forms.DataGridView dtGridList;
        private System.Windows.Forms.ToolStripButton btnAddCar;
    }
}