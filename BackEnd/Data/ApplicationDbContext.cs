using Microsoft.EntityFrameworkCore;
using System;

namespace BackEnd.Data
{
    public class ApplicationDbContext : DbContext
    {
        ///<summary>
        /// This is the connection object for our database
        ///</summary>

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Watcher>()
                .HasIndex(a => a.UserName)
                .IsUnique();

            modelBuilder.Entity<Assignment>()
                .Ignore(s=>s.Duration);

            // Many-to-many: x <-> y
            modelBuilder.Entity<TeamWatcher>()
                .HasKey(c => new { c.TeamID, c.WatcherID });

            modelBuilder.Entity<AssignmentWatcher>()
                .HasKey(c => new {c.AssignmentID, c.WatcherID});

            modelBuilder.Entity<CurrentWorker>()
                .HasKey(c => new {c.AssignmentID, c.WorkerID});

            modelBuilder.Entity<AssignmentTag>()
                .HasKey(t => new {t.AssignmentID, t.TagID});
        }

        public DbSet<Worker> Workers { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Watcher> Watchers { get; set; }
    }
}