using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace ActionService.Data
{
    public class AuctionDbContext : DbContext
    {
        
        public AuctionDbContext(DbContextOptions options): base(options){

        }

        public DbSet<Auction> Auctions { get; set; }
    }
}