using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recorrido_de_Arboles
{
    public partial class Form1 : Form
    {
        int generaciones = 0;
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            GenerarRaiz();
            treeView1.ExpandAll();
        }

        private void GenerarRaiz()
        {
            treeView1.Nodes.Add(txtRaiz.Text);
            //generaciones = Convert.ToInt16(txtRaiz.Text);

            //Manda llamar funcion
            //CrearArbol(treeView1.Nodes[0], contador, generaciones);

            txtRaiz.Enabled = false;
            btnRaiz.Enabled = false;

            cbPadre.Items.Add(treeView1.Nodes[0].Text);
            cbPadre.Text = treeView1.Nodes[0].Text;
        }

        private void CrearArbol(TreeNode node, int contador, int generaciones)
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

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Edgar Barnett");
            generaciones = 3;

            //Manda llamar funcion
            CrearArbol(treeView1.Nodes[0], contador, generaciones);
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btnColapse_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            
        }
    }
}
