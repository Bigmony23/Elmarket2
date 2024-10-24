namespace ElmarketApp
{
    partial class Ostatki
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
            this.tek_OstatkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elmarket33DataSet1 = new ElmarketApp.Elmarket33DataSet1();
            this.tek_OstatkiTableAdapter = new ElmarketApp.Elmarket33DataSet1TableAdapters.Tek_OstatkiTableAdapter();
            this.tableAdapterManager = new ElmarketApp.Elmarket33DataSet1TableAdapters.TableAdapterManager();
            this.elmarketNewDataSet1 = new ElmarketApp.ElmarketNewDataSet1();
            this.tek_OstatkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tek_OstatkiTableAdapter1 = new ElmarketApp.ElmarketNewDataSet1TableAdapters.Tek_OstatkiTableAdapter();
            this.tableAdapterManager1 = new ElmarketApp.ElmarketNewDataSet1TableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.elmarketNewDataSet2 = new ElmarketApp.ElmarketNewDataSet2();
            this.tek_OstatkiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tek_OstatkiTableAdapter2 = new ElmarketApp.ElmarketNewDataSet2TableAdapters.Tek_OstatkiTableAdapter();
            this.tableAdapterManager2 = new ElmarketApp.ElmarketNewDataSet2TableAdapters.TableAdapterManager();
            this.tek_OstatkiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tek_OstatkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarket33DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tek_OstatkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tek_OstatkiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tek_OstatkiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tek_OstatkiBindingSource
            // 
            this.tek_OstatkiBindingSource.DataMember = "Tek_Ostatki";
            this.tek_OstatkiBindingSource.DataSource = this.elmarket33DataSet1;
            // 
            // elmarket33DataSet1
            // 
            this.elmarket33DataSet1.DataSetName = "Elmarket33DataSet1";
            this.elmarket33DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tek_OstatkiTableAdapter
            // 
            this.tek_OstatkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Fakt_OstatkiTableAdapter = null;
            this.tableAdapterManager.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.ProizvoditelTableAdapter = null;
            this.tableAdapterManager.Rasxod1TableAdapter = null;
            this.tableAdapterManager.Tek_OstatkiTableAdapter = this.tek_OstatkiTableAdapter;
            this.tableAdapterManager.TovarsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ElmarketApp.Elmarket33DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_tovaraTableAdapter = null;
            // 
            // elmarketNewDataSet1
            // 
            this.elmarketNewDataSet1.DataSetName = "ElmarketNewDataSet1";
            this.elmarketNewDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tek_OstatkiBindingSource1
            // 
            this.tek_OstatkiBindingSource1.DataMember = "Tek_Ostatki";
            this.tek_OstatkiBindingSource1.DataSource = this.elmarketNewDataSet1;
            // 
            // tek_OstatkiTableAdapter1
            // 
            this.tek_OstatkiTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Fakt_OstatkiTableAdapter = null;
            this.tableAdapterManager1.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager1.PrixodTableAdapter = null;
            this.tableAdapterManager1.ProizvoditelTableAdapter = null;
            this.tableAdapterManager1.Rasxod1TableAdapter = null;
            this.tableAdapterManager1.TableTableAdapter = null;
            this.tableAdapterManager1.Tek_OstatkiTableAdapter = this.tek_OstatkiTableAdapter1;
            this.tableAdapterManager1.TovarsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ElmarketApp.ElmarketNewDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Vid_tovaraTableAdapter = null;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(6, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(589, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // elmarketNewDataSet2
            // 
            this.elmarketNewDataSet2.DataSetName = "ElmarketNewDataSet2";
            this.elmarketNewDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tek_OstatkiBindingSource2
            // 
            this.tek_OstatkiBindingSource2.DataMember = "Tek_Ostatki";
            this.tek_OstatkiBindingSource2.DataSource = this.elmarketNewDataSet2;
            // 
            // tek_OstatkiTableAdapter2
            // 
            this.tek_OstatkiTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Fakt_OstatkiTableAdapter = null;
            this.tableAdapterManager2.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager2.PrixodTableAdapter = null;
            this.tableAdapterManager2.ProizvoditelTableAdapter = null;
            this.tableAdapterManager2.Rasxod1TableAdapter = null;
            this.tableAdapterManager2.Table11TableAdapter = null;
            this.tableAdapterManager2.TableTableAdapter = null;
            this.tableAdapterManager2.Tek_OstatkiTableAdapter = this.tek_OstatkiTableAdapter2;
            this.tableAdapterManager2.TovarsTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = ElmarketApp.ElmarketNewDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.Vid_tovaraTableAdapter = null;
            // 
            // tek_OstatkiDataGridView
            // 
            this.tek_OstatkiDataGridView.AutoGenerateColumns = false;
            this.tek_OstatkiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tek_OstatkiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tek_OstatkiDataGridView.DataSource = this.tek_OstatkiBindingSource2;
            this.tek_OstatkiDataGridView.Location = new System.Drawing.Point(6, 12);
            this.tek_OstatkiDataGridView.Name = "tek_OstatkiDataGridView";
            this.tek_OstatkiDataGridView.RowHeadersWidth = 51;
            this.tek_OstatkiDataGridView.RowTemplate.Height = 24;
            this.tek_OstatkiDataGridView.Size = new System.Drawing.Size(685, 273);
            this.tek_OstatkiDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Fakt_Ostatki";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идентификатор";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Datanum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Product";
            this.dataGridViewTextBoxColumn3.HeaderText = "ИД продукта";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sena_prodaji";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена продажи";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "kolichestvo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Ostatki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 404);
            this.Controls.Add(this.tek_OstatkiDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ostatki";
            this.Text = "Tek_ostatki";
            this.Load += new System.EventHandler(this.Ostatki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tek_OstatkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarket33DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tek_OstatkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tek_OstatkiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tek_OstatkiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Elmarket33DataSet1 elmarket33DataSet1;
        private System.Windows.Forms.BindingSource tek_OstatkiBindingSource;
        private Elmarket33DataSet1TableAdapters.Tek_OstatkiTableAdapter tek_OstatkiTableAdapter;
        private Elmarket33DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private ElmarketNewDataSet1 elmarketNewDataSet1;
        private System.Windows.Forms.BindingSource tek_OstatkiBindingSource1;
        private ElmarketNewDataSet1TableAdapters.Tek_OstatkiTableAdapter tek_OstatkiTableAdapter1;
        private ElmarketNewDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private ElmarketNewDataSet2 elmarketNewDataSet2;
        private System.Windows.Forms.BindingSource tek_OstatkiBindingSource2;
        private ElmarketNewDataSet2TableAdapters.Tek_OstatkiTableAdapter tek_OstatkiTableAdapter2;
        private ElmarketNewDataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView tek_OstatkiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}