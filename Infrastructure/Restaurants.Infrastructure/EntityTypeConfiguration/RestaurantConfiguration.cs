using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurants.Domain.Entities;

namespace Restaurants.Infrastructure.EntityTypeConfiguration;

public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        builder
            .HasKey(r => r.Id);

        builder
            .HasIndex(r => r.Id)
            .IsUnique();

        builder
            .HasMany(r => r.MenuItems)
            .WithOne()
            .HasForeignKey(m => m.RestaurantId);
    }
}