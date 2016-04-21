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
    public partial class AddNewPoint : Form
    {
        protected MainDocument observer;
        protected Point newPoint;
        private Point oldPoint;
        
        public AddNewPoint(MainDocument observer, Point oldPoint)
        {
            InitializeComponent();

            if (oldPoint != null)
            {
                String[] s = new String[] { oldPoint.getX() + "", oldPoint.getY() + "", oldPoint.getC() + "" };
                this.textBoxX.Text = s[0];
                this.textBoxY.Text = s[1];
                this.textBox3.Text = s[2];

                this.oldPoint = oldPoint;
            }

            this.observer = observer;
        }

        public Point getPoint()
        {
            return newPoint;
        }        
        
        protected virtual void OK_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(this.textBoxX.Text);
            int y = Convert.ToInt32(this.textBoxY.Text);
            int c = Convert.ToInt32(this.textBox3.Text);

            newPoint = new Point(x, y, c);

            if(oldPoint != null)
                observer.modifyPoint(oldPoint, newPoint);
            else
                observer.addPoint(newPoint); 

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Dispose();
        }
        
        private void textBoxX_Validating(object sender, CancelEventArgs e)
        {
            int v;
            if (Int32.TryParse(this.textBoxX.Text, out v) != true)
            {
                e.Cancel = true;
                errorX.SetError(textBoxX, "Wpisz liczbę");
            }
        }

        private void textBoxY_Validating(object sender, CancelEventArgs e)
        {
            int v;
            if (Int32.TryParse(this.textBoxY.Text, out v) != true)
            {
                e.Cancel = true;
                errorY.SetError(textBoxY, "Wpisz liczbę");
            }
        }
    }
}
