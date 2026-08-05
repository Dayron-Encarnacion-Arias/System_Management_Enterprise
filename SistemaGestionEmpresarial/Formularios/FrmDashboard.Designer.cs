namespace SistemaGestionEmpresarial.Formularios
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBienvenidaUsuario = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.panelCuerpo = new System.Windows.Forms.Panel();

            // TableLayout principal
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableCards = new System.Windows.Forms.TableLayoutPanel();
            this.tableGrids = new System.Windows.Forms.TableLayoutPanel();

            // Cards
            this.cardClientes = new System.Windows.Forms.Panel();
            this.lblCardClientes = new System.Windows.Forms.Label();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.lblClientesActivos = new System.Windows.Forms.Label();
            this.lblClientesInact = new System.Windows.Forms.Label();
            this.lblCALbl = new System.Windows.Forms.Label();
            this.lblCILbl = new System.Windows.Forms.Label();

            this.cardProductos = new System.Windows.Forms.Panel();
            this.lblCardProductos = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.lblProdActivos = new System.Windows.Forms.Label();
            this.lblStockTotal = new System.Windows.Forms.Label();
            this.lblValorInv = new System.Windows.Forms.Label();
            this.lblPALbl = new System.Windows.Forms.Label();
            this.lblSTLbl = new System.Windows.Forms.Label();
            this.lblVILbl = new System.Windows.Forms.Label();

            this.cardUsuarios = new System.Windows.Forms.Panel();
            this.lblCardUsuarios = new System.Windows.Forms.Label();
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.lblUsuariosLbl = new System.Windows.Forms.Label();

            // Grids
            this.panelCat = new System.Windows.Forms.Panel();
            this.lblCatTitulo = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.panelAccesos = new System.Windows.Forms.Panel();
            this.lblAccesosTitulo = new System.Windows.Forms.Label();
            this.dgvAccesos = new System.Windows.Forms.DataGridView();

            this.panelTitulo.SuspendLayout();
            this.panelCuerpo.SuspendLayout();
            this.tableMain.SuspendLayout();
            this.tableCards.SuspendLayout();
            this.tableGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesos)).BeginInit();
            this.SuspendLayout();

            var ROJO = System.Drawing.Color.FromArgb(211, 47, 47);
            var NEGRO_CARD = System.Drawing.Color.FromArgb(28, 28, 28);
            var NEGRO_BG = System.Drawing.Color.FromArgb(22, 22, 22);

            // ── PANEL TÍTULO ──────────────────────────────────────
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Height = 65;

            var barraRoja = new System.Windows.Forms.Panel();
            barraRoja.BackColor = ROJO;
            barraRoja.Dock = System.Windows.Forms.DockStyle.Left;
            barraRoja.Width = 5;

            this.lblTitulo.Text = "📊  Dashboard — Panel de Control";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 6);
            this.lblTitulo.AutoSize = true;

            this.lblBienvenidaUsuario.Text = "Bienvenido";
            this.lblBienvenidaUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblBienvenidaUsuario.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblBienvenidaUsuario.Location = new System.Drawing.Point(20, 40);
            this.lblBienvenidaUsuario.AutoSize = true;

            this.btnRefrescar.Text = "🔄  Actualizar";
            this.btnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnRefrescar.Location = new System.Drawing.Point(850, 15);
            this.btnRefrescar.Size = new System.Drawing.Size(130, 36);
            this.btnRefrescar.BackColor = ROJO;
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            this.btnRefrescar.MouseEnter += (s, e) => this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.btnRefrescar.MouseLeave += (s, e) => this.btnRefrescar.BackColor = ROJO;

            this.panelTitulo.Controls.AddRange(new System.Windows.Forms.Control[] {
                barraRoja, this.lblTitulo, this.lblBienvenidaUsuario, this.btnRefrescar });

            // ── CUERPO (Fill) ─────────────────────────────────────
            this.panelCuerpo.BackColor = NEGRO_BG;
            this.panelCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuerpo.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);

            // ── TABLE PRINCIPAL: 2 filas, 1 columna ───────────────
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.BackColor = NEGRO_BG;
            this.tableMain.RowCount = 2;
            this.tableMain.ColumnCount = 1;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100));
            this.tableMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;

            // ── TABLE CARDS: 1 fila, 3 columnas ──────────────────
            this.tableCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCards.BackColor = NEGRO_BG;
            this.tableCards.ColumnCount = 3;
            this.tableCards.RowCount = 1;
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30));
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45));
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25));
            this.tableCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100));
            this.tableCards.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableCards.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);

            // ── TABLE GRIDS: 1 fila, 2 columnas ──────────────────
            this.tableGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableGrids.BackColor = NEGRO_BG;
            this.tableGrids.ColumnCount = 2;
            this.tableGrids.RowCount = 1;
            this.tableGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38));
            this.tableGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62));
            this.tableGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100));
            this.tableGrids.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;

            // ── HELPER: crear barra superior de card ──────────────
            System.Windows.Forms.Panel MakeTopBar(System.Drawing.Color c)
            {
                var b = new System.Windows.Forms.Panel();
                b.BackColor = c; b.Dock = System.Windows.Forms.DockStyle.Top; b.Height = 4;
                return b;
            }

            System.Windows.Forms.Label MakeLbl(string txt, float size,
                System.Drawing.Color fg, bool bold = false)
            {
                var l = new System.Windows.Forms.Label();
                l.Text = txt;
                l.Font = new System.Drawing.Font("Segoe UI", size,
                    bold ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
                l.ForeColor = fg;
                l.AutoSize = true;
                return l;
            }

            // ── CARD CLIENTES ──────────────────────────────────────
            this.cardClientes.BackColor = NEGRO_CARD;
            this.cardClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardClientes.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);

            this.lblCardClientes.Text = "👥  CLIENTES";
            this.lblCardClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardClientes.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblCardClientes.Location = new System.Drawing.Point(14, 16); this.lblCardClientes.AutoSize = true;

            this.lblTotalClientes.Text = "0";
            this.lblTotalClientes.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Bold);
            this.lblTotalClientes.ForeColor = System.Drawing.Color.White;
            this.lblTotalClientes.Location = new System.Drawing.Point(10, 38); this.lblTotalClientes.AutoSize = true;

            this.lblCALbl.Text = "Activos:";
            this.lblCALbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCALbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCALbl.Location = new System.Drawing.Point(14, 130); this.lblCALbl.AutoSize = true;
            this.lblClientesActivos.Text = "0";
            this.lblClientesActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClientesActivos.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblClientesActivos.Location = new System.Drawing.Point(75, 130); this.lblClientesActivos.AutoSize = true;

            this.lblCILbl.Text = "Inactivos:";
            this.lblCILbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCILbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCILbl.Location = new System.Drawing.Point(120, 130); this.lblCILbl.AutoSize = true;
            this.lblClientesInact.Text = "0";
            this.lblClientesInact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClientesInact.ForeColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.lblClientesInact.Location = new System.Drawing.Point(200, 130); this.lblClientesInact.AutoSize = true;

            this.cardClientes.Controls.AddRange(new System.Windows.Forms.Control[] {
                MakeTopBar(ROJO),
                this.lblCardClientes, this.lblTotalClientes,
                this.lblCALbl, this.lblClientesActivos,
                this.lblCILbl, this.lblClientesInact });

            // ── CARD PRODUCTOS ─────────────────────────────────────
            this.cardProductos.BackColor = NEGRO_CARD;
            this.cardProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardProductos.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);

            this.lblCardProductos.Text = "📦  PRODUCTOS";
            this.lblCardProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardProductos.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblCardProductos.Location = new System.Drawing.Point(14, 16); this.lblCardProductos.AutoSize = true;

            this.lblTotalProductos.Text = "0";
            this.lblTotalProductos.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Bold);
            this.lblTotalProductos.ForeColor = System.Drawing.Color.White;
            this.lblTotalProductos.Location = new System.Drawing.Point(10, 38); this.lblTotalProductos.AutoSize = true;

            this.lblPALbl.Text = "Activos:"; this.lblPALbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPALbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblPALbl.Location = new System.Drawing.Point(14, 130); this.lblPALbl.AutoSize = true;
            this.lblProdActivos.Text = "0"; this.lblProdActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProdActivos.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblProdActivos.Location = new System.Drawing.Point(72, 130); this.lblProdActivos.AutoSize = true;

            this.lblSTLbl.Text = "Stock total:"; this.lblSTLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSTLbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblSTLbl.Location = new System.Drawing.Point(115, 130); this.lblSTLbl.AutoSize = true;
            this.lblStockTotal.Text = "0"; this.lblStockTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStockTotal.ForeColor = System.Drawing.Color.White;
            this.lblStockTotal.Location = new System.Drawing.Point(205, 130); this.lblStockTotal.AutoSize = true;

            this.lblVILbl.Text = "Valor inventario:"; this.lblVILbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVILbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblVILbl.Location = new System.Drawing.Point(14, 150); this.lblVILbl.AutoSize = true;
            this.lblValorInv.Text = "RD$ 0.00"; this.lblValorInv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValorInv.ForeColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.lblValorInv.Location = new System.Drawing.Point(130, 150); this.lblValorInv.AutoSize = true;

            this.cardProductos.Controls.AddRange(new System.Windows.Forms.Control[] {
                MakeTopBar(System.Drawing.Color.FromArgb(180, 0, 0)),
                this.lblCardProductos, this.lblTotalProductos,
                this.lblPALbl, this.lblProdActivos,
                this.lblSTLbl, this.lblStockTotal,
                this.lblVILbl, this.lblValorInv });

            // ── CARD USUARIOS ──────────────────────────────────────
            this.cardUsuarios.BackColor = NEGRO_CARD;
            this.cardUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardUsuarios.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);

            this.lblCardUsuarios.Text = "🔐  USUARIOS";
            this.lblCardUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardUsuarios.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblCardUsuarios.Location = new System.Drawing.Point(14, 16); this.lblCardUsuarios.AutoSize = true;

            this.lblTotalUsuarios.Text = "0";
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblTotalUsuarios.Location = new System.Drawing.Point(10, 38); this.lblTotalUsuarios.AutoSize = true;

            this.lblUsuariosLbl.Text = "Activos en el sistema";
            this.lblUsuariosLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblUsuariosLbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblUsuariosLbl.Location = new System.Drawing.Point(14, 130); this.lblUsuariosLbl.AutoSize = true;

            this.cardUsuarios.Controls.AddRange(new System.Windows.Forms.Control[] {
                MakeTopBar(System.Drawing.Color.FromArgb(100, 0, 0)),
                this.lblCardUsuarios, this.lblTotalUsuarios, this.lblUsuariosLbl });

            // Agregar cards al tableCards
            this.tableCards.Controls.Add(this.cardClientes, 0, 0);
            this.tableCards.Controls.Add(this.cardProductos, 1, 0);
            this.tableCards.Controls.Add(this.cardUsuarios, 2, 0);

            // ── PANEL CATEGORÍAS ──────────────────────────────────
            this.panelCat.BackColor = NEGRO_CARD;
            this.panelCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCat.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);

            this.lblCatTitulo.Text = "📦  Productos por Categoría";
            this.lblCatTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCatTitulo.ForeColor = ROJO;
            this.lblCatTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCatTitulo.Height = 32;
            this.lblCatTitulo.Padding = new System.Windows.Forms.Padding(8, 6, 0, 0);

            this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = NEGRO_CARD;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = ROJO;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvCategorias.ColumnHeadersHeight = 32;
            this.dgvCategorias.DefaultCellStyle.BackColor = NEGRO_CARD;
            this.dgvCategorias.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvCategorias.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvCategorias.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(150, 20, 20);
            this.dgvCategorias.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvCategorias.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvCategorias.RowTemplate.Height = 28;

            this.panelCat.Controls.Add(this.dgvCategorias);
            this.panelCat.Controls.Add(this.lblCatTitulo);

            // ── PANEL ÚLTIMOS ACCESOS ─────────────────────────────
            this.panelAccesos.BackColor = NEGRO_CARD;
            this.panelAccesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccesos.Margin = new System.Windows.Forms.Padding(0);

            this.lblAccesosTitulo.Text = "🔎  Últimos Accesos al Sistema";
            this.lblAccesosTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccesosTitulo.ForeColor = ROJO;
            this.lblAccesosTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccesosTitulo.Height = 32;
            this.lblAccesosTitulo.Padding = new System.Windows.Forms.Padding(8, 6, 0, 0);

            this.dgvAccesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccesos.ReadOnly = true;
            this.dgvAccesos.AllowUserToAddRows = false;
            this.dgvAccesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccesos.BackgroundColor = NEGRO_CARD;
            this.dgvAccesos.RowHeadersVisible = false;
            this.dgvAccesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccesos.EnableHeadersVisualStyles = false;
            this.dgvAccesos.ColumnHeadersDefaultCellStyle.BackColor = ROJO;
            this.dgvAccesos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAccesos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvAccesos.ColumnHeadersHeight = 32;
            this.dgvAccesos.DefaultCellStyle.BackColor = NEGRO_CARD;
            this.dgvAccesos.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvAccesos.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvAccesos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(150, 20, 20);
            this.dgvAccesos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvAccesos.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvAccesos.RowTemplate.Height = 28;

            this.panelAccesos.Controls.Add(this.dgvAccesos);
            this.panelAccesos.Controls.Add(this.lblAccesosTitulo);

            // Agregar paneles al tableGrids
            this.tableGrids.Controls.Add(this.panelCat, 0, 0);
            this.tableGrids.Controls.Add(this.panelAccesos, 1, 0);

            // Agregar tables al tableMain
            this.tableMain.Controls.Add(this.tableCards, 0, 0);
            this.tableMain.Controls.Add(this.tableGrids, 0, 1);

            this.panelCuerpo.Controls.Add(this.tableMain);

            // ── FORM ──────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = NEGRO_BG;
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.Controls.Add(this.panelCuerpo);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard 📊";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelCuerpo.ResumeLayout(false);
            this.tableMain.ResumeLayout(false);
            this.tableCards.ResumeLayout(false);
            this.tableGrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTitulo, panelCuerpo;
        private System.Windows.Forms.Panel cardClientes, cardProductos, cardUsuarios;
        private System.Windows.Forms.Panel panelCat, panelAccesos;
        private System.Windows.Forms.TableLayoutPanel tableMain, tableCards, tableGrids;
        private System.Windows.Forms.Label lblTitulo, lblBienvenidaUsuario;
        private System.Windows.Forms.Label lblCardClientes, lblTotalClientes, lblClientesActivos, lblClientesInact, lblCALbl, lblCILbl;
        private System.Windows.Forms.Label lblCardProductos, lblTotalProductos, lblProdActivos, lblStockTotal, lblValorInv, lblPALbl, lblSTLbl, lblVILbl;
        private System.Windows.Forms.Label lblCardUsuarios, lblTotalUsuarios, lblUsuariosLbl;
        private System.Windows.Forms.Label lblCatTitulo, lblAccesosTitulo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView dgvCategorias, dgvAccesos;
    }
}