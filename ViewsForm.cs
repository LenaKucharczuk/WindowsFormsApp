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
    public partial class ViewsForm : Form
    {
        public ViewsForm()
        {
            InitializeComponent();
        }
        
        public virtual void refreshOnAdd(Point p)
        { }

        public virtual void refreshOnRemove(Point p)
        { }

        public virtual void refreshOnModify(Point p)
        { }

        protected virtual void PointAdded(object sender, EventArgs args)
        {
            Point p = (Point)sender;
            refreshOnAdd(p);
        }

        protected virtual void refreshOnRemove(object sender, EventArgs args)
        { }

        protected virtual void ModifyPoint(object sender, EventArgs args)
        { }
    }
}
