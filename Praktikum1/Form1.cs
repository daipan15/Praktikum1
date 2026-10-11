using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Khaki, 100, 150, 200, 150);                 
            g.FillPolygon(Brushes.Firebrick, new Point[] {
        new Point(80,150), new Point(200,60), new Point(320,150) });   
            g.FillRectangle(Brushes.SaddleBrown, 180, 220, 40, 80);             
            g.DrawRectangle(Pens.Black, 120, 180, 40, 40);                      
            g.DrawString("Rumah Sederhana", new Font("Arial", 12),
                Brushes.Black, 120, 320);                                        
        }
    }
}
