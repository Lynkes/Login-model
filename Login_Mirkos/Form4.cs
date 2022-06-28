using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Mirkos
{
    public partial class Form4 : Form
    {
        String nomeArquivo = "flddt.txt";
        public LinkedList<Usuario> usr_registrados = new LinkedList<Usuario>();

        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            //Ao carregar o Formulário principal
            //vamos carregar também o arquivo
            //com os dados para o usr_registrados
            try
            {
                StreamReader leitor =
                new StreamReader(nomeArquivo);
                while (!leitor.EndOfStream)
                {
                    Usuario usr = new Usuario();
                    String linha = leitor.ReadLine();
                    String separador = ";";
                    String[] dados = Regex
                        .Split(linha, separador);
                    usr.Nome = dados[0];
                    usr.Telefone = dados[1];
                    usr.Email = dados[2];
                    usr_registrados.AddLast(usr);

                }
                leitor.Close();
            } catch { }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

            Form1 formulario = new Form1(usr_registrados);
            formulario.Show();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            //pronto
            Form2 formulario = new Form2(usr_registrados);
            formulario.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2(usr_registrados);
            formulario.Show();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2(usr_registrados);
            formulario.Show();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.gravaDados();
            this.Close();
        }

        private void gravaDados()
        {
            StreamWriter gravador = new StreamWriter(nomeArquivo);

            foreach (Usuario usr in usr_registrados)
            {
                gravador.WriteLine(usr.Nome + ";" + usr.Telefone + ";" + usr.Email);
            }
            gravador.Close();
        }
    }
}
