using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form n;
        private void calculator(object sender, EventArgs e)
        {
            aggy.Controls.Clear();
            Form2 caty = new Form2();
            caty.TopLevel = false;
            aggy.Controls.Add(caty);
            caty.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes[0].ExpandAll();
            n = new Form3();
            n.TopLevel = false;
            this.aggy.Controls.Add(n);
            n.Dock = DockStyle.Fill;
                

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            switch(node.Text)
            {
                case "calculator":
                    n.Dispose();

                    n = new Form2();
                    n.TopLevel = false;
                    this.aggy.Controls.Add(n);
                    n.Dock = DockStyle.Fill;
                    n.Show();
                    break;

                case "Room":
                    n.Dispose();

                    n = new Form3();
                    n.TopLevel = false;
                    this.aggy.Controls.Add(n);
                    n.Dock = DockStyle.Fill;
                    n.Show();
                    break;

            }
        }
    }
}
