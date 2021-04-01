using Microsoft.EntityFrameworkCore;
using Api.Domain.Entities;
using Api.Data.Mapping;

namespace Api.Data.Context
{
    public class MyContext :DbContext
    {

        public MyContext(DbContextOptions<MyContext> options): base(options){}

        public DbSet<UserEntity> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity> (new UserMap().Configure);
        }
    }
}