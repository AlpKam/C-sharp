namespace ListTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(listBox1.Text);
            MessageBox.Show("L�tfen bir k�k se�in");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.Nodes.Add(listBox1.Text);
            else
                MessageBox.Show("L�tfen K�k D���m Se�iniz");


            treeView1.CollapseAll();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
    }
}
