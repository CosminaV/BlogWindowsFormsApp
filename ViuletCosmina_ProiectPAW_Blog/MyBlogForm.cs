using System;
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
    public partial class MyBlogForm : Form
    {
        
        public MyBlogForm()
        {
            InitializeComponent();
           
        }

        private void schimbaCuloareaFundaluluiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }
        }

        private void CategoriiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoriiComboBox.Text == "STYLE" || CategoriiComboBox.Text == "FOOD" || CategoriiComboBox.Text == "BEAUTY")
            {
                string currentObject = CategoriiComboBox.Text;
                var postareForm = new PostareForm(currentObject);
                postareForm.Size = new Size(900, 650);
                postareForm.ShowDialog();
            }
        }

        //private void CategoriiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (CategoriiComboBox.Text=="STYLE")
        //    {
        //        var styleForm = new StylePostsForm();
        //        styleForm.Show();
        //    }
        //    else if (CategoriiComboBox.Text=="FOOD")
        //    {
        //        var foodForm = new FoodPostsForm();
        //        foodForm.Show();
        //    }
        //    else if (CategoriiComboBox.Text=="BEAUTY")
        //    {
        //        var beautyForm = new PostsForm();
        //        beautyForm.Show();
        //    }
        //}
    }
}
