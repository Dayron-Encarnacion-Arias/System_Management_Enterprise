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

            // Cards fila 1
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
            this.panelGrids = new System.Windows.Forms.Panel();
            this.panelCat = new System.Windows.Forms.Panel();
            this.lblCatTitulo = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.panelAccesos = new System.Windows.Forms.Panel();
            this.lblAccesosTitulo = new System.Windows.Forms.Label();
            this.dgvAccesos = new System.Windows.Forms.DataGridView();

            this.panelTitulo.SuspendLayout();
            this.panelCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesos)).BeginInit();
            this.SuspendLayout();

            var ROJO = System.Drawing.Color.FromArgb(211, 47, 47);
            var NEGRO = System.Drawing.Color.FromArgb(28, 28, 28);

            // ── TÍTULO ────────────────────────────────────────────
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Height = 70;

            var barraRoja = new System.Windows.Forms.Panel();
            barraRoja.BackColor = ROJO;
            barraRoja.Dock = System.Windows.Forms.DockStyle.Left;
            barraRoja.Width = 5;

            this.lblTitulo.Text = "📊  Dashboard — Panel de Control";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 8);
            this.lblTitulo.AutoSize = true;

            this.lblBienvenidaUsuario.Text = "Bienvenido";
            this.lblBienvenidaUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblBienvenidaUsuario.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblBienvenidaUsuario.Location = new System.Drawing.Point(20, 42);
            this.lblBienvenidaUsuario.AutoSize = true;

            this.btnRefrescar.Text = "🔄  Actualizar";
            this.btnRefrescar.Location = new System.Drawing.Point(820, 18);
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

            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.lblBienvenidaUsuario);
            this.panelTitulo.Controls.Add(this.btnRefrescar);
            this.panelTitulo.Controls.Add(barraRoja);

            // ── CUERPO ────────────────────────────────────────────
            this.panelCuerpo.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.panelCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuerpo.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelCuerpo.AutoScroll = true;

            // ── HELPER PARA CARDS ──────────────────────────────────
            System.Windows.Forms.Panel MakeCard(int x, int y, int w, int h, System.Drawing.Color top)
            {
                var p = new System.Windows.Forms.Panel();
                p.BackColor = NEGRO;
                p.Location = new System.Drawing.Point(x, y);
                p.Size = new System.Drawing.Size(w, h);
                p.BorderStyle = System.Windows.Forms.BorderStyle.None;

                var topBar = new System.Windows.Forms.Panel();
                topBar.BackColor = top;
                topBar.Dock = System.Windows.Forms.DockStyle.Top;
                topBar.Height = 4;
                p.Controls.Add(topBar);
                return p;
            }

            System.Windows.Forms.Label MakeLbl(string txt, int x, int y, float size,
                System.Drawing.Color fg, bool bold = false)
            {
                var l = new System.Windows.Forms.Label();
                l.Text = txt;
                l.Font = new System.Drawing.Font("Segoe UI", size,
                    bold ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
                l.ForeColor = fg;
                l.Location = new System.Drawing.Point(x, y);
                l.AutoSize = true;
                return l;
            }

            // ── CARD CLIENTES ──────────────────────────────────────
            this.cardClientes = MakeCard(0, 5, 290, 140, ROJO);

            this.lblCardClientes.Text = "👥  CLIENTES";
            this.lblCardClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardClientes.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblCardClientes.Location = new System.Drawing.Point(12, 14);
            this.lblCardClientes.AutoSize = true;

            this.lblTotalClientes.Text = "0";
            this.lblTotalClientes.Font = new System.Drawing.Font("Segoe UI", 38F, System.Drawing.FontStyle.Bold);
            this.lblTotalClientes.ForeColor = System.Drawing.Color.White;
            this.lblTotalClientes.Location = new System.Drawing.Point(10, 34);
            this.lblTotalClientes.AutoSize = true;

            this.lblCALbl.Text = "Activos:";
            this.lblCALbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCALbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCALbl.Location = new System.Drawing.Point(12, 100);
            this.lblCALbl.AutoSize = true;

            this.lblClientesActivos.Text = "0";
            this.lblClientesActivos.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblClientesActivos.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblClientesActivos.Location = new System.Drawing.Point(68, 100);
            this.lblClientesActivos.AutoSize = true;

            this.lblCILbl.Text = "Inactivos:";
            this.lblCILbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCILbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCILbl.Location = new System.Drawing.Point(120, 100);
            this.lblCILbl.AutoSize = true;

            this.lblClientesInact.Text = "0";
            this.lblClientesInact.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblClientesInact.ForeColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.lblClientesInact.Location = new System.Drawing.Point(190, 100);
            this.lblClientesInact.AutoSize = true;

            this.cardClientes.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCardClientes, this.lblTotalClientes,
                this.lblCALbl, this.lblClientesActivos,
                this.lblCILbl, this.lblClientesInact });

            // ── CARD PRODUCTOS ─────────────────────────────────────
            this.cardProductos = MakeCard(305, 5, 360, 140, System.Drawing.Color.FromArgb(180, 0, 0));

            this.lblCardProductos.Text = "📦  PRODUCTOS";
            this.lblCardProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardProductos.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblCardProductos.Location = new System.Drawing.Point(12, 14);
            this.lblCardProductos.AutoSize = true;

            this.lblTotalProductos.Text = "0";
            this.lblTotalProductos.Font = new System.Drawing.Font("Segoe UI", 38F, System.Drawing.FontStyle.Bold);
            this.lblTotalProductos.ForeColor = System.Drawing.Color.White;
            this.lblTotalProductos.Location = new System.Drawing.Point(10, 34);
            this.lblTotalProductos.AutoSize = true;

            this.lblPALbl.Text = "Activos:";
            this.lblPALbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPALbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblPALbl.Location = new System.Drawing.Point(12, 100); this.lblPALbl.AutoSize = true;
            this.lblProdActivos.Text = "0";
            this.lblProdActivos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblProdActivos.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblProdActivos.Location = new System.Drawing.Point(62, 100); this.lblProdActivos.AutoSize = true;

            this.lblSTLbl.Text = "Stock:";
            this.lblSTLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSTLbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblSTLbl.Location = new System.Drawing.Point(105, 100); this.lblSTLbl.AutoSize = true;
            this.lblStockTotal.Text = "0";
            this.lblStockTotal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStockTotal.ForeColor = System.Drawing.Color.White;
            this.lblStockTotal.Location = new System.Drawing.Point(145, 100); this.lblStockTotal.AutoSize = true;

            this.lblVILbl.Text = "Valor:";
            this.lblVILbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVILbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblVILbl.Location = new System.Drawing.Point(190, 100); this.lblVILbl.AutoSize = true;
            this.lblValorInv.Text = "RD$ 0.00";
            this.lblValorInv.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblValorInv.ForeColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.lblValorInv.Location = new System.Drawing.Point(230, 100); this.lblValorInv.AutoSize = true;

            this.cardProductos.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCardProductos, this.lblTotalProductos,
                this.lblPALbl, this.lblProdActivos,
                this.lblSTLbl, this.lblStockTotal,
                this.lblVILbl, this.lblValorInv });

            // ── CARD USUARIOS ──────────────────────────────────────
            this.cardUsuarios = MakeCard(680, 5, 200, 140, System.Drawing.Color.FromArgb(100, 0, 0));

            this.lblCardUsuarios.Text = "🔐  USUARIOS";
            this.lblCardUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardUsuarios.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblCardUsuarios.Location = new System.Drawing.Point(12, 14); this.lblCardUsuarios.AutoSize = true;

            this.lblTotalUsuarios.Text = "0";
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Segoe UI", 38F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblTotalUsuarios.Location = new System.Drawing.Point(10, 34); this.lblTotalUsuarios.AutoSize = true;

            this.lblUsuariosLbl.Text = "Activos en el sistema";
            this.lblUsuariosLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUsuariosLbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblUsuariosLbl.Location = new System.Drawing.Point(12, 100); this.lblUsuariosLbl.AutoSize = true;

            this.cardUsuarios.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCardUsuarios, this.lblTotalUsuarios, this.lblUsuariosLbl });

            // ── PANEL GRIDS ───────────────────────────────────────
            this.panelGrids.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.panelGrids.Location = new System.Drawing.Point(0, 155);
            this.panelGrids.Size = new System.Drawing.Size(930, 350);

            // Grid Categorías
            this.panelCat.BackColor = NEGRO;
            this.panelCat.Location = new System.Drawing.Point(0, 0);
            this.panelCat.Size = new System.Drawing.Size(350, 320);

            this.lblCatTitulo.Text = "📦  Productos por Categoría";
            this.lblCatTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCatTitulo.ForeColor = ROJO;
            this.lblCatTitulo.Location = new System.Drawing.Point(8, 8); this.lblCatTitulo.AutoSize = true;

            this.dgvCategorias.Location = new System.Drawing.Point(0, 35);
            this.dgvCategorias.Size = new System.Drawing.Size(350, 285);
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = NEGRO;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = ROJO;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvCategorias.DefaultCellStyle.BackColor = NEGRO;
            this.dgvCategorias.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvCategorias.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvCategorias.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvCategorias.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvCategorias.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(150, 20, 20);

            this.panelCat.Controls.Add(this.lblCatTitulo);
            this.panelCat.Controls.Add(this.dgvCategorias);

            // Grid Últimos Accesos
            this.panelAccesos.BackColor = NEGRO;
            this.panelAccesos.Location = new System.Drawing.Point(365, 0);
            this.panelAccesos.Size = new System.Drawing.Size(500, 320);

            this.lblAccesosTitulo.Text = "🔎  Últimos Accesos al Sistema";
            this.lblAccesosTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccesosTitulo.ForeColor = ROJO;
            this.lblAccesosTitulo.Location = new System.Drawing.Point(8, 8); this.lblAccesosTitulo.AutoSize = true;

            this.dgvAccesos.Location = new System.Drawing.Point(0, 35);
            this.dgvAccesos.Size = new System.Drawing.Size(500, 285);
            this.dgvAccesos.ReadOnly = true;
            this.dgvAccesos.AllowUserToAddRows = false;
            this.dgvAccesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccesos.BackgroundColor = NEGRO;
            this.dgvAccesos.RowHeadersVisible = false;
            this.dgvAccesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccesos.EnableHeadersVisualStyles = false;
            this.dgvAccesos.ColumnHeadersDefaultCellStyle.BackColor = ROJO;
            this.dgvAccesos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAccesos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvAccesos.DefaultCellStyle.BackColor = NEGRO;
            this.dgvAccesos.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvAccesos.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvAccesos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvAccesos.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvAccesos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(150, 20, 20);

            this.panelAccesos.Controls.Add(this.lblAccesosTitulo);
            this.panelAccesos.Controls.Add(this.dgvAccesos);

            this.panelGrids.Controls.Add(this.panelCat);
            this.panelGrids.Controls.Add(this.panelAccesos);

            this.panelCuerpo.Controls.Add(this.cardClientes);
            this.panelCuerpo.Controls.Add(this.cardProductos);
            this.panelCuerpo.Controls.Add(this.cardUsuarios);
            this.panelCuerpo.Controls.Add(this.panelGrids);

            // ── FORM ──────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.Controls.Add(this.panelCuerpo);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard 📊";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTitulo, panelCuerpo, panelGrids;
        private System.Windows.Forms.Panel cardClientes, cardProductos, cardUsuarios;
        private System.Windows.Forms.Panel panelCat, panelAccesos;
        private System.Windows.Forms.Label lblTitulo, lblBienvenidaUsuario;
        private System.Windows.Forms.Label lblCardClientes, lblTotalClientes, lblClientesActivos, lblClientesInact, lblCALbl, lblCILbl;
        private System.Windows.Forms.Label lblCardProductos, lblTotalProductos, lblProdActivos, lblStockTotal, lblValorInv, lblPALbl, lblSTLbl, lblVILbl;
        private System.Windows.Forms.Label lblCardUsuarios, lblTotalUsuarios, lblUsuariosLbl;
        private System.Windows.Forms.Label lblCatTitulo, lblAccesosTitulo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView dgvCategorias, dgvAccesos;
    }
}