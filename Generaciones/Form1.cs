using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generaciones
{
    public partial class Form1 : Form
    {
        double inicio = 1;
        double contadorActual = 0;
        double sumaFinal = 0;

        public Form1()
        {

            InitializeComponent();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for (double i = 0; i < Convert.ToInt16(txtGeneraciones.Text); i++)
            {
                contadorActual = inicio * 2;
                sumaFinal += contadorActual;
                inicio = contadorActual;

                //count++;
                MessageBox.Show("Actual: " + contadorActual.ToString());
            }
            
            MessageBox.Show("Suma Final: " + sumaFinal.ToString());


        }
    }
}
