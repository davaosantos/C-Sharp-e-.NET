namespace HelloWorldForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "vitor";
            string msg = "Olá " + nome;
            MessageBox.Show("valor final: " + msg);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 18;
            int idadeFernanda = 23;
            int media = (idadeJoao + idadeFernanda + idadeMaria) / 3;

            double pi = 3.14;

            int piQuebrado = (int)pi;

            MessageBox.Show("Média: " + media);
            MessageBox.Show("pi: " + piQuebrado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 50.0;

            bool podeSacar = (saldo >= valorSaque);

            if(saldo >= valorSaque)
            {
                saldo = saldo - valorSaque;
                MessageBox.Show("Saque realizado com sucesso. Saldo atual: " + saldo);
            }
            else
            {
                MessageBox.Show("Saque não realizado. Saldo atual: " + saldo + podeSacar);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta c =  new Conta(); // Cria uma instancia conta
            c.numero = 1;
            c.titular = "Victor";
            c.saldo = 100;

            c.saldo -= 200;

            MessageBox.Show("Valor final = " + c.saldo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();

            //Inicializa informações da conta
            c.saldo = 100.0;

            //Chama metodo Saca que foi definido
            c.Saca(10.0);
        }
    }
}

public class Conta
{
    public int numero;
    public string titular;
    public double saldo;

    public void Saca(double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
        }
    }
}