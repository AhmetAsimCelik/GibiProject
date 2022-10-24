using GibiProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibiProject.DAL
{
    public class Context:DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-N031PB4; Database=GibiProject2; uid=sa; pwd=1";
            Database.SetInitializer(new İnitializer());

        }
        public DbSet<Dizi> Dizis { get; set; }

        public DbSet<Bolum> Bolums { get; set; }

        public DbSet<Kullanici> Kullanicis { get; set; }

       
    }
}
