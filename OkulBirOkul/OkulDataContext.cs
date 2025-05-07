using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulBirOkul
{
    public class OkulDataContext : DbContext
    {
        public DbSet<DbSınıf> Siniflar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dosya = "okul_veritabani.db";

            optionsBuilder.UseSqlite($"Data Source ={dosya}");
        }
    }
}
 