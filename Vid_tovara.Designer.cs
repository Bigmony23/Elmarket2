namespace ElmarketApp
{
    partial class Vid_tovara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vid_tovara));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.elmarketDataSet1 = new ElmarketApp.ElmarketDataSet1();
            this.vID_TOVARABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vID_TOVARATableAdapter = new ElmarketApp.ElmarketDataSet1TableAdapters.VID_TOVARATableAdapter();
            this.tableAdapterManager = new ElmarketApp.ElmarketDataSet1TableAdapters.TableAdapterManager();
            this.vID_TOVARABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vID_TOVARABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vidtovaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elmarket33DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elmarket33DataSet = new ElmarketApp.Elmarket33DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.vid_tovaraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vid_tovaraTableAdapter1 = new ElmarketApp.Elmarket33DataSetTableAdapters.Vid_tovaraTableAdapter();
            this.tableAdapterManager1 = new ElmarketApp.Elmarket33DataSetTableAdapters.TableAdapterManager();
            this.vid_tovaraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vID_TOVARABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vID_TOVARABindingNavigator)).BeginInit();
            this.vID_TOVARABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidtovaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarket33DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarket33DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_tovaraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_tovaraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(434, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(606, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // elmarketDataSet1
            // 
            this.elmarketDataSet1.DataSetName = "ElmarketDataSet1";
            this.elmarketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vID_TOVARABindingSource
            // 
            this.vID_TOVARABindingSource.DataMember = "VID_TOVARA";
            this.vID_TOVARABindingSource.DataSource = this.elmarketDataSet1;
            // 
            // vID_TOVARATableAdapter
            // 
            this.vID_TOVARATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FAKT_OSTATKI1TableAdapter = null;
            this.tableAdapterManager.FAKT_OSTATKITableAdapter = null;
            this.tableAdapterManager.MESTO_XRANENIYATableAdapter = null;
            this.tableAdapterManager.PRIHOD1TableAdapter = null;
            this.tableAdapterManager.PRIHODTableAdapter = null;
            this.tableAdapterManager.PRIXODTableAdapter = null;
            this.tableAdapterManager.PROIZVODITELTableAdapter = null;
            this.tableAdapterManager.RASHOD1TableAdapter = null;
            this.tableAdapterManager.RASHODTableAdapter = null;
            this.tableAdapterManager.TEK_OSTATKI2TableAdapter = null;
            this.tableAdapterManager.TEK_OSTATKITableAdapter = null;
            this.tableAdapterManager.TOVARTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ElmarketApp.ElmarketDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VID_TOVARATableAdapter = this.vID_TOVARATableAdapter;
            // 
            // vID_TOVARABindingNavigator
            // 
            this.vID_TOVARABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vID_TOVARABindingNavigator.BindingSource = this.vID_TOVARABindingSource;
            this.vID_TOVARABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vID_TOVARABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vID_TOVARABindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vID_TOVARABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vID_TOVARABindingNavigatorSaveItem});
            this.vID_TOVARABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vID_TOVARABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vID_TOVARABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vID_TOVARABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vID_TOVARABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vID_TOVARABindingNavigator.Name = "vID_TOVARABindingNavigator";
            this.vID_TOVARABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vID_TOVARABindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.vID_TOVARABindingNavigator.TabIndex = 2;
            this.vID_TOVARABindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // vID_TOVARABindingNavigatorSaveItem
            // 
            this.vID_TOVARABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vID_TOVARABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vID_TOVARABindingNavigatorSaveItem.Image")));
            this.vID_TOVARABindingNavigatorSaveItem.Name = "vID_TOVARABindingNavigatorSaveItem";
            this.vID_TOVARABindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.vID_TOVARABindingNavigatorSaveItem.Text = "Сохранить данные";
            this.vID_TOVARABindingNavigatorSaveItem.Click += new System.EventHandler(this.vID_TOVARABindingNavigatorSaveItem_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Фильтр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(170, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Показать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vidtovaraBindingSource;
            this.comboBox1.DisplayMember = "Id_Product";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 399);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // vidtovaraBindingSource
            // 
            this.vidtovaraBindingSource.DataMember = "Vid_tovara";
            this.vidtovaraBindingSource.DataSource = this.elmarket33DataSetBindingSource;
            // 
            // elmarket33DataSetBindingSource
            // 
            this.elmarket33DataSetBindingSource.DataSource = this.elmarket33DataSet;
            this.elmarket33DataSetBindingSource.Position = 0;
            // 
            // elmarket33DataSet
            // 
            this.elmarket33DataSet.DataSetName = "Elmarket33DataSet";
            this.elmarket33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "ИД Продукта";
            // 
            // vid_tovaraBindingSource1
            // 
            this.vid_tovaraBindingSource1.DataMember = "Vid_tovara";
            this.vid_tovaraBindingSource1.DataSource = this.elmarket33DataSet;
            // 
            // vid_tovaraTableAdapter1
            // 
            this.vid_tovaraTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Fakt_OstatkiTableAdapter = null;
            this.tableAdapterManager1.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager1.PrixodTableAdapter = null;
            this.tableAdapterManager1.ProizvoditelTableAdapter = null;
            this.tableAdapterManager1.Rasxod1TableAdapter = null;
            this.tableAdapterManager1.Tek_OstatkiTableAdapter = null;
            this.tableAdapterManager1.TovarsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ElmarketApp.Elmarket33DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Vid_tovaraTableAdapter = this.vid_tovaraTableAdapter1;
            // 
            // vid_tovaraDataGridView
            // 
            this.vid_tovaraDataGridView.AutoGenerateColumns = false;
            this.vid_tovaraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vid_tovaraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.vid_tovaraDataGridView.DataSource = this.vid_tovaraBindingSource1;
            this.vid_tovaraDataGridView.Location = new System.Drawing.Point(434, 30);
            this.vid_tovaraDataGridView.Name = "vid_tovaraDataGridView";
            this.vid_tovaraDataGridView.RowHeadersWidth = 51;
            this.vid_tovaraDataGridView.RowTemplate.Height = 24;
            this.vid_tovaraDataGridView.Size = new System.Drawing.Size(323, 284);
            this.vid_tovaraDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Vid_tovara";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД Вид товара";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Product";
            this.dataGridViewTextBoxColumn2.HeaderText = "ИД Продукта";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Vid_tovara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vid_tovaraDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.vID_TOVARABindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Vid_tovara";
            this.Text = "Vid_tovara";
            this.Load += new System.EventHandler(this.Vid_tovara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elmarketDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vID_TOVARABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vID_TOVARABindingNavigator)).EndInit();
            this.vID_TOVARABindingNavigator.ResumeLayout(false);
            this.vID_TOVARABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidtovaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarket33DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarket33DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_tovaraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_tovaraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ElmarketDataSet1 elmarketDataSet1;
        private System.Windows.Forms.BindingSource vID_TOVARABindingSource;
        private ElmarketDataSet1TableAdapters.VID_TOVARATableAdapter vID_TOVARATableAdapter;
        private ElmarketDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vID_TOVARABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vID_TOVARABindingNavigatorSaveItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Elmarket33DataSet elmarket33DataSet;
        private System.Windows.Forms.BindingSource vid_tovaraBindingSource1;
        private Elmarket33DataSetTableAdapters.Vid_tovaraTableAdapter vid_tovaraTableAdapter1;
        private Elmarket33DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView vid_tovaraDataGridView;
        private System.Windows.Forms.BindingSource vidtovaraBindingSource;
        private System.Windows.Forms.BindingSource elmarket33DataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}