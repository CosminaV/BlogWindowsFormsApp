using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViuletCosmina_ProiectPAW_Blog.Extensions
{
    public static class DataGridViewExtensions
    {
        public static DataGridView RefreshDataSource<T>(this DataGridView dataGrid, List<T> obiecte)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = obiecte;
            return dataGrid;
        }

        public static DataGridView AddColumn(this DataGridView dataGrid, int index, string headerText, string property)
        {
            dataGrid.ColumnCount++;
            dataGrid.Columns[index].HeaderText = headerText;
            dataGrid.Columns[index].DataPropertyName = property;
            return dataGrid;
        }

        public static DataGridView AddButtonColumn(this DataGridView dataGrid, string headerText, string name, string text)
        {
            DataGridViewButtonColumn newButtonColumn = new DataGridViewButtonColumn();
            newButtonColumn.HeaderText = headerText;
            newButtonColumn.Name = name;
            newButtonColumn.Text = text;
            newButtonColumn.UseColumnTextForButtonValue = true;
            dataGrid.Columns.Add(newButtonColumn);
            return dataGrid;
        }

    }
}
