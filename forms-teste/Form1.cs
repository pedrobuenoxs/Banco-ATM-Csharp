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

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            Cliente Pedro = new Cliente();
            Pedro.nomeTitular = "Pedro Henrique Bueno Xavier e Silva";
            Pedro.cpf = "064.396.991-80";
            Pedro.rg = "63.396.991-6";
            c.titular = Pedro;

            MessageBox.Show(c.titular.nomeTitular);

            c.addIdConta(1);
            c.Despositar(100);


            MessageBox.Show("seu saldo é: " + c.saldoAtual());
            
            /* Classes criadas até entao:
             * Conta - já com metodos de saque, deposito, mostrar o salto etcc
             * Cliente - necessário criar os metodos dentro dessa classe
             *
             */


                   

        }
    }
}