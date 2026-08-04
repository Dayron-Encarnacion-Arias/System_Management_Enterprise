namespace SistemaGestionEmpresarial.Formularios
{
    partial class FrmBitacora
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.lblBuscarLbl = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblResultadoLbl = new System.Windows.Forms.Label();
            this.cmbResultado = new System.Windows.Forms.ComboBox();
            this.chkFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.lblDesdeLbl = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHastaLbl = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();

            this.panelTitulo.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();

            var ROJO = System.Drawing.Color.FromArgb(211, 47, 47);
            var NEGRO = System.Drawing.Color.FromArgb(28, 28, 28);
            var INPUT = System.Drawing.Color.FromArgb(40, 40, 40);

            // Título
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Height = 60;
            this.panelBarra.BackColor = ROJO;
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBarra.Width = 5;
            this.lblTitulo.Text = "🔎  Bitácora de Accesos";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 8); this.lblTitulo.AutoSize = true;
            this.lblSub.Text = "Registro completo de intentos de inicio de sesión";
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblSub.Location = new System.Drawing.Point(20, 38); this.lblSub.AutoSize = true;
            this.panelTitulo.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelBarra, this.lblTitulo, this.lblSub });

            // Filtros
            this.panelFiltros.BackColor = NEGRO;
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Height = 90;

            var barraFiltro = new System.Windows.Forms.Panel();
            barraFiltro.BackColor = ROJO; barraFiltro.Dock = System.Windows.Forms.DockStyle.Top; barraFiltro.Height = 3;

            this.lblBuscarLbl.Text = "USUARIO:"; this.lblBuscarLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscarLbl.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblBuscarLbl.Location = new System.Drawing.Point(10, 15); this.lblBuscarLbl.AutoSize = true;

            this.txtBuscar.Location = new System.Drawing.Point(10, 32); this.txtBuscar.Size = new System.Drawing.Size(200, 24);
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.BackColor = INPUT; this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

            this.lblResultadoLbl.Text = "RESULTADO:"; this.lblResultadoLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblResultadoLbl.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblResultadoLbl.Location = new System.Drawing.Point(225, 15); this.lblResultadoLbl.AutoSize = true;

            this.cmbResultado.Location = new System.Drawing.Point(225, 32); this.cmbResultado.Size = new System.Drawing.Size(140, 24);
            this.cmbResultado.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.cmbResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultado.BackColor = INPUT; this.cmbResultado.ForeColor = System.Drawing.Color.White;
            this.cmbResultado.Items.AddRange(new object[] { "Todos", "Exitoso", "Fallido" });
            this.cmbResultado.SelectedIndex = 0;
            this.cmbResultado.SelectedIndexChanged += new System.EventHandler(this.cmbResultado_SelectedIndexChanged);

            this.chkFiltrarFecha.Text = "Filtrar por fecha";
            this.chkFiltrarFecha.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.chkFiltrarFecha.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.chkFiltrarFecha.Location = new System.Drawing.Point(380, 35); this.chkFiltrarFecha.AutoSize = true;
            this.chkFiltrarFecha.BackColor = System.Drawing.Color.Transparent;
            this.chkFiltrarFecha.CheckedChanged += new System.EventHandler(this.chkFiltrarFecha_CheckedChanged);

            this.lblDesdeLbl.Text = "DESDE:"; this.lblDesdeLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblDesdeLbl.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblDesdeLbl.Location = new System.Drawing.Point(500, 15); this.lblDesdeLbl.AutoSize = true;
            this.dtpDesde.Location = new System.Drawing.Point(500, 32); this.dtpDesde.Size = new System.Drawing.Size(150, 24);
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9F); this.dtpDesde.Enabled = false;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);

            this.lblHastaLbl.Text = "HASTA:"; this.lblHastaLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblHastaLbl.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblHastaLbl.Location = new System.Drawing.Point(665, 15); this.lblHastaLbl.AutoSize = true;
            this.dtpHasta.Location = new System.Drawing.Point(665, 32); this.dtpHasta.Size = new System.Drawing.Size(150, 24);
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9F); this.dtpHasta.Enabled = false;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);

            this.btnExportar.Text = "📄  Exportar CSV";
            this.btnExportar.Location = new System.Drawing.Point(830, 28); this.btnExportar.Size = new System.Drawing.Size(140, 32);
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnExportar.ForeColor = System.Drawing.Color.White; this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.FlatAppearance.BorderColor = ROJO; this.btnExportar.FlatAppearance.BorderSize = 1;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);

            this.lblTotal.Text = "Total: 0"; this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = ROJO; this.lblTotal.Location = new System.Drawing.Point(10, 65); this.lblTotal.AutoSize = true;

            this.panelFiltros.Controls.AddRange(new System.Windows.Forms.Control[] {
                barraFiltro, this.lblBuscarLbl, this.txtBuscar,
                this.lblResultadoLbl, this.cmbResultado,
                this.chkFiltrarFecha,
                this.lblDesdeLbl, this.dtpDesde,
                this.lblHastaLbl, this.dtpHasta,
                this.btnExportar, this.lblTotal });

            // Grid
            this.dgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBitacora.ReadOnly = true; this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.dgvBitacora.RowHeadersVisible = false; this.dgvBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBitacora.EnableHeadersVisualStyles = false;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.BackColor = ROJO;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvBitacora.ColumnHeadersHeight = 34;
            this.dgvBitacora.DefaultCellStyle.BackColor = NEGRO;
            this.dgvBitacora.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvBitacora.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvBitacora.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(150, 20, 20);
            this.dgvBitacora.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBitacora.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvBitacora.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvBitacora.RowTemplate.Height = 28;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmBitacora"; this.Text = "Bitácora 🔎";
            this.Load += new System.EventHandler(this.FrmBitacora_Load);
            this.panelTitulo.ResumeLayout(false); this.panelTitulo.PerformLayout();
            this.panelFiltros.ResumeLayout(false); this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTitulo, panelFiltros, panelBarra;
        private System.Windows.Forms.Label lblTitulo, lblSub, lblBuscarLbl, lblResultadoLbl;
        private System.Windows.Forms.Label lblDesdeLbl, lblHastaLbl, lblTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbResultado;
        private System.Windows.Forms.CheckBox chkFiltrarFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde, dtpHasta;
        private System.Windows.Forms.Button btnBuscar, btnExportar;
        private System.Windows.Forms.DataGridView dgvBitacora;
    }
}