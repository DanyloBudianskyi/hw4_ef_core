using hw4_ef_core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace hw4_ef_core
{
    public partial class TaskManager : DbContext
    {
        public TaskManager()
            : base("name=TaskManager")
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasRequired(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasRequired(t => t.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.ProjectId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasRequired(u => u.Project)
                .WithMany(p => p.Users)
                .HasForeignKey(u => u.ProjectId)
                .WillCascadeOnDelete(false);
        }
    }
}
