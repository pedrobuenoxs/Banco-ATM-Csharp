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
            titular.Cadastrar("Pedro", "06439699180");


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
            Conta conta = new Conta();
            conta.Depositar(100);
            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            double valor = Convert.ToDouble(textBoxValor.Text);

            if (login == "a" && passwd == "a")
            {
                conta.Depositar(valor);
                MessageBox.Show("Saldo:" + conta.getSaldo());               

            }
            else
            {
                MessageBox.Show("Não autorizado!");
            }
            
           

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

        private void buttonClick_Login(object sender, EventArgs e)
        {
            

            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            string cpf = textBoxCpf.Text;                        

            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.titular = cliente; //titular é do tipo cliente por isso aceita o novo cliente da classe cliente

            /*
            * Preciso verificar dois pontos:
            * 1 - A conta já existe?
            *      Se sim, basta nome e senha para logar. VERIFICAR PELO CPF!!!
                   Se não, o usuário precisa cadastrar o CPF em conjunto para prosseguir.
            *      
            * 2 - É uma nova conta?
            *      Precisamos criar: 

            */
            conta.setID(login); //SQL deve ter um metodo para me dar o id de um cadastro novo
            conta.setSenha(passwd);
            conta.titular.Cadastrar(login, cpf); 

            //Em sequênciar conectar-se ao data base para poder fazer as operações


            



            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}