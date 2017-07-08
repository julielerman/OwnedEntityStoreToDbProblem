using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;


namespace SamuraiApp.Data {
  public class SamuraiContext : DbContext {

    public SamuraiContext (DbContextOptions<SamuraiContext> options) : base (options) {

    }
    public DbSet<Samurai> Samurais { get; set; }
    public DbSet<Quote> Quotes { get; set; }

    protected override void OnModelCreating (ModelBuilder modelBuilder) {
      modelBuilder.Entity<Samurai> ().OwnsOne (typeof (PersonName), "SecretIdentity");
    }

   
  }
}