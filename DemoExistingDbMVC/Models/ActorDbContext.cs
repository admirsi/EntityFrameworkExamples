using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoExistingDbMVC.Models;

public partial class ActorDbContext : DbContext
{
    public ActorDbContext()
    {
    }

    public ActorDbContext(DbContextOptions<ActorDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actors> Actors { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
