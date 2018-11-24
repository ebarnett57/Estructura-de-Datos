using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolAscendencia
{
    public partial class Form1 : Form
    {
        int generaciones = 0;
        int contador = 0;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            Generar();
            treeView1.ExpandAll();
            

        }

        private void Generar()
        {
            treeView1.Nodes.Add("Edgar Barnett");
            generaciones = Convert.ToInt16(txtGeneraciones.Text);
            
            //Manda llamar funcion
            CrearArbol(treeView1.Nodes[0],contador,generaciones);
        }

        private void CrearArbol(TreeNode node, int contador,int generaciones)
        {
            contador++;
            node.Nodes.Add("node" + contador);

            if (contador < generaciones)
            {
                CrearArbol(node.Nodes[0], contador, generaciones);
            }


            //se brinca al siguiente subhijo de la raiz
            node.Nodes.Add("node" + contador);
            if (contador < generaciones)
            {
                CrearArbol(node.Nodes[1], contador, generaciones);
            }
            return;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
    }
}
