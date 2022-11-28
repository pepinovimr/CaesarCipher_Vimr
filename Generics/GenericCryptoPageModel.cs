using CaesarCipher_Vimr.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CaesarCipher_Vimr.Generics
{
    public class GenericCryptoPageModel : PageModel
    {
        [BindProperty]
        public CryptoContent cryptoContent { get; set; } = new CryptoContent();
        protected AppDbContext _context { get; set; }

    }
}
