using CaesarCipher_Vimr.Generics;
using CaesarCipher_Vimr.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace CaesarCipher_Vimr.Pages.CryptoPages
{
    public class HistoryModel : GenericCryptoPageModel
    {
        public List<CryptoContent> ListContent { get; set; }
        public HistoryModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            ListContent = _context.Cryptos.ToList();
        }
    }
}
