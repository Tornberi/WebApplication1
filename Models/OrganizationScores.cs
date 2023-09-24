using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class OrganizationScores
    {
        public int? id { get; set; }

        [Display(Name = "Имя пользователя")]
        [Required(ErrorMessage = "Имя пользователя введено не корректно!")]
        public string UserName { get; set; }

        [Display(Name = "Название организации")]
        [Required(ErrorMessage = "Название организации введено не корректно!")]
        public string OrganizationName { get; set; }

        [Display(Name = "Адрес организации")]
        public string OrganizationAreas { get; set; }

        [Display(Name = "Положительные стороны организации")]
        [Required(ErrorMessage = "Положительные стороны организации введены не корректно!")]
        public string PlusOrganization { get; set; }

        [Display(Name = "Отрицательные стороны организации")]
        public string MinusOrganization { get; set; }

        [Display(Name = "Комментарий")]
        public string Comment { get; set; }

        [Display(Name = "Оценка (от 1 до 5)")]
        [Required(ErrorMessage = "Оценка организации введена не корректно!")]
        [Range(1, 5, ErrorMessage = "Недопустимое значение оценки. Выберите в диапазоне от 1 до 5, где 5 это максимальная положительная оценка!")]
        public byte Scores { get; set; }
    }
}
