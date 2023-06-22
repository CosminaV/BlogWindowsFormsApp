using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViuletCosmina_ProiectPAW_Blog.Database;
using ViuletCosmina_ProiectPAW_Blog.Entities;

namespace ViuletCosmina_ProiectPAW_Blog.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Add(Categorie category)
        {
            FakeDatabase.categorii.Add(category);
        }

        public List<Categorie> getAllCategories()
        {
            return FakeDatabase.categorii;
        }

        public Categorie getById(Guid categoryId)
        {
            return FakeDatabase.categorii.FirstOrDefault(x => x.Id == categoryId);
        }
    }
}
