using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CreateUsers
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Введите имя пользователя!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Пароль введён не корректно!")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage ="Возраст введён не корректно!")]
        public byte UserAge { get; set; }
        public int UserPhone { get; set; }
        [Required(ErrorMessage ="Введите почту!")]
        public string UserMaill { get; set; }
    }
}
