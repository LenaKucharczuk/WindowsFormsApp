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
        int id = 1;
        private List<Point> points;

        public ViewList(List<Point> points, MainDocument observer) : base(observer)
        {
            InitializeComponent();

            this.points = points;
            observer.PointRemoved += refreshOnRemove;
            observer.PointAdded += PointAdded;
            observer.PointChanged += ModifyPoint;
            initializeList();
        }

        private void initializeList()
        {
            foreach (Point p in points) 
            {                
                ListViewItem item = new ListViewItem(new String[] { id++ + "", p.getX() + "", p.getY() + "", p.getC() + "" });
                item.Tag = p;
                listView.Items.Add(item);
            }
        }

        protected override void toolNewPoint_Click(object sender, EventArgs e)
        {
            new AddNewPoint(observer, null).Show();
        }

        protected override void refreshOnAdd(Point p)
        {
            ListViewItem item = new ListViewItem(new String[] { id++ + "", p.getX() + "", p.getY() + "", p.getC() + "" });
            item.Tag = p; 
            listView.Items.Add(item);
        }

        private void ModifyButtonList_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView.SelectedItems[0];
            AddNewPoint mp = new AddNewPoint(observer, (Point)item.Tag);
            mp.Show();
        }

        protected override void ModifyPoint(object sender, EventArgs args)
        {
            List<Point> pair = (List<Point>)sender;
            Point oldPoint = pair[0];
            Point newPoint = pair[1];

            foreach (ListViewItem item in listView.Items)
            {
                if (item.Tag.Equals(oldPoint))
                {
                    int index = item.Index;
                    int id = index + 1;
                    
                    item.SubItems[1].Text = Convert.ToString(newPoint.getX());
                    item.SubItems[2].Text = Convert.ToString(newPoint.getY());
                    item.SubItems[3].Text = Convert.ToString(newPoint.getC());
                }
            }
        }
        
        private void DeleteButtonList_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.SelectedItems)
            {
                observer.RemovePoint((Point)item.Tag);
            }
        }

        protected override void refreshOnRemove(object sender, EventArgs args)
        {
            Point p = (Point)sender;
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Tag.Equals(p))
                {
                    listView.Items.Remove(item);
                }
            }
        }

        private void ViewList_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(toolStripList, observer.toolStrip1); // pasek w glownym, pasek w widoku
            observer.StatusString(points.Count);
        }

        private void ViewList_Deactivate(object sender, EventArgs e)
        {//revert merge
            ToolStripManager.RevertMerge(observer.toolStrip1);
        }

        
    }
}
