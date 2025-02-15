﻿using BenchmarkEFCoreDapper.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BenchmarkEFCoreDapper.Data.Contexts
{
    public class AthleteDbContext : DbContext
    {
        public AthleteDbContext(DbContextOptions<AthleteDbContext> options) : base(options)
        {
        }

        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Sport> Sports { get; set; }
    }
}
