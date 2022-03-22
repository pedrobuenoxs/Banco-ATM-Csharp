namespace forms_teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick_Sacar(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;

            if (login == "PedroHBXS" && passwd == "Bueno")
            {
                MessageBox.Show("Saque realizado!");
            }
            else
            {
                MessageBox.Show("Não autorizado!");
            }

        }

        private void buttonClick_Depositar(object sender, EventArgs e)
        {
            Conta a = new Conta();
            Conta b = new Conta();
            a.Depositar(1000);
            b.Depositar(1000);

            double dinheiro = 280;

            // Falta verificar o login

            if (a.Transferir(dinheiro, b))
            {
                MessageBox.Show("Deu bom!\nConta a:" + a.saldoAtual() + "\nConta b:" + b.saldoAtual());
            }





            /* Classes criadas até entao:
             * Conta - já com metodos de saque, deposito, mostrar o salto etcc
             * Cliente - necessário criar os metodos dentro dessa classe
             *
             */




        }

        private void buttonClick_Transferir(object sender, EventArgs e)
        {
            Conta a = new Conta();
            Conta b = new Conta();
            a.Depositar(1000);
            b.Depositar(1000);

            double dinheiro = 280;

            if (a.Transferir(dinheiro, b))
            {
                MessageBox.Show("Deu bom!\nConta a:" + a.saldoAtual() + "\nConta b:" + b.saldoAtual());
            }





            /* Classes criadas até entao:
             * Conta - já com metodos de saque, deposito, mostrar o salto etcc
             * Cliente - necessário criar os metodos dentro dessa classe
             *
             */




        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
                

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}