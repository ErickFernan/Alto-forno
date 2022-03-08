using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Threading.Tasks;
using System.IO;




namespace Trabalho_2___ELT_435
{
    public partial class Form1 : Form
    {
        //static Mutex m = new Mutex(false, "Sample_Mutex");

        static bool sem_created;
        static int sem_count = 2;

        static Semaphore s = new Semaphore(sem_count, sem_count, "Sample_Sem", out sem_created);


        public Form1()
        {
            InitializeComponent();
            
            //Responsável por criar cores aleatorias
            c = new Color[qntcarrinhos];
            Random r = new Random();

            for (int a=0; a < qntcarrinhos; a++)
            {
                
                c[a] = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                //listBox1.Items.Add(c[a]);
            }


        }


        //Inicializadores
        int resultado;

        //Sentinela para carrinho de escoria
        bool sent_escoria = false;
       
        //Hora início
        DateTime[] H_start = new DateTime[999];

        //Hora fim
        DateTime[] H_end = new DateTime[999];

        //Diferença de hora
        DateTime[] H_dif = new DateTime[999];

        //Criar cor aleatoria
        Color[] c;

        //Desenhar carro

        Graphics[] desenhadorcar = new Graphics[999];

        //zeros para relatório
        int zerosesquerda = 3;

        //Mudar qntcarrinho/thread/pixel pra alterar o numero de carrinho
        int qntcarrinhos = 999;

        //Criar arrays para thread
        int i = -1;
        Thread[] threadsArray = new Thread[999];

        //Criar array thread para escoria
        int n_esc = -1;
        Thread[] threadesc = new Thread[500];

        //movimentação do carrinho
        float[] pixel = new float[999];

        //movimentação carrinho de escoria
        float[] posicaoesc = new float[500];

        //Conta segundos
        int num_seg = 40;

        //Contador de carrinhos
        int novo_carrinho = 0;


        //Contador para controlar carrinhos thread
        int countcar = 0;

        //Contador para numero de vezes apertado o botão NC
        int NC = 0;

        //Sentinela botão start
        bool startpress = false;

        //Sentinela para modo manual/automático
        bool manual = true;

        //Inciar desenhos originais
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

            //Apresenta a imagem final do alto-forno
            PicB_Altoforno.BackgroundImage = imgback;

            //Desenhar trilho/carrinho

            Bitmap imgback2 = new Bitmap(PicB_Trilho.Width, PicB_Trilho.Height);
            Graphics desenhador2 = Graphics.FromImage(imgback2);
            //Criar pincel

            Brush pincel11 = new SolidBrush(Color.Black);
            Brush pincel21 = new SolidBrush(Color.DarkGray);
            //Desenhar Estrada

            //Estrada 1
            //Primeira metade(contornos)
            desenhador2.FillRectangle(pincel11, 0, 65, 255, 5);
            desenhador2.FillRectangle(pincel11, 0, 120, 255, 5);

            //meio(estrada)
            desenhador2.FillRectangle(pincel21, 0, 70, 505, 50);

            //Segunda metade(contornos)
            desenhador2.FillRectangle(pincel11, 305, 65, 200, 5);
            desenhador2.FillRectangle(pincel11, 305, 120, 200, 5);


            //Estrada 2
            //Primeira metade(contornos)
            desenhador2.FillRectangle(pincel11, 0, 0, 310, 5);
            desenhador2.FillRectangle(pincel11, 0, 55, 255, 5);
            desenhador2.FillRectangle(pincel11, 305, 0, 5, 65);
            desenhador2.FillRectangle(pincel11, 250, 60, 5, 5);

            //meio(estrada)
            desenhador2.FillRectangle(pincel21, 0, 5, 305, 50);
            desenhador2.FillRectangle(pincel21, 250, 135, 255, 50);
            desenhador2.FillRectangle(pincel21, 255, 55, 50, 15);
            desenhador2.FillRectangle(pincel21, 255, 120, 50, 15);

            //Segunda metade(contornos)
            desenhador2.FillRectangle(pincel11, 0, 0, 310, 5);
            desenhador2.FillRectangle(pincel11, 0, 55, 255, 5);
            desenhador2.FillRectangle(pincel11, 250, 125, 5, 55);
            desenhador2.FillRectangle(pincel11, 305, 125, 5, 5);
            desenhador2.FillRectangle(pincel11, 305, 130, 200, 5);
            desenhador2.FillRectangle(pincel11, 250, 180, 255, 5);


            PicB_Trilho.BackgroundImage =  imgback2; ;

           

        }

        //Função para desenhar o carrinho

