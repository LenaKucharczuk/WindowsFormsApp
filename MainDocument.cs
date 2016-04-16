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

        private List<ViewsForm> forms;
        private List<Point> points;
        public event EventHandler PointAdded;
        public event EventHandler PointRemoved;
        public event EventHandler PointChanged;

        public MainDocument(List<Point> points)
        {
            InitializeComponent();

            this.points = points;

            forms = new List<ViewsForm>();
            ViewsForm tree = new ViewTree(points, this);
            ViewsForm list = new ViewList(points, this);
            forms.Add(tree);
            forms.Add(list);

            foreach (Form f in forms)
            {
                f.MdiParent = this;
                f.Show();
            }
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
        
    }
}
