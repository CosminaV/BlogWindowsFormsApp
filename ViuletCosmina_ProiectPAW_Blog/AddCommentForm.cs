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
using ViuletCosmina_ProiectPAW_Blog.Repositories;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class AddCommentForm : Form
    {
        private ICommentRepository _commentRepository;
        private Guid _postId;
        public AddCommentForm(Guid Id)
        {
            InitializeComponent();
            _commentRepository = new CommentRepository();
            _postId = Id;
        }

        private void SaveCommentButton_Click(object sender, EventArgs e)
        {
            var comment = new Comentariu();
            comment.PostId = _postId;
            comment.Text = addCommentDescriptionTextBox.Text;
            if (comment.Text == "")
            {
                MessageBox.Show("Nu ai scris nimic!");
            }
            else
            {
                _commentRepository.Add(comment);
                this.Hide();
            }
            
        }
    }
}
