using Biblioteca;
using Newtonsoft.Json;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace iFood
{
    public partial class Pagamento : Form
    {
        public string valor;
        Endereco endereco = new Endereco();
        Login login;
        List<Pedidos> pedidos;
        private const string ApiUrl = "http://localhost:5295/";
        public Pagamento()
        {
            InitializeComponent();
        }
        public Pagamento(string _valor, Login _login, List<Pedidos> pedidos)
        {
            InitializeComponent();
            login = _login;
            valor = _valor;
            this.pedidos = pedidos;
        }
        public void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConsCEP.Clear();
            lblEnd.Text = "-";
            lblNum.Text = "-";
            lblComp.Text = "-";
            lblBairro.Text = "-";
            lblCida.Text = "-";
            lblTotal.Text = "Total: R$0,00";
        }

        public void MostraEnd(Endereco End)
        {
            lblEnd.Text = End.cep;
        }

        public async void btnLer_Click(object sender, EventArgs e)
        {
            endereco.cep = txtConsCEP.Text;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = ApiUrl + $"cep/{endereco.cep}";
                    string jsonContent = JsonConvert.SerializeObject(endereco);
                    HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        Endereco responseList = JsonConvert.DeserializeObject<Endereco>(json);
                        endereco = responseList;
                    }
                    else
                    {
                        MessageBox.Show("CEP não cadastrado!");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro interno do servidor!");
                }
            }
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
            else
            {
                lblEnd.Text = endereco.endereco + ",";
                lblNum.Text = endereco.numero + ",";
                lblComp.Text = endereco.complemento + ",";
                lblBairro.Text = endereco.bairro + ",";
                lblCida.Text = endereco.cidade + "-" + endereco.estado;
                lblTotal.Text = "Total: " + valor + " para " + endereco.endereco + ", " + endereco.numero + ", " + endereco.complemento;

                QRCodeGenerator QG = new QRCodeGenerator();
                var MyData = QG.CreateQrCode(lblTotal.Text, QRCodeGenerator.ECCLevel.H);
                var code = new QRCode(MyData);
                pictureBox1.Image = code.GetGraphic(50);

                foreach (Pedidos p in pedidos)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        try
                        {
                            string url = ApiUrl + $"adiciona/pedido";
                            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", login.Token);
                            string jsonContent = JsonConvert.SerializeObject(p);
                            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                            HttpResponseMessage response = await client.PostAsync(url, content);
                            if (response.IsSuccessStatusCode)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Erro ao fazer pedido");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erro interno do servidor!");
                        }
                    }
                }
                MessageBox.Show("Pedido adicionado");
            }
        }

        public void txtConsCEP_Click(object sender, EventArgs e)
        {
            txtConsCEP.SelectionStart = 0;
            txtConsCEP.SelectionLength = 0;
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "Total: " + valor;
        }
    }
}