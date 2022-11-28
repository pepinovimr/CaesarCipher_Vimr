using CaesarCipher_Vimr.Generics;
using CaesarCipher_Vimr.Logic;
using CaesarCipher_Vimr.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CaesarCipher_Vimr.Pages.CryptoPages
{
    public class EncryptModel : GenericCryptoPageModel
    {
        //[BindProperty]
        //public CryptoContent cryptoContent { get; set; }
        public EncryptModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            cryptoContent = CryptoHelper.Encrypt(cryptoContent.DecryptedText, cryptoContent.Key);

            _context.Cryptos.Add(cryptoContent);
            _context.SaveChanges();

            ModelState.Clear();

            return Page();
        }
    }
}
