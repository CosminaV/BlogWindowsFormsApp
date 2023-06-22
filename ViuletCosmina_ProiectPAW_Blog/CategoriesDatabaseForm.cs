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
using ViuletCosmina_ProiectPAW_Blog.Entities;
using ViuletCosmina_ProiectPAW_Blog.Extensions;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class CategoriesDatabaseForm : Form
    {
        public CategoriesDatabaseForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            categoriesDataGrid.AutoGenerateColumns = false;
            categoriesDataGrid.AddColumn(0, "Category Name", "Name")
                              .AddButtonColumn(string.Empty, "detailsColumn", "View Details");

            categoriesDataGrid.DataSource = FakeDatabase.categorii;
        }

        private void categoriesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;
            if(e.ColumnIndex == categoriesDataGrid.Columns["detailsColumn"].Index)
            {
                var categorie = (Categorie)categoriesDataGrid.CurrentRow.DataBoundItem;
                var detailsCategoryForm = new PostsDatabaseForm(categorie.Id);
                detailsCategoryForm.ShowDialog();
            }
        }

        private void afisAbonatiButton_Click(object sender, EventArgs e)
        {
            ListaAbonatiForm frm = new ListaAbonatiForm();
            frm.ShowDialog();
        }
    }
}
