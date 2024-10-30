using Biblioteca;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using ViaCep;

namespace iFood
{
    public partial class Delivery : Form
    {
        Login login;
        private const string ApiUrl = "http://localhost:5295/";
        public Delivery()
        {
            InitializeComponent();
        }
        public Delivery(Login _login)
        {
            login = _login;
            InitializeComponent();
        }

        private void txtCEP_Click_1(object sender, EventArgs e)
        {
            txtCEP.SelectionStart = 0;
            txtCEP.SelectionLength = 0;
        }

        private async void btnSalva_Click_1(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();
            endereco.cep = txtCEP.Text;
            endereco.cidade = txtCid.Text;
            endereco.endereco = txtEnd.Text;
            endereco.estado = txtEstado.Text;
            endereco.bairro = txtBairro.Text;
            endereco.numero = txtNum.Text;
            endereco.complemento = txtComple.Text;
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
            else
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string url = ApiUrl + "adiciona/cep";
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", login.Token);
                        string jsonContent = JsonConvert.SerializeObject(endereco);
                        HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(url, content);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("CEP cadastrado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cadastrar!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Erro interno do servidor!");
                    }
                }
            }
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {

            var viaCepClient = new ViaCepClient();

            try
            {
                var endereco = await viaCepClient.SearchAsync(txtCEP.Text, new System.Threading.CancellationToken());

                txtEnd.Text = endereco.Street;
                txtBairro.Text = endereco.Neighborhood;
                txtCid.Text = endereco.City;
                txtEstado.Text = endereco.StateInitials;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro geral: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {

        }
    }
}