        public Bitmap desenhista(float[] pixel, Color[] c, float[] posicaoesc)
        {

            Bitmap imgback2 = new Bitmap(PicB_Trilho.Width, PicB_Trilho.Height);
            Graphics desenhador2 = Graphics.FromImage(imgback2);

            

            //Atribuir um cor de fundo
            desenhador2.Clear(Color.Gray);


            //Criar pincel
            Brush pincel11 = new SolidBrush(Color.Black);
            Brush pincel21 = new SolidBrush(Color.DarkGray);


            //Desenhar Estrada

            //Estrada 1
            //Primeira metade(contornos)
            desenhador2.FillRectangle(pincel11, 0, 65, 255, 5);
            desenhador2.FillRectangle(pincel11, 0, 120, 255, 5);

            //meio(estrada)
            desenhador2.FillRectangle(pincel21, 0, 70, 505, 50);

            //Segunda metade(contornos)
            desenhador2.FillRectangle(pincel11, 305, 65, 200, 5);
            desenhador2.FillRectangle(pincel11, 305, 120, 200, 5);


            //Estrada 2
            //Primeira metade(contornos)
            desenhador2.FillRectangle(pincel11, 0, 0, 310, 5);
            desenhador2.FillRectangle(pincel11, 0, 55, 255, 5);
            desenhador2.FillRectangle(pincel11, 305, 0, 5, 65);
            desenhador2.FillRectangle(pincel11, 250, 60, 5, 5);

            //meio(estrada)
            desenhador2.FillRectangle(pincel21, 0, 5, 305, 50);
            desenhador2.FillRectangle(pincel21, 250, 135, 255, 50);
            desenhador2.FillRectangle(pincel21, 255, 55, 50, 15);
            desenhador2.FillRectangle(pincel21, 255, 120, 50, 15);

            //Segunda metade(contornos)
            desenhador2.FillRectangle(pincel11, 0, 0, 310, 5);
            desenhador2.FillRectangle(pincel11, 0, 55, 255, 5);
            desenhador2.FillRectangle(pincel11, 250, 125, 5, 55);
            desenhador2.FillRectangle(pincel11, 305, 125, 5, 5);
            desenhador2.FillRectangle(pincel11, 305, 130, 200, 5);
            desenhador2.FillRectangle(pincel11, 250, 180, 255, 5);



            for (int q = 0; q < qntcarrinhos; q++)
                
            {
                
                // Selecionar cor
                Brush pincel = new SolidBrush(c[q]);

                desenhador2.FillRectangle(pincel, new Rectangle((int)(pixel[q]), 95, 5, 5));
                
            }

            for (int h = 0; h < 500; h++)
            {
                // Selecionar cor
                Brush pincel = new SolidBrush(c[h]);

                if(posicaoesc[h]>=0 && posicaoesc[h]<=225)
                desenhador2.FillRectangle(pincel, new Rectangle(500-(int)(posicaoesc[h]), 160, 5, 5));

                if(posicaoesc[h] > 225 && posicaoesc[h] <= 355)
                desenhador2.FillRectangle(pincel, new Rectangle(275, (160 - (int)(posicaoesc[h]) + 225), 5, 5));

                if (posicaoesc[h] > 355 && posicaoesc[h] <= 630)
                desenhador2.FillRectangle(pincel, new Rectangle(630-(int)(posicaoesc[h]), 30, 5, 5));

            }

            //Apresenta a imagem final
            return imgback2;
            
        }

        
       

        public void k1(object data)
        {
            //Recebe a hora de inicio
            H_start[(int)data] = DateTime.Now;


            for (int h = 0; h < 500; h++)
            {
                
                //Controla posição
                pixel[(int)data]++;

                if (h == 250)
                {
                    //m.WaitOne();
                    s.WaitOne();

                }

                if (h == 300)
                {
                    //m.ReleaseMutex();
                    s.Release();
                    Thread.Sleep(100);
                    
                }

                if (h == 500-1)
                {
                    //Adiciona material ao alto-forno
                    novo_carrinho += 10;

                    //Recebe a hora final
                    H_end[(int)data] = DateTime.Now;


                    if (listBox1.InvokeRequired)
                        listBox1.BeginInvoke((MethodInvoker)
                            delegate {

                                //Calcula tempo total
                                TimeSpan horaTotal = new TimeSpan(H_end[(int)data].Ticks - H_start[(int)data].Ticks);
                                

                            //Escreve o relatório no listbox
                                listBox1.Items.Add("Carrinho " + ((int)data+1).ToString("D"+zerosesquerda.ToString()) + " Início: " + H_start[(int)data].ToString("T") + "; Tempo: "+ horaTotal.TotalSeconds.ToString("F" + zerosesquerda.ToString()) + " segundos" );



                            });
                   
                }
                
                //Controla a velocidade do carrinho
                //Thread.Sleep(190);
                Thread.Sleep(50);

            }



        }
        
