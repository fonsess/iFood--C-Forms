namespace iFood
{
    partial class Cadastro
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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblSim = new System.Windows.Forms.Label();
            this.lblMIN = new System.Windows.Forms.Label();
            this.lblMAI = new System.Windows.Forms.Label();
            this.lblvinte = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCadastro = new iFood.Btn();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.White;
            this.lblNum.Location = new System.Drawing.Point(185, 612);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(231, 20);
            this.lblNum.TabIndex = 45;
            this.lblNum.Text = "• Possuir ao menos um número";
            // 
            // lblSim
            // 
            this.lblSim.AutoSize = true;
            this.lblSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSim.ForeColor = System.Drawing.Color.White;
            this.lblSim.Location = new System.Drawing.Point(185, 579);
            this.lblSim.Name = "lblSim";
            this.lblSim.Size = new System.Drawing.Size(231, 20);
            this.lblSim.TabIndex = 44;
            this.lblSim.Text = "• Possuir ao menos um símbolo";
            // 
            // lblMIN
            // 
            this.lblMIN.AutoSize = true;
            this.lblMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMIN.ForeColor = System.Drawing.Color.White;
            this.lblMIN.Location = new System.Drawing.Point(185, 547);
            this.lblMIN.Name = "lblMIN";
            this.lblMIN.Size = new System.Drawing.Size(292, 20);
            this.lblMIN.TabIndex = 43;
            this.lblMIN.Text = "• Possuir ao menos uma letra minúscula";
            // 
            // lblMAI
            // 
            this.lblMAI.AutoSize = true;
            this.lblMAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAI.ForeColor = System.Drawing.Color.White;
            this.lblMAI.Location = new System.Drawing.Point(185, 510);
            this.lblMAI.Name = "lblMAI";
            this.lblMAI.Size = new System.Drawing.Size(292, 20);
            this.lblMAI.TabIndex = 42;
            this.lblMAI.Text = "• Possuir ao menos uma letra maiúscula";
            // 
            // lblvinte
            // 
            this.lblvinte.AutoSize = true;
            this.lblvinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvinte.ForeColor = System.Drawing.Color.White;
            this.lblvinte.Location = new System.Drawing.Point(185, 474);
            this.lblvinte.Name = "lblvinte";
            this.lblvinte.Size = new System.Drawing.Size(169, 20);
            this.lblvinte.TabIndex = 41;
            this.lblvinte.Text = "• De 8 a 20 caracteres";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSenha.Location = new System.Drawing.Point(159, 388);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(293, 26);
            this.txtSenha.TabIndex = 39;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(155, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Senha: *";
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasc.ForeColor = System.Drawing.Color.White;
            this.rbMasc.Location = new System.Drawing.Point(354, 327);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(98, 24);
            this.rbMasc.TabIndex = 37;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Gênero: *";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNascimento.Location = new System.Drawing.Point(159, 277);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(93, 26);
            this.txtNascimento.TabIndex = 34;
            this.txtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Data de Nascimento: *";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(159, 208);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(293, 26);
            this.txtNome.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nome: *";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(159, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 26);
            this.txtEmail.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Email: *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 73);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cadastro";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(458, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "👁‍🗨";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFem.Location = new System.Drawing.Point(243, 327);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(92, 24);
            this.rbFem.TabIndex = 36;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(155, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "A senha deve possuir: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(566, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 25);
            this.label16.TabIndex = 49;
            this.label16.Text = "X";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Maroon;
            this.btnCadastro.BackgroundColor = System.Drawing.Color.Maroon;
            this.btnCadastro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCadastro.BorderRadius = 20;
            this.btnCadastro.BorderSize = 0;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(225, 670);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(150, 40);
            this.btnCadastro.TabIndex = 46;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextColor = System.Drawing.Color.White;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(616, 732);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblSim);
            this.Controls.Add(this.lblMIN);
            this.Controls.Add(this.lblMAI);
            this.Controls.Add(this.lblvinte);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbFem);
            this.Controls.Add(this.rbMasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cadastro_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblSim;
        private System.Windows.Forms.Label lblMIN;
        private System.Windows.Forms.Label lblMAI;
        private System.Windows.Forms.Label lblvinte;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private Btn btnCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}