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
    public partial class Form6 : Form
    {
        public LinkedList<Usuario> usr_registrados = new LinkedList<Usuario>();
        String nome;
        String email;

        public Form6(LinkedList<Usuario> usr_registrados, String nome, String email)
        {
            this.nome = nome;
            this.email = email;
            this.usr_registrados = usr_registrados;
            InitializeComponent();
            this.textBoxNome.Text = nome;
            this.textBoxEmail.Text = email;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            bool flag = false;

            for (int i = 0; i < this.usr_registrados.Count; i++)
            {
                Usuario user = this.usr_registrados.ElementAt(i);
                if (user.Nome.Equals(textBoxNome.Text) && user.Email.Equals(textBoxEmail.Text))
                {
                    usr_registrados.Remove(user);
                    flag = true;
                    MessageBox.Show("Usuário Removido com sucesso.");
                    textBoxNome.Text = "";
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
