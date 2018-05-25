namespace Foodtruck.Grafico
{
    partial class AdicionarPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLanche = new System.Windows.Forms.ComboBox();
            this.cbBebida = new System.Windows.Forms.ComboBox();
            this.btAddLanche = new System.Windows.Forms.Button();
            this.btAddBebida = new System.Windows.Forms.Button();
            this.dgLanches = new System.Windows.Forms.DataGridView();
            this.NomeLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSalvar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ValorTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(82, 33);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(569, 21);
            this.cbClientes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lanches:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bebidas:";
            // 
            // cbLanche
            // 
            this.cbLanche.FormattingEnabled = true;
            this.cbLanche.Location = new System.Drawing.Point(82, 78);
            this.cbLanche.Name = "cbLanche";
            this.cbLanche.Size = new System.Drawing.Size(181, 21);
            this.cbLanche.TabIndex = 4;
            // 
            // cbBebida
            // 
            this.cbBebida.FormattingEnabled = true;
            this.cbBebida.Location = new System.Drawing.Point(405, 78);
            this.cbBebida.Name = "cbBebida";
            this.cbBebida.Size = new System.Drawing.Size(181, 21);
            this.cbBebida.TabIndex = 5;
            // 
            // btAddLanche
            // 
            this.btAddLanche.Location = new System.Drawing.Point(269, 76);
            this.btAddLanche.Name = "btAddLanche";
            this.btAddLanche.Size = new System.Drawing.Size(60, 23);
            this.btAddLanche.TabIndex = 6;
            this.btAddLanche.Text = "Adicionar";
            this.btAddLanche.UseVisualStyleBackColor = true;
            this.btAddLanche.Click += new System.EventHandler(this.btAddLanche_Click);
            // 
            // btAddBebida
            // 
            this.btAddBebida.Location = new System.Drawing.Point(592, 76);
            this.btAddBebida.Name = "btAddBebida";
            this.btAddBebida.Size = new System.Drawing.Size(59, 23);
            this.btAddBebida.TabIndex = 7;
            this.btAddBebida.Text = "Adicionar";
            this.btAddBebida.UseVisualStyleBackColor = true;
            this.btAddBebida.Click += new System.EventHandler(this.btAddBebida_Click);
            // 
            // dgLanches
            // 
            this.dgLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLanches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeLanche,
            this.PrecoLanche});
            this.dgLanches.Location = new System.Drawing.Point(23, 105);
            this.dgLanches.Name = "dgLanches";
            this.dgLanches.Size = new System.Drawing.Size(306, 257);
            this.dgLanches.TabIndex = 8;
            // 
            // NomeLanche
            // 
            this.NomeLanche.DataPropertyName = "Nome";
            this.NomeLanche.HeaderText = "Nome";
            this.NomeLanche.Name = "NomeLanche";
            // 
            // PrecoLanche
            // 
            this.PrecoLanche.DataPropertyName = "Valor";
            this.PrecoLanche.HeaderText = "Preço";
            this.PrecoLanche.Name = "PrecoLanche";
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Preco,
            this.Tamanho});
            this.dgBebidas.Location = new System.Drawing.Point(345, 105);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.Size = new System.Drawing.Size(306, 257);
            this.dgBebidas.TabIndex = 9;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Valor";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "Tamanho";
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(576, 368);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(495, 368);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor Total:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // ValorTotal
            // 
            this.ValorTotal.AutoSize = true;
            this.ValorTotal.Location = new System.Drawing.Point(87, 373);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Size = new System.Drawing.Size(0, 13);
            this.ValorTotal.TabIndex = 14;
            // 
            // AdicionarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 407);
            this.Controls.Add(this.ValorTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.dgLanches);
            this.Controls.Add(this.btAddBebida);
            this.Controls.Add(this.btAddLanche);
            this.Controls.Add(this.cbBebida);
            this.Controls.Add(this.cbLanche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarPedido";
            this.Text = "AdicionarPedido";
            this.Load += new System.EventHandler(this.AdicionarPedido_Load);
            this.Shown += new System.EventHandler(this.AdicionarPedido_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLanche;
        private System.Windows.Forms.ComboBox cbBebida;
        private System.Windows.Forms.Button btAddLanche;
        private System.Windows.Forms.Button btAddBebida;
        private System.Windows.Forms.DataGridView dgLanches;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ValorTotal;
    }
}