namespace Jogo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTexto = new System.Windows.Forms.Label();
            this.brnCadastro = new System.Windows.Forms.Button();
            this.btnrRanking = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(22, 428);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(338, 13);
            this.lblTexto.TabIndex = 10;
            this.lblTexto.Text = "Programa feito por Caynan Hyago e Gabriel Yure do 2ºInfo";
            // 
            // brnCadastro
            // 
            this.brnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.brnCadastro.FlatAppearance.BorderSize = 0;
            this.brnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnCadastro.Image = global::Jogo.Properties.Resources.btnCadastrar;
            this.brnCadastro.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.brnCadastro.Location = new System.Drawing.Point(60, 298);
            this.brnCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.brnCadastro.Name = "brnCadastro";
            this.brnCadastro.Size = new System.Drawing.Size(243, 73);
            this.brnCadastro.TabIndex = 11;
            this.brnCadastro.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.brnCadastro.UseVisualStyleBackColor = false;
            this.brnCadastro.Click += new System.EventHandler(this.button1_Click);
            this.brnCadastro.MouseEnter += new System.EventHandler(this.brnCadastro_MouseEnter);
            this.brnCadastro.MouseLeave += new System.EventHandler(this.brnCadastro_MouseLeave);
            // 
            // btnrRanking
            // 
            this.btnrRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnrRanking.FlatAppearance.BorderSize = 0;
            this.btnrRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrRanking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnrRanking.Image = global::Jogo.Properties.Resources.btnRank;
            this.btnrRanking.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnrRanking.Location = new System.Drawing.Point(60, 225);
            this.btnrRanking.Margin = new System.Windows.Forms.Padding(0);
            this.btnrRanking.Name = "btnrRanking";
            this.btnrRanking.Size = new System.Drawing.Size(243, 73);
            this.btnrRanking.TabIndex = 7;
            this.btnrRanking.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnrRanking.UseVisualStyleBackColor = false;
            this.btnrRanking.MouseEnter += new System.EventHandler(this.btnrRanking_MouseEnter);
            this.btnrRanking.MouseLeave += new System.EventHandler(this.btnrRanking_MouseLeave);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciar.Image = global::Jogo.Properties.Resources.btnIniciar;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnIniciar.Location = new System.Drawing.Point(65, 151);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(238, 74);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btniniciar_Click);
            this.btnIniciar.MouseEnter += new System.EventHandler(this.btnIniciar_MouseEnter);
            this.btnIniciar.MouseLeave += new System.EventHandler(this.btnIniciar_MouseLeave);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsair.Image = global::Jogo.Properties.Resources.btnSair1;
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnsair.Location = new System.Drawing.Point(9, 371);
            this.btnsair.Margin = new System.Windows.Forms.Padding(0);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(47, 70);
            this.btnsair.TabIndex = 6;
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            this.btnsair.MouseEnter += new System.EventHandler(this.btnsair_MouseEnter);
            this.btnsair.MouseLeave += new System.EventHandler(this.btnsair_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 454);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.brnCadastro);
            this.Controls.Add(this.btnrRanking);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MouseEnter += new System.EventHandler(this.frmPrincipal_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnrRanking;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button brnCadastro;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

