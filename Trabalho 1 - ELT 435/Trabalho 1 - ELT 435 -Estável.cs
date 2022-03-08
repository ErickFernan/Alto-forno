using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_1___ELT_435
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Criação da variavel
        int num_seg = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Enviar hora atual para o relogio
            Relogio.Text = DateTime.Now.ToString("T");

            //Variavél incrementada pelo tempo do timer
            num_seg ++;
            


            //Plotar imagens
            if ((stCliques - num_seg) > 0 && (stCliques - num_seg) < 101)
            {
                Image image = Image.FromFile(@"D:\Projetos\C#\Trabalho 1 - ELT 435\Imagens para animação\img" + (stCliques - num_seg) + ".png");
                this.pictureBox1.Image = image;

            }
            else 
            {
                //Pausar programa

                timer1.Stop();
               

                //Caixa de erro
                if ( MessageBox.Show("Para evitar avarias por mau uso o sistema foi desligado, por favor reinicie a operação",
                                 "Erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error)==DialogResult.OK)
                {
                    Environment.Exit(0); 
                }
                
            }

            //Mostrar quantidade de material processado
            Qnt_processada.Text = "Quantidade de material processado: " + num_seg + " Toneladas.";

            // Mostrar quantidade de material no reservatório
            Qnt_reserv.Text = "Quantidade de material no reservatório: "+(stCliques - num_seg) +" Toneladas.";

            // Avisos para o operador
            if ((stCliques - num_seg) > 72)
            {
                Avisos.ForeColor = System.Drawing.Color.Green;
                Avisos.Text = "Nível do reservatório dentro do desejável.";
            }
            else if ((stCliques - num_seg) > 39 && (stCliques - num_seg) <= 72)
            {
                Avisos.ForeColor = System.Drawing.Color.Yellow;
                Avisos.Text = "Nível do reservatório abaixo do esperado, adicione mais material.";
            }
            else 
            {
                Avisos.ForeColor = System.Drawing.Color.Red;
                Avisos.Text = "Nível do reservatório muito abaixo do esperado, adicione mais material ou o sistema irá desligar.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Iniciar timer
            timer1.Start();
            inic_func.Text = "Horário do início de funcionamento:  " + DateTime.Now.ToString("T")+".";

        }

        private void Relogio_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        //Criação da variavel
        int stCliques = 100;
        int viagens_carrinho = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            stCliques+=10;

            viagens_carrinho++;

            num_carrinhos.Text = "Quantidade de viagens com o carrinho: " + viagens_carrinho + ".";

        }

        private void Avisos_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void temp_func_Click(object sender, EventArgs e)
        {
            
        }
    }
}
