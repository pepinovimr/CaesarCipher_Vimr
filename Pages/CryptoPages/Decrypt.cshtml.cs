using CaesarCipher_Vimr.Generics;
using CaesarCipher_Vimr.Logic;
using CaesarCipher_Vimr.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CaesarCipher_Vimr.Pages.CryptoPages
{
    public class DecryptModel : GenericCryptoPageModel
    {
        //[BindProperty]
        //public CryptoContent cryptoContent { get; set; }
        //public AppDbContext _context { get; set; }
        public DecryptModel(AppDbContext context)
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
            cryptoContent = CryptoHelper.Decrypt(cryptoContent.EncryptedText, cryptoContent.Key);
            
            _context.Cryptos.Add(cryptoContent);
            _context.SaveChanges();

            ModelState.Clear();

            return Page();
        }
    }
}
