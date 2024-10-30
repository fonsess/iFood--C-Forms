using Biblioteca;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace iFood
{
    public partial class VerificaSenha : Form
    {
        private const string ApiUrl = "http://localhost:5295/";
        public VerificaSenha()
        {
            InitializeComponent();
        }

        private async void btnAlterSenha_Click(object sender, EventArgs e)
        {
            Credenciais _cadastro = new Credenciais();
            _cadastro.password = txtSenha.Text;
            _cadastro.email = txtEmail.Text;

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
                        string url = ApiUrl + "redefinir/senha";
                        string jsonContent = JsonConvert.SerializeObject(_cadastro);
                        HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PutAsync(url, content);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Senha alterada");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Campos email e/ou senha incorretos!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Erro interno do servidor!");
                    }
                }
                MessageBox.Show("Senha alterada com sucesso!");
                Close();
            }
        }
    }
}
