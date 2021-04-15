
namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces
{
    partial class InterfaceTransport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceTransport));
            this.dtGridList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.txtIdTransport = new System.Windows.Forms.ToolStripTextBox();
            this.txtProductTransport = new System.Windows.Forms.ToolStripTextBox();
            this.txtQuantityTransport = new System.Windows.Forms.ToolStripTextBox();
            this.btnUpdateTransport = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTransport = new System.Windows.Forms.ToolStripButton();
            this.btnAddTransport = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridList
            // 
            this.dtGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridList.Location = new System.Drawing.Point(12, 34);
            this.dtGridList.Name = "dtGridList";
            this.dtGridList.Size = new System.Drawing.Size(776, 410);
            this.dtGridList.TabIndex = 10;
            this.dtGridList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridList_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.txtIdTransport,
            this.txtProductTransport,
            this.txtQuantityTransport,
            this.btnUpdateTransport,
            this.btnDeleteTransport,
            this.btnAddTransport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 9;
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
            // txtIdTransport
            // 
            this.txtIdTransport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdTransport.Name = "txtIdTransport";
            this.txtIdTransport.Size = new System.Drawing.Size(25, 25);
            // 
            // txtProductTransport
            // 
            this.txtProductTransport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductTransport.Name = "txtProductTransport";
            this.txtProductTransport.Size = new System.Drawing.Size(150, 25);
            // 
            // txtQuantityTransport
            // 
            this.txtQuantityTransport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantityTransport.Name = "txtQuantityTransport";
            this.txtQuantityTransport.Size = new System.Drawing.Size(120, 25);
            // 
            // btnUpdateTransport
            // 
            this.btnUpdateTransport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdateTransport.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTransport.Image")));
            this.btnUpdateTransport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateTransport.Name = "btnUpdateTransport";
            this.btnUpdateTransport.Size = new System.Drawing.Size(23, 22);
            this.btnUpdateTransport.Text = "UpdateRute";
            this.btnUpdateTransport.Click += new System.EventHandler(this.btnUpdateTransport_Click);
            // 
            // btnDeleteTransport
            // 
            this.btnDeleteTransport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteTransport.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTransport.Image")));
            this.btnDeleteTransport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTransport.Name = "btnDeleteTransport";
            this.btnDeleteTransport.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteTransport.Text = "DeleteRute";
            this.btnDeleteTransport.Click += new System.EventHandler(this.btnDeleteTransport_Click);
            // 
            // btnAddTransport
            // 
            this.btnAddTransport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTransport.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTransport.Image")));
            this.btnAddTransport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTransport.Name = "btnAddTransport";
            this.btnAddTransport.Size = new System.Drawing.Size(23, 22);
            this.btnAddTransport.Text = "AddRute";
            this.btnAddTransport.Click += new System.EventHandler(this.btnAddTransport_Click);
            // 
            // InterfaceTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "InterfaceTransport";
            this.Text = "InterfaceTransport";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripTextBox txtIdTransport;
        private System.Windows.Forms.ToolStripTextBox txtProductTransport;
        private System.Windows.Forms.ToolStripTextBox txtQuantityTransport;
        private System.Windows.Forms.ToolStripButton btnUpdateTransport;
        private System.Windows.Forms.ToolStripButton btnDeleteTransport;
        private System.Windows.Forms.ToolStripButton btnAddTransport;
    }
}