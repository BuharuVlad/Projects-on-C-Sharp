
namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    partial class Dashbord
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtGridList = new System.Windows.Forms.DataGridView();
            this.cbNameCar = new System.Windows.Forms.ComboBox();
            this.txtProductsTransport = new System.Windows.Forms.TextBox();
            this.txtQuantityTransport = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbModelCar = new System.Windows.Forms.ComboBox();
            this.lbNameTransport = new System.Windows.Forms.Label();
            this.lbQuantityProducts = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbNameCar = new System.Windows.Forms.Label();
            this.lbModelCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNameRute = new System.Windows.Forms.ComboBox();
            this.cbFirstSecondName = new System.Windows.Forms.ComboBox();
            this.cbFirstNameDriver = new System.Windows.Forms.ComboBox();
            this.txtFromRute = new System.Windows.Forms.TextBox();
            this.txtToRute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSecondNameDriver = new System.Windows.Forms.ComboBox();
            this.cbBirthDayDriver = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.carsToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.ruteToolStripMenuItem,
            this.transportsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.serializareToolStripMenuItem.Text = "Serializare";
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCarsToolStripMenuItem});
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.carsToolStripMenuItem.Text = "Cars";
            // 
            // viewCarsToolStripMenuItem
            // 
            this.viewCarsToolStripMenuItem.Name = "viewCarsToolStripMenuItem";
            this.viewCarsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viewCarsToolStripMenuItem.Text = "View Cars";
            this.viewCarsToolStripMenuItem.Click += new System.EventHandler(this.ViewCarsToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDriversToolStripMenuItem});
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // viewDriversToolStripMenuItem
            // 
            this.viewDriversToolStripMenuItem.Name = "viewDriversToolStripMenuItem";
            this.viewDriversToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.viewDriversToolStripMenuItem.Text = "View Drivers";
            this.viewDriversToolStripMenuItem.Click += new System.EventHandler(this.ViewDriversToolStripMenuItem_Click);
            // 
            // ruteToolStripMenuItem
            // 
            this.ruteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRutesToolStripMenuItem});
            this.ruteToolStripMenuItem.Name = "ruteToolStripMenuItem";
            this.ruteToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ruteToolStripMenuItem.Text = "Rutes";
            // 
            // viewRutesToolStripMenuItem
            // 
            this.viewRutesToolStripMenuItem.Name = "viewRutesToolStripMenuItem";
            this.viewRutesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.viewRutesToolStripMenuItem.Text = "View Rutes";
            this.viewRutesToolStripMenuItem.Click += new System.EventHandler(this.ViewRutesToolStripMenuItem_Click);
            // 
            // transportsToolStripMenuItem
            // 
            this.transportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTransportsToolStripMenuItem});
            this.transportsToolStripMenuItem.Name = "transportsToolStripMenuItem";
            this.transportsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.transportsToolStripMenuItem.Text = "Transports";
            // 
            // viewTransportsToolStripMenuItem
            // 
            this.viewTransportsToolStripMenuItem.Name = "viewTransportsToolStripMenuItem";
            this.viewTransportsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewTransportsToolStripMenuItem.Text = "View Transports";
            this.viewTransportsToolStripMenuItem.Click += new System.EventHandler(this.ViewTransportsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // dtGridList
            // 
            this.dtGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridList.Location = new System.Drawing.Point(12, 228);
            this.dtGridList.Name = "dtGridList";
            this.dtGridList.Size = new System.Drawing.Size(943, 336);
            this.dtGridList.TabIndex = 1;
            // 
            // cbNameCar
            // 
            this.cbNameCar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNameCar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNameCar.FormattingEnabled = true;
            this.cbNameCar.Location = new System.Drawing.Point(94, 103);
            this.cbNameCar.Name = "cbNameCar";
            this.cbNameCar.Size = new System.Drawing.Size(154, 21);
            this.cbNameCar.TabIndex = 2;
            this.cbNameCar.SelectedIndexChanged += new System.EventHandler(this.cbNameCar_SelectedIndexChanged);
            this.cbNameCar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNameCar_KeyDown);
            // 
            // txtProductsTransport
            // 
            this.txtProductsTransport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProductsTransport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductsTransport.Location = new System.Drawing.Point(94, 51);
            this.txtProductsTransport.Name = "txtProductsTransport";
            this.txtProductsTransport.Size = new System.Drawing.Size(154, 20);
            this.txtProductsTransport.TabIndex = 3;
            this.txtProductsTransport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductsTransport_KeyDown);
            this.txtProductsTransport.Validating += new System.ComponentModel.CancelEventHandler(this.txtProductsTransport_Validating);
            // 
            // txtQuantityTransport
            // 
            this.txtQuantityTransport.Location = new System.Drawing.Point(94, 77);
            this.txtQuantityTransport.Name = "txtQuantityTransport";
            this.txtQuantityTransport.Size = new System.Drawing.Size(154, 20);
            this.txtQuantityTransport.TabIndex = 4;
            this.txtQuantityTransport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantityTransport_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbModelCar
            // 
            this.cbModelCar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbModelCar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbModelCar.FormattingEnabled = true;
            this.cbModelCar.Location = new System.Drawing.Point(94, 130);
            this.cbModelCar.Name = "cbModelCar";
            this.cbModelCar.Size = new System.Drawing.Size(154, 21);
            this.cbModelCar.TabIndex = 6;
            // 
            // lbNameTransport
            // 
            this.lbNameTransport.AutoSize = true;
            this.lbNameTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTransport.Location = new System.Drawing.Point(12, 52);
            this.lbNameTransport.Name = "lbNameTransport";
            this.lbNameTransport.Size = new System.Drawing.Size(69, 16);
            this.lbNameTransport.TabIndex = 7;
            this.lbNameTransport.Text = "Products";
            // 
            // lbQuantityProducts
            // 
            this.lbQuantityProducts.AutoSize = true;
            this.lbQuantityProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantityProducts.Location = new System.Drawing.Point(12, 79);
            this.lbQuantityProducts.Name = "lbQuantityProducts";
            this.lbQuantityProducts.Size = new System.Drawing.Size(64, 16);
            this.lbQuantityProducts.TabIndex = 8;
            this.lbQuantityProducts.Text = "Quantity";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // lbNameCar
            // 
            this.lbNameCar.AutoSize = true;
            this.lbNameCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCar.Location = new System.Drawing.Point(12, 108);
            this.lbNameCar.Name = "lbNameCar";
            this.lbNameCar.Size = new System.Drawing.Size(77, 16);
            this.lbNameCar.TabIndex = 9;
            this.lbNameCar.Text = "Name Car";
            // 
            // lbModelCar
            // 
            this.lbModelCar.AutoSize = true;
            this.lbModelCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelCar.Location = new System.Drawing.Point(12, 135);
            this.lbModelCar.Name = "lbModelCar";
            this.lbModelCar.Size = new System.Drawing.Size(79, 16);
            this.lbModelCar.TabIndex = 10;
            this.lbModelCar.Text = "Model Car";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "First Name";
            // 
            // cbNameRute
            // 
            this.cbNameRute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNameRute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNameRute.FormattingEnabled = true;
            this.cbNameRute.Location = new System.Drawing.Point(396, 50);
            this.cbNameRute.Name = "cbNameRute";
            this.cbNameRute.Size = new System.Drawing.Size(154, 21);
            this.cbNameRute.TabIndex = 19;
            this.cbNameRute.SelectedIndexChanged += new System.EventHandler(this.cbNameRute_SelectedIndexChanged);
            // 
            // cbFirstSecondName
            // 
            this.cbFirstSecondName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFirstSecondName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFirstSecondName.FormattingEnabled = true;
            this.cbFirstSecondName.Location = new System.Drawing.Point(396, 130);
            this.cbFirstSecondName.Name = "cbFirstSecondName";
            this.cbFirstSecondName.Size = new System.Drawing.Size(154, 21);
            this.cbFirstSecondName.TabIndex = 22;
            // 
            // cbFirstNameDriver
            // 
            this.cbFirstNameDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFirstNameDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFirstNameDriver.FormattingEnabled = true;
            this.cbFirstNameDriver.Location = new System.Drawing.Point(396, 130);
            this.cbFirstNameDriver.Name = "cbFirstNameDriver";
            this.cbFirstNameDriver.Size = new System.Drawing.Size(154, 21);
            this.cbFirstNameDriver.TabIndex = 22;
            // 
            // txtFromRute
            // 
            this.txtFromRute.Location = new System.Drawing.Point(396, 79);
            this.txtFromRute.Name = "txtFromRute";
            this.txtFromRute.Size = new System.Drawing.Size(154, 20);
            this.txtFromRute.TabIndex = 23;
            // 
            // txtToRute
            // 
            this.txtToRute.Location = new System.Drawing.Point(396, 104);
            this.txtToRute.Name = "txtToRute";
            this.txtToRute.Size = new System.Drawing.Size(154, 20);
            this.txtToRute.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Last Name";
            // 
            // cbSecondNameDriver
            // 
            this.cbSecondNameDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSecondNameDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSecondNameDriver.FormattingEnabled = true;
            this.cbSecondNameDriver.Location = new System.Drawing.Point(659, 52);
            this.cbSecondNameDriver.Name = "cbSecondNameDriver";
            this.cbSecondNameDriver.Size = new System.Drawing.Size(194, 21);
            this.cbSecondNameDriver.TabIndex = 26;
            this.cbSecondNameDriver.Leave += new System.EventHandler(this.cbSecondNameDriver_Leave);
            // 
            // cbBirthDayDriver
            // 
            this.cbBirthDayDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBirthDayDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBirthDayDriver.FormattingEnabled = true;
            this.cbBirthDayDriver.Location = new System.Drawing.Point(659, 81);
            this.cbBirthDayDriver.Name = "cbBirthDayDriver";
            this.cbBirthDayDriver.Size = new System.Drawing.Size(194, 21);
            this.cbBirthDayDriver.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Birth Date";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 576);
            this.Controls.Add(this.cbBirthDayDriver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSecondNameDriver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtToRute);
            this.Controls.Add(this.txtFromRute);
            this.Controls.Add(this.cbFirstNameDriver);
            this.Controls.Add(this.cbFirstSecondName);
            this.Controls.Add(this.cbNameRute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbModelCar);
            this.Controls.Add(this.lbNameCar);
            this.Controls.Add(this.lbQuantityProducts);
            this.Controls.Add(this.lbNameTransport);
            this.Controls.Add(this.cbModelCar);
            this.Controls.Add(this.txtQuantityTransport);
            this.Controls.Add(this.txtProductsTransport);
            this.Controls.Add(this.cbNameCar);
            this.Controls.Add(this.dtGridList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtGridList;
        private System.Windows.Forms.ComboBox cbNameCar;
        private System.Windows.Forms.TextBox txtProductsTransport;
        private System.Windows.Forms.TextBox txtQuantityTransport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbModelCar;
        private System.Windows.Forms.Label lbNameTransport;
        private System.Windows.Forms.Label lbQuantityProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.Label lbNameCar;
        private System.Windows.Forms.Label lbModelCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNameRute;
        private System.Windows.Forms.ComboBox cbFirstSecondName;
        private System.Windows.Forms.ComboBox cbFirstNameDriver;
        private System.Windows.Forms.TextBox txtFromRute;
        private System.Windows.Forms.TextBox txtToRute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSecondNameDriver;
        private System.Windows.Forms.ComboBox cbBirthDayDriver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}