        public void escoria(object data)
        {
            for (int h = 0; h < 630; h++)
            {
                posicaoesc[(int)data]++;
                //Thread.Sleep(190);
                Thread.Sleep(10);

                if (h == 265)
                {
                    //m.WaitOne();
                    s.WaitOne();

                }

                if (h == 315)
                {
                    //m.ReleaseMutex();
                    s.Release();
                    Thread.Sleep(100);
                    
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        
        //Timer para o relógio
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Enviar hora atual para o relogio
            Relogio.Text = DateTime.Now.ToString("T");
            
        }

        
        //Parte responsável pelo alto-forno
        private void timer_operação_Tick(object sender, EventArgs e)
        {
            //Qntidade de material no altoforno
            //resultado = num_seg - novo_carrinho;

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


            
           

            
            //Texto indicador de volume no reservatório          

            nv_reserv.BackColor = Color.Transparent;
            nv_reserv.Text = "Nível do reservatório: "+(100-resultado) + " %";


            //Mostrar quantidade de material processado
            Qnt_processada.Text = "Quantidade de material processado: " + num_seg + " Toneladas.";


            // Avisos para o operador
            if (resultado <= 33)
            {
                Avisos.ForeColor = System.Drawing.Color.Green;
                Avisos.Text = "Nível do reservatório dentro do desejável.";
            }
            else if (resultado > 33 && resultado <= 66)
            {
                Avisos.ForeColor = System.Drawing.Color.Yellow;
                Avisos.Text = "Nível do reservatório abaixo do esperado, adicione mais material.";
            }
            else
            {
                Avisos.ForeColor = System.Drawing.Color.Red;
                Avisos.Text = "Nível do reservatório muito abaixo do esperado, adicione mais material urgentemente.";
            }

            if (resultado < 100)
            {
                //Contador de tempo
                num_seg++;
            }
            

           

            

        }


        //Botão Start
        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = num_seg - novo_carrinho;
            if (resultado >= 100)
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
                inic_func.Text = "Horário do início de funcionamento:  " + DateTime.Now.ToString("T") + ".";
                timer_esteira.Start();
                start_residuo.Start();
                startpress = true;
            }
        }

        //Botão Novo carrinho
        private void btn_NC_Click(object sender, EventArgs e)
        {
            if (manual)
            {
                //Adicionar um carrinho
                if (i != qntcarrinhos)
                {

                    i++;

                }

                int resultado = num_seg - novo_carrinho;
                if (resultado <= 11 || !startpress)
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

                    if (NC == 0)
                    {

                        timer_esteira.Start();

                    }

                    countcar++;
                    NC++;
                    numcarrinhos.Text = ("Quantidade de carrinhos: " + NC + " carrinhos.");

                    //Cria uma thread no array na posição i
                    threadsArray[i] = new Thread(k1);

                    //inicia a thread i
                    threadsArray[i].Start(i);

                    //Adicionar uma unidade à variável i


                }
            }

