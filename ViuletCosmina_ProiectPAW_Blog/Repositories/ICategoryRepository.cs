using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViuletCosmina_ProiectPAW_Blog.Entities;

namespace ViuletCosmina_ProiectPAW_Blog.Repositories
{
    public interface ICategoryRepository
    {
        void Add(Categorie category);
        List<Categorie> getAllCategories();
        Categorie getById(Guid categoryId);
    }
}
