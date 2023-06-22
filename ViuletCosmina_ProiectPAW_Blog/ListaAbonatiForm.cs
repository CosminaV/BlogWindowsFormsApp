using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViuletCosmina_ProiectPAW_Blog.Database;
using ViuletCosmina_ProiectPAW_Blog.Entities;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class ListaAbonatiForm : Form
    {
        static int y = 10;
        public ListaAbonatiForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            foreach (AbonatNou a in FakeDatabase.abonati)
            {
                ListViewItem item = new ListViewItem(a.Nume);
                item.SubItems.Add(a.Prenume);
                item.SubItems.Add(a.Email);
                item.SubItems.Add(a.Varsta.ToString());
                item.SubItems.Add(a.Sex);
                AbonatiListView.Items.Add(item);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var graficFrm = new Grafic();
            graficFrm.ShowDialog();
        }


        private void AbonatiListView_ItemActivate(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in AbonatiListView.Items)
            {
                if(itm.Selected)
                {
                    itm.ForeColor = Color.Pink;
                }
            }
        }

        private void AbonatiListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                e.Item.BackColor = Color.Aqua;
            }
        }

        private void AbonatiListView_MouseDown(object sender, MouseEventArgs e)
        {
            AbonatiListView.DoDragDrop(AbonatiListView.SelectedItems, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if((e.KeyState & 8)==8 && (e.AllowedEffect & DragDropEffects.Copy)==DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if((e.AllowedEffect & DragDropEffects.Move)==DragDropEffects.Move)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            Graphics gr = Graphics.FromHwnd(panel1.Handle);
            gr.DrawString(item.Text, this.Font, new SolidBrush(Color.Black), 10, y);
            y += 20;
        }
    }
}
