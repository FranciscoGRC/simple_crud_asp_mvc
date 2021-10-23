using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simple_crud_asp_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace simple_crud_asp_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }

    }
}
