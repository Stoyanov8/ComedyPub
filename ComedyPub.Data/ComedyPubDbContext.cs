namespace ComedyPub.Data
{
    using Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ComedyPubDbContext : IdentityDbContext<User>
    {
        public ComedyPubDbContext(DbContextOptions<ComedyPubDbContext> options)
            : base(options)
        {

        }

        public DbSet<Content> Content { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Content>()
                .HasOne(c => c.Creator)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.CreatorId);

           
            base.OnModelCreating(builder);
        }
    }
}
