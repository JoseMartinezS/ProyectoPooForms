using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPooForms
{
    class Lobo : Camioneta
    {
        protected string llantas;


        public string Llantas
        {
            get
            {
                return llantas; 
            }
            set
            {
                llantas = value; 
            }
        }

        public Lobo() : base()
        {
            llantas = "Rodada 16";
        }

        public override string ToString()
        {
            return llantas + " " + base.ToString();
        }


    }
}
