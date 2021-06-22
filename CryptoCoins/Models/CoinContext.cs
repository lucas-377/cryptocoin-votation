using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCoins.Models
{
    public class CoinContext : DbContext
    {
        public DbSet<Coin> CoinContexts { get; set; }

        public CoinContext(DbContextOptions<CoinContext> options) : base(options) { }
    }
}
