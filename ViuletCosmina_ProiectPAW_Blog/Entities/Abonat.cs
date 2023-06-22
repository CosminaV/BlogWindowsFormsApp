using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViuletCosmina_ProiectPAW_Blog.Entities
{
    [Serializable]
    public class Abonat
    {
        private string username;
        private string email;
        private string password;
        private int anAbonare;

        public Abonat()
        {
            username = "anonim";
            email = "necunoscut";
            password = "";
            anAbonare = 0;
        }

        public Abonat(string user, string em, string pswd, int anA)
        {
            this.username = user;
            this.email = em;
            this.password = pswd;
            this.anAbonare = anA;
        }

        public Abonat(string user, string em, string pswd)
        {
            this.username = user;
            this.email = em;
            this.password = pswd;
        }
        public string Username
        {
            get { return username; }
            set { if (value != null && value.Length > 0)
                    username = value;
                }
        }
        public string Email
        {
            get { return email; }
            set { if (value != null & value.Length > 0) email=value; }
        }
        public string Password
        {
            get { return password; }
            set { if (value != null & value.Length > 0) password=value; }
        }

        public int AnAbonare
        {
            get { return anAbonare; }
            set { anAbonare = value; }
        }
    }
}
