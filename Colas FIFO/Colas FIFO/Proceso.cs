using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO
{
    class Proceso
    {
        public Proceso siguente { get; set; }
        static Random miRandom = new Random();
        private int _ciclosProceso;
        public int ciclosProceso { get { return _ciclosProceso; } }

        public Proceso()
        {
            _ciclosProceso = miRandom.Next(4, 15);
            siguente = null;
        }

        public int ciclosRestantes()
        {
            _ciclosProceso--;
            return _ciclosProceso;
        }

        public override string ToString()
        {
            return "Ciclos necesarios: " + _ciclosProceso + Environment.NewLine;
        }
    }
}
