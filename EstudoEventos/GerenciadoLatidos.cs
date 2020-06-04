using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoEventos
{
    public class GerenciadorLatidos
    {
        private int _IntensidadeLatido;
        public event EventHandler ExcessoDecibeisEvent;

        public GerenciadorLatidos()
        {
            _IntensidadeLatido = 0;
        }
        public int Latir()
        {
            _IntensidadeLatido += 10;
            if (_IntensidadeLatido > 80)
            {
                ExcessoDecibeisEventArgs e = new ExcessoDecibeisEventArgs
                {
                    IntensidadeLatido = _IntensidadeLatido
                };
                OnExcessoDecibeis(e);
            }
            return _IntensidadeLatido;
        }
        protected virtual void OnExcessoDecibeis(EventArgs e)
        {
            if (ExcessoDecibeisEvent != null)
            {
                ExcessoDecibeisEvent(this, e);
            }
        }
    }
}
