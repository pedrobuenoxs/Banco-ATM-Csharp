using Microsoft.Data.SqlClient;

namespace forms_teste
{
    public partial class Form1 : Form


    {
        /*
         * PRONTO:
         * 1- LOGIN + CADASTRO NOVO
         * 
         * 
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick_Sacar(object sender, EventArgs e)
        {
            //here is done!
            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            double valor = Convert.ToDouble(textBoxValor.Text);

            //dbGetClienteID dbGetClienteID = new dbGetClienteID(Nome, Senha);
            dbGetClienteID dbGetClienteID = new dbGetClienteID(login, passwd);
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            


            Conta conta = new Conta();
            
            conta.setSaldo(login,passwd);

            
                        
            dbLogin dbLogin = new dbLogin();
            dbLogin.Status(login, passwd);
            

            if (dbLogin.statusLogin && conta.Sacar(valor))

            {
                dbSaque dbSaque = new dbSaque(valor, dbGetClienteID.id);
                MessageBox.Show(dbSaque.msg);
                getContaSaldo getContaSaldo = new getContaSaldo(dbGetClienteID.id);
                frm1.labelSaldo.Text = "R$ " + getContaSaldo.saldo;


            }
            else
            {
                if (dbLogin.statusLogin == false)
                {
                    MessageBox.Show(dbLogin.msg);
                    return;
                }
                else if(!conta.Sacar(valor))
                {
                    MessageBox.Show(conta.statusSaque);
                    return;
                }                
            }







        }

        private void buttonClick_Depositar(object sender, EventArgs e)
        {
            //here is done!
            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            double valor = Convert.ToDouble(textBoxValor.Text);


            Conta conta = new Conta();

            conta.setSaldo(login, passwd);
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            dbGetClienteID dbGetClienteID = new dbGetClienteID(login, passwd);

            dbLogin dbLogin = new dbLogin();
            dbLogin.Status(login, passwd);


            if (dbLogin.statusLogin)

            {
                dbDeposito dbDeposito = new dbDeposito(valor, dbGetClienteID.id);
                MessageBox.Show(dbDeposito.msg);
                getContaSaldo getContaSaldo = new getContaSaldo(dbGetClienteID.id);
                frm1.labelSaldo.Text = "R$ " + getContaSaldo.saldo;


            }
            else
            {
                if (dbLogin.statusLogin == false)
                {
                    MessageBox.Show(dbLogin.msg);
                    return;
                }
                else if (!conta.Sacar(valor))
                {
                    MessageBox.Show(conta.statusSaque);
                    return;
                }
            }



        }

        private void buttonClick_Transferir(object sender, EventArgs e)
        {

            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            double valor = Convert.ToDouble(textBoxValor.Text);
            int idTransf = Convert.ToInt32(textBoxIdTransf.Text);


            dbTransf dbTransf = new dbTransf(login, passwd, idTransf, valor);

            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            dbGetClienteID dbGetClienteID = new dbGetClienteID(login, passwd);
            getContaSaldo getContaSaldo = new getContaSaldo(dbGetClienteID.id);
            frm1.labelSaldo.Text = "R$ " + getContaSaldo.saldo;



        }


        private void buttonClick_Login(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string passwd = textBoxPasswd.Text;
            string cpf = textBoxCpf.Text;
            //definindo as variaveis de entrada de texto do programa

            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.titular = cliente;
                                   
            dbLogin dbLogin = new dbLogin(); //Classe Login instanciada

            dbLogin.Status(login, passwd); //Verificando se esse usuário e senha já estão cadastrados
                       
            verCpf statusCPF = new verCpf(login, cpf); //Classe vercpf instanciada, ela verifica se já existe esse cpf na dba
                                             
            if (dbLogin.statusLogin)
            {
                MessageBox.Show(dbLogin.msg); //True: Logado com sucesso!

            }
            else
            {
                if(cpf == "")
                {
                    MessageBox.Show("Insira o CPF para se cadastrar");
                    return;
                }
                else
                {
                    if(statusCPF.statusCPF)
                    {
                        MessageBox.Show(statusCPF.msg);
                    }
                    else
                    {
                        dbCadastro dbCadastro = new dbCadastro(login, cpf, passwd);                        
                        dbGetClienteID dbGetClienteID = new dbGetClienteID(login,passwd);
                        dbCadastroConta dbCadastroConta = new dbCadastroConta(dbGetClienteID.id);
                        MessageBox.Show(dbCadastro.msg + "\n" + dbCadastroConta.msg);

                    }                   
                }                         
            }
            
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

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}