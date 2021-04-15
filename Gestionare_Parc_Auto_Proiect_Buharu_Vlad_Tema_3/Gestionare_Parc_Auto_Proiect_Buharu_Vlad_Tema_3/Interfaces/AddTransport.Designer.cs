
namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    partial class AddTransport
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelTransport = new System.Windows.Forms.Button();
            this.btnSaveTransport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantityTransport = new System.Windows.Forms.TextBox();
            this.txtProductTransport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quantity";
            // 
            // btnCancelTransport
            // 
            this.btnCancelTransport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTransport.Location = new System.Drawing.Point(306, 232);
            this.btnCancelTransport.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelTransport.Name = "btnCancelTransport";
            this.btnCancelTransport.Size = new System.Drawing.Size(99, 35);
            this.btnCancelTransport.TabIndex = 25;
            this.btnCancelTransport.Text = "Cancel";
            this.btnCancelTransport.UseVisualStyleBackColor = true;
            this.btnCancelTransport.Click += new System.EventHandler(this.btnCancelTransport_Click);
            // 
            // btnSaveTransport
            // 
            this.btnSaveTransport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTransport.Location = new System.Drawing.Point(146, 232);
            this.btnSaveTransport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveTransport.Name = "btnSaveTransport";
            this.btnSaveTransport.Size = new System.Drawing.Size(99, 35);
            this.btnSaveTransport.TabIndex = 24;
            this.btnSaveTransport.Text = "Save";
            this.btnSaveTransport.UseVisualStyleBackColor = true;
            this.btnSaveTransport.Click += new System.EventHandler(this.btnSaveTransport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Products";
            // 
            // txtQuantityTransport
            // 
            this.txtQuantityTransport.Location = new System.Drawing.Point(120, 143);
            this.txtQuantityTransport.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantityTransport.Name = "txtQuantityTransport";
            this.txtQuantityTransport.Size = new System.Drawing.Size(231, 20);
            this.txtQuantityTransport.TabIndex = 22;
            // 
            // txtProductTransport
            // 
            this.txtProductTransport.Location = new System.Drawing.Point(120, 113);
            this.txtProductTransport.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductTransport.Name = "txtProductTransport";
            this.txtProductTransport.Size = new System.Drawing.Size(231, 20);
            this.txtProductTransport.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add Transport";
            // 
            // AddTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelTransport);
            this.Controls.Add(this.btnSaveTransport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantityTransport);
            this.Controls.Add(this.txtProductTransport);
            this.Controls.Add(this.label1);
            this.Name = "AddTransport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTransport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelTransport;
        private System.Windows.Forms.Button btnSaveTransport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantityTransport;
        private System.Windows.Forms.TextBox txtProductTransport;
        private System.Windows.Forms.Label label1;
    }
}