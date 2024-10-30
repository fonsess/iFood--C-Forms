using FastFoodManagement.View.BoxService.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using static FastFoodManagement.View.BoxService.Components.Widget;

namespace iFood
{
    public partial class Cardápio : Form
    {
        Login login;
        List<Pedidos> Pedidos = new List<Pedidos>();
        private const string ApiUrl = "http://localhost:5295/";
        public Cardápio()
        {
            InitializeComponent();
        }
        public Cardápio(Login _login)
        {
            InitializeComponent();
            login = _login;
        }

        #region Método Adiciona Item
        public void AddItem(string name, double cost, categorias category, string icon)
        {
            var w = new Widget()
            {
                Title = name,
                Cost = cost,
                Category = category,
                Icon = Image.FromFile("Imagens/" + icon)
            };

            flowLayoutPanelLanches.Controls.Add(w);
            w.OnSelect += (ss, ee) =>
            {
                var wdg = (Widget)ss;
                foreach (DataGridViewRow item in gridCost.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lblTitle.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(wdg.lblCost.Text.Replace("R$", ""))).ToString("C2");
                        CalcularTotal();
                        return;
                    }
                }
                gridCost.Rows.Add(new object[] { wdg.lblTitle.Text, 1, wdg.lblCost.Text });
                CalcularTotal();
            };
        }
        #endregion

        #region Método Calcula Total
        void CalcularTotal()
        {
            double total = 0;
            foreach (DataGridViewRow item in gridCost.Rows)
            {
                total += double.Parse(item.Cells[2].Value.ToString().Replace("R$", ""));
            }
            lblTotal.Text = total.ToString("C2");
        }
        #endregion

        #region Exibe todos os Itens
        private void ExibirTodosProdutos()
        {
            flowLayoutPanelLanches.Controls.Clear();
            // Lanches
            AddItem("Hamburgão", 10.00, categorias.Lanche, "hamburguer1.png");
            AddItem("X-Salada", 15.00, categorias.Lanche, "x-saladas.png");
            AddItem("X-Bacon", 20.00, categorias.Lanche, "x-bacon.png");
            AddItem("X-Tudo", 30.00, categorias.Lanche, "x-tudo.png");
            AddItem("X-Egg", 20.00, categorias.Lanche, "x-egg.png");

            // Sobremesa
            AddItem("Sorvete Chocolate", 2.00, categorias.Sobremesa, "sorvetecremoso.png");
            AddItem("Casquinha Mista", 2.00, categorias.Sobremesa, "casquinha-mista.png");
            AddItem("Sorvete Cone", 5.00, categorias.Sobremesa, "sorvete-cone-recheado.png");
            AddItem("Casquinha baunilha", 2.00, categorias.Sobremesa, "casquinha-baunilha.png");

            // Bebida
            AddItem("Coca-cola lata", 3.90, categorias.Bebida, "refricoca.png");
            AddItem("Fanta Uva lata", 3.90, categorias.Bebida, "fanta-uva.png");
            AddItem("H2O garrafa", 4.90, categorias.Bebida, "refri-H2O.png");
            AddItem("Tubaina garrafa", 4.90, categorias.Bebida, "tubaina.png");
            AddItem("Pepsi lata", 3.90, categorias.Bebida, "pepsi.png");


            // Bebida Alcoolica
            AddItem("Heineken lata", 4.90, categorias.BebidaAlcoolica, "cervejaheinekenlata.png");
            AddItem("Skol lata", 4.90, categorias.BebidaAlcoolica, "skol.png");
            AddItem("Brahma lata", 4.90, categorias.BebidaAlcoolica, "brahma.png");
            AddItem("Itaipava lata", 4.90, categorias.BebidaAlcoolica, "itaipava.png");
            AddItem("Amstel lata", 4.90, categorias.BebidaAlcoolica, "amstel.png");
        }
        #endregion

        #region Exibe os Lanches
        private void ExibirLanches()
        {
            flowLayoutPanelLanches.Controls.Clear();
            AddItem("Hamburgão", 10.00, categorias.Lanche, "hamburguer1.png");
            AddItem("X-Salada", 15.00, categorias.Lanche, "x-saladas.png");
            AddItem("X-Bacon", 20.00, categorias.Lanche, "x-bacon.png");
            AddItem("X-Tudo", 30.00, categorias.Lanche, "x-tudo.png");
            AddItem("X-Egg", 20.00, categorias.Lanche, "x-egg.png");
        }
        #endregion

        #region Exibe as Sobremesas
        private void ExibirSobremesas()
        {
            flowLayoutPanelLanches.Controls.Clear();
            AddItem("Sorvete Chocolate", 2.00, categorias.Sobremesa, "sorvetecremoso.png");
            AddItem("Casquinha Mista", 2.00, categorias.Sobremesa, "casquinha-mista.png");
            AddItem("Sorvete Cone", 5.00, categorias.Sobremesa, "sorvete-cone-recheado.png");
            AddItem("Casquinha baunilha", 2.00, categorias.Sobremesa, "casquinha-baunilha.png");
        }
        #endregion

        #region Exibe as Bebidas 
        private void ExibirBebidas()
        {
            flowLayoutPanelLanches.Controls.Clear();
            AddItem("Coca-cola lata", 3.90, categorias.Bebida, "refricoca.png");
            AddItem("Fanta Uva lata", 3.90, categorias.Bebida, "fanta-uva.png");
            AddItem("H2O garrafa", 4.90, categorias.Bebida, "refri-H2O.png");
            AddItem("Tubaina garrafa", 4.90, categorias.Bebida, "tubaina.png");
            AddItem("Pepsi lata", 3.90, categorias.Bebida, "pepsi.png");
        }
        #endregion

        #region Exibe as Bebidas Alcoolicas
        private void ExibirBebidasAlcoolicas()
        {
            flowLayoutPanelLanches.Controls.Clear();
            AddItem("Heineken lata", 4.90, categorias.BebidaAlcoolica, "cervejaheinekenlata.png");
            AddItem("Skol lata", 4.90, categorias.BebidaAlcoolica, "skol.png");
            AddItem("Brahma lata", 4.90, categorias.BebidaAlcoolica, "brahma.png");
            AddItem("Itaipava lata", 4.90, categorias.BebidaAlcoolica, "itaipava.png");
            AddItem("Amstel lata", 4.90, categorias.BebidaAlcoolica, "amstel.png");
        }
        #endregion

        #region Ao mostrar o Cardápio
        private void Cardápio_Shown(object sender, EventArgs e)
        {
            ExibirTodosProdutos();
        }
        #endregion

        #region Botao Limpar Tudo
        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            gridCost.Rows.Clear();
            lblTotal.Text = "R$0,00";
        }
        #endregion

        #region Botao Finalizar Pedido
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            string total = lblTotal.Text;
            if (total != "R$0,00")
            {
                foreach (DataGridViewRow row in gridCost.Rows)
                {
                    string nomeProduto = row.Cells[0].Value.ToString();
                    int quantidade = int.Parse(row.Cells[1].Value.ToString());
                    decimal preco = decimal.Parse(row.Cells[2].Value.ToString().Replace("R$", ""));

                    var pedido = new Pedidos
                    {
                        Lanche = nomeProduto,
                        Valor = preco,
                        Quantidade = quantidade
                    };
                    Pedidos.Add(pedido);
                }

                Pagamento pag = new Pagamento(total, login, Pedidos);
                pag.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecione os itens para finalizar o pedido!");
            }
        }
        #endregion

        #region Botao Imprimir
        private void btnImprime_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Define as configurações de impressão, como a impressora padrão e as margens
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Inicia o processo de impressão
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridView dataGridView = gridCost;

            Font fonte = new Font("Arial", 10);
            float margemEsquerda = e.MarginBounds.Left;
            float margemSuperior = e.MarginBounds.Top;
            float alturaLinha = fonte.GetHeight();

            float yPos = margemSuperior;

            string coluna1 = "Itens";
            string coluna2 = "Quantidade";
            string coluna3 = "Valor";


            e.Graphics.DrawString(coluna1, fonte, Brushes.Black, margemEsquerda, yPos);
            e.Graphics.DrawString(coluna2, fonte, Brushes.Black, margemEsquerda + 200, yPos);
            e.Graphics.DrawString(coluna3, fonte, Brushes.Black, margemEsquerda + 400, yPos);

            yPos += alturaLinha * 2;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                coluna1 = row.Cells[0].Value.ToString();
                coluna2 = row.Cells[1].Value.ToString();
                coluna3 = row.Cells[2].Value.ToString();

                e.Graphics.DrawString(coluna1, fonte, Brushes.Black, margemEsquerda, yPos);
                e.Graphics.DrawString(coluna2, fonte, Brushes.Black, margemEsquerda + 200, yPos);
                e.Graphics.DrawString(coluna3, fonte, Brushes.Black, margemEsquerda + 400, yPos);

                yPos += alturaLinha;
            }
        }
        #endregion

        #region Pesquisar Lanches
        private void txbPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || txbPesquisa.Text.Trim().Length == 0)
            {
                foreach (var item in flowLayoutPanelLanches.Controls)
                {
                    var wdg = (Widget)item;
                    wdg.Visible = wdg.lblTitle.Text.ToLower().ToLower().Contains(txbPesquisa.Text.Trim().ToLower());
                }
            }
        }

        private void txbPesquisa_Click(object sender, EventArgs e)
        {
            txbPesquisa.Clear();
        }
        #endregion

        #region Mostrar Lanches
        private void btnLanches_Click(object sender, EventArgs e)
        {
            ExibirLanches();
        }
        #endregion

        #region Mostrar Sobremesas
        private void btnSobremesas_Click(object sender, EventArgs e)
        {
            ExibirSobremesas();
        }
        #endregion

        #region Mostrar Bebidas
        private void btnBebidas_Click(object sender, EventArgs e)
        {
            ExibirBebidas();
        }
        #endregion

        #region Mostrar Alcool
        private void btnAlcool_Click(object sender, EventArgs e)
        {
            ExibirBebidasAlcoolicas();
        }
        #endregion

    }
}