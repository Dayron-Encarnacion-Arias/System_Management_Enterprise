namespace SistemaGestionEmpresarial.Formularios
{
    partial class FrmRoles
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelTitulo    = new System.Windows.Forms.Panel();
            this.panelBarra     = new System.Windows.Forms.Panel();
            this.lblTitulo      = new System.Windows.Forms.Label();
            this.lblTituloSub   = new System.Windows.Forms.Label();
            this.panelIzq       = new System.Windows.Forms.Panel();
            this.panelFormCard  = new System.Windows.Forms.Panel();
            this.lblCardTitle   = new System.Windows.Forms.Label();
            this.lblNombreRol   = new System.Windows.Forms.Label();
            this.txtNombreRol   = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelBotones   = new System.Windows.Forms.Panel();
            this.btnGuardar     = new System.Windows.Forms.Button();
            this.btnEliminar    = new System.Windows.Forms.Button();
            this.btnLimpiar     = new System.Windows.Forms.Button();
            this.panelDer       = new System.Windows.Forms.Panel();
            this.panelFiltros   = new System.Windows.Forms.Panel();
            this.lblFiltrosTitulo = new System.Windows.Forms.Label();
            this.lblBuscarLbl   = new System.Windows.Forms.Label();
            this.txtBuscar      = new System.Windows.Forms.TextBox();
            this.lblTotal       = new System.Windows.Forms.Label();
            this.dgvRoles       = new System.Windows.Forms.DataGridView();

            this.panelTitulo.SuspendLayout();
            this.panelIzq.SuspendLayout();
            this.panelFormCard.SuspendLayout();
            this.panelDer.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();

            var ROJO  = System.Drawing.Color.FromArgb(211, 47, 47);
            var NEGRO = System.Drawing.Color.FromArgb(28, 28, 28);
            var INPUT = System.Drawing.Color.FromArgb(40, 40, 40);

            // ── TÍTULO ────────────────────────────────────────────
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.panelTitulo.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Height    = 60;

            this.panelBarra.BackColor = ROJO;
            this.panelBarra.Dock      = System.Windows.Forms.DockStyle.Left;
            this.panelBarra.Width     = 5;

            this.lblTitulo.Text      = "🛡️  Gestión de Roles";
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location  = new System.Drawing.Point(18, 8);
            this.lblTitulo.AutoSize  = true;

            this.lblTituloSub.Text      = "Administra los roles del sistema (Solo Administrador)";
            this.lblTituloSub.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblTituloSub.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblTituloSub.Location  = new System.Drawing.Point(20, 38);
            this.lblTituloSub.AutoSize  = true;

            this.panelTitulo.Controls.AddRange(new System.Windows.Forms.Control[]
                { this.panelBarra, this.lblTitulo, this.lblTituloSub });

            // ── PANEL IZQUIERDO (Formulario) ──────────────────────
            this.panelIzq.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.panelIzq.Dock      = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Width     = 295;

            this.panelFormCard.BackColor    = NEGRO;
            this.panelFormCard.Dock         = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCard.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblCardTitle.Text      = "✏️  Datos del Rol";
            this.lblCardTitle.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardTitle.BackColor = ROJO;
            this.lblCardTitle.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblCardTitle.Height    = 30;
            this.lblCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCardTitle.Padding   = new System.Windows.Forms.Padding(8, 0, 0, 0);

            // Helper local para agregar campos al card
            int y = 40;
            void addField(System.Windows.Forms.Label lbl, string texto,
                          System.Windows.Forms.Control ctrl, int yy, int h = 24)
            {
                lbl.Text      = texto;
                lbl.Font      = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                lbl.ForeColor = ROJO;
                lbl.Location  = new System.Drawing.Point(10, yy);
                lbl.AutoSize  = true;

                ctrl.Location = new System.Drawing.Point(10, yy + 17);
                ctrl.Size     = new System.Drawing.Size(248, h);

                if (ctrl is System.Windows.Forms.TextBox tb)
                {
                    tb.Font        = new System.Drawing.Font("Segoe UI", 9.5F);
                    tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    tb.BackColor   = INPUT;
                    tb.ForeColor   = System.Drawing.Color.White;
                }

                this.panelFormCard.Controls.Add(lbl);
                this.panelFormCard.Controls.Add(ctrl);
            }

            addField(this.lblNombreRol, "NOMBRE DEL ROL:", this.txtNombreRol, y);
            y += 50;

            // Descripción como TextBox multilinea
            addField(this.lblDescripcion, "DESCRIPCIÓN:", this.txtDescripcion, y, 70);
            this.txtDescripcion.Multiline  = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            this.panelFormCard.Controls.Add(this.lblCardTitle);

            // ── BOTONES ───────────────────────────────────────────
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.panelBotones.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Height    = 55;

            void estBtn(System.Windows.Forms.Button b, string txt, int bx, int bw,
                        System.Drawing.Color bg, System.EventHandler click)
            {
                b.Text        = txt;
                b.Location    = new System.Drawing.Point(bx, 8);
                b.Size        = new System.Drawing.Size(bw, 38);
                b.BackColor   = bg;
                b.ForeColor   = System.Drawing.Color.White;
                b.FlatStyle   = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font        = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                b.Cursor      = System.Windows.Forms.Cursors.Hand;
                b.Click      += click;
            }

            estBtn(this.btnGuardar,  "💾  Guardar",    10,  128, ROJO,
                   this.btnGuardar_Click);
            estBtn(this.btnEliminar, "🗑️ Eliminar",   144,  90,
                   System.Drawing.Color.FromArgb(60, 60, 60), this.btnEliminar_Click);
            estBtn(this.btnLimpiar,  "🔄",             240,  42,
                   System.Drawing.Color.FromArgb(45, 45, 45), this.btnLimpiar_Click);

            this.panelBotones.Controls.AddRange(new System.Windows.Forms.Control[]
                { this.btnGuardar, this.btnEliminar, this.btnLimpiar });

            this.panelIzq.Controls.Add(this.panelFormCard);
            this.panelIzq.Controls.Add(this.panelBotones);

            // ── PANEL DERECHO (Grid + Filtros) ────────────────────
            this.panelDer.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);

            // Barra de filtros
            this.panelFiltros.BackColor = NEGRO;
            this.panelFiltros.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Height    = 85;

            var barraF = new System.Windows.Forms.Panel();
            barraF.BackColor = ROJO;
            barraF.Dock      = System.Windows.Forms.DockStyle.Top;
            barraF.Height    = 3;

            this.lblFiltrosTitulo.Text      = "🔍  Filtros de Búsqueda";
            this.lblFiltrosTitulo.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltrosTitulo.ForeColor = ROJO;
            this.lblFiltrosTitulo.Location  = new System.Drawing.Point(10, 10);
            this.lblFiltrosTitulo.AutoSize  = true;

            this.lblBuscarLbl.Text      = "ID / NOMBRE / DESCRIPCIÓN:";
            this.lblBuscarLbl.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscarLbl.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblBuscarLbl.Location  = new System.Drawing.Point(10, 35);
            this.lblBuscarLbl.AutoSize  = true;

            this.txtBuscar.Location    = new System.Drawing.Point(10, 52);
            this.txtBuscar.Size        = new System.Drawing.Size(280, 24);
            this.txtBuscar.Font        = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.BackColor   = INPUT;
            this.txtBuscar.ForeColor   = System.Drawing.Color.White;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

            this.lblTotal.Text      = "Total: 0";
            this.lblTotal.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = ROJO;
            this.lblTotal.Location  = new System.Drawing.Point(310, 56);
            this.lblTotal.AutoSize  = true;

            this.panelFiltros.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                barraF, this.lblFiltrosTitulo,
                this.lblBuscarLbl, this.txtBuscar, this.lblTotal
            });

            // DataGridView
            this.dgvRoles.Dock                              = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.ReadOnly                         = true;
            this.dgvRoles.AllowUserToAddRows               = false;
            this.dgvRoles.SelectionMode                    = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.MultiSelect                      = false;
            this.dgvRoles.AutoSizeColumnsMode              = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoles.BackgroundColor                  = System.Drawing.Color.FromArgb(22, 22, 22);
            this.dgvRoles.RowHeadersVisible                = false;
            this.dgvRoles.BorderStyle                      = System.Windows.Forms.BorderStyle.None;
            this.dgvRoles.EnableHeadersVisualStyles        = false;
            this.dgvRoles.ColumnHeadersDefaultCellStyle.BackColor = ROJO;
            this.dgvRoles.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRoles.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvRoles.ColumnHeadersHeight              = 34;
            this.dgvRoles.DefaultCellStyle.BackColor       = NEGRO;
            this.dgvRoles.DefaultCellStyle.ForeColor       = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvRoles.DefaultCellStyle.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvRoles.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(150, 20, 20);
            this.dgvRoles.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRoles.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvRoles.GridColor          = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvRoles.RowTemplate.Height = 28;
            this.dgvRoles.CellClick         += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);

            this.panelDer.Controls.Add(this.dgvRoles);
            this.panelDer.Controls.Add(this.panelFiltros);

            // ── FORM ──────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(22, 22, 22);
            this.ClientSize          = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.panelDer);
            this.Controls.Add(this.panelIzq);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmRoles";
            this.Text = "Roles 🛡️";
            this.Load += new System.EventHandler(this.FrmRoles_Load);

            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelIzq.ResumeLayout(false);
            this.panelFormCard.ResumeLayout(false);
            this.panelFormCard.PerformLayout();
            this.panelDer.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Declaración de controles ──────────────────────────────
        private System.Windows.Forms.Panel panelTitulo, panelIzq, panelDer;
        private System.Windows.Forms.Panel panelFormCard, panelBotones, panelFiltros, panelBarra;
        private System.Windows.Forms.Label lblTitulo, lblTituloSub, lblCardTitle;
        private System.Windows.Forms.Label lblNombreRol, lblDescripcion;
        private System.Windows.Forms.Label lblFiltrosTitulo, lblBuscarLbl, lblTotal;
        private System.Windows.Forms.TextBox txtNombreRol, txtDescripcion, txtBuscar;
        private System.Windows.Forms.Button btnGuardar, btnEliminar, btnLimpiar;
        private System.Windows.Forms.DataGridView dgvRoles;
    }
}
