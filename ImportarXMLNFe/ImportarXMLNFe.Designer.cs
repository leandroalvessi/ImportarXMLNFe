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
            this.btnLerFolderXml = new System.Windows.Forms.Button();
            this.txtpathFolderXml = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Série = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaturezaOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmiNomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmiCPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmiInscricaoEstadual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmiLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmiNumeroEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmiMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmiUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesNomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesCPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLerFolderXml
            // 
            this.btnLerFolderXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLerFolderXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerFolderXml.Location = new System.Drawing.Point(561, 12);
            this.btnLerFolderXml.Name = "btnLerFolderXml";
            this.btnLerFolderXml.Size = new System.Drawing.Size(32, 23);
            this.btnLerFolderXml.TabIndex = 3;
            this.btnLerFolderXml.Text = "...";
            this.btnLerFolderXml.UseVisualStyleBackColor = true;
            this.btnLerFolderXml.Click += new System.EventHandler(this.btnLerFolderXml_Click);
            // 
            // txtpathFolderXml
            // 
            this.txtpathFolderXml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpathFolderXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpathFolderXml.Location = new System.Drawing.Point(12, 12);
            this.txtpathFolderXml.Name = "txtpathFolderXml";
            this.txtpathFolderXml.ReadOnly = true;
            this.txtpathFolderXml.Size = new System.Drawing.Size(543, 23);
            this.txtpathFolderXml.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
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
            this.Numero,
            this.Modelo,
            this.Série,
            this.DataEmissao,
            this.NaturezaOperacao,
            this.RazaoSocial,
            this.EmiNomeFantasia,
            this.EmiCPFCNPJ,
            this.EmiInscricaoEstadual,
            this.EmiLogradouro,
            this.EmiNumeroEndereco,
            this.EmiMunicipio,
            this.EmiUF,
            this.DesNomeFantasia,
            this.DesCPFCNPJ,
            this.EMail,
            this.DesLogradouro,
            this.DesNumero,
            this.DesMunicipio,
            this.DesUF,
            this.CEP,
            this.Bairro});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(581, 299);
            this.dataGridView.TabIndex = 27;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 80;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modelo.Visible = false;
            this.Modelo.Width = 50;
            // 
            // Série
            // 
            this.Série.HeaderText = "Serie";
            this.Série.Name = "Série";
            this.Série.ReadOnly = true;
            this.Série.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Série.Visible = false;
            this.Série.Width = 50;
            // 
            // DataEmissao
            // 
            this.DataEmissao.HeaderText = "Data Emissão";
            this.DataEmissao.Name = "DataEmissao";
            this.DataEmissao.ReadOnly = true;
            // 
            // NaturezaOperacao
            // 
            this.NaturezaOperacao.HeaderText = "Natureza Operação";
            this.NaturezaOperacao.Name = "NaturezaOperacao";
            this.NaturezaOperacao.ReadOnly = true;
            this.NaturezaOperacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NaturezaOperacao.Visible = false;
            this.NaturezaOperacao.Width = 300;
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.HeaderText = "Razão Social";
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.ReadOnly = true;
            this.RazaoSocial.Visible = false;
            // 
            // EmiNomeFantasia
            // 
            this.EmiNomeFantasia.HeaderText = "Nome Fantasia";
            this.EmiNomeFantasia.Name = "EmiNomeFantasia";
            this.EmiNomeFantasia.ReadOnly = true;
            this.EmiNomeFantasia.Visible = false;
            // 
            // EmiCPFCNPJ
            // 
            this.EmiCPFCNPJ.HeaderText = "CPF/CNPJ";
            this.EmiCPFCNPJ.Name = "EmiCPFCNPJ";
            this.EmiCPFCNPJ.ReadOnly = true;
            this.EmiCPFCNPJ.Visible = false;
            // 
            // EmiInscricaoEstadual
            // 
            this.EmiInscricaoEstadual.HeaderText = "Inscrição Estadual";
            this.EmiInscricaoEstadual.Name = "EmiInscricaoEstadual";
            this.EmiInscricaoEstadual.ReadOnly = true;
            this.EmiInscricaoEstadual.Visible = false;
            // 
            // EmiLogradouro
            // 
            this.EmiLogradouro.HeaderText = "Logradouro";
            this.EmiLogradouro.Name = "EmiLogradouro";
            this.EmiLogradouro.ReadOnly = true;
            this.EmiLogradouro.Visible = false;
            // 
            // EmiNumeroEndereco
            // 
            this.EmiNumeroEndereco.HeaderText = "Número";
            this.EmiNumeroEndereco.Name = "EmiNumeroEndereco";
            this.EmiNumeroEndereco.ReadOnly = true;
            this.EmiNumeroEndereco.Visible = false;
            // 
            // EmiMunicipio
            // 
            this.EmiMunicipio.HeaderText = "Município";
            this.EmiMunicipio.Name = "EmiMunicipio";
            this.EmiMunicipio.ReadOnly = true;
            this.EmiMunicipio.Visible = false;
            // 
            // EmiUF
            // 
            this.EmiUF.HeaderText = "UF";
            this.EmiUF.Name = "EmiUF";
            this.EmiUF.ReadOnly = true;
            this.EmiUF.Visible = false;
            // 
            // DesNomeFantasia
            // 
            this.DesNomeFantasia.HeaderText = "Nome Fantasia";
            this.DesNomeFantasia.Name = "DesNomeFantasia";
            this.DesNomeFantasia.ReadOnly = true;
            this.DesNomeFantasia.Width = 200;
            // 
            // DesCPFCNPJ
            // 
            this.DesCPFCNPJ.HeaderText = "CPF/CNPJ";
            this.DesCPFCNPJ.Name = "DesCPFCNPJ";
            this.DesCPFCNPJ.ReadOnly = true;
            this.DesCPFCNPJ.Width = 150;
            // 
            // EMail
            // 
            this.EMail.HeaderText = "E-Mail";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            this.EMail.Visible = false;
            // 
            // DesLogradouro
            // 
            this.DesLogradouro.HeaderText = "Logradouro";
            this.DesLogradouro.Name = "DesLogradouro";
            this.DesLogradouro.ReadOnly = true;
            this.DesLogradouro.Visible = false;
            // 
            // DesNumero
            // 
            this.DesNumero.HeaderText = "Número";
            this.DesNumero.Name = "DesNumero";
            this.DesNumero.ReadOnly = true;
            this.DesNumero.Visible = false;
            // 
            // DesMunicipio
            // 
            this.DesMunicipio.HeaderText = "Município";
            this.DesMunicipio.Name = "DesMunicipio";
            this.DesMunicipio.ReadOnly = true;
            // 
            // DesUF
            // 
            this.DesUF.HeaderText = "UF";
            this.DesUF.Name = "DesUF";
            this.DesUF.ReadOnly = true;
            this.DesUF.Width = 50;
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Visible = false;
            // 
            // FormImportarXMLNFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 352);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnLerFolderXml);
            this.Controls.Add(this.txtpathFolderXml);
            this.Name = "FormImportarXMLNFe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar XML NFe/NFC-e";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLerFolderXml;
        private System.Windows.Forms.TextBox txtpathFolderXml;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Série;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaturezaOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmiNomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmiCPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmiInscricaoEstadual;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmiLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmiNumeroEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmiMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmiUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesNomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesCPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
    }
}

