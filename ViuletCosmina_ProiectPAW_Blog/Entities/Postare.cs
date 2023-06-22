using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViuletCosmina_ProiectPAW_Blog.Entities
{
    [Serializable]
    public class Postare : Categorie, ICloneable, IComparable
    {
        public Guid Id { get; set; }
        public string Categorie
        {
            get
            {
                if (IsBeauty == true)
                {
                    return "BEAUTY";
                }
                else if (IsFood == true)
                {
                    return "FOOD";
                }
                else return "STYLE";
            }
            set { }
        }
        public string Titlu { get; set; }
        public string Text { get; set; }
        public int nrVizualizari { get; set; }

        public int nrComentarii { get; set; }

        public Guid categoryId { get; set; }
        public Postare():base()
        {
            Id = Guid.Empty;
            Categorie = "necunoscuta";
            Titlu = "necunoscut";
            Text = "necunoscut";
            nrVizualizari = 0;
            nrComentarii = 0;
        }

        public Postare(string categorie, string titlu, string text, int nrV, int nrC):base(categorie)
        {
            this.Titlu = titlu;
            this.Text = text;
            this.nrComentarii = nrC;
            this.nrVizualizari = nrV;
        }
        public override string ToString()
        {
            return $"Id: {Id}\n" +
                $"Categorie: {Categorie}\n" +
                $"Titlu: {Titlu}\n\n" +
                $"Text: {Text}\n" +
                $"Numar vizualizari: {nrVizualizari}\n" +
                $"Numar comentarii: {nrComentarii}";
        }


        public static Postare operator+(Postare p1, Postare p2)
        {
            Postare p = new Postare();
            p.nrVizualizari = p1.nrVizualizari + p2.nrVizualizari;
            return p;
        }

        public static Postare operator++(Postare p)
        {
            return p++;
        }
        
        public static explicit operator int(Postare p)
        {
            return p.nrVizualizari;
        }
        public object Clone()
        {
            return ((ICloneable)this).Clone();
        }

        public int CompareTo(object obj)
        {
            return nrComentarii.CompareTo(obj);
        }
    }
    
}
