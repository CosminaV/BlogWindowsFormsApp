using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViuletCosmina_ProiectPAW_Blog.Database;
using ViuletCosmina_ProiectPAW_Blog.Entities;
using ViuletCosmina_ProiectPAW_Blog.Extensions;
using ViuletCosmina_ProiectPAW_Blog.Repositories;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class PostsDatabaseForm : Form
    {
        private readonly IPostRepository _postRepository;
        private Guid _categoryId;
        public PostsDatabaseForm(Guid id)
        {
            InitializeComponent();
            this.CenterToScreen();
            _categoryId = id;
            _postRepository = new PostRepository();
            PostsDataGrid.AutoGenerateColumns = false;

            PostsDataGrid.AddColumn(0, "Title (Titlu)", "Titlu")
                        .AddColumn(1, "Text (Text)", "Text")
                        //.AddColumn(2, "Visualization Count (Nr vizualizari)", "nrVizualizari")
                        //.AddColumn(3, "Comment Count (Nr comentarii)", "nrComentarii")
                        .AddButtonColumn(string.Empty, "detailsColumn", "Details")
                        .AddButtonColumn(string.Empty, "editColumn", "Edit")
                        .AddButtonColumn(string.Empty, "deleteColumn", "Delete");
                        
            PostsDataGrid.DataSource = _postRepository.getAll(_categoryId);
            PostsDataGrid.ReadOnly = true;

        }

        private void AddNewPostButton_Click(object sender, EventArgs e)
        {
            var addPostForm = new AddPostForm(_categoryId);
            addPostForm.ShowDialog();
            var data = _postRepository.getAll(_categoryId);
            PostsDataGrid.RefreshDataSource(data).Update();
        }

        private void PostsDataGrid_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if(e.ColumnIndex==PostsDataGrid.Columns["editColumn"].Index)
            {
                var post = PostsDataGrid.CurrentRow.DataBoundItem as Postare;
                var editPostForm = new EditPostForm(post.Id);
                editPostForm.ShowDialog();
                var data = _postRepository.getAll(_categoryId);
                PostsDataGrid.RefreshDataSource(data).Update();
            }
            if(e.ColumnIndex==PostsDataGrid.Columns["deleteColumn"].Index)
            {
                var entity = PostsDataGrid.CurrentRow.DataBoundItem as Postare;
                _postRepository.DeletePost(entity);
                PostsDataGrid.RefreshDataSource(_postRepository.getAll(_categoryId)).Update();
            }
            if(e.ColumnIndex==PostsDataGrid.Columns["detailsColumn"].Index)
            {
                var entity = (Postare)PostsDataGrid.CurrentRow.DataBoundItem;
                var postDetailsForm = new PostDetailsForm(entity.Id);
                postDetailsForm.ShowDialog();
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.dat)|*.dat";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                if(!string.IsNullOrEmpty(dlg.FileName))
                {
                    FileStream fs = new FileStream(dlg.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, FakeDatabase.postari);
                    fs.Close();
                    PostsDataGrid.DataSource = null;
                }
                //else
                //{
                //    FileStream fs = new FileStream(dlg.FileName, FileMode.Append, FileAccess.Write);
                //    BinaryFormatter bf = new BinaryFormatter();
                //    bf.Serialize(fs, FakeDatabase.postari);
                //    fs.Close();
                //}
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.dat)|*.dat";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                FakeDatabase.postari=(List<Postare>)bf.Deserialize(fs);
                foreach(var p in FakeDatabase.postari)
                {
                    p.categoryId = _categoryId;
                }
                fs.Close();
                PostsDataGrid.DataSource = FakeDatabase.postari;
            }
        }
    }
}
