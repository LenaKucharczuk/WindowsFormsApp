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
        private MainDocument observer;
        private Point newPoint;

        public Point getPoint()
        {
            return newPoint;
        }

        public AddNewPoint(MainDocument observer)
        {
            InitializeComponent();
            this.observer = observer;
        }
        
        private void OK_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(this.textBox1.Text);
            int y = Convert.ToInt32(this.textBox2.Text);
            int c = Convert.ToInt32(this.textBox3.Text);

            newPoint = new Point(x, y, c);
            observer.addPoint(newPoint); 

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
