
namespace Trabalho_2___ELT_435
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
            this.button1 = new System.Windows.Forms.Button();
            this.PicB_Altoforno = new System.Windows.Forms.PictureBox();
            this.PicB_Trilho = new System.Windows.Forms.PictureBox();
            this.timer_relogio = new System.Windows.Forms.Timer(this.components);
            this.timer_operação = new System.Windows.Forms.Timer(this.components);
            this.btn_NC = new System.Windows.Forms.Button();
            this.Relogio = new System.Windows.Forms.Label();
            this.nv_reserv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_esteira = new System.Windows.Forms.Timer(this.components);
            this.numcarrinhos = new System.Windows.Forms.Label();
            this.Qnt_processada = new System.Windows.Forms.Label();
            this.Avisos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inic_func = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer10seg = new System.Windows.Forms.Timer(this.components);
            this.timer5seg = new System.Windows.Forms.Timer(this.components);
            this.start_residuo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Altoforno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Trilho)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PicB_Altoforno
            // 
            this.PicB_Altoforno.Location = new System.Drawing.Point(538, 54);
            this.PicB_Altoforno.Name = "PicB_Altoforno";
            this.PicB_Altoforno.Size = new System.Drawing.Size(194, 467);
            this.PicB_Altoforno.TabIndex = 1;
            this.PicB_Altoforno.TabStop = false;
            this.PicB_Altoforno.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PicB_Trilho
            // 
            this.PicB_Trilho.Location = new System.Drawing.Point(12, 396);
            this.PicB_Trilho.Name = "PicB_Trilho";
            this.PicB_Trilho.Size = new System.Drawing.Size(520, 200);
            this.PicB_Trilho.TabIndex = 2;
            this.PicB_Trilho.TabStop = false;
            // 
            // timer_relogio
            // 
            this.timer_relogio.Interval = 1000;
            this.timer_relogio.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_operação
            // 
            this.timer_operação.Interval = 1000;
            this.timer_operação.Tick += new System.EventHandler(this.timer_operação_Tick);
            // 
            // btn_NC
            // 
            this.btn_NC.Location = new System.Drawing.Point(196, 315);
            this.btn_NC.Name = "btn_NC";
            this.btn_NC.Size = new System.Drawing.Size(84, 43);
            this.btn_NC.TabIndex = 3;
            this.btn_NC.Text = "Novo Carrinho ";
            this.btn_NC.UseVisualStyleBackColor = true;
            this.btn_NC.Click += new System.EventHandler(this.btn_NC_Click);
            // 
            // Relogio
            // 
            this.Relogio.AutoSize = true;
            this.Relogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relogio.Location = new System.Drawing.Point(578, 11);
            this.Relogio.Name = "Relogio";
            this.Relogio.Size = new System.Drawing.Size(79, 20);
            this.Relogio.TabIndex = 4;
            this.Relogio.Text = "00:00:00";
            this.Relogio.Click += new System.EventHandler(this.label1_Click);
            // 
            // nv_reserv
            // 
            this.nv_reserv.AutoSize = true;
            this.nv_reserv.BackColor = System.Drawing.Color.Transparent;
            this.nv_reserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nv_reserv.Location = new System.Drawing.Point(515, 31);
            this.nv_reserv.Name = "nv_reserv";
            this.nv_reserv.Size = new System.Drawing.Size(232, 20);
            this.nv_reserv.TabIndex = 5;
            this.nv_reserv.Text = "Nível do reservatório: 100 %";
            this.nv_reserv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nv_reserv.Click += new System.EventHandler(this.nv_reserv_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Comandos:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alto-forno";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resumo:";
            // 
            // timer_esteira
            // 
            this.timer_esteira.Interval = 200;
            this.timer_esteira.Tick += new System.EventHandler(this.timer_esteira_Tick);
            // 
            // numcarrinhos
            // 
            this.numcarrinhos.AutoSize = true;
            this.numcarrinhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numcarrinhos.Location = new System.Drawing.Point(13, 68);
            this.numcarrinhos.Name = "numcarrinhos";
            this.numcarrinhos.Size = new System.Drawing.Size(212, 15);
            this.numcarrinhos.TabIndex = 10;
            this.numcarrinhos.Text = "Quantidade de carrinhos: 0 carrinhos.";
            this.numcarrinhos.Click += new System.EventHandler(this.label4_Click);
            // 
            // Qnt_processada
            // 
            this.Qnt_processada.AutoSize = true;
            this.Qnt_processada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qnt_processada.Location = new System.Drawing.Point(13, 92);
            this.Qnt_processada.Name = "Qnt_processada";
            this.Qnt_processada.Size = new System.Drawing.Size(280, 15);
            this.Qnt_processada.TabIndex = 12;
            this.Qnt_processada.Text = "Quantidade de material processado: 0 Toneladas.";
            // 
            // Avisos
            // 
            this.Avisos.BackColor = System.Drawing.Color.DarkGray;
            this.Avisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Avisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avisos.Location = new System.Drawing.Point(12, 192);
            this.Avisos.Name = "Avisos";
            this.Avisos.Size = new System.Drawing.Size(417, 54);
            this.Avisos.TabIndex = 13;
            this.Avisos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Avisos:";
            // 
            // inic_func
            // 
            this.inic_func.AutoSize = true;
            this.inic_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inic_func.Location = new System.Drawing.Point(13, 115);
            this.inic_func.Name = "inic_func";
            this.inic_func.Size = new System.Drawing.Size(256, 15);
            this.inic_func.TabIndex = 15;
            this.inic_func.Text = "Horário do início de funcionamento: 00:00:00.";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkGray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(772, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(359, 468);
            this.listBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(915, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Relatório:";
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(286, 315);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(84, 43);
            this.Salvar.TabIndex = 18;
            this.Salvar.Text = "Salvar Relatório";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 43);
            this.button3.TabIndex = 19;
            this.button3.Text = "Manual/ Automático";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer10seg
            // 
            this.timer10seg.Interval = 10000;
            this.timer10seg.Tick += new System.EventHandler(this.timer1seg_Tick);
            // 
            // timer5seg
            // 
            this.timer5seg.Interval = 5000;
            this.timer5seg.Tick += new System.EventHandler(this.timer2seg_Tick);
            // 
            // start_residuo
            // 
            this.start_residuo.Interval = 1000;
            this.start_residuo.Tick += new System.EventHandler(this.start_residuo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1143, 625);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.inic_func);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Avisos);
            this.Controls.Add(this.Qnt_processada);
            this.Controls.Add(this.numcarrinhos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nv_reserv);
            this.Controls.Add(this.Relogio);
            this.Controls.Add(this.btn_NC);
            this.Controls.Add(this.PicB_Trilho);
            this.Controls.Add(this.PicB_Altoforno);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trabalho 2 - ELT 345 - Erick 86301";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Altoforno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Trilho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PicB_Altoforno;
        private System.Windows.Forms.PictureBox PicB_Trilho;
        private System.Windows.Forms.Timer timer_relogio;
        private System.Windows.Forms.Timer timer_operação;
        private System.Windows.Forms.Button btn_NC;
        private System.Windows.Forms.Label Relogio;
        private System.Windows.Forms.Label nv_reserv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer_esteira;
        private System.Windows.Forms.Label numcarrinhos;
        private System.Windows.Forms.Label Qnt_processada;
        private System.Windows.Forms.Label Avisos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label inic_func;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer10seg;
        private System.Windows.Forms.Timer timer5seg;
        private System.Windows.Forms.Timer start_residuo;
    }
}

