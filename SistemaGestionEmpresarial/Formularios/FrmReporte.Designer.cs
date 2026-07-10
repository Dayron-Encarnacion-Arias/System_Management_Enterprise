namespace SistemaGestionEmpresarial.Formularios
{
    partial class FrmReporte
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelBarraRoja = new System.Windows.Forms.Panel();
            this.lblTituloReporte = new System.Windows.Forms.Label();
            this.lblFechaGeneracion = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.lblGeneradoPor = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.lblFiltrosTitulo = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro2 = new System.Windows.Forms.Label();
            this.cmbFiltro2 = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();

            this.panelHeader.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();

            var ROJO = System.Drawing.Color.FromArgb(211, 47, 47);
            var NEGRO = System.Drawing.Color.FromArgb(28, 28, 28);
            var INPUT = System.Drawing.Color.FromArgb(40, 40, 40);

            // ══ PANEL HEADER ══════════════════════════════════════
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 100;

            this.panelBarraRoja.BackColor = ROJO;
            this.panelBarraRoja.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBarraRoja.Width = 6;

            this.lblTituloReporte.Text = "📊  Reporte";
            this.lblTituloReporte.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTituloReporte.ForeColor = System.Drawing.Color.White;
            this.lblTituloReporte.Location = new System.Drawing.Point(22, 10);
            this.lblTituloReporte.AutoSize = true;

            this.lblFechaGeneracion.Text = "📅  Fecha de generación: —";
            this.lblFechaGeneracion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaGeneracion.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblFechaGeneracion.Location = new System.Drawing.Point(22, 58);
            this.lblFechaGeneracion.AutoSize = true;

            this.lblTotalRegistros.Text = "🔢  Total: 0 registros";
            this.lblTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalRegistros.ForeColor = ROJO;
            this.lblTotalRegistros.Location = new System.Drawing.Point(22, 76);
            this.lblTotalRegistros.AutoSize = true;

            this.lblGeneradoPor.Text = "👤  Generado por: —";
            this.lblGeneradoPor.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblGeneradoPor.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblGeneradoPor.Location = new System.Drawing.Point(420, 76);
            this.lblGeneradoPor.AutoSize = true;

            this.panelHeader.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelBarraRoja, this.lblTituloReporte,
                this.lblFechaGeneracion, this.lblTotalRegistros, this.lblGeneradoPor });

            // ══ PANEL FILTROS ══════════════════════════════════════
            this.panelFiltros.BackColor = NEGRO;
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Height = 68;

            var barraFiltro = new System.Windows.Forms.Panel();
            barraFiltro.BackColor = ROJO;
            barraFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            barraFiltro.Height = 3;

            this.lblFiltrosTitulo.Text = "🔍  Filtrar:";
            this.lblFiltrosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltrosTitulo.ForeColor = ROJO;
            this.lblFiltrosTitulo.Location = new System.Drawing.Point(10, 12);
            this.lblFiltrosTitulo.AutoSize = true;

            this.lblFiltro.Text = "FILTRO PRINCIPAL:";
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblFiltro.Location = new System.Drawing.Point(90, 12);
            this.lblFiltro.AutoSize = true;

            this.cmbFiltro.Location = new System.Drawing.Point(90, 28);
            this.cmbFiltro.Size = new System.Drawing.Size(200, 24);
            this.cmbFiltro.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.BackColor = INPUT;
            this.cmbFiltro.ForeColor = System.Drawing.Color.White;

            this.lblFiltro2.Text = "ESTADO:";
            this.lblFiltro2.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltro2.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblFiltro2.Location = new System.Drawing.Point(305, 12);
            this.lblFiltro2.AutoSize = true;

            this.cmbFiltro2.Location = new System.Drawing.Point(305, 28);
            this.cmbFiltro2.Size = new System.Drawing.Size(150, 24);
            this.cmbFiltro2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFiltro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro2.BackColor = INPUT;
            this.cmbFiltro2.ForeColor = System.Drawing.Color.White;

            // Botón Generar
            this.btnGenerar.Text = "🔄  Generar";
            this.btnGenerar.Location = new System.Drawing.Point(470, 24);
            this.btnGenerar.Size = new System.Drawing.Size(115, 32);
            this.btnGenerar.BackColor = ROJO;
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            // Botón Exportar CSV
            this.btnExportarCSV.Text = "📄  Exportar CSV";
            this.btnExportarCSV.Location = new System.Drawing.Point(593, 24);
            this.btnExportarCSV.Size = new System.Drawing.Size(140, 32);
            this.btnExportarCSV.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnExportarCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportarCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarCSV.FlatAppearance.BorderColor = ROJO;
            this.btnExportarCSV.FlatAppearance.BorderSize = 1;
            this.btnExportarCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportarCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);

            // Botón Imprimir
            this.btnImprimir.Text = "🖨️  Imprimir";
            this.btnImprimir.Location = new System.Drawing.Point(741, 24);
            this.btnImprimir.Size = new System.Drawing.Size(120, 32);
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.btnImprimir.FlatAppearance.BorderSize = 1;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);

            // Hover effects en botones de reporte
            this.btnGenerar.MouseEnter += (s, e) => { this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(244, 67, 54); };
            this.btnGenerar.MouseLeave += (s, e) => { this.btnGenerar.BackColor = ROJO; };
            this.btnExportarCSV.MouseEnter += (s, e) => { this.btnExportarCSV.BackColor = System.Drawing.Color.FromArgb(80, 80, 80); };
            this.btnExportarCSV.MouseLeave += (s, e) => { this.btnExportarCSV.BackColor = System.Drawing.Color.FromArgb(60, 60, 60); };
            this.btnImprimir.MouseEnter += (s, e) => { this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(65, 65, 65); };
            this.btnImprimir.MouseLeave += (s, e) => { this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(45, 45, 45); };

            this.panelFiltros.Controls.AddRange(new System.Windows.Forms.Control[] {
                barraFiltro, this.lblFiltrosTitulo,
                this.lblFiltro, this.cmbFiltro,
                this.lblFiltro2, this.cmbFiltro2,
                this.btnGenerar, this.btnExportarCSV, this.btnImprimir });

            // ══ DATAGRIDVIEW ══════════════════════════════════════
            this.dgvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporte.EnableHeadersVisualStyles = false;
            this.dgvReporte.ColumnHeadersDefaultCellStyle.BackColor = ROJO;
            this.dgvReporte.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReporte.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvReporte.ColumnHeadersHeight = 34;
            this.dgvReporte.DefaultCellStyle.BackColor = NEGRO;
            this.dgvReporte.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvReporte.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvReporte.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(150, 20, 20);
            this.dgvReporte.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReporte.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvReporte.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvReporte.RowTemplate.Height = 28;

            // ══ FORM ══════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            this.ClientSize = new System.Drawing.Size(1050, 680);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmReporte";
            this.Text = "Reporte 📊";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader, panelFiltros, panelBarraRoja;
        private System.Windows.Forms.Label lblTituloReporte, lblFechaGeneracion;
        private System.Windows.Forms.Label lblTotalRegistros, lblGeneradoPor;
        private System.Windows.Forms.Label lblFiltrosTitulo, lblFiltro, lblFiltro2;
        private System.Windows.Forms.ComboBox cmbFiltro, cmbFiltro2;
        private System.Windows.Forms.Button btnGenerar, btnExportarCSV, btnImprimir;
        private System.Windows.Forms.DataGridView dgvReporte;
    }
}