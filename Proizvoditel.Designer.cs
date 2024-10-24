namespace ElmarketApp
{
    partial class Proizvoditel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proizvoditel));
            this.elmarketNewDataSet2 = new ElmarketApp.ElmarketNewDataSet2();
            this.proizvoditelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvoditelTableAdapter = new ElmarketApp.ElmarketNewDataSet2TableAdapters.ProizvoditelTableAdapter();
            this.tableAdapterManager = new ElmarketApp.ElmarketNewDataSet2TableAdapters.TableAdapterManager();
            this.proizvoditelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.proizvoditelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.proizvoditelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelBindingNavigator)).BeginInit();
            this.proizvoditelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // elmarketNewDataSet2
            // 
            this.elmarketNewDataSet2.DataSetName = "ElmarketNewDataSet2";
            this.elmarketNewDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proizvoditelBindingSource
            // 
            this.proizvoditelBindingSource.DataMember = "Proizvoditel";
            this.proizvoditelBindingSource.DataSource = this.elmarketNewDataSet2;
            // 
            // proizvoditelTableAdapter
            // 
            this.proizvoditelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Fakt_OstatkiTableAdapter = null;
            this.tableAdapterManager.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.ProizvoditelTableAdapter = this.proizvoditelTableAdapter;
            this.tableAdapterManager.Rasxod1TableAdapter = null;
            this.tableAdapterManager.Table11TableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.Tek_OstatkiTableAdapter = null;
            this.tableAdapterManager.TovarsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ElmarketApp.ElmarketNewDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_tovaraTableAdapter = null;
            // 
            // proizvoditelBindingNavigator
            // 
            this.proizvoditelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proizvoditelBindingNavigator.BindingSource = this.proizvoditelBindingSource;
            this.proizvoditelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proizvoditelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proizvoditelBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.proizvoditelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.proizvoditelBindingNavigatorSaveItem});
            this.proizvoditelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proizvoditelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proizvoditelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proizvoditelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proizvoditelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proizvoditelBindingNavigator.Name = "proizvoditelBindingNavigator";
            this.proizvoditelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proizvoditelBindingNavigator.Size = new System.Drawing.Size(840, 27);
            this.proizvoditelBindingNavigator.TabIndex = 0;
            this.proizvoditelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // proizvoditelBindingNavigatorSaveItem
            // 
            this.proizvoditelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proizvoditelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proizvoditelBindingNavigatorSaveItem.Image")));
            this.proizvoditelBindingNavigatorSaveItem.Name = "proizvoditelBindingNavigatorSaveItem";
            this.proizvoditelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.proizvoditelBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.proizvoditelBindingNavigatorSaveItem.Click += new System.EventHandler(this.proizvoditelBindingNavigatorSaveItem_Click);
            // 
            // proizvoditelDataGridView
            // 
            this.proizvoditelDataGridView.AutoGenerateColumns = false;
            this.proizvoditelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvoditelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.proizvoditelDataGridView.DataSource = this.proizvoditelBindingSource;
            this.proizvoditelDataGridView.Location = new System.Drawing.Point(87, 41);
            this.proizvoditelDataGridView.Name = "proizvoditelDataGridView";
            this.proizvoditelDataGridView.RowHeadersWidth = 51;
            this.proizvoditelDataGridView.RowTemplate.Height = 24;
            this.proizvoditelDataGridView.Size = new System.Drawing.Size(430, 261);
            this.proizvoditelDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Proizvoditel";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Proizvoditel";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Proizvoditel";
            this.dataGridViewTextBoxColumn2.HeaderText = "Proizvoditel";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Product";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Product";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Производитель";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.proizvoditelBindingSource;
            this.comboBox1.DisplayMember = "Proizvoditel";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 395);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(189, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 30);
            this.button6.TabIndex = 27;
            this.button6.Text = "Показать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(393, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 30);
            this.button5.TabIndex = 26;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(544, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(37, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 24;
            this.button1.Text = "Фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proizvoditel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.proizvoditelDataGridView);
            this.Controls.Add(this.proizvoditelBindingNavigator);
            this.Name = "Proizvoditel";
            this.Text = "Proizvoditel";
            this.Load += new System.EventHandler(this.Proizvoditel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelBindingNavigator)).EndInit();
            this.proizvoditelBindingNavigator.ResumeLayout(false);
            this.proizvoditelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElmarketNewDataSet2 elmarketNewDataSet2;
        private System.Windows.Forms.BindingSource proizvoditelBindingSource;
        private ElmarketNewDataSet2TableAdapters.ProizvoditelTableAdapter proizvoditelTableAdapter;
        private ElmarketNewDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proizvoditelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton proizvoditelBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView proizvoditelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}