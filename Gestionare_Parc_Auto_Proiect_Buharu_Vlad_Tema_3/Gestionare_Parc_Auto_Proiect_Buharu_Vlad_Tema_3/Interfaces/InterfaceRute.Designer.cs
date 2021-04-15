
namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces
{
    partial class InterfaceRute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceRute));
            this.dtGridList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.txtIdRute = new System.Windows.Forms.ToolStripTextBox();
            this.txtNameRute = new System.Windows.Forms.ToolStripTextBox();
            this.txtFromRute = new System.Windows.Forms.ToolStripTextBox();
            this.txtToRute = new System.Windows.Forms.ToolStripTextBox();
            this.btnUpdateRute = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteRute = new System.Windows.Forms.ToolStripButton();
            this.btnAddRute = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridList
            // 
            this.dtGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridList.Location = new System.Drawing.Point(12, 28);
            this.dtGridList.Name = "dtGridList";
            this.dtGridList.Size = new System.Drawing.Size(776, 410);
            this.dtGridList.TabIndex = 8;
            this.dtGridList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridList_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.txtIdRute,
            this.txtNameRute,
            this.txtFromRute,
            this.txtToRute,
            this.btnUpdateRute,
            this.btnDeleteRute,
            this.btnAddRute});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 7;
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
            // txtIdRute
            // 
            this.txtIdRute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdRute.Name = "txtIdRute";
            this.txtIdRute.Size = new System.Drawing.Size(25, 25);
            // 
            // txtNameRute
            // 
            this.txtNameRute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameRute.Name = "txtNameRute";
            this.txtNameRute.Size = new System.Drawing.Size(100, 25);
            // 
            // txtFromRute
            // 
            this.txtFromRute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFromRute.Name = "txtFromRute";
            this.txtFromRute.Size = new System.Drawing.Size(100, 25);
            // 
            // txtToRute
            // 
            this.txtToRute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtToRute.Name = "txtToRute";
            this.txtToRute.Size = new System.Drawing.Size(100, 25);
            // 
            // btnUpdateRute
            // 
            this.btnUpdateRute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdateRute.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRute.Image")));
            this.btnUpdateRute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateRute.Name = "btnUpdateRute";
            this.btnUpdateRute.Size = new System.Drawing.Size(23, 22);
            this.btnUpdateRute.Text = "UpdateRute";
            this.btnUpdateRute.Click += new System.EventHandler(this.btnUpdateRute_Click);
            // 
            // btnDeleteRute
            // 
            this.btnDeleteRute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteRute.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRute.Image")));
            this.btnDeleteRute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteRute.Name = "btnDeleteRute";
            this.btnDeleteRute.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteRute.Text = "DeleteRute";
            this.btnDeleteRute.Click += new System.EventHandler(this.btnDeleteRute_Click);
            // 
            // btnAddRute
            // 
            this.btnAddRute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddRute.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRute.Image")));
            this.btnAddRute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddRute.Name = "btnAddRute";
            this.btnAddRute.Size = new System.Drawing.Size(23, 22);
            this.btnAddRute.Text = "AddRute";
            this.btnAddRute.Click += new System.EventHandler(this.btnAddRute_Click);
            // 
            // InterfaceRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "InterfaceRute";
            this.Text = "InterfaceRute";
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
        private System.Windows.Forms.ToolStripTextBox txtIdRute;
        private System.Windows.Forms.ToolStripTextBox txtNameRute;
        private System.Windows.Forms.ToolStripTextBox txtFromRute;
        private System.Windows.Forms.ToolStripTextBox txtToRute;
        private System.Windows.Forms.ToolStripButton btnUpdateRute;
        private System.Windows.Forms.ToolStripButton btnDeleteRute;
        private System.Windows.Forms.ToolStripButton btnAddRute;
    }
}