using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViuletCosmina_ProiectPAW_Blog.Repositories;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class EditPostForm : Form
    {
        private readonly Guid _postId;
        private readonly IPostRepository _postRepository;
        public EditPostForm(Guid id)
        {
            InitializeComponent();
            _postId = id;
            _postRepository = new PostRepository();
            var entity = _postRepository.GetById(_postId);
            PostTitleTextBox.Text = entity.Titlu;
            PostTextBox.Text = entity.Text;
        }

        private void EditPostSaveButton_Click(object sender, EventArgs e)
        {
            var post = _postRepository.GetById(_postId);
            post.Titlu = PostTitleTextBox.Text;
            post.Text = PostTextBox.Text;
            this.Hide();
        }
    }
}
