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
            gibi.Aciklama = "Yılmaz, İlkkan ve Ersoy...Sürekli olarak  birbirleriyle didişmekte olan üç arkadaş.En büyük özellikleri ise sıradan hayatlarını altüst edecek bir şeyler yapmayı her zaman becermek.";
            gibi.DiziFoto = "gibifoto.jpg";
            context.Dizis.Add(gibi);

            Dizi bcs = new Dizi();
            bcs.DiziAdi = "Better Call Saul";
            bcs.Aciklama = "Açıklama satırı";
            bcs.DiziFoto = "bcsfoto.jpg";
            context.Dizis.Add(bcs);

            Bolum bolum = new Bolum();
            bolum.BolumAdi = "Kokariç";
            bolum.BolumNumara = "1";
            bolum.BolumSezon = "1";
            bolum.Aciklama = "açıklamasatırı";
            bolum.BolumFoto = "gibifoto.jpg";
            bolum.Dizi = gibi;
            context.Bolums.Add(bolum);

            Bolum bolum1 = new Bolum();
            bolum1.BolumAdi = "Vatka";
            bolum1.BolumNumara = "2";
            bolum1.BolumSezon = "1";
            bolum1.Aciklama = "açıklamasatırı";
            bolum1.BolumFoto = "gibifoto.jpg";
            bolum1.Dizi = gibi;
            context.Bolums.Add(bolum1);

            Bolum bolum5 = new Bolum();
            bolum5.BolumAdi = "Nü Model";
            bolum5.BolumNumara = "3";
            bolum5.BolumSezon = "1";
            bolum5.Aciklama = "açıklamasatırı";
            bolum5.BolumFoto = "gibifoto.jpg";
            bolum5.Dizi = gibi;
            context.Bolums.Add(bolum5);

            Bolum bolum6 = new Bolum();
            bolum6.BolumAdi = "Erasmusla Gelen Yamyam";
            bolum6.BolumNumara = "4";
            bolum6.BolumSezon = "1";
            bolum6.Aciklama = "açıklamasatırı";
            bolum6.BolumFoto = "gibifoto.jpg";
            bolum6.Dizi = gibi;
            context.Bolums.Add(bolum6);

            Bolum bolum2 = new Bolum();
            bolum2.BolumAdi = "Bir";
            bolum2.BolumNumara = "1";
            bolum2.BolumSezon = "1";
            bolum2.Aciklama = "Zorlu bir dönemden geçen Jimmy McGill karanlık geçmişini geride bırakmaya çalışır.Ama büyük bir fırsat belirdiği zaman eski alışkanlıkları bırakmak zordur.";
            bolum2.BolumFoto = "bcsfoto.jpg";
            bolum2.Dizi = bcs;
            context.Bolums.Add(bolum2);

            Bolum bolum3 = new Bolum();
            bolum3.BolumAdi = "Oğlum";
            bolum3.BolumNumara = "2";
            bolum3.BolumSezon = "1";
            bolum3.Aciklama = "Tehlikeli suçlara karşı şiddet dolu ve gergin anlar yaşayan Jimmy,kendi ikna gücü sayesinde ya hayatta kalacak yada ölecektir.";
            bolum3.BolumFoto = "bcsfoto.jpg";
            bolum3.Dizi = bcs;
            context.Bolums.Add(bolum3);

            Bolum bolum4 = new Bolum();
            bolum4.BolumAdi = "Nacho";
            bolum4.BolumNumara = "3";
            bolum4.BolumSezon = "1";
            bolum4.Aciklama = "Çok tehlikeli yeni bir müvekkili polisin elinde olan Jimmy,polisin dikkatini başka yöne çekerek bir yandan da kendi paçasını kurtarmaya çalışır";
            bolum4.BolumFoto = "bcsfoto.jpg";
            bolum4.Dizi = bcs;
            context.Bolums.Add(bolum4);

            context.SaveChanges();    
        }
    }
}
