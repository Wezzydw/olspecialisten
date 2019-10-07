using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Ølspecialisten.Core.Entity;

namespace Ølspecialisten.Infrastructure.Data
{
    public class BeerContext : DbContext
    {
        public  BeerContext(DbContextOptions opt) :  base(opt)
        {
        }

        public DbSet<Beer> Beers { get; set; }
    }
}
