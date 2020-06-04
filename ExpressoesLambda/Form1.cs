using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressoesLambda
{
    public partial class frmLambda : Form
    {
        public frmLambda()
        {
            InitializeComponent();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            //Expressão lambda utilizada com delegate do tipo Func
            Func<string, string, string> concatenador = (s1, s2) =>
            {
                return s1 + " " + s2 + " é isso aí!";
            };
            //txbResultado.Text = concatenador(txbTexto1.Text, txbTexto2.Text);

            //Expressão lambda utilizada com delegate do tipo Action
            Action<string> escritor = (s1) =>
            {
                txbResultado.Text = s1;
            };
            escritor(concatenador(txbTexto1.Text, txbTexto2.Text));
            
        }
    }
}
