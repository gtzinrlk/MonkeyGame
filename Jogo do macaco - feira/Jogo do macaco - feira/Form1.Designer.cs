namespace Jogo_do_macaco___feira
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Comecar = new System.Windows.Forms.Label();
            this.lbl_Rank = new System.Windows.Forms.Label();
            this.lbl_Sair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Comecar
            // 
            this.lbl_Comecar.AutoSize = true;
            this.lbl_Comecar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Comecar.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comecar.Location = new System.Drawing.Point(344, 109);
            this.lbl_Comecar.Name = "lbl_Comecar";
            this.lbl_Comecar.Size = new System.Drawing.Size(128, 45);
            this.lbl_Comecar.TabIndex = 0;
            this.lbl_Comecar.Text = "JOGAR";
            this.lbl_Comecar.Click += new System.EventHandler(this.lbl_Comecar_Click);
            this.lbl_Comecar.MouseLeave += new System.EventHandler(this.lbl_Comecar_MouseLeave);
            this.lbl_Comecar.MouseHover += new System.EventHandler(this.lbl_Comecar_MouseHover);
            // 
            // lbl_Rank
            // 
            this.lbl_Rank.AutoSize = true;
            this.lbl_Rank.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Rank.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Rank.Location = new System.Drawing.Point(344, 194);
            this.lbl_Rank.Name = "lbl_Rank";
            this.lbl_Rank.Size = new System.Drawing.Size(171, 45);
            this.lbl_Rank.TabIndex = 1;
            this.lbl_Rank.Text = "RANKING";
            this.lbl_Rank.MouseLeave += new System.EventHandler(this.lbl_Rank_MouseLeave);
            this.lbl_Rank.MouseHover += new System.EventHandler(this.lbl_Rank_MouseHover);
            // 
            // lbl_Sair
            // 
            this.lbl_Sair.AutoSize = true;
            this.lbl_Sair.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sair.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Sair.Location = new System.Drawing.Point(344, 274);
            this.lbl_Sair.Name = "lbl_Sair";
            this.lbl_Sair.Size = new System.Drawing.Size(94, 45);
            this.lbl_Sair.TabIndex = 2;
            this.lbl_Sair.Text = "SAIR";
            this.lbl_Sair.Click += new System.EventHandler(this.lbl_Sair_Click);
            this.lbl_Sair.MouseLeave += new System.EventHandler(this.lbl_Sair_MouseLeave);
            this.lbl_Sair.MouseHover += new System.EventHandler(this.lbl_Sair_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Sair);
            this.Controls.Add(this.lbl_Rank);
            this.Controls.Add(this.lbl_Comecar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Jogo do macaco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Comecar;
        private System.Windows.Forms.Label lbl_Rank;
        private System.Windows.Forms.Label lbl_Sair;
    }
}