            else
            {
                if (MessageBox.Show("Modo automático habilitado",
                                             "Erro",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
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
            //timer_esteira.Stop();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Timer que controla a esteira
        private void timer_esteira_Tick(object sender, EventArgs e)
        {

            PicB_Trilho.BackgroundImage = desenhista(pixel, c,posicaoesc);
            //Rotina para salvar arquivos do Listbox

            const string sPath = "Relatorio.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();


            // Atualiza a vaíável "resultado" mais rápido, fiz essa mudança para evitar problemas com os carrinhos de residuo
            resultado = num_seg - novo_carrinho;

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            //Rotina para salvar arquivos do Listbox

            const string sPath = "Relatorio.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Relatório salvo!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (manual == true)
            {
                manual = false;
                timer10seg.Start();
                timer5seg.Start();
            }
            else
            {
                manual = true;
                timer10seg.Stop();
                timer5seg.Stop();
            }
        }

        private void timer1seg_Tick(object sender, EventArgs e)
        {
            if (!manual)
            {
                if (resultado <= 61)
                {
                    //Adicionar um carrinho
                    if (i != qntcarrinhos)
                    {

                        i++;

                    }

                    resultado = num_seg - novo_carrinho;


                    if (NC == 0)
                    {

                        timer_esteira.Start();

                    }

                    countcar++;
                    NC++;
                    numcarrinhos.Text = ("Quantidade de carrinhos: " + NC + " carrinhos.");

                    //Cria uma thread no array na posição i
                    threadsArray[i] = new Thread(k1);

                    //inicia a thread i
                    threadsArray[i].Start(i);

                    //Adicionar uma unidade à variável i

                }
                
            }

            
        }

        private void timer2seg_Tick(object sender, EventArgs e)
        {
            if (!manual)
            {
                if (resultado > 61)
                {
                    //Adicionar um carrinho
                    if (i != qntcarrinhos)
                    {

                        i++;

                    }

                    


                    if (NC == 0)
                    {

                        timer_esteira.Start();

                    }

                    countcar++;
                    NC++;
                    numcarrinhos.Text = ("Quantidade de carrinhos: " + NC + " carrinhos.");

                    //Cria uma thread no array na posição i
                    threadsArray[i] = new Thread(k1);

                    //inicia a thread i
                    threadsArray[i].Start(i);

                    //Adicionar uma unidade à variável i


                }
            }
        }

        private void start_residuo_Tick(object sender, EventArgs e)
        {
            if (num_seg % 20 == 0 && num_seg != 0 )
            {
                if (resultado == 100)
                {
                    if (sent_escoria == false)
                    {
                        n_esc++;

                        //Cria uma thread no array na posição i
                        threadesc[n_esc] = new Thread(escoria);

                        //inicia a thread i
                        threadesc[n_esc].Start(n_esc);

                        sent_escoria = true;
                    }

                }

                else
                {
                    n_esc++;

                    //Cria uma thread no array na posição i
                    threadesc[n_esc] = new Thread(escoria);

                    //inicia a thread i
                    threadesc[n_esc].Start(n_esc);

                    sent_escoria = false;
                    
                }
            }
        }

        ////PARTE HTTP


        //public static HttpListener listener;
        //public static string url = "http://localhost:8000/";
        //public static int pageViews = 0;
        //public static int requestCount = 0;
        //public static string pageData =
        //    "<!DOCTYPE>" +
        //    "<html>" +
        //    "  <head>" +
        //    "    <title>HttpListener Example</title>" +
        //    "  </head>" +
        //    "  <body>" +
        //    "    <p>Page Views: {0}</p>" +
        //    "    <form method=\"post\" action=\"shutdown\">" +
        //    "      <input type=\"submit\" value=\"Shutdown\" {1}>" +
        //    "    </form>" +
        //    "  </body>" +
        //    "</html>";


        //public static async Task HandleIncomingConnections()
        //{
        //    bool runServer = true;

        //    // While a user hasn't visited the `shutdown` url, keep on handling requests
        //    while (runServer)
        //    {
        //        // Will wait here until we hear from a connection
        //        HttpListenerContext ctx = await listener.GetContextAsync();

        //        // Peel out the requests and response objects
        //        HttpListenerRequest req = ctx.Request;
        //        HttpListenerResponse resp = ctx.Response;

        //        // Print out some info about the request
        //        Console.WriteLine("Request #: {0}", ++requestCount);
        //        Console.WriteLine(req.Url.ToString());
        //        Console.WriteLine(req.HttpMethod);
        //        Console.WriteLine(req.UserHostName);
        //        Console.WriteLine(req.UserAgent);
        //        Console.WriteLine();

        //        // If `shutdown` url requested w/ POST, then shutdown the server after serving the page
        //        if ((req.HttpMethod == "POST") && (req.Url.AbsolutePath == "/shutdown"))
        //        {
        //            Console.WriteLine("Shutdown requested");
        //            runServer = false;
        //        }

        //        // Make sure we don't increment the page views counter if `favicon.ico` is requested
        //        if (req.Url.AbsolutePath != "/favicon.ico")
        //            pageViews += 1;

        //        // Write the response info
        //        string disableSubmit = !runServer ? "disabled" : "";
        //        byte[] data = Encoding.UTF8.GetBytes(String.Format(pageData, pageViews, disableSubmit));
        //        resp.ContentType = "text/html";
        //        resp.ContentEncoding = Encoding.UTF8;
        //        resp.ContentLength64 = data.LongLength;

        //        // Write out to the response stream (asynchronously), then close it
        //        await resp.OutputStream.WriteAsync(data, 0, data.Length);
        //        resp.Close();
        //    }
        //}


        //public static void Main(string[] args)
        //{
        //    // Create a Http server and start listening for incoming connections
        //    listener = new HttpListener();
        //    listener.Prefixes.Add(url);
        //    listener.Start();
        //    Console.WriteLine("Listening for connections on {0}", url);

        //    // Handle requests
        //    Task listenTask = HandleIncomingConnections();
        //    listenTask.GetAwaiter().GetResult();

        //    // Close the listener
        //    listener.Close();
        //}


    }
}
// Anotações sobre o estado atual

//Criar thread para a parte HTTP