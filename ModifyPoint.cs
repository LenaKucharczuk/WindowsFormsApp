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
    public partial class ModifyPoint : AddNewPoint
    {
        Point oldPoint;
        public ModifyPoint(MainDocument observer, Point oldPoint)
            : base(observer)
        {
            InitializeComponent();
            String[] s =  new String [] { oldPoint.getX() + "", oldPoint.getY() + "", oldPoint.getC() + "" };
            this.textBox1.Text = s[0];
            this.textBox2.Text = s[1];
            this.textBox3.Text = s[2];

            this.oldPoint = oldPoint;
        }

        protected override void OK_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(this.textBox1.Text);
            int y = Convert.ToInt32(this.textBox2.Text);
            int c = Convert.ToInt32(this.textBox3.Text);

            newPoint = new Point(x, y, c);
            observer.modifyPoint(oldPoint, newPoint);

            this.Close();
        }
    }
}
