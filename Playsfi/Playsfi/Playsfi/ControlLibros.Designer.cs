namespace Playsfi
{
    partial class ControlLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlLibros));
            this.tbControlLibros = new System.Windows.Forms.TabControl();
            this.cmsInformes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.informePorCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeFavorítosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeDescatalogádosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgLibros = new System.Windows.Forms.DataGridView();
            this.libroidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoríaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexionCasa = new Playsfi.ConexionCasa();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbTituloBorrar = new System.Windows.Forms.ComboBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtgBorrados = new System.Windows.Forms.DataGridView();
            this.btnSeVa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBuscaFav = new System.Windows.Forms.Button();
            this.cmbBusca = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbTituloFav = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.dtgFavs = new System.Windows.Forms.DataGridView();
            this.btnFav = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbTituloModificar = new System.Windows.Forms.ComboBox();
            this.btnTodosCambian = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIsbnCambio = new System.Windows.Forms.TextBox();
            this.txtAutorCambio = new System.Windows.Forms.TextBox();
            this.txtCategoriaCambio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnTCampos = new System.Windows.Forms.Button();
            this.btnUnCampo = new System.Windows.Forms.Button();
            this.txtDniUser = new System.Windows.Forms.TextBox();
            this.txtEdadUser = new System.Windows.Forms.TextBox();
            this.txtApeUser = new System.Windows.Forms.TextBox();
            this.txtNomUser = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.cmbTituloBusca = new System.Windows.Forms.ComboBox();
            this.btnBuscaAutor = new System.Windows.Forms.Button();
            this.btnBuscaTtulo = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.librosTableAdapter = new Playsfi.ConexionCasaTableAdapters.LibrosTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tltAñadir = new System.Windows.Forms.ToolTip(this.components);
            this.tltEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.tltFavs = new System.Windows.Forms.ToolTip(this.components);
            this.tltBuscaFav = new System.Windows.Forms.ToolTip(this.components);
            this.tltUnCampo = new System.Windows.Forms.ToolTip(this.components);
            this.tltTodos = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.tbControlLibros.SuspendLayout();
            this.cmsInformes.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionCasa)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBorrados)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFavs)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlLibros
            // 
            this.tbControlLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbControlLibros.ContextMenuStrip = this.cmsInformes;
            this.tbControlLibros.Controls.Add(this.tabPage6);
            this.tbControlLibros.Controls.Add(this.tabPage1);
            this.tbControlLibros.Controls.Add(this.tabPage2);
            this.tbControlLibros.Controls.Add(this.tabPage3);
            this.tbControlLibros.Controls.Add(this.tabPage4);
            this.tbControlLibros.Controls.Add(this.tabPage5);
            this.tbControlLibros.Controls.Add(this.tabPage7);
            this.helpProvider1.SetHelpKeyword(this.tbControlLibros, "F1");
            this.tbControlLibros.Location = new System.Drawing.Point(9, 10);
            this.tbControlLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbControlLibros.Name = "tbControlLibros";
            this.tbControlLibros.SelectedIndex = 0;
            this.helpProvider1.SetShowHelp(this.tbControlLibros, true);
            this.tbControlLibros.Size = new System.Drawing.Size(595, 335);
            this.tbControlLibros.TabIndex = 0;
            // 
            // cmsInformes
            // 
            this.cmsInformes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInformes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informePorCategoríasToolStripMenuItem,
            this.informeDeFavorítosToolStripMenuItem,
            this.informeDeDescatalogádosToolStripMenuItem});
            this.cmsInformes.Name = "contextMenuStrip1";
            this.cmsInformes.Size = new System.Drawing.Size(218, 70);
            // 
            // informePorCategoríasToolStripMenuItem
            // 
            this.informePorCategoríasToolStripMenuItem.Name = "informePorCategoríasToolStripMenuItem";
            this.informePorCategoríasToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.informePorCategoríasToolStripMenuItem.Text = "Informe por categorías";
            this.informePorCategoríasToolStripMenuItem.Click += new System.EventHandler(this.informePorCategoríasToolStripMenuItem_Click);
            // 
            // informeDeFavorítosToolStripMenuItem
            // 
            this.informeDeFavorítosToolStripMenuItem.Name = "informeDeFavorítosToolStripMenuItem";
            this.informeDeFavorítosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.informeDeFavorítosToolStripMenuItem.Text = "Informe de favorítos";
            this.informeDeFavorítosToolStripMenuItem.Click += new System.EventHandler(this.informeDeFavorítosToolStripMenuItem_Click);
            // 
            // informeDeDescatalogádosToolStripMenuItem
            // 
            this.informeDeDescatalogádosToolStripMenuItem.Name = "informeDeDescatalogádosToolStripMenuItem";
            this.informeDeDescatalogádosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.informeDeDescatalogádosToolStripMenuItem.Text = "Informe de descatalogádos";
            this.informeDeDescatalogádosToolStripMenuItem.Click += new System.EventHandler(this.informeDeDescatalogádosToolStripMenuItem_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.dtgLibros);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Size = new System.Drawing.Size(587, 309);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Mis Libros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estós son tus libros, \r\nsi deseas hacer algún cambio selecciona la pestaña corres" +
    "pondiente";
            // 
            // dtgLibros
            // 
            this.dtgLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgLibros.AutoGenerateColumns = false;
            this.dtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libroidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.categoríaDataGridViewTextBoxColumn});
            this.dtgLibros.DataSource = this.librosBindingSource;
            this.dtgLibros.Location = new System.Drawing.Point(34, 61);
            this.dtgLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgLibros.Name = "dtgLibros";
            this.dtgLibros.RowHeadersWidth = 51;
            this.dtgLibros.RowTemplate.Height = 24;
            this.dtgLibros.Size = new System.Drawing.Size(549, 244);
            this.dtgLibros.TabIndex = 0;
            // 
            // libroidDataGridViewTextBoxColumn
            // 
            this.libroidDataGridViewTextBoxColumn.DataPropertyName = "libro_id";
            this.libroidDataGridViewTextBoxColumn.HeaderText = "libro_id";
            this.libroidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.libroidDataGridViewTextBoxColumn.Name = "libroidDataGridViewTextBoxColumn";
            this.libroidDataGridViewTextBoxColumn.Width = 125;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoríaDataGridViewTextBoxColumn
            // 
            this.categoríaDataGridViewTextBoxColumn.DataPropertyName = "categoría";
            this.categoríaDataGridViewTextBoxColumn.HeaderText = "categoría";
            this.categoríaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoríaDataGridViewTextBoxColumn.Name = "categoríaDataGridViewTextBoxColumn";
            this.categoríaDataGridViewTextBoxColumn.Width = 125;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.conexionCasa;
            // 
            // conexionCasa
            // 
            this.conexionCasa.DataSetName = "ConexionCasa";
            this.conexionCasa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.btnInsertar);
            this.tabPage1.Controls.Add(this.txtCategoria);
            this.tabPage1.Controls.Add(this.txtAutor);
            this.tabPage1.Controls.Add(this.txtTitulo);
            this.tabPage1.Controls.Add(this.txtIsbn);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(587, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Añadir Libro";
            // 
            // btnInsertar
            // 
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsertar.Location = new System.Drawing.Point(161, 181);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 28);
            this.btnInsertar.TabIndex = 9;
            this.btnInsertar.Text = "Insertar";
            this.tltAñadir.SetToolTip(this.btnInsertar, "btnInsertar");
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(191, 139);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(129, 20);
            this.txtCategoria.TabIndex = 8;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(191, 110);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(129, 20);
            this.txtAutor.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(191, 82);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(129, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(191, 49);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(129, 20);
            this.txtIsbn.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(442, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Rellena estos campos para añadir un nuevo libro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ISBN:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.cmbTituloBorrar);
            this.tabPage2.Controls.Add(this.txtRazon);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.dtgBorrados);
            this.tabPage2.Controls.Add(this.btnSeVa);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(587, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar Libro";
            // 
            // cmbTituloBorrar
            // 
            this.cmbTituloBorrar.FormattingEnabled = true;
            this.cmbTituloBorrar.Location = new System.Drawing.Point(26, 52);
            this.cmbTituloBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTituloBorrar.Name = "cmbTituloBorrar";
            this.cmbTituloBorrar.Size = new System.Drawing.Size(156, 21);
            this.cmbTituloBorrar.TabIndex = 6;
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(26, 128);
            this.txtRazon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRazon.Multiline = true;
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(155, 62);
            this.txtRazon.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label15.Location = new System.Drawing.Point(23, 93);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "¿Por qué lo vas a eliminar?";
            // 
            // dtgBorrados
            // 
            this.dtgBorrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBorrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBorrados.Location = new System.Drawing.Point(240, 82);
            this.dtgBorrados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgBorrados.Name = "dtgBorrados";
            this.dtgBorrados.RowHeadersWidth = 51;
            this.dtgBorrados.RowTemplate.Height = 24;
            this.dtgBorrados.Size = new System.Drawing.Size(320, 202);
            this.dtgBorrados.TabIndex = 3;
            // 
            // btnSeVa
            // 
            this.btnSeVa.Location = new System.Drawing.Point(55, 202);
            this.btnSeVa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeVa.Name = "btnSeVa";
            this.btnSeVa.Size = new System.Drawing.Size(124, 19);
            this.btnSeVa.TabIndex = 2;
            this.btnSeVa.Text = "Borrar";
            this.tltEliminar.SetToolTip(this.btnSeVa, "btnSeVa");
            this.btnSeVa.UseVisualStyleBackColor = true;
            this.btnSeVa.Click += new System.EventHandler(this.btnSeVa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label7.Location = new System.Drawing.Point(23, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dame el título del libro que deseas eliminar";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.Controls.Add(this.btnBuscaFav);
            this.tabPage3.Controls.Add(this.cmbBusca);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.cmbTituloFav);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.txtNota);
            this.tabPage3.Controls.Add(this.dtgFavs);
            this.tabPage3.Controls.Add(this.btnFav);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(587, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Añadir a favoritos";
            // 
            // btnBuscaFav
            // 
            this.btnBuscaFav.Location = new System.Drawing.Point(7, 243);
            this.btnBuscaFav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscaFav.Name = "btnBuscaFav";
            this.btnBuscaFav.Size = new System.Drawing.Size(99, 19);
            this.btnBuscaFav.TabIndex = 9;
            this.btnBuscaFav.Text = "Buscar";
            this.tltBuscaFav.SetToolTip(this.btnBuscaFav, "btnBuscaFav");
            this.btnBuscaFav.UseVisualStyleBackColor = true;
            this.btnBuscaFav.Click += new System.EventHandler(this.btnBuscaFav_Click);
            // 
            // cmbBusca
            // 
            this.cmbBusca.FormattingEnabled = true;
            this.cmbBusca.Location = new System.Drawing.Point(7, 210);
            this.cmbBusca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBusca.Name = "cmbBusca";
            this.cmbBusca.Size = new System.Drawing.Size(100, 21);
            this.cmbBusca.TabIndex = 8;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label25.Location = new System.Drawing.Point(4, 184);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(153, 16);
            this.label25.TabIndex = 7;
            this.label25.Text = "Buscar favorito por título:";
            // 
            // cmbTituloFav
            // 
            this.cmbTituloFav.FormattingEnabled = true;
            this.cmbTituloFav.Location = new System.Drawing.Point(9, 49);
            this.cmbTituloFav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTituloFav.Name = "cmbTituloFav";
            this.cmbTituloFav.Size = new System.Drawing.Size(98, 21);
            this.cmbTituloFav.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label22.Location = new System.Drawing.Point(7, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(140, 16);
            this.label22.TabIndex = 5;
            this.label22.Text = "Califícalo con una nota:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(7, 113);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 4;
            // 
            // dtgFavs
            // 
            this.dtgFavs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgFavs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFavs.Location = new System.Drawing.Point(201, 49);
            this.dtgFavs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgFavs.Name = "dtgFavs";
            this.dtgFavs.RowHeadersWidth = 51;
            this.dtgFavs.RowTemplate.Height = 24;
            this.dtgFavs.Size = new System.Drawing.Size(371, 246);
            this.dtgFavs.TabIndex = 3;
            // 
            // btnFav
            // 
            this.btnFav.Location = new System.Drawing.Point(8, 148);
            this.btnFav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(115, 19);
            this.btnFav.TabIndex = 2;
            this.btnFav.Text = "Favorito";
            this.tltFavs.SetToolTip(this.btnFav, "btnFav");
            this.btnFav.UseVisualStyleBackColor = true;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label8.Location = new System.Drawing.Point(4, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dame el título del libro que deseas agregar a favoritos";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage4.Controls.Add(this.cmbTituloModificar);
            this.tabPage4.Controls.Add(this.btnTodosCambian);
            this.tabPage4.Controls.Add(this.btnModificar);
            this.tabPage4.Controls.Add(this.txtIsbnCambio);
            this.tabPage4.Controls.Add(this.txtAutorCambio);
            this.tabPage4.Controls.Add(this.txtCategoriaCambio);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(587, 309);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Modificar Libro";
            // 
            // cmbTituloModificar
            // 
            this.cmbTituloModificar.FormattingEnabled = true;
            this.cmbTituloModificar.Location = new System.Drawing.Point(247, 80);
            this.cmbTituloModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTituloModificar.Name = "cmbTituloModificar";
            this.cmbTituloModificar.Size = new System.Drawing.Size(95, 21);
            this.cmbTituloModificar.TabIndex = 12;
            // 
            // btnTodosCambian
            // 
            this.btnTodosCambian.Location = new System.Drawing.Point(286, 230);
            this.btnTodosCambian.Name = "btnTodosCambian";
            this.btnTodosCambian.Size = new System.Drawing.Size(124, 23);
            this.btnTodosCambian.TabIndex = 11;
            this.btnTodosCambian.Text = "Modificar todos";
            this.tltTodos.SetToolTip(this.btnTodosCambian, "btnTodosCambian");
            this.btnTodosCambian.UseVisualStyleBackColor = true;
            this.btnTodosCambian.Click += new System.EventHandler(this.btnTodosCambian_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(286, 199);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 25);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar un campo";
            this.tltUnCampo.SetToolTip(this.btnModificar, "btnModificar");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIsbnCambio
            // 
            this.txtIsbnCambio.Location = new System.Drawing.Point(247, 109);
            this.txtIsbnCambio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIsbnCambio.Name = "txtIsbnCambio";
            this.txtIsbnCambio.Size = new System.Drawing.Size(95, 20);
            this.txtIsbnCambio.TabIndex = 8;
            // 
            // txtAutorCambio
            // 
            this.txtAutorCambio.Location = new System.Drawing.Point(247, 140);
            this.txtAutorCambio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAutorCambio.Name = "txtAutorCambio";
            this.txtAutorCambio.Size = new System.Drawing.Size(95, 20);
            this.txtAutorCambio.TabIndex = 7;
            // 
            // txtCategoriaCambio
            // 
            this.txtCategoriaCambio.Location = new System.Drawing.Point(247, 167);
            this.txtCategoriaCambio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategoriaCambio.Name = "txtCategoriaCambio";
            this.txtCategoriaCambio.Size = new System.Drawing.Size(95, 20);
            this.txtCategoriaCambio.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label14.Location = new System.Drawing.Point(172, 167);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Categoría:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label13.Location = new System.Drawing.Point(175, 140);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Autor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label12.Location = new System.Drawing.Point(175, 109);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "ISBN:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label11.Location = new System.Drawing.Point(172, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Título:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label10.Location = new System.Drawing.Point(128, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "El título es obligatorio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 14F);
            this.label9.Location = new System.Drawing.Point(72, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(479, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Rellena solo los campos que deseas modifiar del libro";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage5.Controls.Add(this.btnTCampos);
            this.tabPage5.Controls.Add(this.btnUnCampo);
            this.tabPage5.Controls.Add(this.txtDniUser);
            this.tabPage5.Controls.Add(this.txtEdadUser);
            this.tabPage5.Controls.Add(this.txtApeUser);
            this.tabPage5.Controls.Add(this.txtNomUser);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(587, 309);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Modificar cuenta";
            // 
            // btnTCampos
            // 
            this.btnTCampos.Location = new System.Drawing.Point(332, 203);
            this.btnTCampos.Name = "btnTCampos";
            this.btnTCampos.Size = new System.Drawing.Size(125, 23);
            this.btnTCampos.TabIndex = 12;
            this.btnTCampos.Text = "Modificar todo";
            this.tltTodos.SetToolTip(this.btnTCampos, "btnTCampos");
            this.btnTCampos.UseVisualStyleBackColor = true;
            this.btnTCampos.Click += new System.EventHandler(this.btnTCampos_Click);
            // 
            // btnUnCampo
            // 
            this.btnUnCampo.Location = new System.Drawing.Point(332, 173);
            this.btnUnCampo.Name = "btnUnCampo";
            this.btnUnCampo.Size = new System.Drawing.Size(125, 23);
            this.btnUnCampo.TabIndex = 11;
            this.btnUnCampo.Text = "Modificar un campo";
            this.tltUnCampo.SetToolTip(this.btnUnCampo, "btnUnCampo");
            this.btnUnCampo.UseVisualStyleBackColor = true;
            this.btnUnCampo.Click += new System.EventHandler(this.btnUnCampo_Click);
            // 
            // txtDniUser
            // 
            this.txtDniUser.Location = new System.Drawing.Point(199, 177);
            this.txtDniUser.Name = "txtDniUser";
            this.txtDniUser.Size = new System.Drawing.Size(100, 20);
            this.txtDniUser.TabIndex = 10;
            // 
            // txtEdadUser
            // 
            this.txtEdadUser.Location = new System.Drawing.Point(199, 146);
            this.txtEdadUser.Name = "txtEdadUser";
            this.txtEdadUser.Size = new System.Drawing.Size(100, 20);
            this.txtEdadUser.TabIndex = 9;
            // 
            // txtApeUser
            // 
            this.txtApeUser.Location = new System.Drawing.Point(199, 115);
            this.txtApeUser.Name = "txtApeUser";
            this.txtApeUser.Size = new System.Drawing.Size(100, 20);
            this.txtApeUser.TabIndex = 8;
            // 
            // txtNomUser
            // 
            this.txtNomUser.Location = new System.Drawing.Point(199, 85);
            this.txtNomUser.Name = "txtNomUser";
            this.txtNomUser.Size = new System.Drawing.Size(100, 20);
            this.txtNomUser.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label21.Location = new System.Drawing.Point(130, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 16);
            this.label21.TabIndex = 6;
            this.label21.Text = "DNI:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label20.Location = new System.Drawing.Point(130, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 16);
            this.label20.TabIndex = 5;
            this.label20.Text = "Edad:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label19.Location = new System.Drawing.Point(126, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "Apellidos:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label18.Location = new System.Drawing.Point(126, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 16);
            this.label18.TabIndex = 3;
            this.label18.Text = "Nombre: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(47, 33);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(524, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Rellena solo los campos que deseas modifiar de tú cuenta";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage7.Controls.Add(this.cmbAutores);
            this.tabPage7.Controls.Add(this.cmbTituloBusca);
            this.tabPage7.Controls.Add(this.btnBuscaAutor);
            this.tabPage7.Controls.Add(this.btnBuscaTtulo);
            this.tabPage7.Controls.Add(this.txtBusqueda);
            this.tabPage7.Controls.Add(this.label24);
            this.tabPage7.Controls.Add(this.label23);
            this.tabPage7.Controls.Add(this.label17);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage7.Size = new System.Drawing.Size(587, 309);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Busqueda";
            // 
            // cmbAutores
            // 
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(127, 108);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(100, 21);
            this.cmbAutores.TabIndex = 9;
            // 
            // cmbTituloBusca
            // 
            this.cmbTituloBusca.FormattingEnabled = true;
            this.cmbTituloBusca.Location = new System.Drawing.Point(127, 79);
            this.cmbTituloBusca.Name = "cmbTituloBusca";
            this.cmbTituloBusca.Size = new System.Drawing.Size(100, 21);
            this.cmbTituloBusca.TabIndex = 8;
            // 
            // btnBuscaAutor
            // 
            this.btnBuscaAutor.Location = new System.Drawing.Point(249, 108);
            this.btnBuscaAutor.Name = "btnBuscaAutor";
            this.btnBuscaAutor.Size = new System.Drawing.Size(99, 23);
            this.btnBuscaAutor.TabIndex = 7;
            this.btnBuscaAutor.Text = "Buscar por autor";
            this.btnBuscaAutor.UseVisualStyleBackColor = true;
            this.btnBuscaAutor.Click += new System.EventHandler(this.btnBuscaAutor_Click);
            // 
            // btnBuscaTtulo
            // 
            this.btnBuscaTtulo.Location = new System.Drawing.Point(249, 79);
            this.btnBuscaTtulo.Name = "btnBuscaTtulo";
            this.btnBuscaTtulo.Size = new System.Drawing.Size(99, 23);
            this.btnBuscaTtulo.TabIndex = 6;
            this.btnBuscaTtulo.Text = "Buscar por título";
            this.btnBuscaTtulo.UseVisualStyleBackColor = true;
            this.btnBuscaTtulo.Click += new System.EventHandler(this.btnBuscaTtulo_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(77, 146);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(271, 139);
            this.txtBusqueda.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(74, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Autor:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(74, 84);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Titulo:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(473, 42);
            this.label17.TabIndex = 0;
            this.label17.Text = "Si no recuerdas algo de un libro yo creo que puedo ayudarte\r\nSolo necesito su tít" +
    "ulo o autor";
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(548, 349);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 19);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tltAñadir
            // 
            this.tltAñadir.ToolTipTitle = "Porfavor rellena todos los datos del libro que deseas añadir";
            // 
            // tltEliminar
            // 
            this.tltEliminar.ToolTipTitle = "Porfavor rellena todos los datos del libro que deseas eliminar";
            // 
            // tltFavs
            // 
            this.tltFavs.ToolTipTitle = "Porfavor rellena todos los datos del libro que deseas añadir a favoritos";
            // 
            // tltBuscaFav
            // 
            this.tltBuscaFav.ToolTipTitle = "Indica el título del libro a buscar";
            // 
            // tltUnCampo
            // 
            this.tltUnCampo.ToolTipTitle = "Si solo deseas modificar un campo, porfavor rellenalo.";
            // 
            // tltTodos
            // 
            this.tltTodos.ToolTipTitle = "Porfavor rellena todos los campos";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "G:\\23-24\\interfaces\\Proyecto\\GuiaUsuarioPlaysfi.chm";
            // 
            // btnAyuda
            // 
            this.helpProvider1.SetHelpKeyword(this.btnAyuda, "F1");
            this.btnAyuda.Location = new System.Drawing.Point(488, 350);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.helpProvider1.SetShowHelp(this.btnAyuda, true);
            this.btnAyuda.Size = new System.Drawing.Size(56, 19);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // ControlLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(615, 379);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tbControlLibros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ControlLibros";
            this.Text = " ";
            this.tbControlLibros.ResumeLayout(false);
            this.cmsInformes.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionCasa)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBorrados)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFavs)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlLibros;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dtgLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSeVa;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgFavs;
        private System.Windows.Forms.DataGridView dtgBorrados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIsbnCambio;
        private System.Windows.Forms.TextBox txtAutorCambio;
        private System.Windows.Forms.TextBox txtCategoriaCambio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnModificar;
        private ConexionCasa conexionCasa;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private ConexionCasaTableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn libroidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoríaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDniUser;
        private System.Windows.Forms.TextBox txtEdadUser;
        private System.Windows.Forms.TextBox txtApeUser;
        private System.Windows.Forms.TextBox txtNomUser;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnTodosCambian;
        private System.Windows.Forms.Button btnTCampos;
        private System.Windows.Forms.Button btnUnCampo;
        private System.Windows.Forms.ComboBox cmbTituloBorrar;
        private System.Windows.Forms.ComboBox cmbTituloFav;
        private System.Windows.Forms.ComboBox cmbTituloModificar;
        private System.Windows.Forms.ContextMenuStrip cmsInformes;
        private System.Windows.Forms.ToolStripMenuItem informePorCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeFavorítosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeDescatalogádosToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnBuscaAutor;
        private System.Windows.Forms.Button btnBuscaTtulo;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbTituloBusca;
        private System.Windows.Forms.ComboBox cmbAutores;
        private System.Windows.Forms.Button btnBuscaFav;
        private System.Windows.Forms.ComboBox cmbBusca;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ToolTip tltAñadir;
        private System.Windows.Forms.ToolTip tltEliminar;
        private System.Windows.Forms.ToolTip tltFavs;
        private System.Windows.Forms.ToolTip tltBuscaFav;
        private System.Windows.Forms.ToolTip tltUnCampo;
        private System.Windows.Forms.ToolTip tltTodos;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnAyuda;
    }
}