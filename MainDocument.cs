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
    public partial class MainDocument : Form
    {
        // lista widoków - implementują interfejs, nie zna ich typu, wywołuje metody dla wszystkich
        // lub zdarzenia: delegat wsk na funkcje, events

        //private List<ViewsForm> forms;
        private List<Point> points;
        public event EventHandler PointAdded;
        public event EventHandler PointRemoved;
        public event EventHandler PointChanged;

        public MainDocument(List<Point> points)
        {
            InitializeComponent();

            this.points = points;

            ViewTree tree = new ViewTree(points, this);
            ViewList list = new ViewList(points, this);
            tree.MdiParent = this;
            tree.Show();
            list.MdiParent = this;
            list.Show();
        }

        public void addPoint(Point p)
        {
            points.Add(p);

            // emituje obslugiwane przez widoki zdarzenie
            if (PointAdded != null)
            {
                PointAdded.Invoke(p, null);
            }
        }

        public void modifyPoint(Point oldPoint, Point newPoint)
        {
            List<Point> pair = new List<Point>();
            pair.Add(oldPoint);
            pair.Add(newPoint);

            foreach (Point p in points)
            {
                if (p.Equals(oldPoint))
                {
                    PointChanged.Invoke(pair, null);
                    p.setC(newPoint.getC());
                    p.setX(newPoint.getX());
                    p.setY(newPoint.getY());
                }
            }
        }

        public void RemovePoint(Point point)
        {
            int counter = 0;
            foreach (Point p in points)
            {
                if (p.Equals(point))
                {
                    PointRemoved.Invoke(point, null);
                    points.RemoveAt(counter);
                    return;
                }
                counter++;
            }
        }        

        private void drzewoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTree tree = new ViewTree(points, this);            
            tree.MdiParent = this;
            tree.Show();
            
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewList list = new ViewList(points, this);
            list.MdiParent = this;
            list.Show();
        }
        
    }
}
