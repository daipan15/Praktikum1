using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Praktikum1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; 

            g.Clear(Color.SkyBlue);                                             
            g.FillEllipse(Brushes.Gold, 600, 40, 80, 80);                       
            g.FillEllipse(Brushes.White, 100, 60, 120, 50);                      
            g.FillPolygon(Brushes.SlateGray, new Point[] {
        new Point(0,400), new Point(200,150), new Point(400,400) });    
            g.FillPolygon(Brushes.DarkSlateGray, new Point[] {
        new Point(300,400), new Point(500,200), new Point(700,400) });   
            g.FillRectangle(Brushes.ForestGreen, 0, 380, 800, 220);             
            g.FillRectangle(Brushes.Khaki, 120, 380, 200, 130);                 
            g.FillPolygon(Brushes.Firebrick, new Point[] {
        new Point(100,380), new Point(220,300), new Point(340,380) });  
            g.FillRectangle(Brushes.SaddleBrown, 200, 440, 40, 70);             
            g.FillRectangle(Brushes.LightCyan, 140, 410, 35, 35);               
            g.DrawRectangle(Pens.Black, 140, 410, 35, 35);                      
            g.FillRectangle(Brushes.Sienna, 560, 400, 25, 100);                  
            g.FillEllipse(Brushes.DarkGreen, 520, 330, 105, 90);                
            g.DrawLine(new Pen(Color.Black, 2), 0, 510, 800, 510);              
            g.DrawString("Pemandangan Desa", new Font("Arial", 16, FontStyle.Bold),
                Brushes.White, 20, 20);                                         
        }
    }
}
