using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazinzadrdomlubimciViktor5.Model
{
    public class AnimalContext : DbContext
    {
        public AnimalContext() : base("AnimalContext")
        {

        }
        public DbSet<Animal> Animals { get; set; } //Animal table
        public DbSet<AnimalsTypes> AnimalsTypes { get; set; }
    }
}
