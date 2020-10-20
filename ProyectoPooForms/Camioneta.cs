using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPooForms
{
    class Camioneta : Vehiculo
    {
        protected string marca;

        public string Marca
        {
            get
            { 
                return Marca; 
            }
            set
            { 
                marca = value; 
            }
        }
        public Camioneta() : base()
        {
            marca = "";
        }

        public override string ToString()
        {
            return marca + " " +  base.ToString();
        }
    }
}
