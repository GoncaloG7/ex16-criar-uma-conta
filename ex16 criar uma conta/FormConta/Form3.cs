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

namespace ex16_criar_uma_conta.FormConta
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = dados.nome;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fechar.fecharForm();
        }
    }
}
