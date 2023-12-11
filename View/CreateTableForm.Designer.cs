namespace View
{
    partial class CreateTableForm
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
            this.button_addColumn = new System.Windows.Forms.Button();
            this.textBox_columnName = new System.Windows.Forms.TextBox();
            this.checkBox_uniqueValue = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_selectedType = new System.Windows.Forms.ToolStripMenuItem();
            this.wrap_panel_1 = new System.Windows.Forms.Panel();
            this.button_createTable = new System.Windows.Forms.Button();
            this.listView_columnList = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_tableName = new System.Windows.Forms.TextBox();
            this.wrap_panel_2 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.wrap_panel_1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.wrap_panel_2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_addColumn
            // 
            this.button_addColumn.Location = new System.Drawing.Point(482, 41);
            this.button_addColumn.Name = "button_addColumn";
            this.button_addColumn.Size = new System.Drawing.Size(75, 23);
            this.button_addColumn.TabIndex = 1;
            this.button_addColumn.Text = "Add";
            this.button_addColumn.UseVisualStyleBackColor = true;
            this.button_addColumn.Click += new System.EventHandler(this.addClick);
            // 
            // textBox_columnName
            // 
            this.textBox_columnName.Location = new System.Drawing.Point(12, 43);
            this.textBox_columnName.Name = "textBox_columnName";
            this.textBox_columnName.Size = new System.Drawing.Size(100, 20);
            this.textBox_columnName.TabIndex = 2;
            // 
            // checkBox_uniqueValue
            // 
            this.checkBox_uniqueValue.AutoSize = true;
            this.checkBox_uniqueValue.Location = new System.Drawing.Point(210, 45);
            this.checkBox_uniqueValue.Name = "checkBox_uniqueValue";
            this.checkBox_uniqueValue.Size = new System.Drawing.Size(60, 17);
            this.checkBox_uniqueValue.TabIndex = 4;
            this.checkBox_uniqueValue.Text = "Unique";
            this.checkBox_uniqueValue.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_selectedType});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(75, 23);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "asdasdas";
            // 
            // toolStripMenuItem_selectedType
            // 
            this.toolStripMenuItem_selectedType.Name = "toolStripMenuItem_selectedType";
            this.toolStripMenuItem_selectedType.Size = new System.Drawing.Size(43, 19);
            this.toolStripMenuItem_selectedType.Text = "Type";
            // 
            // wrap_panel_1
            // 
            this.wrap_panel_1.Controls.Add(this.menuStrip1);
            this.wrap_panel_1.Location = new System.Drawing.Point(129, 41);
            this.wrap_panel_1.Name = "wrap_panel_1";
            this.wrap_panel_1.Size = new System.Drawing.Size(75, 23);
            this.wrap_panel_1.TabIndex = 6;
            // 
            // button_createTable
            // 
            this.button_createTable.Location = new System.Drawing.Point(129, 10);
            this.button_createTable.Name = "button_createTable";
            this.button_createTable.Size = new System.Drawing.Size(75, 23);
            this.button_createTable.TabIndex = 7;
            this.button_createTable.Text = "Create";
            this.button_createTable.UseVisualStyleBackColor = true;
            this.button_createTable.Click += new System.EventHandler(this.createClick);
            // 
            // listView_columnList
            // 
            this.listView_columnList.CheckBoxes = true;
            this.listView_columnList.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_columnList.HideSelection = false;
            this.listView_columnList.Location = new System.Drawing.Point(5, 69);
            this.listView_columnList.Name = "listView_columnList";
            this.listView_columnList.Size = new System.Drawing.Size(783, 369);
            this.listView_columnList.TabIndex = 8;
            this.listView_columnList.UseCompatibleStateImageBehavior = false;
            this.listView_columnList.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteField);
            // 
            // textBox_tableName
            // 
            this.textBox_tableName.Location = new System.Drawing.Point(12, 12);
            this.textBox_tableName.Name = "textBox_tableName";
            this.textBox_tableName.Size = new System.Drawing.Size(100, 20);
            this.textBox_tableName.TabIndex = 9;
            // 
            // wrap_panel_2
            // 
            this.wrap_panel_2.Controls.Add(this.menuStrip2);
            this.wrap_panel_2.Location = new System.Drawing.Point(276, 40);
            this.wrap_panel_2.Name = "wrap_panel_2";
            this.wrap_panel_2.Size = new System.Drawing.Size(200, 23);
            this.wrap_panel_2.TabIndex = 10;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(200, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem2.Text = "None";
            // 
            // CreateTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wrap_panel_2);
            this.Controls.Add(this.textBox_tableName);
            this.Controls.Add(this.listView_columnList);
            this.Controls.Add(this.button_createTable);
            this.Controls.Add(this.wrap_panel_1);
            this.Controls.Add(this.checkBox_uniqueValue);
            this.Controls.Add(this.textBox_columnName);
            this.Controls.Add(this.button_addColumn);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateTableForm";
            this.Text = "CreateTableForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.wrap_panel_1.ResumeLayout(false);
            this.wrap_panel_1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.wrap_panel_2.ResumeLayout(false);
            this.wrap_panel_2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_addColumn;
        private System.Windows.Forms.TextBox textBox_columnName;
        private System.Windows.Forms.CheckBox checkBox_uniqueValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel wrap_panel_1;
        private System.Windows.Forms.Button button_createTable;
        private System.Windows.Forms.ListView listView_columnList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_selectedType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_tableName;
        private System.Windows.Forms.Panel wrap_panel_2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}