using CryptoCoins.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCoins.ViewComponents
{
    public class CoinViewComponent : ViewComponent
    {
        private readonly CoinContext _coinsContext;

        // Dependency injection
        public CoinViewComponent(CoinContext coinsContext) 
        {
            _coinsContext = coinsContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _coinsContext.CoinContexts.ToListAsync());
        }
    }
}
