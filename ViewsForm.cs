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
        protected MainDocument observer;
        public ViewsForm()
        {
            InitializeComponent();
        }

        public ViewsForm(MainDocument observer)
        {
            InitializeComponent();
            this.observer = observer;
        }

        protected virtual void refreshOnAdd(Point p)
        { }

        protected virtual void refreshOnRemove(Point p)
        { }

        protected virtual void refreshOnModify(Point p)
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

        protected virtual void toolNewPoint_Click(object sender, EventArgs e)
        {
            new AddNewPoint(observer).Show();
        }

        private void ViewsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (observer.MdiChildren.Count() == 1)
            {
                e.Cancel = true;
            }
        }
    }
}
