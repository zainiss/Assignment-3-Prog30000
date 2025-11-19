using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Core.Models;
using Microsoft.EntityFrameworkCore;


namespace BlogApp.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
                
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.OriginPost!)
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade); // cascade delete
        }
    }
}