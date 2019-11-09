namespace BlueberrySwap.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlueberrySwapDb : DbContext
    {
        public BlueberrySwapDb()
            : base("name=BlueberrySwapDb")
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.title)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .Property(e => e.description)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .Property(e => e.status)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .Property(e => e.created_at)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.item_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.created_at)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.type)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.first_name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.last_name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.email_address)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.phone_number)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.address)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.author_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.sellerr_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Transactions1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.buyer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Users1)
                .WithRequired(e => e.User1);
        }
    }
}
