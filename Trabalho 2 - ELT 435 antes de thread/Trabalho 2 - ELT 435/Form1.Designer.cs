
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
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Altoforno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Trilho)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PicB_Altoforno
            // 
            this.PicB_Altoforno.Location = new System.Drawing.Point(738, 54);
            this.PicB_Altoforno.Name = "PicB_Altoforno";
            this.PicB_Altoforno.Size = new System.Drawing.Size(194, 467);
            this.PicB_Altoforno.TabIndex = 1;
            this.PicB_Altoforno.TabStop = false;
            this.PicB_Altoforno.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PicB_Trilho
            // 
            this.PicB_Trilho.Location = new System.Drawing.Point(12, 353);
            this.PicB_Trilho.Name = "PicB_Trilho";
            this.PicB_Trilho.Size = new System.Drawing.Size(635, 171);
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
            this.btn_NC.Size = new System.Drawing.Size(84, 27);
            this.btn_NC.TabIndex = 3;
            this.btn_NC.Text = "Novo Carrinho";
            this.btn_NC.UseVisualStyleBackColor = true;
            this.btn_NC.Click += new System.EventHandler(this.btn_NC_Click);
            // 
            // Relogio
            // 
            this.Relogio.AutoSize = true;
            this.Relogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relogio.Location = new System.Drawing.Point(853, 9);
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
            this.nv_reserv.Location = new System.Drawing.Point(700, 31);
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
            this.button2.Size = new System.Drawing.Size(84, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(779, 504);
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
            this.timer_esteira.Tick += new System.EventHandler(this.timer_esteira_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(944, 533);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

