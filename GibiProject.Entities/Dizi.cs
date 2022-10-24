using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibiProject.Entities
{
    public class Dizi
    {
        public int Id { get; set; }
        public string DiziAdi { get; set; }
        public string Aciklama { get; set; }
        public string DiziFoto { get; set; }
        public virtual List<Bolum> Bolum { get; set; }
        public Dizi()
        {
            Bolum = new List<Bolum>();

        }
    }
}
