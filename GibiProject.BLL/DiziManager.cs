using GibiProject.DAL;
using GibiProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibiProject.BLL
{
    public  class DiziManager
    {
        Repository<Dizi> dizi = new Repository<Dizi>();

        public List<Dizi> DiziList()
        {
            return dizi.List();
        }
        public Dizi BolumGetirDizi(int id)
        {
            return dizi.Find(c => c.Id == id);
        }

    }
}
