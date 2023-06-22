using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViuletCosmina_ProiectPAW_Blog.Entities
{
    [Serializable]
    public class AbonatNou: Abonat, ICloneable, IComparable
    {
        private string nume;
        private string prenume;
        private int varsta;
        private string sex;

        public AbonatNou():base()
        {
            nume = "";
            prenume = "";
            varsta = 0;
            sex = "";
        }

        public AbonatNou(string user, string em, string pswd, int an ,string n, string p, int v, string s):base(user,em,pswd,an)
        {
            this.nume = n;
            this.prenume = p;
            this.varsta = v;
            this.sex = s;
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null && value.Length > 0) nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set { if (value != null && value.Length > 0) prenume = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { if (value != null && value.Length > 0) sex = value; }
        }
        
        public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }
        
        public object Clone()
        {
            AbonatNou clona = (AbonatNou)this.MemberwiseClone();
            return clona;
        }

        public override string ToString()
        {
            return nume+" "+prenume+" "+AnAbonare+"\n";
        }

        public int CompareTo(object obj)
        {
            AbonatNou ab = (AbonatNou)(obj);
            if (this.AnAbonare < ab.AnAbonare)
                return -1;
            else if (this.AnAbonare > ab.AnAbonare)
                return 1;
            else return 0;
        }
    }
}
