using GibiProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibiProject.DAL
{
    public class İnitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            Dizi gibi = new Dizi();
            gibi.DiziAdi = "Gibi";
            context.Dizis.Add(gibi);

            Dizi bcs = new Dizi();
            bcs.DiziAdi = "Better Call Saul";
            context.Dizis.Add(bcs);

            Bolum bolum = new Bolum();
            bolum.BolumAdi = "abc";
            bolum.BolumNumara = "1";
            bolum.Dizi = gibi;
            context.Bolums.Add(bolum);

            Bolum bolum1 = new Bolum();
            bolum1.BolumAdi = "agsdgdgsbc";
            bolum1.BolumNumara = "2";
            bolum1.Dizi = gibi;
            context.Bolums.Add(bolum1);

            Bolum bolum2 = new Bolum();
            bolum2.BolumAdi = "sadsadasdas";
            bolum2.BolumNumara = "1";
            bolum2.Dizi = bcs;
            context.Bolums.Add(bolum2);

           context.SaveChanges();    
        }
    }
}
