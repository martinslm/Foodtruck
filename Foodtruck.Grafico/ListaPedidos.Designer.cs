namespace Foodtruck.Grafico
{
    partial class ListaPedidos
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
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEditaPedido = new System.Windows.Forms.Button();
            this.btRemoverPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cliente,
            this.Valor,
            this.Data});
            this.dgPedidos.Location = new System.Drawing.Point(19, 56);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.Size = new System.Drawing.Size(764, 382);
            this.dgPedidos.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NomeCliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ValorTotal";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DataCompra";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // btEditaPedido
            // 
            this.btEditaPedido.Location = new System.Drawing.Point(19, 12);
            this.btEditaPedido.Name = "btEditaPedido";
            this.btEditaPedido.Size = new System.Drawing.Size(75, 38);
            this.btEditaPedido.TabIndex = 2;
            this.btEditaPedido.Text = "Editar";
            this.btEditaPedido.UseVisualStyleBackColor = true;
            this.btEditaPedido.Click += new System.EventHandler(this.btEditaPedido_Click);
            // 
            // btRemoverPedido
            // 
            this.btRemoverPedido.Location = new System.Drawing.Point(100, 12);
            this.btRemoverPedido.Name = "btRemoverPedido";
            this.btRemoverPedido.Size = new System.Drawing.Size(75, 38);
            this.btRemoverPedido.TabIndex = 3;
            this.btRemoverPedido.Text = "Remover";
            this.btRemoverPedido.UseVisualStyleBackColor = true;
            this.btRemoverPedido.Click += new System.EventHandler(this.btRemoverPedido_Click);
            // 
            // ListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRemoverPedido);
            this.Controls.Add(this.btEditaPedido);
            this.Controls.Add(this.dgPedidos);
            this.Name = "ListaPedidos";
            this.Text = "ListaPedidos";
            this.Load += new System.EventHandler(this.ListaPedidos_Load);
            this.Shown += new System.EventHandler(this.ListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Button btEditaPedido;
        private System.Windows.Forms.Button btRemoverPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}