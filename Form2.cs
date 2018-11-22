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
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2 (Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;

            Conta conta = new Conta();
            conta.Titular = nome;
     
            form1.AddConta(conta);

            Dispose();
        }
    }
}
