using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViuletCosmina_ProiectPAW_Blog.Entities;

namespace ViuletCosmina_ProiectPAW_Blog.Repositories
{
    public interface ICommentRepository
    {
        void Add(Comentariu comment);
        List<Comentariu> getCommentsForPost(Guid postareId);
        Comentariu getById(Guid commentId);
        void Remove(Comentariu comment);

    }
}
