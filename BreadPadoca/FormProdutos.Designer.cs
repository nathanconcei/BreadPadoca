namespace BreadPadoca
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.txbNomeCadastrar = new System.Windows.Forms.TextBox();
            this.txbPrecoCadastro = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastro = new System.Windows.Forms.Label();
            this.lblCategoriaCadastro = new System.Windows.Forms.Label();
            this.cmbCategoriaCadastro = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cmbCategoriaApagar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaApagar = new System.Windows.Forms.Label();
            this.txbPrecoApagar = new System.Windows.Forms.TextBox();
            this.lblPrecoApagar = new System.Windows.Forms.Label();
            this.txbNomeApagar = new System.Windows.Forms.TextBox();
            this.lblNomeApagar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescricaoApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(776, 198);
            this.dgvProdutos.TabIndex = 0;
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.txbPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.lblPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastrar);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastro);
            this.grbCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.grbCadastrar.Location = new System.Drawing.Point(12, 262);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(200, 176);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(6, 27);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(42, 15);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome:";
            // 
            // txbNomeCadastrar
            // 
            this.txbNomeCadastrar.Location = new System.Drawing.Point(50, 24);
            this.txbNomeCadastrar.Name = "txbNomeCadastrar";
            this.txbNomeCadastrar.Size = new System.Drawing.Size(143, 23);
            this.txbNomeCadastrar.TabIndex = 1;
            // 
            // txbPrecoCadastro
            // 
            this.txbPrecoCadastro.Location = new System.Drawing.Point(61, 59);
            this.txbPrecoCadastro.Name = "txbPrecoCadastro";
            this.txbPrecoCadastro.Size = new System.Drawing.Size(132, 23);
            this.txbPrecoCadastro.TabIndex = 3;
            // 
            // lblPrecoCadastro
            // 
            this.lblPrecoCadastro.AutoSize = true;
            this.lblPrecoCadastro.Location = new System.Drawing.Point(6, 62);
            this.lblPrecoCadastro.Name = "lblPrecoCadastro";
            this.lblPrecoCadastro.Size = new System.Drawing.Size(49, 15);
            this.lblPrecoCadastro.TabIndex = 2;
            this.lblPrecoCadastro.Text = "Preco:";
            // 
            // lblCategoriaCadastro
            // 
            this.lblCategoriaCadastro.AutoSize = true;
            this.lblCategoriaCadastro.Location = new System.Drawing.Point(6, 101);
            this.lblCategoriaCadastro.Name = "lblCategoriaCadastro";
            this.lblCategoriaCadastro.Size = new System.Drawing.Size(77, 15);
            this.lblCategoriaCadastro.TabIndex = 4;
            this.lblCategoriaCadastro.Text = "Categoria:";
            // 
            // cmbCategoriaCadastro
            // 
            this.cmbCategoriaCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCadastro.FormattingEnabled = true;
            this.cmbCategoriaCadastro.Location = new System.Drawing.Point(80, 98);
            this.cmbCategoriaCadastro.Name = "cmbCategoriaCadastro";
            this.cmbCategoriaCadastro.Size = new System.Drawing.Size(113, 23);
            this.cmbCategoriaCadastro.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.Color.Peru;
            this.btnCadastrar.Location = new System.Drawing.Point(9, 138);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(184, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.cmbCategoriaEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEditar);
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.grbEditar.Location = new System.Drawing.Point(232, 262);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(200, 176);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.ForeColor = System.Drawing.Color.Peru;
            this.btnEditar.Location = new System.Drawing.Point(9, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(184, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(89, 98);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(104, 23);
            this.cmbCategoriaEditar.TabIndex = 5;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(6, 101);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(77, 15);
            this.lblCategoriaEditar.TabIndex = 4;
            this.lblCategoriaEditar.Text = "Categoria:";
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(61, 59);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(132, 23);
            this.txbPrecoEditar.TabIndex = 3;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(6, 62);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(49, 15);
            this.lblPrecoEditar.TabIndex = 2;
            this.lblPrecoEditar.Text = "Preco:";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(50, 24);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(143, 23);
            this.txbNomeEditar.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(6, 27);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(42, 15);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.lblDescricaoApagar);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.cmbCategoriaApagar);
            this.grbApagar.Controls.Add(this.lblCategoriaApagar);
            this.grbApagar.Controls.Add(this.txbPrecoApagar);
            this.grbApagar.Controls.Add(this.lblPrecoApagar);
            this.grbApagar.Controls.Add(this.txbNomeApagar);
            this.grbApagar.Controls.Add(this.lblNomeApagar);
            this.grbApagar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.ForeColor = System.Drawing.SystemColors.Control;
            this.grbApagar.Location = new System.Drawing.Point(447, 262);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(341, 176);
            this.grbApagar.TabIndex = 8;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(9, 147);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(326, 23);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoriaApagar
            // 
            this.cmbCategoriaApagar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaApagar.FormattingEnabled = true;
            this.cmbCategoriaApagar.Location = new System.Drawing.Point(89, 77);
            this.cmbCategoriaApagar.Name = "cmbCategoriaApagar";
            this.cmbCategoriaApagar.Size = new System.Drawing.Size(246, 23);
            this.cmbCategoriaApagar.TabIndex = 5;
            // 
            // lblCategoriaApagar
            // 
            this.lblCategoriaApagar.AutoSize = true;
            this.lblCategoriaApagar.Location = new System.Drawing.Point(6, 80);
            this.lblCategoriaApagar.Name = "lblCategoriaApagar";
            this.lblCategoriaApagar.Size = new System.Drawing.Size(77, 15);
            this.lblCategoriaApagar.TabIndex = 4;
            this.lblCategoriaApagar.Text = "Categoria:";
            // 
            // txbPrecoApagar
            // 
            this.txbPrecoApagar.Location = new System.Drawing.Point(61, 48);
            this.txbPrecoApagar.Name = "txbPrecoApagar";
            this.txbPrecoApagar.Size = new System.Drawing.Size(274, 23);
            this.txbPrecoApagar.TabIndex = 3;
            // 
            // lblPrecoApagar
            // 
            this.lblPrecoApagar.AutoSize = true;
            this.lblPrecoApagar.Location = new System.Drawing.Point(6, 51);
            this.lblPrecoApagar.Name = "lblPrecoApagar";
            this.lblPrecoApagar.Size = new System.Drawing.Size(49, 15);
            this.lblPrecoApagar.TabIndex = 2;
            this.lblPrecoApagar.Text = "Preco:";
            // 
            // txbNomeApagar
            // 
            this.txbNomeApagar.Location = new System.Drawing.Point(50, 19);
            this.txbNomeApagar.Name = "txbNomeApagar";
            this.txbNomeApagar.Size = new System.Drawing.Size(285, 23);
            this.txbNomeApagar.TabIndex = 1;
            // 
            // lblNomeApagar
            // 
            this.lblNomeApagar.AutoSize = true;
            this.lblNomeApagar.Location = new System.Drawing.Point(6, 19);
            this.lblNomeApagar.Name = "lblNomeApagar";
            this.lblNomeApagar.Size = new System.Drawing.Size(42, 15);
            this.lblNomeApagar.TabIndex = 0;
            this.lblNomeApagar.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(12, 225);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 24);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Gerenciamento de Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BreadPadoca.Properties.Resources.cart;
            this.pictureBox1.Location = new System.Drawing.Point(659, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescricaoApagar
            // 
            this.lblDescricaoApagar.AutoSize = true;
            this.lblDescricaoApagar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoApagar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescricaoApagar.Location = new System.Drawing.Point(6, 117);
            this.lblDescricaoApagar.Name = "lblDescricaoApagar";
            this.lblDescricaoApagar.Size = new System.Drawing.Size(238, 14);
            this.lblDescricaoApagar.TabIndex = 11;
            this.lblDescricaoApagar.Text = "Selecione o produto para excluir:";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.TextBox txbPrecoCadastro;
        private System.Windows.Forms.Label lblPrecoCadastro;
        private System.Windows.Forms.TextBox txbNomeCadastrar;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastro;
        private System.Windows.Forms.Label lblCategoriaCadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ComboBox cmbCategoriaApagar;
        private System.Windows.Forms.Label lblCategoriaApagar;
        private System.Windows.Forms.TextBox txbPrecoApagar;
        private System.Windows.Forms.Label lblPrecoApagar;
        private System.Windows.Forms.TextBox txbNomeApagar;
        private System.Windows.Forms.Label lblNomeApagar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescricaoApagar;
    }
}