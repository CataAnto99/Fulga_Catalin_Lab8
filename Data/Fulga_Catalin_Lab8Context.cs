using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fulga_Catalin_Lab8.Models;

namespace Fulga_Catalin_Lab8.Data
{
    public class Fulga_Catalin_Lab8Context : DbContext
    {
        public Fulga_Catalin_Lab8Context (DbContextOptions<Fulga_Catalin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Fulga_Catalin_Lab8.Models.Book> Book { get; set; }

        public DbSet<Fulga_Catalin_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Fulga_Catalin_Lab8.Models.Category> Category { get; set; }
    }
}
