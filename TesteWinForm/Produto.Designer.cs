namespace TesteWinForm
{
    partial class Produto
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
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.textBoxEntradaSaida = new System.Windows.Forms.TextBox();
            this.textBoxPosicaoEstoque = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.buttonSaldo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(568, 23);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(116, 23);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(568, 50);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(116, 23);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(568, 77);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(116, 23);
            this.buttonAtualizar.TabIndex = 2;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(568, 104);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(116, 23);
            this.buttonDeletar.TabIndex = 3;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(568, 297);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(116, 23);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Entrada / Saida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Posição do Estoque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade";
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(124, 23);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(262, 23);
            this.textBoxNomeProduto.TabIndex = 10;
            this.textBoxNomeProduto.Validated += new System.EventHandler(this.textBoxNomeProduto_Validated);
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(124, 61);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(43, 23);
            this.textBoxSaldo.TabIndex = 11;
            // 
            // textBoxEntradaSaida
            // 
            this.textBoxEntradaSaida.Location = new System.Drawing.Point(124, 99);
            this.textBoxEntradaSaida.Name = "textBoxEntradaSaida";
            this.textBoxEntradaSaida.Size = new System.Drawing.Size(115, 23);
            this.textBoxEntradaSaida.TabIndex = 12;
            // 
            // textBoxPosicaoEstoque
            // 
            this.textBoxPosicaoEstoque.Location = new System.Drawing.Point(124, 137);
            this.textBoxPosicaoEstoque.Name = "textBoxPosicaoEstoque";
            this.textBoxPosicaoEstoque.Size = new System.Drawing.Size(115, 23);
            this.textBoxPosicaoEstoque.TabIndex = 13;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(124, 175);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(43, 23);
            this.textBoxQuantidade.TabIndex = 14;
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Location = new System.Drawing.Point(12, 225);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowTemplate.Height = 25;
            this.dataGridViewProduto.Size = new System.Drawing.Size(550, 150);
            this.dataGridViewProduto.TabIndex = 15;
            this.dataGridViewProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduto_CellClick);
            // 
            // buttonSaldo
            // 
            this.buttonSaldo.Location = new System.Drawing.Point(568, 133);
            this.buttonSaldo.Name = "buttonSaldo";
            this.buttonSaldo.Size = new System.Drawing.Size(116, 23);
            this.buttonSaldo.TabIndex = 16;
            this.buttonSaldo.Text = "Verifica Saldo";
            this.buttonSaldo.UseVisualStyleBackColor = true;
            this.buttonSaldo.Click += new System.EventHandler(this.buttonSaldo_Click);
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 387);
            this.Controls.Add(this.buttonSaldo);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxPosicaoEstoque);
            this.Controls.Add(this.textBoxEntradaSaida);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonNovo;
        private Button buttonSalvar;
        private Button buttonAtualizar;
        private Button buttonDeletar;
        private Button buttonSair;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxNomeProduto;
        private TextBox textBoxSaldo;
        private TextBox textBoxEntradaSaida;
        private TextBox textBoxPosicaoEstoque;
        private TextBox textBoxQuantidade;
        private DataGridView dataGridViewProduto;
        private Button buttonSaldo;
    }
}