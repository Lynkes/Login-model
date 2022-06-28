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
    public partial class Form2 : Form
    {
        public LinkedList<Usuario> usr_registrados = new LinkedList<Usuario>();
        Usuario user;

        public Form2(LinkedList<Usuario> usr_registrados)
        {
            this.usr_registrados = usr_registrados;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;

                for (int i = 0; i < this.usr_registrados.Count; i++)
                {
                    Usuario user = this.usr_registrados.ElementAt(i);
                    if (user.Nome.Equals(textBox1.Text))
                    {
                    MessageBox.Show("Nome: " + user.Nome + "\nTelefone: " +
                        user.Telefone+"\nEmail: "+user.Email);
                        buttonEditar.Enabled = true;
                        buttonRemover.Enabled = true;
                        this.user = user;
                        flag = true;
                    }
                    


                }
                if (!flag)
                {
                    MessageBox.Show("Usuário não encontrado.");
                }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Form5 formulario = new Form5(usr_registrados, textBox1.Text);
            formulario.Show();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            Form6 formulario = new Form6(usr_registrados, textBox1.Text, user.Email);
            formulario.Show();
        }
    }
}
