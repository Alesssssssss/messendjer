using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace messendjer.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указаны имя и фамилия")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Не указан логин")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}
