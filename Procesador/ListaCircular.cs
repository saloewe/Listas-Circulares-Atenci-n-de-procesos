using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesador
{
    class ListaCircular
    {
        public Proceso primero = new Proceso();
        public Proceso ultimo = new Proceso();
        
        public ListaCircular()
        {
            primero = null;
            ultimo = null;
        }

        public void Agregar()
        {
            Proceso nuevo = new Proceso();

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = primero;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;

            }
        }
            public void Eliminar()
        {
            primero = primero.Siguiente;
            ultimo.Siguiente = primero;
        }

        public void Decrecer()
        {
            primero.Contador -= 1;   
        }

        public void Rotar()
        {
            Proceso temp = primero;
            primero = primero.Siguiente;
            temp.Siguiente = primero;
            ultimo.Siguiente = temp;
            ultimo = temp;
        }


        public string Prendientes()
        {
            Proceso actual = primero;
            int ciclo=0;
            int proceso = 0;
            while (actual.Siguiente != primero)
            {
                ciclo += actual.Contador;
                proceso++;
                actual = actual.Siguiente;
            }
          
            return " Pendientes: "+proceso+ " ciclos necesarios "+ ciclo;
        }
    }
}
