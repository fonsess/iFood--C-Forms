using Biblioteca;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace iFood
{
    public partial class Form1 : Form
    {
        Credenciais cadastro = new Credenciais();
        Endereco endereco = new Endereco();
        private const string ApiUrl = "http://localhost:5295/";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro app = new Cadastro("cadastra");
            app.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            cadastro.email = txtEmail.Text.ToLower();
            cadastro.password = txtSenha.Text;


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
                        string url = ApiUrl + "login";
                        string jsonContent = JsonConvert.SerializeObject(cadastro);
                        HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(url, content);
                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            Login viaCepResponse = JsonConvert.DeserializeObject<Login>(json);
                            if (viaCepResponse.User.Role != "admin")
                            {
                                App cadastro = new App(viaCepResponse);
                                cadastro.ShowDialog();
                            }
                            else
                            {
                                label5_Click(sender, e, viaCepResponse);
                            }
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
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            VerificaSenha senha = new VerificaSenha();
            senha.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e, Login login)
        {
            Admin adm = new Admin(login);
            adm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}