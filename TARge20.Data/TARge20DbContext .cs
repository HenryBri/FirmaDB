using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        public DbSet<Ametinimetus> Ametinimetus { get; set; }
        public DbSet<Haiguslehed> Haiguslehed { get; set; }
        public DbSet<Harukontor> Harukontor { get; set; }
        public DbSet<Laenutus> Laenutus { get; set; }
        public DbSet<Lapsed> Lapsed { get; set; }
        public DbSet<Ligipääsuload> Ligipääsuload { get; set; }
        public DbSet<Palved> Palved { get; set; }
        public DbSet<Peakontor> Peakontor { get; set; }
        public DbSet<Puhkused> Puhkused { get; set; }
        public DbSet<Tervisekontroll> Tervisekontroll { get; set; }
        public DbSet<Töötaja> Töötaja { get; set; }
        public DbSet<Vihjed> Vihjed { get; set; }
    }
}