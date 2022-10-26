using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibiProject.Entities
{
    public class Bolum
    {
        public int Id { get; set; }
        public string BolumAdi { get; set; }
        public string BolumNumara { get; set; }
        public string BolumSezon { get; set; }

        public string Aciklama { get; set; }
        public string BolumFoto { get; set; }
        public int DiziId { get; set; }
        public Dizi Dizi { get; set; }

    }
}
