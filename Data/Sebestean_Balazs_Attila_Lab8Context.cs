using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect.Models;

namespace Proiect.Data
{
    public class Sebestean_Balazs_Attila_Lab8Context : DbContext
    {
        public Sebestean_Balazs_Attila_Lab8Context (DbContextOptions<Sebestean_Balazs_Attila_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Proiect.Models.Book> Book { get; set; }

        public DbSet<Proiect.Models.Publisher> Publisher { get; set; }

        public DbSet<Proiect.Models.Category> Category { get; set; }
    }
}
