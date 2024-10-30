namespace iFood
{
    partial class Cardápio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCardapio = new System.Windows.Forms.Panel();
            this.btnAlcool = new FontAwesome.Sharp.IconButton();
            this.btnBebidas = new FontAwesome.Sharp.IconButton();
            this.btnSobre = new FontAwesome.Sharp.IconButton();
            this.btnLanches = new FontAwesome.Sharp.IconButton();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelLanches = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImprime = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridCost = new System.Windows.Forms.DataGridView();
            this.ITENS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREÇO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCardapio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCost)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCardapio
            // 
            this.panelCardapio.Controls.Add(this.btnAlcool);
            this.panelCardapio.Controls.Add(this.btnBebidas);
            this.panelCardapio.Controls.Add(this.btnSobre);
            this.panelCardapio.Controls.Add(this.btnLanches);
            this.panelCardapio.Controls.Add(this.txbPesquisa);
            this.panelCardapio.Controls.Add(this.flowLayoutPanelLanches);
            this.panelCardapio.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCardapio.Location = new System.Drawing.Point(0, 0);
            this.panelCardapio.Name = "panelCardapio";
            this.panelCardapio.Size = new System.Drawing.Size(845, 749);
            this.panelCardapio.TabIndex = 8;
            // 
            // btnAlcool
            // 
            this.btnAlcool.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAlcool.IconColor = System.Drawing.Color.Black;
            this.btnAlcool.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlcool.Location = new System.Drawing.Point(495, 25);
            this.btnAlcool.Name = "btnAlcool";
            this.btnAlcool.Size = new System.Drawing.Size(75, 23);
            this.btnAlcool.TabIndex = 6;
            this.btnAlcool.Text = "Alcool";
            this.btnAlcool.UseVisualStyleBackColor = true;
            this.btnAlcool.Click += new System.EventHandler(this.btnAlcool_Click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBebidas.IconColor = System.Drawing.Color.Black;
            this.btnBebidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBebidas.Location = new System.Drawing.Point(414, 25);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(75, 23);
            this.btnBebidas.TabIndex = 5;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSobre.IconColor = System.Drawing.Color.Black;
            this.btnSobre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSobre.Location = new System.Drawing.Point(333, 25);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "Sobremesas";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobremesas_Click);
            // 
            // btnLanches
            // 
            this.btnLanches.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLanches.IconColor = System.Drawing.Color.Black;
            this.btnLanches.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLanches.Location = new System.Drawing.Point(252, 25);
            this.btnLanches.Name = "btnLanches";
            this.btnLanches.Size = new System.Drawing.Size(75, 23);
            this.btnLanches.TabIndex = 3;
            this.btnLanches.Text = "Lanches";
            this.btnLanches.UseVisualStyleBackColor = true;
            this.btnLanches.Click += new System.EventHandler(this.btnLanches_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Font = new System.Drawing.Font("Nirmala UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.txbPesquisa.Location = new System.Drawing.Point(12, 12);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(207, 39);
            this.txbPesquisa.TabIndex = 2;
            this.txbPesquisa.Text = "Pesquisar";
            this.txbPesquisa.Click += new System.EventHandler(this.txbPesquisa_Click);
            this.txbPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPesquisa_KeyUp);
            // 
            // flowLayoutPanelLanches
            // 
            this.flowLayoutPanelLanches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelLanches.AutoScroll = true;
            this.flowLayoutPanelLanches.Location = new System.Drawing.Point(0, 64);
            this.flowLayoutPanelLanches.Name = "flowLayoutPanelLanches";
            this.flowLayoutPanelLanches.Size = new System.Drawing.Size(845, 685);
            this.flowLayoutPanelLanches.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLimparTudo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gridCost);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(896, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 749);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImprime);
            this.panel2.Controls.Add(this.btnFinalizarPedido);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 227);
            this.panel2.TabIndex = 52;
            // 
            // btnImprime
            // 
            this.btnImprime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprime.BackColor = System.Drawing.Color.Maroon;
            this.btnImprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprime.Font = new System.Drawing.Font("Nirmala UI", 17F);
            this.btnImprime.ForeColor = System.Drawing.Color.White;
            this.btnImprime.Location = new System.Drawing.Point(0, 165);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(304, 47);
            this.btnImprime.TabIndex = 6;
            this.btnImprime.Text = "Imprimir pedido";
            this.btnImprime.UseVisualStyleBackColor = false;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.Maroon;
            this.btnFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Nirmala UI", 17F);
            this.btnFinalizarPedido.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(0, 79);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(304, 80);
            this.btnFinalizarPedido.TabIndex = 5;
            this.btnFinalizarPedido.Text = "Finalizar pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(144, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(118, 42);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "R$0,00";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total";
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparTudo.BackColor = System.Drawing.Color.White;
            this.btnLimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTudo.Location = new System.Drawing.Point(226, 33);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(69, 29);
            this.btnLimparTudo.TabIndex = 51;
            this.btnLimparTudo.Text = "Limpar tudo";
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 50;
            this.label2.Text = "Carrinho";
            // 
            // gridCost
            // 
            this.gridCost.AllowUserToAddRows = false;
            this.gridCost.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridCost.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCost.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCost.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCost.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCost.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCost.ColumnHeadersHeight = 50;
            this.gridCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITENS,
            this.QUANTIDADE,
            this.PREÇO});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCost.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCost.EnableHeadersVisualStyles = false;
            this.gridCost.Location = new System.Drawing.Point(3, 105);
            this.gridCost.Name = "gridCost";
            this.gridCost.ReadOnly = true;
            this.gridCost.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCost.RowHeadersVisible = false;
            this.gridCost.Size = new System.Drawing.Size(304, 454);
            this.gridCost.TabIndex = 49;
            // 
            // ITENS
            // 
            this.ITENS.HeaderText = "ITENS";
            this.ITENS.Name = "ITENS";
            this.ITENS.ReadOnly = true;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            // 
            // PREÇO
            // 
            this.PREÇO.HeaderText = "PREÇO";
            this.PREÇO.Name = "PREÇO";
            this.PREÇO.ReadOnly = true;
            // 
            // Cardápio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1203, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCardapio);
            this.Name = "Cardápio";
            this.Text = "Cardápio";
            this.Shown += new System.EventHandler(this.Cardápio_Shown);
            this.panelCardapio.ResumeLayout(false);
            this.panelCardapio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCardapio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLanches;
        private System.Windows.Forms.DataGridView gridCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITENS;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREÇO;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPesquisa;
        private FontAwesome.Sharp.IconButton btnLanches;
        private FontAwesome.Sharp.IconButton btnAlcool;
        private FontAwesome.Sharp.IconButton btnBebidas;
        private FontAwesome.Sharp.IconButton btnSobre;
        private System.Windows.Forms.Button btnImprime;
    }
}