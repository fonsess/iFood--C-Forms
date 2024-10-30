namespace iFood
{
    partial class Pagamento
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
        public void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panelEnd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConsCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnLer = new FontAwesome.Sharp.IconButton();
            this.lblCida = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(10, 139);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 24);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: R$0,00";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(15, 411);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panelEnd
            // 
            this.panelEnd.Controls.Add(this.label1);
            this.panelEnd.Controls.Add(this.label2);
            this.panelEnd.Controls.Add(this.label3);
            this.panelEnd.Controls.Add(this.label4);
            this.panelEnd.Controls.Add(this.label5);
            this.panelEnd.Controls.Add(this.txtConsCEP);
            this.panelEnd.Controls.Add(this.btnLimpar);
            this.panelEnd.Controls.Add(this.btnLer);
            this.panelEnd.Controls.Add(this.lblTotal);
            this.panelEnd.Controls.Add(this.lblCida);
            this.panelEnd.Controls.Add(this.pictureBox1);
            this.panelEnd.Controls.Add(this.lblBairro);
            this.panelEnd.Controls.Add(this.lblComp);
            this.panelEnd.Controls.Add(this.lblNum);
            this.panelEnd.Controls.Add(this.lblEnd);
            this.panelEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnd.Location = new System.Drawing.Point(0, 0);
            this.panelEnd.Name = "panelEnd";
            this.panelEnd.Size = new System.Drawing.Size(528, 446);
            this.panelEnd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bairro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Complemento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rua";
            // 
            // txtConsCEP
            // 
            this.txtConsCEP.Location = new System.Drawing.Point(15, 195);
            this.txtConsCEP.Mask = "00000-000";
            this.txtConsCEP.Name = "txtConsCEP";
            this.txtConsCEP.Size = new System.Drawing.Size(85, 20);
            this.txtConsCEP.TabIndex = 16;
            this.txtConsCEP.Click += new System.EventHandler(this.txtConsCEP_Click);
            // 
            // btnLer
            // 
            this.btnLer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLer.IconColor = System.Drawing.Color.Black;
            this.btnLer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLer.Location = new System.Drawing.Point(15, 363);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(53, 23);
            this.btnLer.TabIndex = 8;
            this.btnLer.Text = "Pagar";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // lblCida
            // 
            this.lblCida.AutoSize = true;
            this.lblCida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCida.ForeColor = System.Drawing.Color.White;
            this.lblCida.Location = new System.Drawing.Point(100, 330);
            this.lblCida.Name = "lblCida";
            this.lblCida.Size = new System.Drawing.Size(10, 13);
            this.lblCida.TabIndex = 6;
            this.lblCida.Text = "-";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(100, 307);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(10, 13);
            this.lblBairro.TabIndex = 5;
            this.lblBairro.Text = "-";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.ForeColor = System.Drawing.Color.White;
            this.lblComp.Location = new System.Drawing.Point(100, 283);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(10, 13);
            this.lblComp.TabIndex = 4;
            this.lblComp.Text = "-";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.White;
            this.lblNum.Location = new System.Drawing.Point(100, 259);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(10, 13);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "-";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(100, 237);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(10, 13);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.Text = "-";
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(528, 446);
            this.Controls.Add(this.panelEnd);
            this.Name = "Pagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEnd.ResumeLayout(false);
            this.panelEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panelEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblCida;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblNum;
        private FontAwesome.Sharp.IconButton btnLer;
        private System.Windows.Forms.MaskedTextBox txtConsCEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}