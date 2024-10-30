using Biblioteca;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace iFood
{
    public partial class Cadastro : Form
    {
        Credenciais cadastro = new Credenciais();
        string forma;
        Login login;
        int userId;
        private const string ApiUrl = "http://localhost:5295/";
        public Cadastro()
        {
            InitializeComponent();
        }
        public Cadastro(string forma)
        {
            InitializeComponent();
            this.forma = forma;
        }
        public Cadastro(Login _login, int userId, string forma)
        {
            InitializeComponent();
            this.forma = forma;
            login = _login;
            this.userId = userId;
        }

        private async void btnCadastro_Click(object sender, EventArgs e)
        {
            cadastro.email = txtEmail.Text.ToLower();
            cadastro.name = txtNome.Text;
            cadastro.nascimento = txtNascimento.Text;
            if (rbMasc.Checked)
            {
                cadastro.genero = 'M';
            }
            if (rbFem.Checked)
            {
                cadastro.genero = 'F';
            }
            if (!rbMasc.Checked && !rbFem.Checked)
            {
                cadastro.genero = ' ';
            }
            cadastro.password = txtSenha.Text;

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
            else
            {
                if (forma == "cadastra")
                {
                    using (HttpClient client = new HttpClient())
                    {
                        try
                        {
                            string url = ApiUrl + "cadastro";
                            string jsonContent = JsonConvert.SerializeObject(cadastro);
                            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                            HttpResponseMessage response = await client.PostAsync(url, content);
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Cadastrado com sucesso!");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível cadastrar um usuário!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erro interno do servidor!");
                        }
                    }
                }
                else
                {
                    using (HttpClient client = new HttpClient())
                    {
                        try
                        {
                            string url = ApiUrl + $"update/user/{userId}";
                            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", login.Token);
                            string jsonContent = JsonConvert.SerializeObject(cadastro);
                            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                            HttpResponseMessage response = await client.PutAsync(url, content);
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Atualizado com sucesso!");
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
                }

            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            bool temNum = false, temLetMAI = false, temLetMIN = false, temSim = false, tem8ou20 = false;
            foreach (char c in txtSenha.Text)
            {
                if (Char.IsDigit(c))
                {
                    temNum = true;
                }
                else
                {
                    if (temNum == false)
                    {
                        temNum = false;
                    }
                }
                if (Char.IsLetter(c))
                {
                    if (Char.IsUpper(c))
                    {
                        temLetMAI = true;
                    }
                    else
                    {
                        if (temLetMAI == false)
                        {
                            temLetMAI = false;
                        }
                    }
                    if (Char.IsLower(c))
                    {
                        temLetMIN = true;
                    }
                    else
                    {
                        if (temLetMIN == false)
                        {
                            temLetMIN = false;
                        }
                    }
                }
                if (Char.IsSymbol(c) || Char.IsPunctuation(c))
                {
                    temSim = true;
                }
                else
                {
                    if (temSim == false)
                    {
                        temSim = false;
                    }
                }
            }
            if (txtSenha.Text.Length >= 8 && txtSenha.Text.Length <= 20)
            {
                tem8ou20 = true;
            }
            else
            {
                tem8ou20 = false;
            }
            if (temNum == true)
            {
                lblNum.ForeColor = Color.Lime;
            }
            else
            {
                lblNum.ForeColor = Color.White;
            }
            if (temLetMAI == true)
            {
                lblMAI.ForeColor = Color.Lime;
            }
            else
            {
                lblMAI.ForeColor = Color.White;
            }
            if (temLetMIN == true)
            {
                lblMIN.ForeColor = Color.Lime;
            }
            else
            {
                lblMIN.ForeColor = Color.White;
            }
            if (temSim == true)
            {
                lblSim.ForeColor = Color.Lime;
            }
            else
            {
                lblSim.ForeColor = Color.White;
            }
            if (tem8ou20 == true)
            {
                lblvinte.ForeColor = Color.Lime;
            }
            else
            {
                lblvinte.ForeColor = Color.White;
            }
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

        private void label16_Click(object sender, EventArgs e)
        {
            Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Cadastro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            if (forma == "cadastra")
            {
                label6.Text = "Cadastro";
                btnCadastro.Text = "Cadastro";
            }
            else
            {
                label6.Text = "Update";
                btnCadastro.Text = "Atualiza";
            }
        }
    }
}