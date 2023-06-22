using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViuletCosmina_ProiectPAW_Blog.Entities;

namespace ViuletCosmina_ProiectPAW_Blog.Repositories
{
    public interface IPostRepository
    {
        List<Postare> getAll(Guid id);
        void AddPost(Postare postare);
        void DeletePost(Postare postare);

        Postare GetById(Guid id);
    }
}
