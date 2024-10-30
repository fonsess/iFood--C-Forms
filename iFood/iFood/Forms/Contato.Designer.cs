namespace iFood
{
    partial class Contato
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
            this.panelTxt = new System.Windows.Forms.Panel();
            this.lblTxt = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.Label();
            this.telTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTxt
            // 
            this.panelTxt.BackColor = System.Drawing.Color.DarkRed;
            this.panelTxt.Controls.Add(this.lblTxt);
            this.panelTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTxt.Location = new System.Drawing.Point(0, 0);
            this.panelTxt.Name = "panelTxt";
            this.panelTxt.Size = new System.Drawing.Size(800, 186);
            this.panelTxt.TabIndex = 0;
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.BackColor = System.Drawing.Color.DarkRed;
            this.lblTxt.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt.ForeColor = System.Drawing.Color.White;
            this.lblTxt.Location = new System.Drawing.Point(135, 64);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(553, 58);
            this.lblTxt.TabIndex = 0;
            this.lblTxt.Text = "Como você prefere falar com a gente?";
            // 
            // emailTxt
            // 
            this.emailTxt.AutoSize = true;
            this.emailTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.emailTxt.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.ForeColor = System.Drawing.Color.Brown;
            this.emailTxt.Location = new System.Drawing.Point(116, 237);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(74, 38);
            this.emailTxt.TabIndex = 1;
            this.emailTxt.Text = "E-mail";
            // 
            // telTxt
            // 
            this.telTxt.AutoSize = true;
            this.telTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.telTxt.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTxt.ForeColor = System.Drawing.Color.Brown;
            this.telTxt.Location = new System.Drawing.Point(495, 237);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(101, 38);
            this.telTxt.TabIndex = 2;
            this.telTxt.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "ifoodtestecsharp@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "(13) 91234-5678";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tem alguma dúvida?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Você pode ligar a qualquer hora.";
            // 
            // Contato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.panelTxt);
            this.Name = "Contato";
            this.Text = "Contato";
            this.panelTxt.ResumeLayout(false);
            this.panelTxt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTxt;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Label emailTxt;
        private System.Windows.Forms.Label telTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}