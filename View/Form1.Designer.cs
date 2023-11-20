namespace View
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautyShopDBDataSet = new View.BeautyShopDBDataSet();
            this.ordersTableAdapter = new View.BeautyShopDBDataSetTableAdapters.OrdersTableAdapter();
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mastersTableAdapter = new View.BeautyShopDBDataSetTableAdapters.MastersTableAdapter();
            this.mastersMasterTimetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterTimetableTableAdapter = new View.BeautyShopDBDataSetTableAdapters.MasterTimetableTableAdapter();
            this.ordersServicesInOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesInOrderTableAdapter = new View.BeautyShopDBDataSetTableAdapters.ServicesInOrderTableAdapter();
            this.mastersOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyShopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersMasterTimetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersServicesInOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.masteridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mastersOrdersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.beautyShopDBDataSet;
            // 
            // beautyShopDBDataSet
            // 
            this.beautyShopDBDataSet.DataSetName = "BeautyShopDBDataSet";
            this.beautyShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // mastersBindingSource
            // 
            this.mastersBindingSource.DataMember = "Masters";
            this.mastersBindingSource.DataSource = this.beautyShopDBDataSet;
            // 
            // mastersTableAdapter
            // 
            this.mastersTableAdapter.ClearBeforeFill = true;
            // 
            // mastersMasterTimetableBindingSource
            // 
            this.mastersMasterTimetableBindingSource.DataMember = "MastersMasterTimetable";
            this.mastersMasterTimetableBindingSource.DataSource = this.mastersBindingSource;
            // 
            // masterTimetableTableAdapter
            // 
            this.masterTimetableTableAdapter.ClearBeforeFill = true;
            // 
            // ordersServicesInOrderBindingSource
            // 
            this.ordersServicesInOrderBindingSource.DataMember = "OrdersServicesInOrder";
            this.ordersServicesInOrderBindingSource.DataSource = this.ordersBindingSource;
            // 
            // servicesInOrderTableAdapter
            // 
            this.servicesInOrderTableAdapter.ClearBeforeFill = true;
            // 
            // mastersOrdersBindingSource
            // 
            this.mastersOrdersBindingSource.DataMember = "MastersOrders";
            this.mastersOrdersBindingSource.DataSource = this.mastersBindingSource;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            // 
            // masteridDataGridViewTextBoxColumn
            // 
            this.masteridDataGridViewTextBoxColumn.DataPropertyName = "master_id";
            this.masteridDataGridViewTextBoxColumn.HeaderText = "master_id";
            this.masteridDataGridViewTextBoxColumn.Name = "masteridDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyShopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersMasterTimetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersServicesInOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BeautyShopDBDataSet beautyShopDBDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private BeautyShopDBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource mastersBindingSource;
        private BeautyShopDBDataSetTableAdapters.MastersTableAdapter mastersTableAdapter;
        private System.Windows.Forms.BindingSource mastersMasterTimetableBindingSource;
        private BeautyShopDBDataSetTableAdapters.MasterTimetableTableAdapter masterTimetableTableAdapter;
        private System.Windows.Forms.BindingSource ordersServicesInOrderBindingSource;
        private BeautyShopDBDataSetTableAdapters.ServicesInOrderTableAdapter servicesInOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mastersOrdersBindingSource;
    }
}