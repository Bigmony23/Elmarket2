namespace ElmarketApp
{
    partial class Fakt_ostatkii2
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
            this.button1 = new System.Windows.Forms.Button();
            this.elmarket33DataSet = new ElmarketApp.Elmarket33DataSet();
            this.fakt_OstatkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakt_OstatkiTableAdapter = new ElmarketApp.Elmarket33DataSetTableAdapters.Fakt_OstatkiTableAdapter();
            this.tableAdapterManager = new ElmarketApp.Elmarket33DataSetTableAdapters.TableAdapterManager();
            this.elmarket33DataSet1 = new ElmarketApp.Elmarket33DataSet1();
            this.fakt_OstatkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fakt_OstatkiTableAdapter1 = new ElmarketApp.Elmarket33DataSet1TableAdapters.Fakt_OstatkiTableAdapter();
            this.tableAdapterManager1 = new ElmarketApp.Elmarket33DataSet1TableAdapters.TableAdapterManager();
            this.button3 = new System.Windows.Forms.Button();
            this.faktOstatkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.elmarketNewDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.elmarketNewDataSet2 = new ElmarketApp.ElmarketNewDataSet2();
            this.fakt_OstatkiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.elmarketNewDataSet1 = new ElmarketApp.ElmarketNewDataSet1();
            this.fakt_OstatkiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fakt_OstatkiTableAdapter2 = new ElmarketApp.ElmarketNewDataSet1TableAdapters.Fakt_OstatkiTableAdapter();
            this.tableAdapterManager2 = new ElmarketApp.ElmarketNewDataSet1TableAdapters.TableAdapterManager();
            this.fakt_OstatkiTableAdapter3 = new ElmarketApp.ElmarketNewDataSet2TableAdapters.Fakt_OstatkiTableAdapter();
            this.tableAdapterManager3 = new ElmarketApp.ElmarketNewDataSet2TableAdapters.TableAdapterManager();
            this.fakt_OstatkiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elmarketNewDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faktOstatkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.elmarket33DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakt_OstatkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarket33DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakt_OstatkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faktOstatkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakt_OstatkiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakt_OstatkiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakt_OstatkiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faktOstatkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(40, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "обновление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // elmarket33DataSet
            // 
            this.elmarket33DataSet.DataSetName = "Elmarket33DataSet";
            this.elmarket33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fakt_OstatkiBindingSource
            // 
            this.fakt_OstatkiBindingSource.DataMember = "Fakt_Ostatki";
            this.fakt_OstatkiBindingSource.DataSource = this.elmarket33DataSet;
            // 
            // fakt_OstatkiTableAdapter
            // 
            this.fakt_OstatkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Fakt_OstatkiTableAdapter = this.fakt_OstatkiTableAdapter;
            this.tableAdapterManager.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.ProizvoditelTableAdapter = null;
            this.tableAdapterManager.Rasxod1TableAdapter = null;
            this.tableAdapterManager.Tek_OstatkiTableAdapter = null;
            this.tableAdapterManager.TovarsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ElmarketApp.Elmarket33DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_tovaraTableAdapter = null;
            // 
            // elmarket33DataSet1
            // 
            this.elmarket33DataSet1.DataSetName = "Elmarket33DataSet1";
            this.elmarket33DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fakt_OstatkiBindingSource1
            // 
            this.fakt_OstatkiBindingSource1.DataMember = "Fakt_Ostatki";
            this.fakt_OstatkiBindingSource1.DataSource = this.elmarket33DataSet1;
            // 
            // fakt_OstatkiTableAdapter1
            // 
            this.fakt_OstatkiTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Fakt_OstatkiTableAdapter = this.fakt_OstatkiTableAdapter1;
            this.tableAdapterManager1.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager1.PrixodTableAdapter = null;
            this.tableAdapterManager1.ProizvoditelTableAdapter = null;
            this.tableAdapterManager1.Rasxod1TableAdapter = null;
            this.tableAdapterManager1.Tek_OstatkiTableAdapter = null;
            this.tableAdapterManager1.TovarsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ElmarketApp.Elmarket33DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Vid_tovaraTableAdapter = null;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(461, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // faktOstatkiBindingSource1
            // 
            this.faktOstatkiBindingSource1.DataMember = "Fakt_Ostatki";
            this.faktOstatkiBindingSource1.DataSource = this.elmarketNewDataSet2BindingSource1;
            // 
            // elmarketNewDataSet2BindingSource1
            // 
            this.elmarketNewDataSet2BindingSource1.DataSource = this.elmarketNewDataSet2;
            this.elmarketNewDataSet2BindingSource1.Position = 0;
            // 
            // elmarketNewDataSet2
            // 
            this.elmarketNewDataSet2.DataSetName = "ElmarketNewDataSet2";
            this.elmarketNewDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fakt_OstatkiBindingSource3
            // 
            this.fakt_OstatkiBindingSource3.DataMember = "Fakt_Ostatki";
            this.fakt_OstatkiBindingSource3.DataSource = this.elmarketNewDataSet2;
            // 
            // elmarketNewDataSet1
            // 
            this.elmarketNewDataSet1.DataSetName = "ElmarketNewDataSet1";
            this.elmarketNewDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fakt_OstatkiBindingSource2
            // 
            this.fakt_OstatkiBindingSource2.DataMember = "Fakt_Ostatki";
            this.fakt_OstatkiBindingSource2.DataSource = this.elmarketNewDataSet1;
            // 
            // fakt_OstatkiTableAdapter2
            // 
            this.fakt_OstatkiTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Fakt_OstatkiTableAdapter = this.fakt_OstatkiTableAdapter2;
            this.tableAdapterManager2.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager2.PrixodTableAdapter = null;
            this.tableAdapterManager2.ProizvoditelTableAdapter = null;
            this.tableAdapterManager2.Rasxod1TableAdapter = null;
            this.tableAdapterManager2.TableTableAdapter = null;
            this.tableAdapterManager2.Tek_OstatkiTableAdapter = null;
            this.tableAdapterManager2.TovarsTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = ElmarketApp.ElmarketNewDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.Vid_tovaraTableAdapter = null;
            // 
            // fakt_OstatkiTableAdapter3
            // 
            this.fakt_OstatkiTableAdapter3.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Fakt_OstatkiTableAdapter = this.fakt_OstatkiTableAdapter3;
            this.tableAdapterManager3.Mesto_xraneniyaTableAdapter = null;
            this.tableAdapterManager3.PrixodTableAdapter = null;
            this.tableAdapterManager3.ProizvoditelTableAdapter = null;
            this.tableAdapterManager3.Rasxod1TableAdapter = null;
            this.tableAdapterManager3.Table11TableAdapter = null;
            this.tableAdapterManager3.TableTableAdapter = null;
            this.tableAdapterManager3.Tek_OstatkiTableAdapter = null;
            this.tableAdapterManager3.TovarsTableAdapter = null;
            this.tableAdapterManager3.UpdateOrder = ElmarketApp.ElmarketNewDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager3.Vid_tovaraTableAdapter = null;
            // 
            // fakt_OstatkiDataGridView
            // 
            this.fakt_OstatkiDataGridView.AutoGenerateColumns = false;
            this.fakt_OstatkiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fakt_OstatkiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.fakt_OstatkiDataGridView.DataSource = this.fakt_OstatkiBindingSource3;
            this.fakt_OstatkiDataGridView.Location = new System.Drawing.Point(40, 3);
            this.fakt_OstatkiDataGridView.Name = "fakt_OstatkiDataGridView";
            this.fakt_OstatkiDataGridView.RowHeadersWidth = 51;
            this.fakt_OstatkiDataGridView.RowTemplate.Height = 24;
            this.fakt_OstatkiDataGridView.Size = new System.Drawing.Size(530, 272);
            this.fakt_OstatkiDataGridView.TabIndex = 14;
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
            this.dataGridViewTextBoxColumn3.HeaderText = "ИД продукт";
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
            this.dataGridViewTextBoxColumn5.HeaderText = "количество";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // elmarketNewDataSet2BindingSource
            // 
            this.elmarketNewDataSet2BindingSource.DataSource = this.elmarketNewDataSet2;
            this.elmarketNewDataSet2BindingSource.Position = 0;
            // 
            // faktOstatkiBindingSource
            // 
            this.faktOstatkiBindingSource.DataMember = "Fakt_Ostatki";
            this.faktOstatkiBindingSource.DataSource = this.elmarketNewDataSet2BindingSource;
            // 
            // Fakt_ostatkii2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 404);
            this.Controls.Add(this.fakt_OstatkiDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fakt_ostatkii2";
            this.Text = "Fakt_ostatkii2";
            this.Load += new System.EventHandler(this.Fakt_ostatkii2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elmarket33DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakt_OstatkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarket33DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakt_OstatkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faktOstatkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakt_OstatkiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakt_OstatkiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakt_OstatkiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elmarketNewDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faktOstatkiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Elmarket33DataSet elmarket33DataSet;
        private System.Windows.Forms.BindingSource fakt_OstatkiBindingSource;
        private Elmarket33DataSetTableAdapters.Fakt_OstatkiTableAdapter fakt_OstatkiTableAdapter;
        private Elmarket33DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Elmarket33DataSet1 elmarket33DataSet1;
        private System.Windows.Forms.BindingSource fakt_OstatkiBindingSource1;
        private Elmarket33DataSet1TableAdapters.Fakt_OstatkiTableAdapter fakt_OstatkiTableAdapter1;
        private Elmarket33DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button3;
        private ElmarketNewDataSet1 elmarketNewDataSet1;
        private System.Windows.Forms.BindingSource fakt_OstatkiBindingSource2;
        private ElmarketNewDataSet1TableAdapters.Fakt_OstatkiTableAdapter fakt_OstatkiTableAdapter2;
        private ElmarketNewDataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
        private ElmarketNewDataSet2 elmarketNewDataSet2;
        private System.Windows.Forms.BindingSource fakt_OstatkiBindingSource3;
        private ElmarketNewDataSet2TableAdapters.Fakt_OstatkiTableAdapter fakt_OstatkiTableAdapter3;
        private ElmarketNewDataSet2TableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.DataGridView fakt_OstatkiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource faktOstatkiBindingSource;
        private System.Windows.Forms.BindingSource elmarketNewDataSet2BindingSource;
        private System.Windows.Forms.BindingSource faktOstatkiBindingSource1;
        private System.Windows.Forms.BindingSource elmarketNewDataSet2BindingSource1;
    }
}