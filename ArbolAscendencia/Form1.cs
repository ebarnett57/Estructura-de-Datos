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

        TreeNode treeNode = new TreeNode();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            Generar();
        }

        private void Generar()
        {
            treeView1.Nodes.Add("Edgar Barnett");



            treeView1.ExpandAll();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
    }
}
