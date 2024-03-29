﻿using Microsoft.EntityFrameworkCore;
using WebMinimalAPI.Models;

namespace WebMinimalAPI.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options) => Database.EnsureCreated();

        public DbSet<Produto> Produto { get; set; }
    }
}
