using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesador
{
    class Proceso
    {
        static public Random rd = new Random();
        private int _contador;
        private Proceso _sig;

        public int Contador
        {
            get { return _contador; }
            set { _contador = value; }
        }

        public Proceso Siguiente
        {
            get { return _sig; }
            set { _sig = value; }
        }

        public Proceso()
        {
            _contador = rd.Next(4, 15);
            _sig = null;
        }
    }
}
