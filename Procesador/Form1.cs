using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesador
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaCircular lst = new ListaCircular();
            
            int proba, vacio=0, atendidos=0, pendiente=0, ciclos=0;
            for(int i =0; i<300; i++)
            {
                proba = rd.Next(0, 101);
                if (proba <= 35)
                {
                    lst.Agregar();
                }

                if (lst.primero == null)
                {
                    vacio++;
                }
                else
                {
                    lst.Decrecer();
                    if (lst.primero.Contador == 0)
                    {
                        lst.Eliminar();
                        atendidos++;
                    }
                    lst.Rotar();
                }
            }

            textBox1.Text = "atendidos "+ atendidos + "  vacio"+vacio + lst.Prendientes();
        }
    }
}
