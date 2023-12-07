using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ex16_criar_uma_conta.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ex16_criar_uma_conta.FormConta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            fechar.fecharForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fechar.voltarForm1(this);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == dados.nome || textBox2.Text == dados.gmail && textBox3.Text == pass.word )
            {
                MessageBox.Show("Bem vindo de volta!");
                fechar.abrirForm3(this);
            }
            else
            {
                MessageBox.Show("Password ou Utilizador errados!");
            }
        }
    }
}
