using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEventos
{
    public partial class frmGerenciadorLatidos : Form
    {
        private GerenciadorLatidos _gerenciadorLatidos;
        public frmGerenciadorLatidos()
        {
            InitializeComponent();
            _gerenciadorLatidos = new GerenciadorLatidos();

            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) =>
            {
                ExcessoDecibeisEventArgs eventArgs = (ExcessoDecibeisEventArgs)args;
                MessageBox.Show(string.Format("O cachorro passou do limites, com {0} decibéis", eventArgs.IntensidadeLatido), "Exceso de decobéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            };
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) =>
            {
                MessageBox.Show("O cachorro passou do limites novamente.", "Exceso de decobéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }
        private void frmGerenciadorLatidos_Load(object sender, EventArgs e)
        {
            pgbIntensidadeLatido.Value = 0;
        }

        private void btnLatir_Click(object sender, EventArgs e)
        {
            pgbIntensidadeLatido.Value = _gerenciadorLatidos.Latir();
        }
    }
}
