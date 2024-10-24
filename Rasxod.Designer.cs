namespace ElmarketApp
{
    partial class Rasxod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rasxod));
            this.elmarketNewDataSet2 = new ElmarketApp.ElmarketNewDataSet2();
            this.rasxod1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rasxod1TableAdapter = new ElmarketApp.ElmarketNewDataSet2TableAdapters.Rasxod1TableAdapter();
            this.tableAdapterManager = new ElmarketApp.ElmarketNewDataSet2TableAdapters.TableAdapterManager();
            this.rasxod1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rasxod1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rasxod1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tovarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarsTableAdapter = new ElmarketApp.ElmarketNewDataSet2TableAdapters.TovarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxod1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxod1BindingNavigator)).BeginInit();
            this.rasxod1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rasxod1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // elmarketNewDataSet2
            // 
            this.elmarketNewDataSet2.DataSetName = "ElmarketNewDataSet2";
            this.elmarketNewDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rasxod1BindingSource
            // 
            this.rasxod1BindingSource.DataMember = "Rasxod1";
            this.rasxod1BindingSource.DataSource = this.elmarketNewDataSet2;
            // 
            // rasxod1TableAdapter
            // 
            this.rasxod1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Fakt_OstatkiTableAdapter = null;
            this.tableAdapterManager.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.ProizvoditelTableAdapter = null;
            this.tableAdapterManager.Rasxod1TableAdapter = this.rasxod1TableAdapter;
            this.tableAdapterManager.Table11TableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.Tek_OstatkiTableAdapter = null;
            this.tableAdapterManager.TovarsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ElmarketApp.ElmarketNewDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_tovaraTableAdapter = null;
            // 
            // rasxod1BindingNavigator
            // 
            this.rasxod1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rasxod1BindingNavigator.BindingSource = this.rasxod1BindingSource;
            this.rasxod1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rasxod1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rasxod1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rasxod1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rasxod1BindingNavigatorSaveItem});
            this.rasxod1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rasxod1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rasxod1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rasxod1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rasxod1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rasxod1BindingNavigator.Name = "rasxod1BindingNavigator";
            this.rasxod1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rasxod1BindingNavigator.Size = new System.Drawing.Size(773, 27);
            this.rasxod1BindingNavigator.TabIndex = 0;
            this.rasxod1BindingNavigator.Text = "bindingNavigator1";
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
            // rasxod1BindingNavigatorSaveItem
            // 
            this.rasxod1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rasxod1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rasxod1BindingNavigatorSaveItem.Image")));
            this.rasxod1BindingNavigatorSaveItem.Name = "rasxod1BindingNavigatorSaveItem";
            this.rasxod1BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.rasxod1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.rasxod1BindingNavigatorSaveItem.Click += new System.EventHandler(this.rasxod1BindingNavigatorSaveItem_Click);
            // 
            // rasxod1DataGridView
            // 
            this.rasxod1DataGridView.AutoGenerateColumns = false;
            this.rasxod1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rasxod1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rasxod1DataGridView.DataSource = this.rasxod1BindingSource;
            this.rasxod1DataGridView.Location = new System.Drawing.Point(16, 33);
            this.rasxod1DataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rasxod1DataGridView.Name = "rasxod1DataGridView";
            this.rasxod1DataGridView.RowHeadersWidth = 51;
            this.rasxod1DataGridView.RowTemplate.Height = 24;
            this.rasxod1DataGridView.Size = new System.Drawing.Size(687, 259);
            this.rasxod1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Rasxod";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идентификатор";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data_Prixoda";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата продажи";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Product";
            this.dataGridViewTextBoxColumn3.HeaderText = "ИД Продукта";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Moddel_tovara";
            this.dataGridViewTextBoxColumn4.HeaderText = "Модель товара";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sena_prodaji";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена Продажи";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Kolichestvo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Дата продажи";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rasxod1BindingSource;
            this.comboBox1.DisplayMember = "Data_Prixoda";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 333);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 23);
            this.comboBox1.TabIndex = 34;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(161, 298);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 28);
            this.button6.TabIndex = 33;
            this.button6.Text = "Показать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(397, 322);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 28);
            this.button5.TabIndex = 32;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(581, 322);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 28);
            this.button3.TabIndex = 31;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(28, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "Фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tovarsBindingSource
            // 
            this.tovarsBindingSource.DataMember = "Tovars";
            this.tovarsBindingSource.DataSource = this.elmarketNewDataSet2;
            // 
            // tovarsTableAdapter
            // 
            this.tovarsTableAdapter.ClearBeforeFill = true;
            // 
            // Rasxod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rasxod1DataGridView);
            this.Controls.Add(this.rasxod1BindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Rasxod";
            this.Text = "Rasxod";
            this.Load += new System.EventHandler(this.Rasxod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxod1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxod1BindingNavigator)).EndInit();
            this.rasxod1BindingNavigator.ResumeLayout(false);
            this.rasxod1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rasxod1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElmarketNewDataSet2 elmarketNewDataSet2;
        private System.Windows.Forms.BindingSource rasxod1BindingSource;
        private ElmarketNewDataSet2TableAdapters.Rasxod1TableAdapter rasxod1TableAdapter;
        private ElmarketNewDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rasxod1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rasxod1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rasxod1DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource tovarsBindingSource;
        private ElmarketNewDataSet2TableAdapters.TovarsTableAdapter tovarsTableAdapter;
    }
}