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
        int i = 0;
        private List<Point> points;

        public ViewTree(List<Point> points, MainDocument observer) : base(observer)
        {
            InitializeComponent();

            this.points = points;

            observer.PointRemoved += refreshOnRemove;
            observer.PointAdded += PointAdded;
            observer.PointChanged += ModifyPoint;

            initializeTree();
        }

        private void addNode(int i, Point p)
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
        }

        private void initializeTree()
        {
            foreach (Point p in points)
            {
                addNode(i, p);
                treeView.Nodes[0].Nodes[i].Tag = p;
                ++i;
            }
        }

        protected override void toolNewPoint_Click(object sender, EventArgs e)
        {
           new AddNewPoint(observer, null).ShowDialog();
        }

        protected override void refreshOnAdd(Point p)
        {
            i = treeView.Nodes[0].Nodes.Count;
            
            addNode(i, p);
            treeView.Nodes[0].Nodes[i].Tag = p;
            ++i;
        }

        private void ViewTree_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(toolStrip1, observer.toolStrip1);
            observer.StatusString(points.Count);
        }

        private void ViewTree_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(observer.toolStrip1);
        }
        
        private void DeleteButtonTree_Click(object sender, EventArgs e)
        {
            TreeNode item = treeView.SelectedNode;
            if (item.Tag != null)
            {
                observer.RemovePoint((Point)item.Tag);
            }
        }

        protected override void refreshOnRemove(object sender, EventArgs args)
        {
            Point p = (Point)sender;

            for (int i = 0; i < treeView.Nodes[0].Nodes.Count; ++i)
            {
                TreeNode node = treeView.Nodes[0].Nodes[i];
                if (node.Tag.Equals(p))
                {
                    node.Remove();
                }
            }
        }

        private void ModifyButtonTree_Click(object sender, EventArgs e)
        {
            TreeNode item = treeView.SelectedNode;
            if (item.Tag != null)
            {
                AddNewPoint mp = new AddNewPoint(observer, (Point)item.Tag);
                mp.ShowDialog();
            }
        }

        protected override void ModifyPoint(object sender, EventArgs args)
        {
            List<Point> pair = (List<Point>)sender;
            Point oldPoint = pair[0];
            Point newPoint = pair[1];

            for (int i = 0; i < treeView.Nodes[0].Nodes.Count; ++i)
            {
                TreeNode node = treeView.Nodes[0].Nodes[i];
                if (node.Tag.Equals(oldPoint))
                {
                    int index = node.Index;
                    int id = index + 1;

                    treeView.Nodes[0].Nodes[index].Nodes[0].Nodes[0].Text = Convert.ToString(newPoint.getX());
                    treeView.Nodes[0].Nodes[index].Nodes[1].Nodes[0].Text = Convert.ToString(newPoint.getY());
                    treeView.Nodes[0].Nodes[index].Nodes[2].Nodes[0].Text = Convert.ToString(newPoint.getC());

                    break;
                }
            }
        }
    }
}
