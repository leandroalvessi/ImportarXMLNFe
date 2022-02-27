namespace ImportarXMLNFe
{
    partial class FormImportarXMLNFe
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportarXMLNFe));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dhEmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCaminho = new System.Windows.Forms.GroupBox();
            this.btnLerFolderXml = new System.Windows.Forms.Button();
            this.txtPathFolderXml = new System.Windows.Forms.TextBox();
            this.grpTipoVisualizacao = new System.Windows.Forms.GroupBox();
            this.chkVisualizarPdf = new System.Windows.Forms.CheckBox();
            this.grpPeriodo = new System.Windows.Forms.GroupBox();
            this.dtaFim = new System.Windows.Forms.DateTimePicker();
            this.dtaInicio = new System.Windows.Forms.DateTimePicker();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpInscricao = new System.Windows.Forms.GroupBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.radioTodas = new System.Windows.Forms.RadioButton();
            this.radioSaida = new System.Windows.Forms.RadioButton();
            this.radioEntrada = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.grpCaminho.SuspendLayout();
            this.grpTipoVisualizacao.SuspendLayout();
            this.grpPeriodo.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            this.grpInscricao.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nNF,
            this.mod,
            this.dhEmi,
            this.vNF,
            this.Path,
            this.xNome,
            this.CpfCnpj,
            this.xMun,
            this.UF,
            this.CEP});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(12, 128);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1010, 421);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // nNF
            // 
            this.nNF.HeaderText = "Número";
            this.nNF.Name = "nNF";
            this.nNF.ReadOnly = true;
            this.nNF.Width = 80;
            // 
            // mod
            // 
            this.mod.HeaderText = "Modelo";
            this.mod.Name = "mod";
            this.mod.ReadOnly = true;
            this.mod.Width = 60;
            // 
            // dhEmi
            // 
            this.dhEmi.HeaderText = "Data Emissão";
            this.dhEmi.Name = "dhEmi";
            this.dhEmi.ReadOnly = true;
            // 
            // vNF
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.vNF.DefaultCellStyle = dataGridViewCellStyle2;
            this.vNF.HeaderText = "Valor Nota Fiscal";
            this.vNF.Name = "vNF";
            this.vNF.ReadOnly = true;
            this.vNF.Width = 120;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Visible = false;
            // 
            // xNome
            // 
            this.xNome.HeaderText = "Nome Fantasia";
            this.xNome.Name = "xNome";
            this.xNome.ReadOnly = true;
            this.xNome.Width = 300;
            // 
            // CpfCnpj
            // 
            this.CpfCnpj.HeaderText = "CPF/CNPJ";
            this.CpfCnpj.Name = "CpfCnpj";
            this.CpfCnpj.ReadOnly = true;
            this.CpfCnpj.Width = 150;
            // 
            // xMun
            // 
            this.xMun.HeaderText = "Município";
            this.xMun.Name = "xMun";
            this.xMun.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            this.UF.Width = 50;
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // grpCaminho
            // 
            this.grpCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCaminho.Controls.Add(this.btnLerFolderXml);
            this.grpCaminho.Controls.Add(this.txtPathFolderXml);
            this.grpCaminho.Location = new System.Drawing.Point(362, 12);
            this.grpCaminho.Name = "grpCaminho";
            this.grpCaminho.Size = new System.Drawing.Size(401, 52);
            this.grpCaminho.TabIndex = 2;
            this.grpCaminho.TabStop = false;
            this.grpCaminho.Text = "Caminho dos arquivos";
            // 
            // btnLerFolderXml
            // 
            this.btnLerFolderXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLerFolderXml.BackColor = System.Drawing.SystemColors.Window;
            this.btnLerFolderXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerFolderXml.Location = new System.Drawing.Point(356, 18);
            this.btnLerFolderXml.Name = "btnLerFolderXml";
            this.btnLerFolderXml.Size = new System.Drawing.Size(39, 27);
            this.btnLerFolderXml.TabIndex = 2;
            this.btnLerFolderXml.Text = "...";
            this.btnLerFolderXml.UseVisualStyleBackColor = true;
            this.btnLerFolderXml.Click += new System.EventHandler(this.btnLerFolderXml_Click);
            // 
            // txtPathFolderXml
            // 
            this.txtPathFolderXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathFolderXml.BackColor = System.Drawing.SystemColors.Window;
            this.txtPathFolderXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathFolderXml.Location = new System.Drawing.Point(6, 20);
            this.txtPathFolderXml.Name = "txtPathFolderXml";
            this.txtPathFolderXml.Size = new System.Drawing.Size(344, 23);
            this.txtPathFolderXml.TabIndex = 1;
            // 
            // grpTipoVisualizacao
            // 
            this.grpTipoVisualizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTipoVisualizacao.Controls.Add(this.chkVisualizarPdf);
            this.grpTipoVisualizacao.Location = new System.Drawing.Point(895, 12);
            this.grpTipoVisualizacao.Name = "grpTipoVisualizacao";
            this.grpTipoVisualizacao.Size = new System.Drawing.Size(127, 52);
            this.grpTipoVisualizacao.TabIndex = 5;
            this.grpTipoVisualizacao.TabStop = false;
            this.grpTipoVisualizacao.Text = "Tipo de Visualização";
            // 
            // chkVisualizarPdf
            // 
            this.chkVisualizarPdf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVisualizarPdf.AutoSize = true;
            this.chkVisualizarPdf.Location = new System.Drawing.Point(7, 24);
            this.chkVisualizarPdf.Name = "chkVisualizarPdf";
            this.chkVisualizarPdf.Size = new System.Drawing.Size(47, 17);
            this.chkVisualizarPdf.TabIndex = 1;
            this.chkVisualizarPdf.Text = "PDF";
            this.chkVisualizarPdf.UseVisualStyleBackColor = true;
            // 
            // grpPeriodo
            // 
            this.grpPeriodo.Controls.Add(this.dtaFim);
            this.grpPeriodo.Controls.Add(this.dtaInicio);
            this.grpPeriodo.Location = new System.Drawing.Point(12, 12);
            this.grpPeriodo.Name = "grpPeriodo";
            this.grpPeriodo.Size = new System.Drawing.Size(191, 52);
            this.grpPeriodo.TabIndex = 1;
            this.grpPeriodo.TabStop = false;
            this.grpPeriodo.Text = "Período";
            // 
            // dtaFim
            // 
            this.dtaFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtaFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaFim.Location = new System.Drawing.Point(98, 20);
            this.dtaFim.Name = "dtaFim";
            this.dtaFim.Size = new System.Drawing.Size(86, 23);
            this.dtaFim.TabIndex = 2;
            this.dtaFim.Validating += new System.ComponentModel.CancelEventHandler(this.dtaFim_Validating);
            // 
            // dtaInicio
            // 
            this.dtaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaInicio.Location = new System.Drawing.Point(6, 20);
            this.dtaInicio.Name = "dtaInicio";
            this.dtaInicio.Size = new System.Drawing.Size(86, 23);
            this.dtaInicio.TabIndex = 1;
            this.dtaInicio.Validating += new System.ComponentModel.CancelEventHandler(this.dtaInicio_Validating);
            // 
            // grpBuscar
            // 
            this.grpBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Location = new System.Drawing.Point(769, 12);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(120, 52);
            this.grpBuscar.TabIndex = 4;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar NF-e";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(6, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 27);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpInscricao
            // 
            this.grpInscricao.Controls.Add(this.txtCpfCnpj);
            this.grpInscricao.Location = new System.Drawing.Point(209, 12);
            this.grpInscricao.Name = "grpInscricao";
            this.grpInscricao.Size = new System.Drawing.Size(147, 52);
            this.grpInscricao.TabIndex = 2;
            this.grpInscricao.TabStop = false;
            this.grpInscricao.Text = "Inscrição";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpfCnpj.BackColor = System.Drawing.SystemColors.Window;
            this.txtCpfCnpj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCnpj.Location = new System.Drawing.Point(6, 20);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(135, 23);
            this.txtCpfCnpj.TabIndex = 1;
            this.txtCpfCnpj.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCpfCnpj_Validating);
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.radioTodas);
            this.grpTipo.Controls.Add(this.radioSaida);
            this.grpTipo.Controls.Add(this.radioEntrada);
            this.grpTipo.Location = new System.Drawing.Point(12, 70);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(191, 52);
            this.grpTipo.TabIndex = 6;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo NFe/NFCe";
            // 
            // radioTodas
            // 
            this.radioTodas.AutoSize = true;
            this.radioTodas.Location = new System.Drawing.Point(129, 18);
            this.radioTodas.Name = "radioTodas";
            this.radioTodas.Size = new System.Drawing.Size(55, 17);
            this.radioTodas.TabIndex = 3;
            this.radioTodas.Text = "Todas";
            this.radioTodas.UseVisualStyleBackColor = true;
            this.radioTodas.CheckedChanged += new System.EventHandler(this.radioTodas_CheckedChanged);
            // 
            // radioSaida
            // 
            this.radioSaida.AutoSize = true;
            this.radioSaida.Checked = true;
            this.radioSaida.Location = new System.Drawing.Point(74, 18);
            this.radioSaida.Name = "radioSaida";
            this.radioSaida.Size = new System.Drawing.Size(52, 17);
            this.radioSaida.TabIndex = 2;
            this.radioSaida.TabStop = true;
            this.radioSaida.Text = "Saida";
            this.radioSaida.UseVisualStyleBackColor = true;
            // 
            // radioEntrada
            // 
            this.radioEntrada.AutoSize = true;
            this.radioEntrada.Location = new System.Drawing.Point(6, 18);
            this.radioEntrada.Name = "radioEntrada";
            this.radioEntrada.Size = new System.Drawing.Size(62, 17);
            this.radioEntrada.TabIndex = 1;
            this.radioEntrada.Text = "Entrada";
            this.radioEntrada.UseVisualStyleBackColor = true;
            // 
            // FormImportarXMLNFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grpInscricao);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.grpPeriodo);
            this.Controls.Add(this.grpTipoVisualizacao);
            this.Controls.Add(this.grpCaminho);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImportarXMLNFe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar XML NFe/NFCe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.grpCaminho.ResumeLayout(false);
            this.grpCaminho.PerformLayout();
            this.grpTipoVisualizacao.ResumeLayout(false);
            this.grpTipoVisualizacao.PerformLayout();
            this.grpPeriodo.ResumeLayout(false);
            this.grpBuscar.ResumeLayout(false);
            this.grpInscricao.ResumeLayout(false);
            this.grpInscricao.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox grpCaminho;
        private System.Windows.Forms.Button btnLerFolderXml;
        private System.Windows.Forms.TextBox txtPathFolderXml;
        private System.Windows.Forms.GroupBox grpTipoVisualizacao;
        private System.Windows.Forms.CheckBox chkVisualizarPdf;
        private System.Windows.Forms.GroupBox grpPeriodo;
        private System.Windows.Forms.DateTimePicker dtaFim;
        private System.Windows.Forms.DateTimePicker dtaInicio;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dhEmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMun;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.GroupBox grpInscricao;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton radioTodas;
        private System.Windows.Forms.RadioButton radioSaida;
        private System.Windows.Forms.RadioButton radioEntrada;
    }
}

