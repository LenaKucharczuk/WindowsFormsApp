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
    public partial class ViewList : ViewsForm
    {
        static int id = 1;
        private List<Point> points;
        private MainDocument observer;

        public ViewList(List<Point> points, MainDocument observer)
        {
            InitializeComponent();

            this.points = points;
            this.observer = observer;
            observer.PointRemoved += RemovePoint;
            observer.PointAdded += PointAdded;
            initializeList();
        }

        public override void refreshOnAdd(Point p)
        {
            points.Add(p);
            ListViewItem item = new ListViewItem(new String[] { id++ + "", p.getX() + "", p.getY() + "", p.getC() + "" });
            listView.Items.Add(item);
        }

        private void initializeList()
        {
            foreach (Point p in points) 
            {                
                ListViewItem item = new ListViewItem(new String[] { id++ + "", p.getX() + "", p.getY() + "", p.getC() + "" });
                listView.Items.Add(item);
            }
        }

        private void toolNewPoint_Click(object sender, EventArgs e)
        {
            new AddNewPoint(observer).Show();
        }

        private void ViewList_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(toolStripList, observer.toolStrip1); // pasek w glownym, pasek w widoku

        }

        private void ViewList_Deactivate(object sender, EventArgs e)
        {//revert merge
            ToolStripManager.RevertMerge(observer.toolStrip1);
        }
    }
}
