using CaesarCipher_Vimr.Logic;
using CaesarCipher_Vimr.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CaesarCipher_Vimr.Pages.CryptoPages
{
    public class DecryptModel : PageModel
    {
        [BindProperty]
        public CryptoContent cryptoContent { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            cryptoContent = CryptoHelper.Decrypt(cryptoContent.EncryptedText, cryptoContent.Key);

            ModelState.Clear();

            return Page();
        }
    }
}
