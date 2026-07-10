namespace SistemaGestionEmpresarial.Formularios
{
    partial class FrmProductos
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloSub = new System.Windows.Forms.Label();
            this.panelBarraRoja = new System.Windows.Forms.Panel();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.panelFormCard = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelDer = new System.Windows.Forms.Panel();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.lblFiltrosTitulo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.cmbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();

            this.panelTitulo.SuspendLayout();
            this.panelIzq.SuspendLayout();
            this.panelFormCard.SuspendLayout();
            this.panelDer.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();

            var ROJO = System.Drawing.Color.FromArgb(211, 47, 47);
            var NEGRO = System.Drawing.Color.FromArgb(28, 28, 28);
            var INPUT = System.Drawing.Color.FromArgb(40, 40, 40);

            // Título
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Height = 60;
            this.panelBarraRoja.BackColor = ROJO;
            this.panelBarraRoja.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBarraRoja.Width = 5;
            this.lblTitulo.Text = "📦  Gestión de Productos";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 8); this.lblTitulo.AutoSize = true;
            this.lblTituloSub.Text = "Administra el inventario con categorías";
            this.lblTituloSub.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblTituloSub.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblTituloSub.Location = new System.Drawing.Point(20, 38); this.lblTituloSub.AutoSize = true;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.lblTituloSub);
            this.panelTitulo.Controls.Add(this.panelBarraRoja);

            // Panel Izq
            this.panelIzq.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Width = 295;

            this.panelFormCard.BackColor = NEGRO;
            this.panelFormCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblCardTitle.Text = "✏️  Datos del Producto";
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardTitle.BackColor = ROJO;
            this.lblCardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardTitle.Height = 30;
            this.lblCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCardTitle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);

            int y = 40;
            void addF(System.Windows.Forms.Label l, string t, System.Windows.Forms.TextBox tb, int yy)
            {
                l.Text = t; l.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                l.ForeColor = ROJO; l.Location = new System.Drawing.Point(10, yy); l.AutoSize = true;
                tb.Location = new System.Drawing.Point(10, yy + 17); tb.Size = new System.Drawing.Size(248, 24);
                tb.Font = new System.Drawing.Font("Segoe UI", 9.5F); tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                tb.BackColor = INPUT; tb.ForeColor = System.Drawing.Color.White;
                this.panelFormCard.Controls.Add(l); this.panelFormCard.Controls.Add(tb);
            }

            addF(this.lblCodigo, "CÓDIGO:", this.txtCodigo, y); y += 50;
            addF(this.lblNombre, "NOMBRE:", this.txtNombre, y); y += 50;
            addF(this.lblPrecio, "PRECIO ($):", this.txtPrecio, y); this.txtPrecio.Text = "0"; y += 50;
            addF(this.lblStock, "STOCK:", this.txtStock, y); this.txtStock.Text = "0"; y += 50;

            this.lblCategoria.Text = "CATEGORÍA:"; this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.ForeColor = ROJO; this.lblCategoria.Location = new System.Drawing.Point(10, y); this.lblCategoria.AutoSize = true;
            this.cmbCategoria.Location = new System.Drawing.Point(10, y + 17); this.cmbCategoria.Size = new System.Drawing.Size(248, 24);
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.BackColor = INPUT; this.cmbCategoria.ForeColor = System.Drawing.Color.White;
            this.panelFormCard.Controls.Add(this.lblCategoria); this.panelFormCard.Controls.Add(this.cmbCategoria); y += 50;

            this.lblEstado.Text = "ESTADO:"; this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = ROJO; this.lblEstado.Location = new System.Drawing.Point(10, y); this.lblEstado.AutoSize = true;
            this.cmbEstado.Location = new System.Drawing.Point(10, y + 17); this.cmbEstado.Size = new System.Drawing.Size(248, 24);
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.BackColor = INPUT; this.cmbEstado.ForeColor = System.Drawing.Color.White;
            this.cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" }); this.cmbEstado.SelectedIndex = 0;
            this.panelFormCard.Controls.Add(this.lblEstado); this.panelFormCard.Controls.Add(this.cmbEstado);
            this.panelFormCard.Controls.Add(this.lblCardTitle);

            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Height = 50;

            void estBtn(System.Windows.Forms.Button b, string txt, int bx, int bw, System.Drawing.Color bg, System.EventHandler click)
            {
                b.Text = txt; b.Location = new System.Drawing.Point(bx, 5); b.Size = new System.Drawing.Size(bw, 38);
                b.BackColor = bg; b.ForeColor = System.Drawing.Color.White;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat; b.FlatAppearance.BorderSize = 0;
                b.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                b.Cursor = System.Windows.Forms.Cursors.Hand; b.Click += click;
            }

            estBtn(this.btnGuardar, "💾  Guardar", 0, 128, ROJO, this.btnGuardar_Click);
            estBtn(this.btnEliminar, "🗑️ Eliminar", 134, 90, System.Drawing.Color.FromArgb(60, 60, 60), this.btnEliminar_Click);
            estBtn(this.btnLimpiar, "🔄", 230, 42, System.Drawing.Color.FromArgb(45, 45, 45), this.btnLimpiar_Click);

            this.panelBotones.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnGuardar, this.btnEliminar, this.btnLimpiar });
            this.panelIzq.Controls.Add(this.panelFormCard);
            this.panelIzq.Controls.Add(this.panelBotones);

            // Panel Der
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);

            this.panelFiltros.BackColor = NEGRO;
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Height = 85;

            var barra = new System.Windows.Forms.Panel();
            barra.BackColor = ROJO; barra.Dock = System.Windows.Forms.DockStyle.Top; barra.Height = 3;

            this.lblFiltrosTitulo.Text = "🔍  Filtros de Búsqueda";
            this.lblFiltrosTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltrosTitulo.ForeColor = ROJO; this.lblFiltrosTitulo.Location = new System.Drawing.Point(10, 10); this.lblFiltrosTitulo.AutoSize = true;

            this.lblBuscar.Text = "ID / CÓDIGO / NOMBRE:"; this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150); this.lblBuscar.Location = new System.Drawing.Point(10, 35); this.lblBuscar.AutoSize = true;
            this.txtBuscar.Location = new System.Drawing.Point(10, 52); this.txtBuscar.Size = new System.Drawing.Size(240, 24);
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.BackColor = INPUT; this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

            this.lblFiltroCategoria.Text = "CATEGORÍA:"; this.lblFiltroCategoria.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroCategoria.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150); this.lblFiltroCategoria.Location = new System.Drawing.Point(262, 35); this.lblFiltroCategoria.AutoSize = true;
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(262, 52); this.cmbFiltroCategoria.Size = new System.Drawing.Size(185, 24);
            this.cmbFiltroCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cmbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroCategoria.BackColor = INPUT; this.cmbFiltroCategoria.ForeColor = System.Drawing.Color.White;
            this.cmbFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCategoria_SelectedIndexChanged);

            this.lblFiltroEstado.Text = "ESTADO:"; this.lblFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150); this.lblFiltroEstado.Location = new System.Drawing.Point(460, 35); this.lblFiltroEstado.AutoSize = true;
            this.cmbFiltroEstado.Location = new System.Drawing.Point(460, 52); this.cmbFiltroEstado.Size = new System.Drawing.Size(130, 24);
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.BackColor = INPUT; this.cmbFiltroEstado.ForeColor = System.Drawing.Color.White;
            this.cmbFiltroEstado.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" }); this.cmbFiltroEstado.SelectedIndex = 0;
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);

            this.lblTotal.Text = "Total: 0"; this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = ROJO; this.lblTotal.Location = new System.Drawing.Point(605, 56); this.lblTotal.AutoSize = true;

            this.panelFiltros.Controls.AddRange(new System.Windows.Forms.Control[] {
                barra, this.lblFiltrosTitulo, this.lblBuscar, this.txtBuscar,
                this.lblFiltroCategoria, this.cmbFiltroCategoria,
                this.lblFiltroEstado, this.cmbFiltroEstado, this.lblTotal });

            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.ReadOnly = true; this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = ROJO;
            this.dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvProductos.ColumnHeadersHeight = 34;
            this.dgvProductos.DefaultCellStyle.BackColor = NEGRO;
            this.dgvProductos.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvProductos.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvProductos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(150, 20, 20);
            this.dgvProductos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);

            this.panelDer.Controls.Add(this.dgvProductos);
            this.panelDer.Controls.Add(this.panelFiltros);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.Controls.Add(this.panelDer);
            this.Controls.Add(this.panelIzq);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmProductos"; this.Text = "Productos 📦";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.panelTitulo.ResumeLayout(false); this.panelTitulo.PerformLayout();
            this.panelIzq.ResumeLayout(false);
            this.panelFormCard.ResumeLayout(false); this.panelFormCard.PerformLayout();
            this.panelDer.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false); this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTitulo, panelIzq, panelDer;
        private System.Windows.Forms.Panel panelFormCard, panelBotones, panelFiltros, panelBarraRoja;
        private System.Windows.Forms.Label lblTitulo, lblTituloSub, lblCardTitle;
        private System.Windows.Forms.Label lblCodigo, lblNombre, lblPrecio, lblStock, lblCategoria, lblEstado;
        private System.Windows.Forms.Label lblFiltrosTitulo, lblBuscar, lblFiltroCategoria, lblFiltroEstado, lblTotal;
        private System.Windows.Forms.TextBox txtCodigo, txtNombre, txtPrecio, txtStock, txtBuscar;
        private System.Windows.Forms.ComboBox cmbCategoria, cmbEstado, cmbFiltroCategoria, cmbFiltroEstado;
        private System.Windows.Forms.Button btnGuardar, btnEliminar, btnLimpiar;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}