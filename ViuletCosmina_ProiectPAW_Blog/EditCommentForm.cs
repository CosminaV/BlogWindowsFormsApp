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
    public partial class EditCommentForm : Form
    {
        private Guid _commentId;
        private ICommentRepository _commentRepository;
        public EditCommentForm(Guid id)
        {
            InitializeComponent();
            this.CenterToScreen();
            _commentId = id;
            _commentRepository = new CommentRepository();
            var comment = _commentRepository.getById(_commentId);
            addCommentDescriptionTextBox.Text = comment.Text;

        }

        private void SaveCommentButton_Click(object sender, EventArgs e)
        {
            var comment = _commentRepository.getById(_commentId);
            comment.Text = addCommentDescriptionTextBox.Text;
            this.Hide();
        }
    }
}
