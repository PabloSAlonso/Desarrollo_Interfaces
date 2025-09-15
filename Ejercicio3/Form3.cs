using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
         

        int saldo = 50;
        Random rndm = new Random();
        public (int, int, int) Aleatorios (int minimo, int maximo)
        {   
            
            return (rndm.Next(minimo, maximo + 1), rndm.Next(minimo, maximo + 1), rndm.Next(minimo, maximo + 1));
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            var aleatorio = Aleatorios(1, 7);
            saldo -= 2;
            int premio;
            int n1 = aleatorio.Item1;
            int n2 = aleatorio.Item2;
            int n3 = aleatorio.Item3;
            num1.Text = n1.ToString();
            num2.Text = n2.ToString();
            num3.Text = n3.ToString();
            if (n1 == n2 && n1 == n3)
            {
                premio = 20;
                lblPremio.Text = "El premio es de: " + premio.ToString();
                saldo += premio;
                numSaldo.Text = saldo.ToString();
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                premio = 5;
                lblPremio.Text = "El premio es de: " + premio.ToString();
                saldo += premio;
                numSaldo.Text = saldo.ToString();
            }
            else
            {
                premio = 0;
                lblPremio.Text = "El premio es de: " + premio.ToString();
                numSaldo.Text = saldo.ToString();
            }
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            saldo += 10;
            numSaldo.Text = saldo.ToString();
        }

        private void numSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
