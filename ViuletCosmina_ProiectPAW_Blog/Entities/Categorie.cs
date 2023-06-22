using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViuletCosmina_ProiectPAW_Blog.Entities
{
    [Serializable]
    public class Categorie 
    {
        public Guid Id { get; set; }
        public bool IsStyle { get; set; }
        public bool IsFood { get; set; }
        public bool IsBeauty { get; set; }
        public string Name
        {
            get
            {
                if (IsStyle == true)
                    return "Style";
                else if (IsFood == true)
                    return "Food";
                else return "Beauty";
            }
            set { }
        }
        public Categorie()
        {
            IsStyle = false;
            IsFood = false;
            IsBeauty = false;
        }
        public Categorie(string categorie)
        {
            if (categorie == "STYLE")
            {
                IsStyle = true;
            }
            else if (categorie == "FOOD")
            {
                IsFood = true;
            }
            else IsBeauty = true;
        }
        
        public object Clone()
        {
            return ((ICloneable)this).Clone();
        }
    }
}
