using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Georgea_Adina_Lab2.Models;

namespace Georgea_Adina_Lab2.Data
{
    public class Georgea_Adina_Lab2Context : DbContext
    {
        public Georgea_Adina_Lab2Context (DbContextOptions<Georgea_Adina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Georgea_Adina_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Georgea_Adina_Lab2.Models.Publisher> Publisher { get; set; } = default!;

        public DbSet<Georgea_Adina_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
