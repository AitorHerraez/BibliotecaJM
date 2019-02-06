namespace BibliotecaJM
{
    partial class FM_Prestamos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.gbBusquedaLector = new System.Windows.Forms.GroupBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnBuscarIDLector = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbIDLector = new System.Windows.Forms.TextBox();
            this.id_lecLabel1 = new System.Windows.Forms.Label();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.nombre_lecLabel1 = new System.Windows.Forms.Label();
            this.fecha_penalizacion_lecLabel1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbBusquedaLibro = new System.Windows.Forms.GroupBox();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.btnRealizarPrestamo = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.btnBuscarIdentificador = new System.Windows.Forms.Button();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dS_Prestamos = new BibliotecaJM.DS_Prestamos();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new BibliotecaJM.DS_PrestamosTableAdapters.prestamosTableAdapter();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager1 = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            this.tableAdapterManager2 = new BibliotecaJM.DS_PrestamosTableAdapters.TableAdapterManager();
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.tableAdapterManager3 = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.TableAdapterManager();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.gbBusquedaLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.gbBusquedaLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(31, 117);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(35, 13);
            id_lecLabel.TabIndex = 3;
            id_lecLabel.Text = "id lec:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(31, 140);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(62, 13);
            nombre_lecLabel.TabIndex = 5;
            nombre_lecLabel.Text = "nombre lec:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(31, 163);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(67, 13);
            domicilio_lecLabel.TabIndex = 7;
            domicilio_lecLabel.Text = "domicilio lec:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(31, 187);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(116, 13);
            fecha_penalizacion_lecLabel.TabIndex = 15;
            fecha_penalizacion_lecLabel.Text = "fecha penalizacion lec:";
            // 
            // gbBusquedaLector
            // 
            this.gbBusquedaLector.Controls.Add(this.btnBuscarNombre);
            this.gbBusquedaLector.Controls.Add(this.btnBuscarIDLector);
            this.gbBusquedaLector.Controls.Add(this.tbNombre);
            this.gbBusquedaLector.Controls.Add(this.tbIDLector);
            this.gbBusquedaLector.Controls.Add(id_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.id_lecLabel1);
            this.gbBusquedaLector.Controls.Add(nombre_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.nombre_lecLabel1);
            this.gbBusquedaLector.Controls.Add(domicilio_lecLabel);
            this.gbBusquedaLector.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbBusquedaLector.Controls.Add(this.fecha_penalizacion_lecLabel1);
            this.gbBusquedaLector.Controls.Add(this.label5);
            this.gbBusquedaLector.Controls.Add(this.label4);
            this.gbBusquedaLector.Location = new System.Drawing.Point(8, 12);
            this.gbBusquedaLector.Name = "gbBusquedaLector";
            this.gbBusquedaLector.Size = new System.Drawing.Size(439, 218);
            this.gbBusquedaLector.TabIndex = 0;
            this.gbBusquedaLector.TabStop = false;
            this.gbBusquedaLector.Text = "Busqueda Lector";
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(348, 64);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNombre.TabIndex = 19;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnBuscarIDLector
            // 
            this.btnBuscarIDLector.Location = new System.Drawing.Point(348, 26);
            this.btnBuscarIDLector.Name = "btnBuscarIDLector";
            this.btnBuscarIDLector.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarIDLector.TabIndex = 10;
            this.btnBuscarIDLector.Text = "Buscar";
            this.btnBuscarIDLector.UseVisualStyleBackColor = true;
            this.btnBuscarIDLector.Click += new System.EventHandler(this.btnBuscarIDLector_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(89, 67);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(253, 20);
            this.tbNombre.TabIndex = 18;
            // 
            // tbIDLector
            // 
            this.tbIDLector.Location = new System.Drawing.Point(89, 28);
            this.tbIDLector.Name = "tbIDLector";
            this.tbIDLector.Size = new System.Drawing.Size(253, 20);
            this.tbIDLector.TabIndex = 17;
            // 
            // id_lecLabel1
            // 
            this.id_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecLabel1.Location = new System.Drawing.Point(153, 117);
            this.id_lecLabel1.Name = "id_lecLabel1";
            this.id_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_lecLabel1.TabIndex = 4;
            this.id_lecLabel1.Text = "label6";
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombre_lecLabel1
            // 
            this.nombre_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecLabel1.Location = new System.Drawing.Point(153, 140);
            this.nombre_lecLabel1.Name = "nombre_lecLabel1";
            this.nombre_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.nombre_lecLabel1.TabIndex = 6;
            this.nombre_lecLabel1.Text = "label6";
            // 
            // fecha_penalizacion_lecLabel1
            // 
            this.fecha_penalizacion_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecLabel1.Location = new System.Drawing.Point(153, 187);
            this.fecha_penalizacion_lecLabel1.Name = "fecha_penalizacion_lecLabel1";
            this.fecha_penalizacion_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.fecha_penalizacion_lecLabel1.TabIndex = 16;
            this.fecha_penalizacion_lecLabel1.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Lector:";
            // 
            // gbBusquedaLibro
            // 
            this.gbBusquedaLibro.Controls.Add(this.librosDataGridView);
            this.gbBusquedaLibro.Controls.Add(this.btnRealizarPrestamo);
            this.gbBusquedaLibro.Controls.Add(this.btnBuscarAutor);
            this.gbBusquedaLibro.Controls.Add(this.btnBuscarTitulo);
            this.gbBusquedaLibro.Controls.Add(this.btnBuscarIdentificador);
            this.gbBusquedaLibro.Controls.Add(this.tbTitulo);
            this.gbBusquedaLibro.Controls.Add(this.tbAutor);
            this.gbBusquedaLibro.Controls.Add(this.tbIdentificador);
            this.gbBusquedaLibro.Controls.Add(this.label3);
            this.gbBusquedaLibro.Controls.Add(this.label2);
            this.gbBusquedaLibro.Controls.Add(this.label1);
            this.gbBusquedaLibro.Location = new System.Drawing.Point(462, 12);
            this.gbBusquedaLibro.Name = "gbBusquedaLibro";
            this.gbBusquedaLibro.Size = new System.Drawing.Size(542, 635);
            this.gbBusquedaLibro.TabIndex = 1;
            this.gbBusquedaLibro.TabStop = false;
            this.gbBusquedaLibro.Text = "Busqueda Libro";
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(6, 163);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(530, 416);
            this.librosDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "seccion_lib";
            this.dataGridViewTextBoxColumn4.HeaderText = "Seccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prestado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRealizarPrestamo
            // 
            this.btnRealizarPrestamo.Location = new System.Drawing.Point(8, 585);
            this.btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            this.btnRealizarPrestamo.Size = new System.Drawing.Size(528, 30);
            this.btnRealizarPrestamo.TabIndex = 20;
            this.btnRealizarPrestamo.Text = "REALIZAR PRESTAMO";
            this.btnRealizarPrestamo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Location = new System.Drawing.Point(350, 112);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAutor.TabIndex = 9;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // btnBuscarTitulo
            // 
            this.btnBuscarTitulo.Location = new System.Drawing.Point(350, 65);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTitulo.TabIndex = 8;
            this.btnBuscarTitulo.Text = "Buscar";
            this.btnBuscarTitulo.UseVisualStyleBackColor = true;
            this.btnBuscarTitulo.Click += new System.EventHandler(this.btnBuscarTitulo_Click);
            // 
            // btnBuscarIdentificador
            // 
            this.btnBuscarIdentificador.Location = new System.Drawing.Point(350, 20);
            this.btnBuscarIdentificador.Name = "btnBuscarIdentificador";
            this.btnBuscarIdentificador.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarIdentificador.TabIndex = 7;
            this.btnBuscarIdentificador.Text = "Buscar";
            this.btnBuscarIdentificador.UseVisualStyleBackColor = true;
            this.btnBuscarIdentificador.Click += new System.EventHandler(this.btnBuscarIdentificador_Click);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(94, 68);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(250, 20);
            this.tbTitulo.TabIndex = 6;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(94, 112);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(250, 20);
            this.tbAutor.TabIndex = 5;
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.Location = new System.Drawing.Point(94, 23);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.Size = new System.Drawing.Size(250, 20);
            this.tbIdentificador.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificador:";
            // 
            // dS_Prestamos
            // 
            this.dS_Prestamos.DataSetName = "DS_Prestamos";
            this.dS_Prestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "prestamos";
            this.prestamosBindingSource.DataSource = this.dS_Prestamos;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.lectoresTableAdapter = this.lectoresTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.prestamosTableAdapter = this.prestamosTableAdapter;
            this.tableAdapterManager2.UpdateOrder = BibliotecaJM.DS_PrestamosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = BibliotecaJM.DS_LibrosPrestadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AllowUserToAddRows = false;
            this.librosPrestadosDataGridView.AllowUserToDeleteRows = false;
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(8, 236);
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.ReadOnly = true;
            this.librosPrestadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(439, 411);
            this.librosPrestadosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn7.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha Prestamo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fecha Devolucion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.librosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1028, 700);
            this.Controls.Add(this.librosPrestadosDataGridView);
            this.Controls.Add(this.gbBusquedaLibro);
            this.Controls.Add(this.gbBusquedaLector);
            this.Name = "FM_Prestamos";
            this.Load += new System.EventHandler(this.FM_Prestamos_Load);
            this.gbBusquedaLector.ResumeLayout(false);
            this.gbBusquedaLector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.gbBusquedaLibro.ResumeLayout(false);
            this.gbBusquedaLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBusquedaLector;
        private System.Windows.Forms.GroupBox gbBusquedaLibro;
        private DS_Prestamos dS_Prestamos;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.Button btnBuscarIdentificador;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbIdentificador;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnBuscarIDLector;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbIDLector;
        private System.Windows.Forms.Label id_lecLabel1;
        private System.Windows.Forms.Label nombre_lecLabel1;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel1;
        private System.Windows.Forms.Button btnRealizarPrestamo;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DS_PrestamosTableAdapters.TableAdapterManager tableAdapterManager2;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private DS_LibrosPrestadosTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
