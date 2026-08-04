namespace SistemaGestionEmpresarial.Formularios
{
    partial class FrmUsuarios
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloSub = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.panelFormCard = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblPasswordInfo = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.cmbActivo = new System.Windows.Forms.ComboBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelDer = new System.Windows.Forms.Panel();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.lblFiltrosTitulo = new System.Windows.Forms.Label();
            this.lblBuscarLbl = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltroRolLbl = new System.Windows.Forms.Label();
            this.cmbFiltroRol = new System.Windows.Forms.ComboBox();
            this.lblFiltroActivo = new System.Windows.Forms.Label();
            this.cmbFiltroActivo = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();

            this.panelTitulo.SuspendLayout();
            this.panelIzq.SuspendLayout();
            this.panelFormCard.SuspendLayout();
            this.panelDer.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();

            var ROJO = System.Drawing.Color.FromArgb(211, 47, 47);
            var NEGRO = System.Drawing.Color.FromArgb(28, 28, 28);
            var INPUT = System.Drawing.Color.FromArgb(40, 40, 40);

            // ── TÍTULO ────────────────────────────────────────────
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Height = 60;
            this.panelBarra.BackColor = ROJO;
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBarra.Width = 5;
            this.lblTitulo.Text = "🔐  Gestión de Usuarios";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 8);
            this.lblTitulo.AutoSize = true;
            this.lblTituloSub.Text = "Administra los usuarios y roles del sistema (Solo Administrador)";
            this.lblTituloSub.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblTituloSub.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblTituloSub.Location = new System.Drawing.Point(20, 38);
            this.lblTituloSub.AutoSize = true;
            this.panelTitulo.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelBarra, this.lblTitulo, this.lblTituloSub });

            // ── PANEL IZQUIERDO ───────────────────────────────────
            this.panelIzq.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Width = 295;

            this.panelFormCard.BackColor = NEGRO;
            this.panelFormCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblCardTitle.Text = "✏️  Datos del Usuario";
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardTitle.BackColor = ROJO;
            this.lblCardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardTitle.Height = 30;
            this.lblCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCardTitle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);

            int y = 40;
            void addField(System.Windows.Forms.Label l, string t,
                          System.Windows.Forms.Control ctrl, int yy, int h = 24)
            {
                l.Text = t; l.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                l.ForeColor = ROJO; l.Location = new System.Drawing.Point(10, yy); l.AutoSize = true;
                ctrl.Location = new System.Drawing.Point(10, yy + 17);
                ctrl.Size = new System.Drawing.Size(248, h);
                if (ctrl is System.Windows.Forms.TextBox tb)
                { tb.Font = new System.Drawing.Font("Segoe UI", 9.5F); tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; tb.BackColor = INPUT; tb.ForeColor = System.Drawing.Color.White; }
                if (ctrl is System.Windows.Forms.ComboBox cmb)
                { cmb.Font = new System.Drawing.Font("Segoe UI", 9.5F); cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; cmb.BackColor = INPUT; cmb.ForeColor = System.Drawing.Color.White; }
                this.panelFormCard.Controls.Add(l);
                this.panelFormCard.Controls.Add(ctrl);
            }

            addField(this.lblNombreUsuario, "USUARIO:", this.txtNombreUsuario, y); y += 50;
            addField(this.lblNombre, "NOMBRE COMPLETO:", this.txtNombre, y); y += 50;

            addField(this.lblContraseña, "CONTRASEÑA:", this.txtContraseña, y);
            this.txtContraseña.PasswordChar = '*';
            y += 50;

            this.lblPasswordInfo.Text = "💡 Dejar vacío para no cambiar la contraseña";
            this.lblPasswordInfo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblPasswordInfo.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblPasswordInfo.Location = new System.Drawing.Point(10, y);
            this.lblPasswordInfo.AutoSize = true;
            this.lblPasswordInfo.Visible = false;
            this.panelFormCard.Controls.Add(this.lblPasswordInfo);
            y += 20;

            addField(this.lblRol, "ROL:", this.cmbRol, y); y += 50;
            addField(this.lblActivo, "ESTADO:", this.cmbActivo, y);
            this.cmbActivo.Items.AddRange(new object[] { "Activo", "Inactivo" });
            this.cmbActivo.SelectedIndex = 0;

            this.panelFormCard.Controls.Add(this.lblCardTitle);

            // Botones
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Height = 55;

            void estBtn(System.Windows.Forms.Button b, string txt, int bx, int bw,
                        System.Drawing.Color bg, System.EventHandler click)
            {
                b.Text = txt; b.Location = new System.Drawing.Point(bx, 8);
                b.Size = new System.Drawing.Size(bw, 38);
                b.BackColor = bg; b.ForeColor = System.Drawing.Color.White;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                b.Cursor = System.Windows.Forms.Cursors.Hand;
                b.Click += click;
            }

            estBtn(this.btnGuardar, "💾  Guardar", 10, 128, ROJO, this.btnGuardar_Click);
            estBtn(this.btnEliminar, "🗑️ Eliminar", 144, 90,
                   System.Drawing.Color.FromArgb(60, 60, 60), this.btnEliminar_Click);
            estBtn(this.btnLimpiar, "🔄", 240, 42,
                   System.Drawing.Color.FromArgb(45, 45, 45), this.btnLimpiar_Click);

            this.panelBotones.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnGuardar, this.btnEliminar, this.btnLimpiar });

            this.panelIzq.Controls.Add(this.panelFormCard);
            this.panelIzq.Controls.Add(this.panelBotones);

            // ── PANEL DERECHO ─────────────────────────────────────
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);

            // Filtros
            this.panelFiltros.BackColor = NEGRO;
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Height = 85;

            var barraF = new System.Windows.Forms.Panel();
            barraF.BackColor = ROJO; barraF.Dock = System.Windows.Forms.DockStyle.Top; barraF.Height = 3;

            this.lblFiltrosTitulo.Text = "🔍  Filtros de Búsqueda";
            this.lblFiltrosTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltrosTitulo.ForeColor = ROJO;
            this.lblFiltrosTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblFiltrosTitulo.AutoSize = true;

            this.lblBuscarLbl.Text = "ID / USUARIO / NOMBRE:";
            this.lblBuscarLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscarLbl.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblBuscarLbl.Location = new System.Drawing.Point(10, 35);
            this.lblBuscarLbl.AutoSize = true;

            this.txtBuscar.Location = new System.Drawing.Point(10, 52);
            this.txtBuscar.Size = new System.Drawing.Size(240, 24);
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.BackColor = INPUT;
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

            this.lblFiltroRolLbl.Text = "ROL:";
            this.lblFiltroRolLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroRolLbl.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblFiltroRolLbl.Location = new System.Drawing.Point(265, 35);
            this.lblFiltroRolLbl.AutoSize = true;

            this.cmbFiltroRol.Location = new System.Drawing.Point(265, 52);
            this.cmbFiltroRol.Size = new System.Drawing.Size(175, 24);
            this.cmbFiltroRol.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFiltroRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroRol.BackColor = INPUT;
            this.cmbFiltroRol.ForeColor = System.Drawing.Color.White;
            this.cmbFiltroRol.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroRol_SelectedIndexChanged);

            this.lblFiltroActivo.Text = "ESTADO:";
            this.lblFiltroActivo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroActivo.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblFiltroActivo.Location = new System.Drawing.Point(455, 35);
            this.lblFiltroActivo.AutoSize = true;

            this.cmbFiltroActivo.Location = new System.Drawing.Point(455, 52);
            this.cmbFiltroActivo.Size = new System.Drawing.Size(140, 24);
            this.cmbFiltroActivo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFiltroActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroActivo.BackColor = INPUT;
            this.cmbFiltroActivo.ForeColor = System.Drawing.Color.White;
            this.cmbFiltroActivo.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" });
            this.cmbFiltroActivo.SelectedIndex = 0;
            this.cmbFiltroActivo.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroActivo_SelectedIndexChanged);

            this.lblTotal.Text = "Total: 0";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = ROJO;
            this.lblTotal.Location = new System.Drawing.Point(610, 56);
            this.lblTotal.AutoSize = true;

            this.panelFiltros.Controls.AddRange(new System.Windows.Forms.Control[] {
                barraF, this.lblFiltrosTitulo,
                this.lblBuscarLbl, this.txtBuscar,
                this.lblFiltroRolLbl, this.cmbFiltroRol,
                this.lblFiltroActivo, this.cmbFiltroActivo, this.lblTotal });

            // DataGridView
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = ROJO;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvUsuarios.ColumnHeadersHeight = 34;
            this.dgvUsuarios.DefaultCellStyle.BackColor = NEGRO;
            this.dgvUsuarios.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvUsuarios.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvUsuarios.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(150, 20, 20);
            this.dgvUsuarios.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);

            this.panelDer.Controls.Add(this.dgvUsuarios);
            this.panelDer.Controls.Add(this.panelFiltros);

            // ── FORM ──────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.Controls.Add(this.panelDer);
            this.Controls.Add(this.panelIzq);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmUsuarios";
            this.Text = "Usuarios 🔐";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelIzq.ResumeLayout(false);
            this.panelFormCard.ResumeLayout(false);
            this.panelFormCard.PerformLayout();
            this.panelDer.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTitulo, panelIzq, panelDer;
        private System.Windows.Forms.Panel panelFormCard, panelBotones, panelFiltros, panelBarra;
        private System.Windows.Forms.Label lblTitulo, lblTituloSub, lblCardTitle;
        private System.Windows.Forms.Label lblNombreUsuario, lblNombre, lblContraseña, lblPasswordInfo;
        private System.Windows.Forms.Label lblRol, lblActivo;
        private System.Windows.Forms.Label lblFiltrosTitulo, lblBuscarLbl, lblFiltroRolLbl, lblFiltroActivo, lblTotal;
        private System.Windows.Forms.TextBox txtNombreUsuario, txtNombre, txtContraseña, txtBuscar;
        private System.Windows.Forms.ComboBox cmbRol, cmbActivo, cmbFiltroRol, cmbFiltroActivo;
        private System.Windows.Forms.Button btnGuardar, btnEliminar, btnLimpiar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}