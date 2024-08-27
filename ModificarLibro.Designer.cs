namespace Integrador___Biblioteca
{
    partial class ModificarLibro
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
            this.dataGridView_Libro = new System.Windows.Forms.DataGridView();
            this._Integrador_LibreriaDataSet = new Integrador___Biblioteca._Integrador_LibreriaDataSet();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new Integrador___Biblioteca._Integrador_LibreriaDataSetTableAdapters.LibrosTableAdapter();
            this.tableAdapterManager = new Integrador___Biblioteca._Integrador_LibreriaDataSetTableAdapters.TableAdapterManager();
            this.button_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Libro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Integrador_LibreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Libro
            // 
            this.dataGridView_Libro.AllowUserToAddRows = false;
            this.dataGridView_Libro.AllowUserToDeleteRows = false;
            this.dataGridView_Libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Libro.Location = new System.Drawing.Point(32, 31);
            this.dataGridView_Libro.Name = "dataGridView_Libro";
            this.dataGridView_Libro.Size = new System.Drawing.Size(849, 115);
            this.dataGridView_Libro.TabIndex = 0;
            // 
            // _Integrador_LibreriaDataSet
            // 
            this._Integrador_LibreriaDataSet.DataSetName = "_Integrador_LibreriaDataSet";
            this._Integrador_LibreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this._Integrador_LibreriaDataSet;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EditorialesTableAdapter = null;
            this.tableAdapterManager.LibrosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Integrador___Biblioteca._Integrador_LibreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(370, 154);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(149, 23);
            this.button_guardar.TabIndex = 1;
            this.button_guardar.Text = "Guardar Cambios";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // ModificarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 189);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.dataGridView_Libro);
            this.Name = "ModificarLibro";
            this.Text = "ModificarLibro";
            this.Load += new System.EventHandler(this.ModificarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Libro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Integrador_LibreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Libro;
        private _Integrador_LibreriaDataSet _Integrador_LibreriaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private _Integrador_LibreriaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private _Integrador_LibreriaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button_guardar;
    }
}