using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViuletCosmina_ProiectPAW_Blog.Database;
using ViuletCosmina_ProiectPAW_Blog.Entities;

namespace ViuletCosmina_ProiectPAW_Blog.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        public void Add(Comentariu comment)
        {
            comment.Id = Guid.NewGuid();
            FakeDatabase.comentarii.Add(comment);
        }

        public Comentariu getById(Guid commentId)
        {
            return FakeDatabase.comentarii.FirstOrDefault(x => x.Id == commentId);
        }

        public List<Comentariu> getCommentsForPost(Guid postareId)
        {
            return FakeDatabase.comentarii.Where(x => x.PostId == postareId).ToList();
        }

        public void Remove(Comentariu comment)
        {
            FakeDatabase.comentarii.Remove(comment);
        }
    }
}
