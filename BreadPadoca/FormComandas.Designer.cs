namespace BreadPadoca
{
    partial class FormComandas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComandas));
            this.grbInformações = new System.Windows.Forms.GroupBox();
            this.lblInformacaoComanda = new System.Windows.Forms.Label();
            this.lblInformacaoCodProduto = new System.Windows.Forms.Label();
            this.btnInformacaoContinuar = new System.Windows.Forms.Button();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.btnLancamentoLancar = new System.Windows.Forms.Button();
            this.lblLancamentoQuantidade = new System.Windows.Forms.Label();
            this.lblLancamentoProduto = new System.Windows.Forms.Label();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.lblComandasTitulo = new System.Windows.Forms.Label();
            this.pibBarCode = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbInformações.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformações
            // 
            this.grbInformações.Controls.Add(this.txbCodProduto);
            this.grbInformações.Controls.Add(this.txbComanda);
            this.grbInformações.Controls.Add(this.btnInformacaoContinuar);
            this.grbInformações.Controls.Add(this.lblInformacaoCodProduto);
            this.grbInformações.Controls.Add(this.lblInformacaoComanda);
            this.grbInformações.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformações.ForeColor = System.Drawing.SystemColors.Control;
            this.grbInformações.Location = new System.Drawing.Point(13, 13);
            this.grbInformações.Name = "grbInformações";
            this.grbInformações.Size = new System.Drawing.Size(238, 196);
            this.grbInformações.TabIndex = 0;
            this.grbInformações.TabStop = false;
            this.grbInformações.Text = "Informações";
            // 
            // lblInformacaoComanda
            // 
            this.lblInformacaoComanda.AutoSize = true;
            this.lblInformacaoComanda.BackColor = System.Drawing.Color.Peru;
            this.lblInformacaoComanda.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacaoComanda.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInformacaoComanda.Location = new System.Drawing.Point(55, 39);
            this.lblInformacaoComanda.Name = "lblInformacaoComanda";
            this.lblInformacaoComanda.Size = new System.Drawing.Size(90, 22);
            this.lblInformacaoComanda.TabIndex = 1;
            this.lblInformacaoComanda.Text = "Comanda:";
            // 
            // lblInformacaoCodProduto
            // 
            this.lblInformacaoCodProduto.AutoSize = true;
            this.lblInformacaoCodProduto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacaoCodProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInformacaoCodProduto.Location = new System.Drawing.Point(15, 100);
            this.lblInformacaoCodProduto.Name = "lblInformacaoCodProduto";
            this.lblInformacaoCodProduto.Size = new System.Drawing.Size(130, 22);
            this.lblInformacaoCodProduto.TabIndex = 2;
            this.lblInformacaoCodProduto.Text = "Cód.Produto:";
            // 
            // btnInformacaoContinuar
            // 
            this.btnInformacaoContinuar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacaoContinuar.ForeColor = System.Drawing.Color.Peru;
            this.btnInformacaoContinuar.Location = new System.Drawing.Point(9, 140);
            this.btnInformacaoContinuar.Name = "btnInformacaoContinuar";
            this.btnInformacaoContinuar.Size = new System.Drawing.Size(223, 39);
            this.btnInformacaoContinuar.TabIndex = 3;
            this.btnInformacaoContinuar.Text = "CONTINUAR";
            this.btnInformacaoContinuar.UseVisualStyleBackColor = true;
            this.btnInformacaoContinuar.Click += new System.EventHandler(this.btnInformacaoContinuar_Click);
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(151, 24);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(72, 45);
            this.txbComanda.TabIndex = 4;
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProduto.Location = new System.Drawing.Point(151, 85);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(72, 45);
            this.txbCodProduto.TabIndex = 5;
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.btnCancelar);
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Controls.Add(this.txbNomeProduto);
            this.grbLancamento.Controls.Add(this.btnLancamentoLancar);
            this.grbLancamento.Controls.Add(this.lblLancamentoQuantidade);
            this.grbLancamento.Controls.Add(this.lblLancamentoProduto);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLancamento.ForeColor = System.Drawing.SystemColors.Control;
            this.grbLancamento.Location = new System.Drawing.Point(13, 215);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(238, 182);
            this.grbLancamento.TabIndex = 6;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(117, 53);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(112, 30);
            this.txbQuantidade.TabIndex = 5;
            // 
            // txbNomeProduto
            // 
            this.txbNomeProduto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeProduto.Location = new System.Drawing.Point(120, 14);
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.ReadOnly = true;
            this.txbNomeProduto.Size = new System.Drawing.Size(112, 30);
            this.txbNomeProduto.TabIndex = 4;
            // 
            // btnLancamentoLancar
            // 
            this.btnLancamentoLancar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancamentoLancar.ForeColor = System.Drawing.Color.Peru;
            this.btnLancamentoLancar.Location = new System.Drawing.Point(6, 96);
            this.btnLancamentoLancar.Name = "btnLancamentoLancar";
            this.btnLancamentoLancar.Size = new System.Drawing.Size(223, 39);
            this.btnLancamentoLancar.TabIndex = 3;
            this.btnLancamentoLancar.Text = "LANÇAR";
            this.btnLancamentoLancar.UseVisualStyleBackColor = true;
            this.btnLancamentoLancar.Click += new System.EventHandler(this.btnLancamentoLancar_Click);
            // 
            // lblLancamentoQuantidade
            // 
            this.lblLancamentoQuantidade.AutoSize = true;
            this.lblLancamentoQuantidade.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamentoQuantidade.Location = new System.Drawing.Point(6, 53);
            this.lblLancamentoQuantidade.Name = "lblLancamentoQuantidade";
            this.lblLancamentoQuantidade.Size = new System.Drawing.Size(108, 19);
            this.lblLancamentoQuantidade.TabIndex = 2;
            this.lblLancamentoQuantidade.Text = "Quantidade:";
            // 
            // lblLancamentoProduto
            // 
            this.lblLancamentoProduto.AutoSize = true;
            this.lblLancamentoProduto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamentoProduto.Location = new System.Drawing.Point(33, 19);
            this.lblLancamentoProduto.Name = "lblLancamentoProduto";
            this.lblLancamentoProduto.Size = new System.Drawing.Size(81, 19);
            this.lblLancamentoProduto.TabIndex = 1;
            this.lblLancamentoProduto.Text = "Produto:";
            // 
            // dgvComandas
            // 
            this.dgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComandas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(273, 13);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(515, 281);
            this.dgvComandas.TabIndex = 7;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // lblComandasTitulo
            // 
            this.lblComandasTitulo.AutoSize = true;
            this.lblComandasTitulo.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandasTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblComandasTitulo.Location = new System.Drawing.Point(346, 316);
            this.lblComandasTitulo.Name = "lblComandasTitulo";
            this.lblComandasTitulo.Size = new System.Drawing.Size(367, 34);
            this.lblComandasTitulo.TabIndex = 8;
            this.lblComandasTitulo.Text = "Lançamento de Comandas";
            // 
            // pibBarCode
            // 
            this.pibBarCode.Image = global::BreadPadoca.Properties.Resources.barcode2;
            this.pibBarCode.Location = new System.Drawing.Point(352, 353);
            this.pibBarCode.Name = "pibBarCode";
            this.pibBarCode.Size = new System.Drawing.Size(348, 85);
            this.pibBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibBarCode.TabIndex = 9;
            this.pibBarCode.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Tomato;
            this.btnCancelar.Location = new System.Drawing.Point(6, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(223, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pibBarCode);
            this.Controls.Add(this.lblComandasTitulo);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInformações);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandas";
            this.grbInformações.ResumeLayout(false);
            this.grbInformações.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformações;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Button btnInformacaoContinuar;
        private System.Windows.Forms.Label lblInformacaoCodProduto;
        private System.Windows.Forms.Label lblInformacaoComanda;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbNomeProduto;
        private System.Windows.Forms.Button btnLancamentoLancar;
        private System.Windows.Forms.Label lblLancamentoQuantidade;
        private System.Windows.Forms.Label lblLancamentoProduto;
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Label lblComandasTitulo;
        private System.Windows.Forms.PictureBox pibBarCode;
        private System.Windows.Forms.Button btnCancelar;
    }
}