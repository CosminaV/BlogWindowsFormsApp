using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViuletCosmina_ProiectPAW_Blog.Entities;
using ViuletCosmina_ProiectPAW_Blog.Repositories;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class AddPostForm : Form
    {
        ArrayList listaPct;
        bool mouseApasat;
        Graphics context;
        Bitmap img;
       private readonly IPostRepository _postRepository;
        private Guid _categoryId;
        public AddPostForm(Guid id)
        {
            InitializeComponent();
            this.CenterToScreen();
            _postRepository = new PostRepository();
            listaPct = new ArrayList();
            img = new Bitmap(signaturePanel.Width, signaturePanel.Height);
            context = Graphics.FromImage(img);
            hScrollBar1.Visible = false;

            _categoryId = id;
        }

        private void signaturePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listaPct.Add(p);
                mouseApasat = true;
            }
        }
        
        private void signaturePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listaPct.Add(p);
                Pen creion = new Pen(this.ForeColor);
                creion.Width = hScrollBar1.Value;
                if(mouseApasat==true)
                {
                    context.DrawLine(creion, (Point)listaPct[listaPct.Count - 2], (Point)listaPct[listaPct.Count - 1]);
                    signaturePanel.Invalidate();
                }
                
            }
        }

        private void signaturePanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                mouseApasat = false;
            }
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                signaturePanel.ForeColor= dlg.Color;
            }
        }

        private void schimbaGrosimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hScrollBar1.Visible = true;
        }

        //private void AddPostForm_Paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.DrawImage(img, 361, 398);
        //}

        private void salvare(Control c, string denumire)
        {
            Graphics g = c.CreateGraphics();
            Bitmap bmp = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(bmp, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.Width, c.Height));
            bmp.Save(denumire);
            bmp.Dispose();
        }

        private void salvareImagineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvare(signaturePanel, "semnatura.bmp");
            MessageBox.Show("S-a salvat semnatura!");

        }

        private void signaturePanel_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void PostSaveButton_Click(object sender, EventArgs e)
        {
            if (PostTitleTextBox.Text == "")
            {
                errorProvider1.SetError(PostTitleTextBox, "Nu ati introdus titlul postarii!");
            }
            else if (PostTextBox.Text == "")
            {
                errorProvider1.SetError(PostTextBox, "Nu ati introdus descrierea postarii!");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    var post = new Postare();
                    post.Id = Guid.NewGuid();
                    //post.IsStyle = StyleCheckBox.Checked;
                    //post.IsFood = FoodCheckBox.Checked;
                    //post.IsBeauty = BeautyCheckBox.Checked;
                    post.Titlu = PostTitleTextBox.Text;
                    post.Text = PostTextBox.Text;
                    post.categoryId = _categoryId;
                    _postRepository.AddPost(post);
                    MessageBox.Show(post.ToString());
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    PostTitleTextBox.Clear();
                    PostTextBox.Clear();
                    signaturePanel.Dispose();
                }
            }
        }
    }
}
