using System.Data.SqlClient;

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
            Conta conta = new Conta();
            Cliente titular = new Cliente();
            conta.titular = titular;
            titular.Cadastrar("Pedro", "06439699180","aa");


            MessageBox.Show("cpf: " + conta.titular.getCpf());
            conta.Depositar(100);
            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            double valor = Convert.ToDouble(textBoxValor.Text);

            if (login == "a" && passwd == "a")
            {
                conta.Sacar(valor); 
                MessageBox.Show("Saldo:" + conta.getSaldo());
                
            }
            else
            {
                MessageBox.Show("Não autorizado!");
            }

        }

        private void buttonClick_Depositar(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            string cpf = textBoxCpf.Text;
            //double valor = Convert.ToDouble(textBoxValor.Text);

            dbConexao dbConexao = new dbConexao();
            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.titular = cliente;

            
            dbGetClienteID dbGetClienteID = new dbGetClienteID(login,passwd);
            MessageBox.Show(dbGetClienteID.msg);



        }

        private void buttonClick_Transferir(object sender, EventArgs e)
        {

            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            string cpf = textBoxCpf.Text;

            



            

            double valor = Convert.ToDouble(textBoxValor.Text);

            

            





            /* Classes criadas até entao:
             * Conta - já com metodos de saque, deposito, mostrar o salto etcc
             * Cliente - necessário criar os metodos dentro dessa classe
             *
             */




        }

        private void buttonClick_Login(object sender, EventArgs e)
        {


            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            string cpf = textBoxCpf.Text;

            dbConexao dbConexao = new dbConexao();
            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.titular = cliente;

            dbCadastro dbCadastro = new dbCadastro(login, passwd, cpf);
            

            

            
            

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

        private void textValor_TextChanged(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            string cpf = textBoxCpf.Text;
            //double valor = textBoxValor.Text;

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}