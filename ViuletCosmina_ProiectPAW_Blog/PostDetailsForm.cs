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
using ViuletCosmina_ProiectPAW_Blog.Extensions;
using ViuletCosmina_ProiectPAW_Blog.Repositories;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class PostDetailsForm : Form
    {
        private Guid _postId;
        private ICommentRepository _commRepository;
        private IPostRepository _postRepository;
        public PostDetailsForm(Guid Id)
        {
            InitializeComponent();
            this.CenterToScreen();
            _postId = Id;
            _commRepository = new CommentRepository();
            _postRepository = new PostRepository();
            commentsDataGrid.AutoGenerateColumns = false;

            var post = _postRepository.GetById(_postId);
            postTitle.Text = post.Titlu;
            commentsDataGrid.AddColumn(0, "Text", "Text")
                            .AddButtonColumn(string.Empty, "editColumn", "Edit")
                            .AddButtonColumn(string.Empty, "deleteColumn", "Delete");

            commentsDataGrid.DataSource = _commRepository.getCommentsForPost(_postId);
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            var addComment = new AddCommentForm(_postId);
            addComment.ShowDialog();
            var data = _commRepository.getCommentsForPost(_postId);
            commentsDataGrid.RefreshDataSource<Comentariu>(data);
        }

        private void commentsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;
            if(e.ColumnIndex == commentsDataGrid.Columns["editColumn"].Index)
            {
                var comment = (Comentariu)commentsDataGrid.CurrentRow.DataBoundItem;
                var editCommentForm = new EditCommentForm(comment.Id);
                editCommentForm.ShowDialog();
                var data = _commRepository.getCommentsForPost(_postId);
                commentsDataGrid.RefreshDataSource(data).Update();
            }
            if(e.ColumnIndex == commentsDataGrid.Columns["deleteColumn"].Index)
            {
                var comment = (Comentariu)commentsDataGrid.CurrentRow.DataBoundItem;
                _commRepository.Remove(comment);
                var data = _commRepository.getCommentsForPost(_postId);
                commentsDataGrid.RefreshDataSource(data).Update();
            }
        }
    }
}
