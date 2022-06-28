using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Mirkos
{
    public partial class Form1 : Form
    {
        
        public LinkedList<Usuario> usr_registrados = new LinkedList<Usuario>();

        public Form1(LinkedList<Usuario> usr_registrados)
        {
            this.usr_registrados = usr_registrados;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //grava arquivo com o conteúdo do usr_registrados
            
        }

        

        
            

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Nome = textBox1.Text;
            user.Telefone = textBox2.Text;
            user.Email = textBox3.Text;

            this.usr_registrados.AddLast(user);
            MessageBox.Show("Usuário Criado");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
