namespace ElmarketApp
{
    partial class Prixod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prixod));
            this.elmarketNewDataSet2 = new ElmarketApp.ElmarketNewDataSet2();
            this.prixodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prixodTableAdapter = new ElmarketApp.ElmarketNewDataSet2TableAdapters.PrixodTableAdapter();
            this.tableAdapterManager = new ElmarketApp.ElmarketNewDataSet2TableAdapters.TableAdapterManager();
            this.prixodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prixodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prixodDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Vid_Tovara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixodBindingNavigator)).BeginInit();
            this.prixodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prixodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // elmarketNewDataSet2
            // 
            this.elmarketNewDataSet2.DataSetName = "ElmarketNewDataSet2";
            this.elmarketNewDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prixodBindingSource
            // 
            this.prixodBindingSource.DataMember = "Prixod";
            this.prixodBindingSource.DataSource = this.elmarketNewDataSet2;
            // 
            // prixodTableAdapter
            // 
            this.prixodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Fakt_OstatkiTableAdapter = null;
            this.tableAdapterManager.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = this.prixodTableAdapter;
            this.tableAdapterManager.ProizvoditelTableAdapter = null;
            this.tableAdapterManager.Rasxod1TableAdapter = null;
            this.tableAdapterManager.Table11TableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.Tek_OstatkiTableAdapter = null;
            this.tableAdapterManager.TovarsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ElmarketApp.ElmarketNewDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_tovaraTableAdapter = null;
            // 
            // prixodBindingNavigator
            // 
            this.prixodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prixodBindingNavigator.BindingSource = this.prixodBindingSource;
            this.prixodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prixodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prixodBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.prixodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prixodBindingNavigatorSaveItem});
            this.prixodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prixodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prixodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prixodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prixodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prixodBindingNavigator.Name = "prixodBindingNavigator";
            this.prixodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prixodBindingNavigator.Size = new System.Drawing.Size(773, 27);
            this.prixodBindingNavigator.TabIndex = 0;
            this.prixodBindingNavigator.Text = "bindingNavigator1";
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
            // prixodBindingNavigatorSaveItem
            // 
            this.prixodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prixodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prixodBindingNavigatorSaveItem.Image")));
            this.prixodBindingNavigatorSaveItem.Name = "prixodBindingNavigatorSaveItem";
            this.prixodBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.prixodBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.prixodBindingNavigatorSaveItem.Click += new System.EventHandler(this.prixodBindingNavigatorSaveItem_Click);
            // 
            // prixodDataGridView
            // 
            this.prixodDataGridView.AutoGenerateColumns = false;
            this.prixodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prixodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Id_Vid_Tovara,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.prixodDataGridView.DataSource = this.prixodBindingSource;
            this.prixodDataGridView.Location = new System.Drawing.Point(10, 37);
            this.prixodDataGridView.Name = "prixodDataGridView";
            this.prixodDataGridView.RowHeadersWidth = 51;
            this.prixodDataGridView.RowTemplate.Height = 24;
            this.prixodDataGridView.Size = new System.Drawing.Size(681, 279);
            this.prixodDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Prixod";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идентификатор";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data_Prixoda";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата Прихода";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Id_Vid_Tovara
            // 
            this.Id_Vid_Tovara.DataPropertyName = "Id_Vid_Tovara";
            this.Id_Vid_Tovara.HeaderText = "Ид вид товара";
            this.Id_Vid_Tovara.MinimumWidth = 6;
            this.Id_Vid_Tovara.Name = "Id_Vid_Tovara";
            this.Id_Vid_Tovara.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Product";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ид продукта";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sena_zakupki";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена Закупки";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "kolichestvo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Дата прихода";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.prixodBindingSource;
            this.comboBox1.DisplayMember = "Data_Prixoda";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 23);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(150, 322);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 28);
            this.button6.TabIndex = 21;
            this.button6.Text = "Показать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(435, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 28);
            this.button5.TabIndex = 20;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(567, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 28);
            this.button3.TabIndex = 19;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(17, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prixod
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
            this.Controls.Add(this.prixodDataGridView);
            this.Controls.Add(this.prixodBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prixod";
            this.Text = "Prixod";
            this.Load += new System.EventHandler(this.Prixod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixodBindingNavigator)).EndInit();
            this.prixodBindingNavigator.ResumeLayout(false);
            this.prixodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prixodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElmarketNewDataSet2 elmarketNewDataSet2;
        private System.Windows.Forms.BindingSource prixodBindingSource;
        private ElmarketNewDataSet2TableAdapters.PrixodTableAdapter prixodTableAdapter;
        private ElmarketNewDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prixodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prixodBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView prixodDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Vid_Tovara;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}