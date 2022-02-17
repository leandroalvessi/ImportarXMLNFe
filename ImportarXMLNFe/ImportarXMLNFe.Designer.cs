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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLerFolderXml = new System.Windows.Forms.Button();
            this.txtpathFolderXml = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Série = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaturezaOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Modelo,
            this.Série,
            this.DataEmissao,
            this.NaturezaOperacao});
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
            this.Modelo.Width = 50;
            // 
            // Série
            // 
            this.Série.HeaderText = "Serie";
            this.Série.Name = "Série";
            this.Série.ReadOnly = true;
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
            this.NaturezaOperacao.Width = 300;
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
    }
}

