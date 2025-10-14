using Microsoft.EntityFrameworkCore;
using Library_Management_Case_Study.Data.Models;

namespace Library_Management_Case_Study.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasIndex(b => b.Title)
                .IsUnique();

            modelBuilder.Entity<Author>()
                .HasIndex(b => b.Name)
                .IsUnique();

            modelBuilder.Entity<Category>()
                .HasIndex(b => b.Name)
                .IsUnique();

            modelBuilder.Entity<MembershipCard>()
                .HasIndex(m => m.CardNo)
                .IsUnique();


            modelBuilder.Entity<Book>()
                .HasMany(b => b.Authors)
                .WithMany(b => b.Books)
                .UsingEntity(h => h.ToTable("BooksAuthors"));

            modelBuilder.Entity<User>()
                .HasOne(b => b.MembershipCard)
                .WithOne(b => b.User)
                .HasForeignKey<MembershipCard>(x => x.UserId);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Science"},
                new Category { Id = 2, Name = "History"},
                new Category { Id = 3, Name = "Self-Improvement"},
                new Category { Id = 4, Name = "Math"},
                new Category { Id = 5, Name = "Fiction"}
            );

            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Nour El den", Bio = "Bio 1"},
                new Author { Id = 2, Name = "Seif Mohamed", Bio = "Bio 2" },
                new Author { Id = 3, Name = "Seif Ahmed", Bio = "Bio 3" },
                new Author { Id = 4, Name = "Hamsa Ehab", Bio = "Bio 4" },
                new Author { Id = 5, Name = "Hana Elsayed", Bio = "Bio 5" },
                new Author { Id = 6, Name = "Ahmed ElSewedy", Bio = "Bio 6" },
                new Author { Id = 7, Name = "Salah El den", Bio = "Bio 7" },
                new Author { Id = 8, Name = "Anas", Bio = "Bio 8" },
                new Author { Id = 9, Name = "Ahmed Sherif", Bio = "Bio 9" },
                new Author { Id = 10, Name = "Hussien Mohamed", Bio = "Bio 10" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Science 1", Description = "", PublishDate = new DateTime(2025, 10, 10), Copies = 10, CategoryId = 1}, 
                new Book { Id = 2, Title = "History 1", Description = "", PublishDate = new DateTime(2025, 10, 10), Copies = 15, CategoryId = 2}, 
                new Book { Id = 3, Title = "Self-Improvement", Description = "", PublishDate = new DateTime(2025, 10, 10), Copies = 5, CategoryId = 3}, 
                new Book { Id = 4, Title = "Math", Description = "", PublishDate = new DateTime(2025, 10, 10), Copies = 2, CategoryId = 4}, 
                new Book { Id = 5, Title = "Fiction", Description = "", PublishDate = new DateTime(2025, 10, 10), Copies = 13, CategoryId = 5}, 
                new Book { Id = 6, Title = "Science 2", Description = "", PublishDate = new DateTime(2025, 10, 10), Copies = 30, CategoryId = 1}, 
                new Book { Id = 7, Title = "History 2", Description = "", PublishDate = new DateTime(2025, 10, 10), Copies = 50, CategoryId = 2} 
            );

        }



        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<MembershipCard> MembershipCards { get; set; }

    }
}
