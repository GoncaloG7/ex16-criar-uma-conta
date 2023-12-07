using ex16_criar_uma_conta.Classes;

namespace ex16_criar_uma_conta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fechar.fecharForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fechar.voltarForm2(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dados.nome = textBox1.Text;
            dados.gmail = textBox2.Text;
            pass.word = textBox3.Text;
            MessageBox.Show("Criado com sucesso" + "\nNome: " + dados.nome + "\nGmail: " + dados.gmail + "\nPassword: " + pass.word);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fechar.abrirForm3(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
             
        }
    }
}
