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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Relogio.Text = DateTime.Now.ToString("T");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Relogio_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"D:\Projetos\C#\Trabalho 1 - ELT 435\Imagens para animação\img" + 99 + ".png");
            this.pictureBox1.Image = image;
        }
    }
}
