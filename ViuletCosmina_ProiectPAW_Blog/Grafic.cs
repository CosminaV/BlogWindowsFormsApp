using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViuletCosmina_ProiectPAW_Blog.Database;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class Grafic : Form
    {
        Graphics gr;
        Bitmap bmp;
        int y = 40;
        public Grafic()
        {
            InitializeComponent();
            this.CenterToScreen();
            bmp = new Bitmap(this.Width, this.Height);
            gr = Graphics.FromImage(bmp);
            
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Black, 1);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            gr.DrawRectangle(pen, rec);
            gr.DrawString("Grafic cu cei abonati de minim 3 ani", this.Font, new SolidBrush(Color.DeepPink), 40, 25);
            foreach (var a in FakeDatabase.abonati)
            {
                if (System.DateTime.Now.Year - a.AnAbonare > 3)
                {
                    gr.DrawString(a.ToString(), this.Font, new SolidBrush(Color.Black), 40, y);
                    y += 20;
                }
                if(y>this.Height)
                {
                    y = 10;
                }
            }
            this.Invalidate();
        }

        private void Grafic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
