using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreandoArbol
{
    public partial class Form1 : Form
    {
        int gen = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtGenerar.Text = "1";
            int totalGen = Convert.ToInt16(txtGenerar.Text);
            TreeNode node = treeView1.SelectedNode;

            for (int i = 0; i < totalGen; i++)
            {
                SubNodo(i);
            }

        }

        private void SubNodo(int i)
        {
                TreeNode treeNode = new TreeNode("Edgar Barnett");
                TreeNode node2 = new TreeNode("Madre #" + gen);
                gen++;
                TreeNode node3 = new TreeNode("Padre #" + gen);
                gen++;
                TreeNode[] array = new TreeNode[] { node2, node3 };
                treeNode = new TreeNode("Edgar Barnett", array);
                treeView1.Nodes.Add(treeNode);
            
        
        }

    }
}
