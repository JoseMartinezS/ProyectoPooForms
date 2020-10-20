using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPooForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo v;
            v = new Vehiculo();
            v.Modelo = 2002;
            MessageBox.Show(v.ToString());
        }

        private void btnCamioneta_Click(object sender, EventArgs e)
        {
            Camioneta m;
            m = new Camioneta();
            m.Modelo = 2000;
            m.Marca = "Ford";
            MessageBox.Show(m.ToString());
        }

        private void btnCuatrimoto_Click(object sender, EventArgs e)
        {
            Lobo c;
            c = new Lobo();
            c.Modelo = 2019;
            c.Marca = "Ford";
            c.Llantas = "Rodada 16";
            MessageBox.Show(c.ToString());
                
        }
    }
}
