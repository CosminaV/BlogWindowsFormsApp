using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViuletCosmina_ProiectPAW_Blog.Entities
{
    [Serializable]
    public class Comentariu
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public string Text { get; set; }
    }
}
