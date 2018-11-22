using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        Conta[] contas = new Conta[20];
        int conta = 20;
        int conta2 = 20;
        int qtd = 0;

        public void AddConta (Conta conta)
        {
            conta.Numero = qtd+1;
            contas[qtd]=conta;
            comboBox1.Items.Add(contas[qtd].Titular);
            comboBox2.Items.Add(contas[qtd].Titular);
            MessageBox.Show("Conta criada com sucesso! Número da conta: " + conta.Numero);

            qtd++;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas[0] = new Conta();
            this.contas[0].Titular = "Bruce Wayne";
            this.contas[0].Saldo = 140000000000;
            this.contas[0].Numero = 1;
            qtd++;
            this.contas[1] = new Conta();
            this.contas[1].Titular = "Antony Stark";
            this.contas[1].Saldo = 200000000000;
            this.contas[1].Numero = 2;
            qtd++;
            this.contas[2] = new Conta();
            this.contas[2].Titular = "Howard Stark";
            this.contas[2].Saldo = 20000000;
            this.contas[2].Numero = 3;
            qtd++;
            this.contas[3] = new Conta();
            this.contas[3].Titular = "Pepper Pots Stark";
            this.contas[3].Saldo = 2000000000;
            this.contas[3].Numero = 4;
            qtd++;
            this.contas[4] = new Conta();
            this.contas[4].Titular = "Steve Rogers";
            this.contas[4].Saldo = 5432;
            this.contas[4].Numero = 5;
            qtd++;
            this.contas[5] = new Conta();
            this.contas[5].Titular = "Reed Richards";
            this.contas[5].Saldo = 4560000;
            this.contas[5].Numero = 6;
            qtd++;
            this.contas[6] = new Conta();
            this.contas[6].Titular = "Peter Parker";
            this.contas[6].Saldo = 2;
            this.contas[6].Numero = 7;
            qtd++;
            this.contas[7] = new Conta();
            this.contas[7].Titular = "Natasha Romanoff";
            this.contas[7].Saldo = 200000000000000000;
            this.contas[7].Numero = 8;
            qtd++;
            this.contas[8] = new Conta();
            this.contas[8].Titular = "J. Jonah Jemson Jr";
            this.contas[8].Saldo = 245000000;
            this.contas[8].Numero = 9;
            qtd++;
            this.contas[9] = new Conta();
            this.contas[9].Titular = "Benjamin Parker";
            this.contas[9].Saldo = 0;
            this.contas[9].Numero = 10;
            qtd++;

            for (int i = 0; i < qtd; i++)
            {
                comboBox1.Items.Add(contas[i].Titular);
                comboBox2.Items.Add(contas[i].Titular);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != 0 && textBox4.Text != "")
            {
                int conta = comboBox1.SelectedIndex;
                double valor = Convert.ToDouble(textBox4.Text);
                contas[conta].Saldo = contas[conta].Saldo + valor;
                textBox3.Text = Convert.ToString(contas[conta].Saldo);
                MessageBox.Show("Operação realizada com sucesso! Saldo atual: " + contas[conta].Saldo);
            }
            else
            {
                MessageBox.Show("Favor rever os dados");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0 && textBox4.Text != "")
            {
                int conta = comboBox1.SelectedIndex;
                double valor = Convert.ToDouble(textBox4.Text);

                if (valor > contas[conta].Saldo)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    contas[conta].Saldo = contas[conta].Saldo - valor;
                    textBox3.Text = Convert.ToString(contas[conta].Saldo);
                    MessageBox.Show("Operação realizada com sucesso! Saldo atual: " + contas[conta].Saldo);
                }
            }
            else
            {
                MessageBox.Show("Favor rever os dados");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int conta = Convert.ToInt16(textBox2.Text) - 1;       
                Conta selec = contas[conta];
                textBox1.Text = (selec.Titular);
                textBox2.Text = Convert.ToString(selec.Numero);
                textBox3.Text = Convert.ToString(selec.Saldo);
                comboBox1.SelectedIndex = conta;
            }
            else
            {
                MessageBox.Show("Favor rever os dados");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int conta = comboBox1.SelectedIndex;

            Conta selec = contas[conta];

            textBox1.Text = (selec.Titular);
            textBox2.Text = Convert.ToString(selec.Numero);
            textBox3.Text = Convert.ToString(selec.Saldo);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int conta2 = comboBox2.SelectedIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0 && textBox4.Text != "" && comboBox2.SelectedIndex >= 0)
            {
                int conta = comboBox1.SelectedIndex;
                int conta2 = comboBox2.SelectedIndex;
                double valor = Convert.ToDouble(textBox4.Text);

                if (valor > contas[conta].Saldo)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    contas[conta].Saldo = contas[conta].Saldo - valor;
                    contas[conta2].Saldo = contas[conta2].Saldo + valor;
                    textBox3.Text = Convert.ToString(contas[conta].Saldo);
                    MessageBox.Show("Operação realizada com sucesso! Saldo atual: " + contas[conta].Saldo);
                    MessageBox.Show("Valor transferido: " + valor);
                }
            }
            else
            {
                MessageBox.Show("Favor rever os dados");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2 (this);
            form.ShowDialog();
        }
    }

}

