using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coroian_Emanuel_Lab2.Models;

namespace Coroian_Emanuel_Lab2.Data
{
    public class Coroian_Emanuel_Lab2Context : DbContext
    {
        public Coroian_Emanuel_Lab2Context (DbContextOptions<Coroian_Emanuel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Coroian_Emanuel_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Coroian_Emanuel_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
