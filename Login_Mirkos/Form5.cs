using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Mirkos
{
    public partial class Form5 : Form
    {
        public LinkedList<Usuario> usr_registrados = new LinkedList<Usuario>();
        String nome;

        public Form5(LinkedList<Usuario> usr_registrados, String nome)
        {
            this.usr_registrados = usr_registrados;
            InitializeComponent();
            this.nome = nome;
            bool flag = false;

            for (int i = 0; i < this.usr_registrados.Count; i++)
            {
                Usuario user = this.usr_registrados.ElementAt(i);
                if (user.Nome.Equals(nome))
                {
                    //editar
                    textBoxNome.Text = user.Nome;
                    textBoxEmail.Text = user.Email;
                    textBoxTelefone.Text = user.Telefone;

                    flag = true;
                }



            }
            if (!flag)
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < this.usr_registrados.Count; i++)
            {
                Usuario user = this.usr_registrados.ElementAt(i);
                if (user.Nome.Equals(nome))
                {
                    //editar
                    user.Nome = textBoxNome.Text;
                    user.Email = textBoxEmail.Text;
                    user.Telefone = textBoxTelefone.Text;
                    MessageBox.Show("Usuário Editado com sucesso.");
                    textBoxNome.Text = "";
                    textBoxEmail.Text = "";
                    textBoxTelefone.Text = "";
                    flag = true;
                }



            }
            if (!flag)
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
