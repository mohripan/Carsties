using AuctionService.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.API.Data
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Auction> Auctions { get; set; }
    }
}
