﻿using PostgreSQLBlazorApp.Models;
using Microsoft.EntityFrameworkCore;


namespace PostgreSQLBlazorApp.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Famille> Famille { get; set; }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<Enfant> Enfant { get; set; }
    }
}
