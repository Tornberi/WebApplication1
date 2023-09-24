using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("dbo.Users")]
    public class OpenUsers
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Имя не указано!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Пароль не указан")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "Возраст не указан!")]
        public byte UserAge { get; set; }

        public int UserPhone { get; set; }

        public string UserMaill { get; set; }
    }
}
