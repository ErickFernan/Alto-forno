using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Trabalho_2___ELT_435
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Temporizador da esteira
        float tick = 0;

        //Variáveis para cor do carrinho
        Color c;
        Random r;

        //Conta segundos
        int num_seg = 10;

        //Contador de carrinhos
        int novo_carrinho = 0;

        //Variável para contar pixels andado pelo carrinho
        float pixel = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            //Parte Relacionada ao Alto-Forno


            //criar a folha em branco
            Bitmap imgback = new Bitmap(PicB_Altoforno.Width, PicB_Altoforno.Height);
            Graphics desenhador = Graphics.FromImage(imgback);

            //Atribuir um cor de fundo
            desenhador.Clear(Color.Gray);

            //Criar lápis
            Pen lapis = new Pen(Color.Black, 4);

            //Preenchimento
            Brush pincel = new SolidBrush(Color.Black);
            Brush pincel1 = new LinearGradientBrush(new Point(30, 430),
                                                    new Point(30, 29),
                                                    Color.Red,
                                                    Color.Yellow
                                                    );


            //Plotagem

            //Desenhar altoforno
            desenhador.DrawRectangle(lapis, new Rectangle(8, 27, 154, 405));

            //Preencher altoforno
            desenhador.FillRectangle(pincel1, new Rectangle(10, 30, 150, 400));

            //Detalhes sup e inf
            desenhador.FillRectangle(pincel, new Rectangle(6, 0, 158, 25));
            desenhador.FillRectangle(pincel, new Rectangle(6, 430, 158, 50));

            //Apresenta a imagem final
            PicB_Altoforno.BackgroundImage = imgback;







            //Parte relacionada a esteira

            //Carrinho

            //Criar cor aleatória
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));



            float seno = (float)(Math.Sin((0.06 * tick)));
            float cosseno = (float)(Math.Cos((0.06 * tick)));

            float seno2 = (float)(Math.Sin(((0.06 * tick) + Math.PI / 2)));
            float cosseno2 = (float)(Math.Cos(((0.06 * tick) + Math.PI / 2)));

            //Criar folha em branco
            Bitmap imgback2 = new Bitmap(PicB_Trilho.Width, PicB_Trilho.Height);
            Graphics desenhador2 = Graphics.FromImage(imgback2);

            //Atribuir um cor de fundo
            desenhador2.Clear(Color.Gray);

            //Criar lápis
            Pen lapis01 = new Pen(Color.Black, 4);
            Pen lapis11 = new Pen(c, 2);
            Pen lapis21 = new Pen(Color.BurlyWood, 2);

            //Criar pincel
            Brush pincel01 = new SolidBrush(c);
            Brush pincel11 = new SolidBrush(Color.Black);
            Brush pincel21 = new SolidBrush(Color.DarkGray);




            //Pontos do carrinho
            PointF[] curvePointscarrinho = new PointF[]
            {

            new PointF(00.0F+tick,  100.0F),
            new PointF(120.0F+tick,  100.0F),
            new PointF(100.0F+tick, 135.0F),
            new PointF(20.0F+tick, 135.0F)

            };



            //Desenhar carrinho
            desenhador2.FillPolygon(pincel11, curvePointscarrinho);




            //Pontos da forma do material
            PointF[] curvePointsmaterial = new PointF[]
           {

            new PointF(3.0F+tick,  100.0F),
            new PointF(117.0F+tick,  100.0F),
            new PointF(107.0F+tick, 80.0F),
            new PointF(17.0F+tick, 80.0F)

           };


            //Desenhar material
            desenhador2.FillPolygon(pincel01, curvePointsmaterial);


            //Desenhar Estrada
            desenhador2.FillRectangle(pincel11, 0, 145, 620, 15);
            desenhador2.FillRectangle(pincel21, 0, 160, 620, 20);


            //Desenhar roda 1
            desenhador2.DrawLine(lapis11, (10 * -cosseno ) + 85 + tick, (10 * -seno ) + 135, (10 * cosseno ) + 85 + tick, (10 * seno ) + 135);
            desenhador2.DrawLine(lapis11, (10 * -cosseno2) + 85 + tick, (10 * -seno2) + 135, (10 * cosseno2) + 85 + tick, (10 * seno2) + 135);
            desenhador2.DrawEllipse(lapis21, new RectangleF(75 + tick, 125, 20, 20));


            //Desenhar roda 2
            desenhador2.DrawLine(lapis11, (10 * -cosseno ) + 35 + tick, (10 * -seno ) + 135, (10 * cosseno ) + 35 + tick, (10 * seno ) + 135);
            desenhador2.DrawLine(lapis11, (10 * -cosseno2) + 35 + tick, (10 * -seno2) + 135, (10 * cosseno2) + 35 + tick, (10 * seno2) + 135);
            desenhador2.DrawEllipse(lapis21, new RectangleF(25 + tick, 125, 20, 20));


            



            



            //Apresenta a imagem final
            PicB_Trilho.BackgroundImage = imgback2;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Enviar hora atual para o relogio
            Relogio.Text = DateTime.Now.ToString("T");
        }

        
        
        private void timer_operação_Tick(object sender, EventArgs e)
        {
            //Qntidade de material no altoforno
            int resultado = num_seg - novo_carrinho;

            //criar a folha em branco
            Bitmap imgback = new Bitmap(PicB_Altoforno.Width, PicB_Altoforno.Height);
            Graphics desenhador = Graphics.FromImage(imgback);

            //Atribuir um cor de fundo
            desenhador.Clear(Color.Gray);

            //Criar lápis
            Pen lapis = new Pen(Color.Black, 4);

            //Preenchimento
            Brush pincel = new SolidBrush(Color.Black);
            Brush pincel1 = new LinearGradientBrush(new Point(30, 430),
                                                    new Point(30, 29),
                                                    Color.Red,
                                                    Color.Yellow
                                                    );


            //Plotagem

            //Desenhar altoforno
            desenhador.DrawRectangle(lapis, new Rectangle(8, 27, 154, 405));

            //Preencher altoforno
            desenhador.FillRectangle(pincel1, new Rectangle(10, (30+4*resultado), 150, (400-4*resultado)));

            //Detalhes sup e inf
            desenhador.FillRectangle(pincel, new Rectangle(6, 0, 158, 25));
            desenhador.FillRectangle(pincel, new Rectangle(6, 430, 158, 50));

            //Apresenta a imagem final
            PicB_Altoforno.BackgroundImage = imgback;


            
           if(resultado == 100) 
            {
                timer_operação.Stop();
            }


            //Texto indicador de volume no reservatório          

            nv_reserv.BackColor = Color.Transparent;
            nv_reserv.Text = "Nível do reservatório: "+(100-resultado) + " %";


            //Contador de tempo
            num_seg++;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = num_seg - novo_carrinho;
            if (resultado == 101)
            {
                if (MessageBox.Show("Reservatóio vazio, adicione mais material para ligar o sistema.",
                                        "Erro",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

            else
            {
                timer_operação.Start();
                timer_relogio.Start();
                //timer_esteira.Start();
            }
        }

        private void btn_NC_Click(object sender, EventArgs e)
        {
            int resultado = num_seg - novo_carrinho;
            if (resultado <= 11)
            {
                if (MessageBox.Show("Não é possível adicionar mais material, reservatório cheio.",
                                     "Erro",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }

            else
            {

                
                timer_operação.Start();
                timer_esteira.Start();
                r = new Random();
                c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                pixel = 0;
                tick = 0;
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nv_reserv_Click(object sender, EventArgs e)
        {
            
        }

        private void nv_reserv_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer_operação.Stop();
            timer_esteira.Stop();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer_esteira_Tick(object sender, EventArgs e)
        {
            //Parte relacionada a esteira

            //Variáveis para movimentação das rodas

            float seno = (float)(Math.Sin((0.06 * tick)));
            float cosseno = (float)(Math.Cos((0.06 * tick)));

            float seno2 = (float)(Math.Sin(((0.06 * tick) + Math.PI / 2)));
            float cosseno2 = (float)(Math.Cos(((0.06 * tick) + Math.PI / 2)));



            //Caso o carrinho não tenha completado o caminho

            if (pixel < 510)
            {
                //Carrinho

                //Criar folha em branco
                Bitmap imgback2 = new Bitmap(PicB_Trilho.Width, PicB_Trilho.Height);
                Graphics desenhador2 = Graphics.FromImage(imgback2);

                //Atribuir um cor de fundo
                desenhador2.Clear(Color.Gray);

                //Criar lápis
                Pen lapis01 = new Pen(Color.Black, 4);
                Pen lapis11 = new Pen(c, 2);
                Pen lapis21 = new Pen(Color.BurlyWood, 2);

                //Criar pincel
                Brush pincel01 = new SolidBrush(c);
                Brush pincel11 = new SolidBrush(Color.Black);
                Brush pincel21 = new SolidBrush(Color.DarkGray);




                //Pontos do carrinho
                PointF[] curvePointscarrinho = new PointF[]
                {

            new PointF(00.0F+tick,  100.0F),
            new PointF(120.0F+tick,  100.0F),
            new PointF(100.0F+tick, 135.0F),
            new PointF(20.0F+tick, 135.0F)

                };



                //Desenhar carrinho
                desenhador2.FillPolygon(pincel11, curvePointscarrinho);




                //Pontos da forma do material
                PointF[] curvePointsmaterial = new PointF[]
               {

            new PointF(3.0F+tick,  100.0F),
            new PointF(117.0F+tick,  100.0F),
            new PointF(107.0F+tick, 80.0F),
            new PointF(17.0F+tick, 80.0F)

               };


                //Desenhar material
                desenhador2.FillPolygon(pincel01, curvePointsmaterial);


                //Desenhar Estrada
                desenhador2.FillRectangle(pincel11, 0, 145, 620, 15);
                desenhador2.FillRectangle(pincel21, 0, 160, 620, 20);


                //Desenhar roda 1
                desenhador2.DrawLine(lapis11, (10 * -cosseno) + 85 + tick, (10 * -seno) + 135, (10 * cosseno) + 85 + tick, (10 * seno) + 135);
                desenhador2.DrawLine(lapis11, (10 * -cosseno2) + 85 + tick, (10 * -seno2) + 135, (10 * cosseno2) + 85 + tick, (10 * seno2) + 135);
                desenhador2.DrawEllipse(lapis21, new RectangleF(75 + tick, 125, 20, 20));


                //Desenhar roda 2
                desenhador2.DrawLine(lapis11, (10 * -cosseno) + 35 + tick, (10 * -seno) + 135, (10 * cosseno) + 35 + tick, (10 * seno) + 135);
                desenhador2.DrawLine(lapis11, (10 * -cosseno2) + 35 + tick, (10 * -seno2) + 135, (10 * cosseno2) + 35 + tick, (10 * seno2) + 135);
                desenhador2.DrawEllipse(lapis21, new RectangleF(25 + tick, 125, 20, 20));


                //Apresenta a imagem final
                PicB_Trilho.BackgroundImage = imgback2;


            }

            else
            {
                //Criar folha em branco
                Bitmap imgback2 = new Bitmap(PicB_Trilho.Width, PicB_Trilho.Height);
                Graphics desenhador2 = Graphics.FromImage(imgback2);

                //Atribuir um cor de fundo
                desenhador2.Clear(Color.Gray);

                //Criar lápis
                Pen lapis01 = new Pen(Color.Black, 4);
                Pen lapis11 = new Pen(c, 2);
                Pen lapis21 = new Pen(Color.BurlyWood, 2);

                //Criar pincel
                Brush pincel01 = new SolidBrush(c);
                Brush pincel11 = new SolidBrush(Color.Black);
                Brush pincel21 = new SolidBrush(Color.DarkGray);
                //Desenhar Estrada
                desenhador2.FillRectangle(pincel11, 0, 145, 620, 15);
                desenhador2.FillRectangle(pincel21, 0, 160, 620, 20);
                //Apresenta a imagem final
                PicB_Trilho.BackgroundImage = imgback2;

            }




            //Parte responsável por somar +10 no reservatório qnd o carrinho terminar o percusso

            if (pixel == 500)
            {
                novo_carrinho += 10;
            }


            //tick  = tick  + (float)(0.5);//Rever se mantem 100 ou 200;
            tick = tick + 5;
            //pixel = pixel + (float)(0.5);
            pixel = pixel +5;


        }
    }
}
