using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCoins.Models
{
    public class Coin
    {
        public int CoinId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        [NotMapped] // Do not map to database
        public bool IsChecked { get; set; }
    }
}
