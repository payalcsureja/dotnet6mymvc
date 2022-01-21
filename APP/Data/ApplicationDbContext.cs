using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Models;
using Microsoft.EntityFrameworkCore;

namespace APP.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories {get; set;}
    }
}