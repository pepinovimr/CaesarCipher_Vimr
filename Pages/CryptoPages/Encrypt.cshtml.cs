using CaesarCipher_Vimr.Logic;
using CaesarCipher_Vimr.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CaesarCipher_Vimr.Pages.CryptoPages
{
    public class EncryptModel : PageModel
    {
        [BindProperty]
        public CryptoContent cryptoContent { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            cryptoContent = CryptoService.Encrypt(cryptoContent.DecryptedText, cryptoContent.Key);

            ModelState.Clear();

            return Page();
        }
    }
}
