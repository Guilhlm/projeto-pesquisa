using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquivo_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string lerarquivo(string endereco)
        {
            string conteudo = "";

            if(File.Exists(endereco))
            {
                using (StreamReader sr = new StreamReader(endereco))
                {
                    conteudo += sr.ReadToEnd();
                }
            }

            return conteudo;
        }


        private void buttonsalvar_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string telefone = textBox2.Text;
            string email = textBox3.Text;

            
            if (rbemail.Checked)
            {
                email = "-";
                
            }
            else if (rbtelefone.Checked)
            {
            
                telefone = "-";
                
            }

            string contato = nome + "|" + telefone + "|" + email;

            string caminho = "C:/Users/guilherme.lmaia/source/repos/c#/aula3 texto/Arquivo texto/dados.txt";

            string textoantigo = lerarquivo(caminho);


            using (StreamWriter sw = new StreamWriter(caminho))
            {
                sw.WriteLine(textoantigo + contato);

            }

            MessageBox.Show("arquivin sarvou paizao");
        }

        private void buttonler_Click(object sender, EventArgs e)
        {
 
            // pesquisar pelos lables



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string caminho = "C:/Users/guilherme.lmaia/source/repos/c#/aula3 texto/Arquivo texto/dados.txt";

            string texto = lerarquivo(caminho);


            Array lista = texto.Split('\n');



            foreach (string pessoa in lista)
            {

                string[] dados = pessoa.Split('|');


                comboBox1.Items.Add(dados[0]);

            }
        }
    }
}
