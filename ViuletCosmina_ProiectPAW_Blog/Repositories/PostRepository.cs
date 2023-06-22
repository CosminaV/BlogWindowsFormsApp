using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViuletCosmina_ProiectPAW_Blog.Database;
using ViuletCosmina_ProiectPAW_Blog.Entities;

namespace ViuletCosmina_ProiectPAW_Blog.Repositories
{
    public class PostRepository : IPostRepository
    {
        public void AddPost(Postare postare)
        {
            postare.Id = Guid.NewGuid();
            FakeDatabase.postari.Add(postare);
        }

        public void DeletePost(Postare postare)
        {
            FakeDatabase.postari.Remove(postare);
        }

        public List<Postare> getAll(Guid categoryId)
        {
            return FakeDatabase.postari.Where(x => x.categoryId == categoryId).ToList();
        }

        public Postare GetById(Guid id)
        {
            return FakeDatabase.postari.FirstOrDefault(x => x.Id == id);
        }
    }
}
