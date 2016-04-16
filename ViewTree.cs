using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_lab2
{
    public partial class ViewTree : ViewsForm
    {
        static int i = 0;
        private List<Point> points;
        private MainDocument observer;

        public ViewTree(List<Point> points, MainDocument observer)
        {
            InitializeComponent();

            this.points = points;
            this.observer = observer;

            observer.PointRemoved += RemovePoint;
            observer.PointAdded += PointAdded;

            initializeTree();
        }

        public override void refreshOnRemove(Point p)
        {

        }

        public override void refreshOnAdd(Point p)
        {
            points.Add(p);

            treeView.Nodes[0].Nodes.Add("person");
            treeView.Nodes[0].Nodes[i].Nodes.Add("x");
            treeView.Nodes[0].Nodes[i].Nodes.Add("y");
            treeView.Nodes[0].Nodes[i].Nodes.Add("colour");

            TreeNode X = new TreeNode(p.getX() + "");
            treeView.Nodes[0].Nodes[i].Nodes[0].Nodes.Add(X);
            TreeNode Y = new TreeNode(p.getY() + "");
            treeView.Nodes[0].Nodes[i].Nodes[1].Nodes.Add(Y);
            TreeNode C = new TreeNode(p.getC() + "");
            treeView.Nodes[0].Nodes[i].Nodes[2].Nodes.Add(C);
            ++i;
        }

        private void initializeTree()
        {
            foreach (Point p in points)
            {
                treeView.Nodes[0].Nodes.Add("person");
                treeView.Nodes[0].Nodes[i].Nodes.Add("x");
                treeView.Nodes[0].Nodes[i].Nodes.Add("y");
                treeView.Nodes[0].Nodes[i].Nodes.Add("colour");
                
                TreeNode X = new TreeNode(p.getX() + "");
                treeView.Nodes[0].Nodes[i].Nodes[0].Nodes.Add(X);
                TreeNode Y = new TreeNode(p.getY() + "");
                treeView.Nodes[0].Nodes[i].Nodes[1].Nodes.Add(Y);
                TreeNode C = new TreeNode(p.getC() + "");
                treeView.Nodes[0].Nodes[i].Nodes[2].Nodes.Add(C);
                
                ++i;
            }
        }

        private void toolNewPoint_Click(object sender, EventArgs e)
        {
           new AddNewPoint(observer).Show();
        }

        private void ViewTree_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(toolStrip1, observer.toolStrip1);
        }

        private void ViewTree_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(observer.toolStrip1);
        }
    }
}
