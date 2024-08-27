namespace Integrador___Biblioteca
{
    partial class Libros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            this._Integrador_LibreriaDataSet = new Integrador___Biblioteca._Integrador_LibreriaDataSet();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new Integrador___Biblioteca._Integrador_LibreriaDataSetTableAdapters.LibrosTableAdapter();
            this.tableAdapterManager = new Integrador___Biblioteca._Integrador_LibreriaDataSetTableAdapters.TableAdapterManager();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.libroIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerNombreAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoNombreAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vista_LibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Editoriales = new System.Windows.Forms.ComboBox();
            this.editorialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editorialesTableAdapter = new Integrador___Biblioteca._Integrador_LibreriaDataSetTableAdapters.EditorialesTableAdapter();
            this.comboBox_Autores = new System.Windows.Forms.ComboBox();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoresTableAdapter = new Integrador___Biblioteca._Integrador_LibreriaDataSetTableAdapters.AutoresTableAdapter();
            this.vista_LibrosTableAdapter = new Integrador___Biblioteca._Integrador_LibreriaDataSetTableAdapters.Vista_LibrosTableAdapter();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.librosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.Buscar_Libros = new System.Windows.Forms.Button();
            this.checkBox_TodasLasEditoriales = new System.Windows.Forms.CheckBox();
            this.checkBox_TodosLosAutores = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.librosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Integrador_LibreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_LibrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingNavigator)).BeginInit();
            this.librosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libroIDDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.fechaPublicacionDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.editorialDataGridViewTextBoxColumn,
            this.primerNombreAutorDataGridViewTextBoxColumn,
            this.segundoNombreAutorDataGridViewTextBoxColumn,
            this.apellidoAutorDataGridViewTextBoxColumn});
            this.librosDataGridView.DataSource = this.vista_LibrosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(12, 28);
            this.librosDataGridView.MultiSelect = false;
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.Size = new System.Drawing.Size(1093, 369);
            this.librosDataGridView.TabIndex = 1;
            // 
            // libroIDDataGridViewTextBoxColumn
            // 
            this.libroIDDataGridViewTextBoxColumn.DataPropertyName = "LibroID";
            this.libroIDDataGridViewTextBoxColumn.HeaderText = "LibroID";
            this.libroIDDataGridViewTextBoxColumn.Name = "libroIDDataGridViewTextBoxColumn";
            this.libroIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 250;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPublicacionDataGridViewTextBoxColumn
            // 
            this.fechaPublicacionDataGridViewTextBoxColumn.DataPropertyName = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.HeaderText = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.Name = "fechaPublicacionDataGridViewTextBoxColumn";
            this.fechaPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editorialDataGridViewTextBoxColumn
            // 
            this.editorialDataGridViewTextBoxColumn.DataPropertyName = "Editorial";
            this.editorialDataGridViewTextBoxColumn.HeaderText = "Editorial";
            this.editorialDataGridViewTextBoxColumn.Name = "editorialDataGridViewTextBoxColumn";
            this.editorialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primerNombreAutorDataGridViewTextBoxColumn
            // 
            this.primerNombreAutorDataGridViewTextBoxColumn.DataPropertyName = "Primer Nombre Autor";
            this.primerNombreAutorDataGridViewTextBoxColumn.HeaderText = "Primer Nombre Autor";
            this.primerNombreAutorDataGridViewTextBoxColumn.Name = "primerNombreAutorDataGridViewTextBoxColumn";
            this.primerNombreAutorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // segundoNombreAutorDataGridViewTextBoxColumn
            // 
            this.segundoNombreAutorDataGridViewTextBoxColumn.DataPropertyName = "Segundo Nombre Autor";
            this.segundoNombreAutorDataGridViewTextBoxColumn.HeaderText = "Segundo Nombre Autor";
            this.segundoNombreAutorDataGridViewTextBoxColumn.Name = "segundoNombreAutorDataGridViewTextBoxColumn";
            this.segundoNombreAutorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoAutorDataGridViewTextBoxColumn
            // 
            this.apellidoAutorDataGridViewTextBoxColumn.DataPropertyName = "Apellido Autor";
            this.apellidoAutorDataGridViewTextBoxColumn.HeaderText = "Apellido Autor";
            this.apellidoAutorDataGridViewTextBoxColumn.Name = "apellidoAutorDataGridViewTextBoxColumn";
            this.apellidoAutorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vista_LibrosBindingSource
            // 
            this.vista_LibrosBindingSource.DataMember = "Vista Libros";
            this.vista_LibrosBindingSource.DataSource = this._Integrador_LibreriaDataSet;
            // 
            // comboBox_Editoriales
            // 
            this.comboBox_Editoriales.DataSource = this.editorialesBindingSource;
            this.comboBox_Editoriales.DisplayMember = "Nombre";
            this.comboBox_Editoriales.FormattingEnabled = true;
            this.comboBox_Editoriales.Location = new System.Drawing.Point(209, 412);
            this.comboBox_Editoriales.Name = "comboBox_Editoriales";
            this.comboBox_Editoriales.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Editoriales.TabIndex = 4;
            this.comboBox_Editoriales.ValueMember = "EditorialID";
            // 
            // editorialesBindingSource
            // 
            this.editorialesBindingSource.DataMember = "Editoriales";
            this.editorialesBindingSource.DataSource = this._Integrador_LibreriaDataSet;
            // 
            // editorialesTableAdapter
            // 
            this.editorialesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_Autores
            // 
            this.comboBox_Autores.DataSource = this.autoresBindingSource;
            this.comboBox_Autores.DisplayMember = "Apellido";
            this.comboBox_Autores.FormattingEnabled = true;
            this.comboBox_Autores.Location = new System.Drawing.Point(209, 449);
            this.comboBox_Autores.Name = "comboBox_Autores";
            this.comboBox_Autores.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Autores.TabIndex = 5;
            this.comboBox_Autores.ValueMember = "AutorID";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this._Integrador_LibreriaDataSet;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // vista_LibrosTableAdapter
            // 
            this.vista_LibrosTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // librosBindingNavigator
            // 
            this.librosBindingNavigator.AddNewItem = null;
            this.librosBindingNavigator.BindingSource = this.librosBindingSource;
            this.librosBindingNavigator.CountItem = null;
            this.librosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.librosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.Modificar});
            this.librosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.librosBindingNavigator.MoveFirstItem = null;
            this.librosBindingNavigator.MoveLastItem = null;
            this.librosBindingNavigator.MoveNextItem = null;
            this.librosBindingNavigator.MovePreviousItem = null;
            this.librosBindingNavigator.Name = "librosBindingNavigator";
            this.librosBindingNavigator.PositionItem = null;
            this.librosBindingNavigator.Size = new System.Drawing.Size(1125, 25);
            this.librosBindingNavigator.TabIndex = 0;
            this.librosBindingNavigator.Text = "bindingNavigator1";
            // 
            // Modificar
            // 
            this.Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Modificar.Image = global::Integrador___Biblioteca.Properties.Resources.edit_modify_icon_149489;
            this.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(23, 22);
            this.Modificar.Text = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Buscar_Libros
            // 
            this.Buscar_Libros.Location = new System.Drawing.Point(129, 491);
            this.Buscar_Libros.Name = "Buscar_Libros";
            this.Buscar_Libros.Size = new System.Drawing.Size(323, 23);
            this.Buscar_Libros.TabIndex = 9;
            this.Buscar_Libros.Text = "Buscar Libros";
            this.Buscar_Libros.UseVisualStyleBackColor = true;
            this.Buscar_Libros.Click += new System.EventHandler(this.Buscar_Libros_Click);
            // 
            // checkBox_TodasLasEditoriales
            // 
            this.checkBox_TodasLasEditoriales.AutoSize = true;
            this.checkBox_TodasLasEditoriales.Location = new System.Drawing.Point(365, 414);
            this.checkBox_TodasLasEditoriales.Name = "checkBox_TodasLasEditoriales";
            this.checkBox_TodasLasEditoriales.Size = new System.Drawing.Size(87, 17);
            this.checkBox_TodasLasEditoriales.TabIndex = 11;
            this.checkBox_TodasLasEditoriales.Text = "Incluir Todos";
            this.checkBox_TodasLasEditoriales.UseVisualStyleBackColor = true;
            this.checkBox_TodasLasEditoriales.CheckedChanged += new System.EventHandler(this.checkBox_TodasLasEditoriales_CheckedChanged);
            // 
            // checkBox_TodosLosAutores
            // 
            this.checkBox_TodosLosAutores.AutoSize = true;
            this.checkBox_TodosLosAutores.Location = new System.Drawing.Point(365, 451);
            this.checkBox_TodosLosAutores.Name = "checkBox_TodosLosAutores";
            this.checkBox_TodosLosAutores.Size = new System.Drawing.Size(87, 17);
            this.checkBox_TodosLosAutores.TabIndex = 12;
            this.checkBox_TodosLosAutores.Text = "Incluir Todos";
            this.checkBox_TodosLosAutores.UseVisualStyleBackColor = true;
            this.checkBox_TodosLosAutores.CheckedChanged += new System.EventHandler(this.checkBox_TodosLosAutores_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Editoriales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Autores";
            // 
            // librosBindingSource1
            // 
            this.librosBindingSource1.DataMember = "Libros";
            this.librosBindingSource1.DataSource = this._Integrador_LibreriaDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 69);
            this.button1.TabIndex = 15;
            this.button1.Text = "Crear Libro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_TodosLosAutores);
            this.Controls.Add(this.checkBox_TodasLasEditoriales);
            this.Controls.Add(this.Buscar_Libros);
            this.Controls.Add(this.comboBox_Autores);
            this.Controls.Add(this.comboBox_Editoriales);
            this.Controls.Add(this.librosDataGridView);
            this.Controls.Add(this.librosBindingNavigator);
            this.Name = "Libros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Integrador_LibreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_LibrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingNavigator)).EndInit();
            this.librosBindingNavigator.ResumeLayout(false);
            this.librosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Integrador_LibreriaDataSet _Integrador_LibreriaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private _Integrador_LibreriaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private _Integrador_LibreriaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.ComboBox comboBox_Editoriales;
        private System.Windows.Forms.BindingSource editorialesBindingSource;
        private _Integrador_LibreriaDataSetTableAdapters.EditorialesTableAdapter editorialesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_Autores;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private _Integrador_LibreriaDataSetTableAdapters.AutoresTableAdapter autoresTableAdapter;
        private System.Windows.Forms.BindingSource vista_LibrosBindingSource;
        private _Integrador_LibreriaDataSetTableAdapters.Vista_LibrosTableAdapter vista_LibrosTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator librosBindingNavigator;
        private System.Windows.Forms.Button Buscar_Libros;
        private System.Windows.Forms.CheckBox checkBox_TodasLasEditoriales;
        private System.Windows.Forms.CheckBox checkBox_TodosLosAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource librosBindingSource1;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn libroIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerNombreAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoNombreAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}