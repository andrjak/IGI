using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewSocialNetwork.Models;

namespace NewSocialNetwork.Data
{
    public class ApplicationContext : IdentityDbContext<User> // Update-Database используется для миграции
    {
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Follow> Follows { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)  
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserChat>()
                .HasKey(uc => new { uc.UserId, uc.ChatId });

            modelBuilder.Entity<UserChat>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.Chats)
                .HasForeignKey(uc => uc.UserId);

            modelBuilder.Entity<UserChat>()
                .HasOne(uc => uc.Chat)
                .WithMany(c => c.Users)
                .HasForeignKey(uc => uc.ChatId);

            modelBuilder.Entity<Follow>().HasOne(ing => ing.Following).WithMany(er => er.Followers);
            modelBuilder.Entity<Follow>().HasOne(er => er.Follower).WithMany(ing => ing.Followings);

            base.OnModelCreating(modelBuilder);
        }
    }
}
