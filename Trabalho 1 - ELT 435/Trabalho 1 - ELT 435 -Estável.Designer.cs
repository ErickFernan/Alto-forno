
namespace Trabalho_1___ELT_435
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Relogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.Qnt_processada = new System.Windows.Forms.Label();
            this.Qnt_reserv = new System.Windows.Forms.Label();
            this.num_carrinhos = new System.Windows.Forms.Label();
            this.Avisos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inic_func = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Relogio
            // 
            this.Relogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relogio.Location = new System.Drawing.Point(682, 9);
            this.Relogio.Name = "Relogio";
            this.Relogio.Size = new System.Drawing.Size(106, 23);
            this.Relogio.TabIndex = 0;
            this.Relogio.Text = "00:00:00";
            this.Relogio.Click += new System.EventHandler(this.Relogio_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(427, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkGray;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(188, 381);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(146, 57);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Novo Carrinho";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Qnt_processada
            // 
            this.Qnt_processada.AutoSize = true;
            this.Qnt_processada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qnt_processada.Location = new System.Drawing.Point(46, 90);
            this.Qnt_processada.Name = "Qnt_processada";
            this.Qnt_processada.Size = new System.Drawing.Size(407, 20);
            this.Qnt_processada.TabIndex = 3;
            this.Qnt_processada.Text = "Quantidade de material processado: 0 Toneladas.";
            // 
            // Qnt_reserv
            // 
            this.Qnt_reserv.AutoSize = true;
            this.Qnt_reserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qnt_reserv.Location = new System.Drawing.Point(46, 128);
            this.Qnt_reserv.Name = "Qnt_reserv";
            this.Qnt_reserv.Size = new System.Drawing.Size(454, 20);
            this.Qnt_reserv.TabIndex = 4;
            this.Qnt_reserv.Text = "Quantidade de material no reservatório: 100 Toneladas.";
            // 
            // num_carrinhos
            // 
            this.num_carrinhos.AutoSize = true;
            this.num_carrinhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_carrinhos.Location = new System.Drawing.Point(46, 164);
            this.num_carrinhos.Name = "num_carrinhos";
            this.num_carrinhos.Size = new System.Drawing.Size(341, 20);
            this.num_carrinhos.TabIndex = 5;
            this.num_carrinhos.Text = "Quantidade de viagens com o carrinho: 0.";
            // 
            // Avisos
            // 
            this.Avisos.BackColor = System.Drawing.Color.DarkGray;
            this.Avisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Avisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avisos.Location = new System.Drawing.Point(50, 324);
            this.Avisos.Name = "Avisos";
            this.Avisos.Size = new System.Drawing.Size(417, 54);
            this.Avisos.TabIndex = 6;
            this.Avisos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Avisos.Click += new System.EventHandler(this.Avisos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Avisos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inic_func
            // 
            this.inic_func.AutoSize = true;
            this.inic_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inic_func.Location = new System.Drawing.Point(46, 202);
            this.inic_func.Name = "inic_func";
            this.inic_func.Size = new System.Drawing.Size(373, 20);
            this.inic_func.TabIndex = 8;
            this.inic_func.Text = "Horário do início de funcionamento: 00:00:00.";
            this.inic_func.Click += new System.EventHandler(this.temp_func_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resumo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(801, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inic_func);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Avisos);
            this.Controls.Add(this.num_carrinhos);
            this.Controls.Add(this.Qnt_reserv);
            this.Controls.Add(this.Qnt_processada);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Relogio);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ELT 435 - Projeto 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Relogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label Qnt_processada;
        private System.Windows.Forms.Label Qnt_reserv;
        private System.Windows.Forms.Label num_carrinhos;
        private System.Windows.Forms.Label Avisos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inic_func;
        private System.Windows.Forms.Label label2;
    }
}

