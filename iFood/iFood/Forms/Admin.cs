using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFood
{
    public partial class Admin : Form
    {
        Login login;
        private const string ApiUrl = "http://localhost:5295/";
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(Login _login)
        {
            login = _login;
            InitializeComponent();
        }

        private async void Admin_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = ApiUrl + $"usuarios";
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", login.Token);
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        List<Credenciais> responseList = JsonConvert.DeserializeObject<List<Credenciais>>(json);
                        foreach (Credenciais user in responseList)
                        {
                            TextBox textBox1 = new TextBox();
                            textBox1.Text = $"{user.name}";
                            textBox1.ReadOnly = true;
                            textBox1.Width = flowLayoutPanel1.Width - 30;
                            textBox1.Height = 60;
                            textBox1.TextAlign = HorizontalAlignment.Center;
                            textBox1.BackColor = Color.White;
                            textBox1.Font = new Font(textBox1.Font.FontFamily, 14, FontStyle.Bold);

                            TextBox textBox2 = new TextBox();
                            textBox2.Text = $"{user.email}";
                            textBox2.ReadOnly = true;
                            textBox2.Width = flowLayoutPanel1.Width - 30;
                            textBox2.Height = 60;
                            textBox2.TextAlign = HorizontalAlignment.Center;
                            textBox2.BackColor = Color.White;
                            textBox2.Font = new Font(textBox2.Font.FontFamily, 14, FontStyle.Bold);

                            Button btnEditar = new Button();
                            btnEditar.Text = "Editar";
                            btnEditar.BackColor = Color.White;
                            btnEditar.ForeColor = Color.Red;
                            btnEditar.FlatStyle = FlatStyle.Flat;
                            btnEditar.FlatAppearance.BorderSize = 0;
                            btnEditar.Size = new Size(223, 30);
                            btnEditar.Tag = user.id;
                            btnEditar.Click += BtnEditar_Click;

                            Button btnExcluir = new Button();
                            btnExcluir.Text = "Excluir";
                            btnExcluir.BackColor = Color.White;
                            btnExcluir.ForeColor = Color.Red;
                            btnExcluir.FlatStyle = FlatStyle.Flat;
                            btnExcluir.FlatAppearance.BorderSize = 0;
                            btnExcluir.Size = new Size(223, 30);
                            btnExcluir.Tag = user.id;
                            btnExcluir.Click += BtnExcluir_Click;

                            Label margem = new Label();
                            margem.Height = 20;
                            margem.Width = flowLayoutPanel1.Width - 20;

                            flowLayoutPanel1.Controls.Add(textBox1);
                            flowLayoutPanel1.Controls.Add(textBox2);
                            flowLayoutPanel1.Controls.Add(btnEditar);
                            flowLayoutPanel1.Controls.Add(btnExcluir);
                            flowLayoutPanel1.Controls.Add(margem);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro interno no servidor");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro interno do servidor!");
                }
            }
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int userId = (int)btn.Tag;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = ApiUrl + $"remove/user/{userId}";
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", login.Token);
                    HttpResponseMessage response = await client.DeleteAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Usuário deletado com sucesso!");
                        Admin_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Usuário e todas suas transações deletados com sucesso");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro interno do servidor!");
                }
            }
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int userId = (int)btn.Tag;

            Cadastro cadastro = new Cadastro(login, userId, "atualiza");
            cadastro.ShowDialog();
            Admin_Load(sender, e);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro app = new Cadastro("cadastra");
            app.ShowDialog();
            Admin_Load(sender, e);
        }
    }
}
