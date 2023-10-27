using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                // obter BASE e ALTURA dos textboxes
                double n1, n2;
                n1 = double.Parse(txtBase.Text);
                n2 = double.Parse(txtAltura.Text);

                // Obter AREA através da conta (base * altura)/2
                txtResultado.Text = (n1 * n2 / 2).ToString();
            }
            catch
            {
                //Limpar os dados
                MessageBox.Show("Dados Inválidos informados!");
                txtResultado.Clear();
                txtAltura.Clear();
                txtBase.Clear();
            }
        }
    }
}
