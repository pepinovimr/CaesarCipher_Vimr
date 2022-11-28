using System;
using System.ComponentModel.DataAnnotations;

namespace CaesarCipher_Vimr.Model
{
    public class CryptoContent
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        [Range(1, 25,ErrorMessage = "Klíč musí být větší než 0 a menší než 26!")]
        public int Key { get; set; } = 3;
        public string DecryptedText { get; set; }
        public string EncryptedText{ get; set; }
    }
}
