using CaesarCipher_Vimr.Logic;
using CaesarCipher_Vimr.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CaesarCipher_Vimr.Pages.CryptoPages
{
    public class EncryptModel : PageModel
    {
        [BindProperty]
        public PageContent pageContent { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            pageContent =  CryptoService.Encrypt(pageContent.DecryptedText, pageContent.Key);

            ModelState.Clear();

            return Page();
        }
    }
}
