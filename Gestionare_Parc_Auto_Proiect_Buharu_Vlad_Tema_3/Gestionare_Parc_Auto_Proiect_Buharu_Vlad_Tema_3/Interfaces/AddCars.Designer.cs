
namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    partial class AddCars
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCar = new System.Windows.Forms.TextBox();
            this.txtModelCar = new System.Windows.Forms.TextBox();
            this.SaveCar = new System.Windows.Forms.Button();
            this.CancelCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Cars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model Car";
            // 
            // txtNameCar
            // 
            this.txtNameCar.Location = new System.Drawing.Point(88, 105);
            this.txtNameCar.Name = "txtNameCar";
            this.txtNameCar.Size = new System.Drawing.Size(200, 20);
            this.txtNameCar.TabIndex = 4;
            // 
            // txtModelCar
            // 
            this.txtModelCar.Location = new System.Drawing.Point(88, 147);
            this.txtModelCar.Name = "txtModelCar";
            this.txtModelCar.Size = new System.Drawing.Size(200, 20);
            this.txtModelCar.TabIndex = 5;
            // 
            // SaveCar
            // 
            this.SaveCar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCar.Location = new System.Drawing.Point(92, 212);
            this.SaveCar.Name = "SaveCar";
            this.SaveCar.Size = new System.Drawing.Size(75, 27);
            this.SaveCar.TabIndex = 7;
            this.SaveCar.Text = "Save";
            this.SaveCar.UseVisualStyleBackColor = true;
            this.SaveCar.Click += new System.EventHandler(this.SaveCar_Click);
            // 
            // CancelCar
            // 
            this.CancelCar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelCar.Location = new System.Drawing.Point(200, 212);
            this.CancelCar.Name = "CancelCar";
            this.CancelCar.Size = new System.Drawing.Size(75, 27);
            this.CancelCar.TabIndex = 8;
            this.CancelCar.Text = "Cancel";
            this.CancelCar.UseVisualStyleBackColor = true;
            this.CancelCar.Click += new System.EventHandler(this.CancelCar_Click);
            // 
            // AddCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 278);
            this.Controls.Add(this.CancelCar);
            this.Controls.Add(this.SaveCar);
            this.Controls.Add(this.txtModelCar);
            this.Controls.Add(this.txtNameCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameCar;
        private System.Windows.Forms.TextBox txtModelCar;
        private System.Windows.Forms.Button SaveCar;
        private System.Windows.Forms.Button CancelCar;
    }
}