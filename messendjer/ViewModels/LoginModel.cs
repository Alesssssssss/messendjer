using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace messendjer.ViewModels
{
    public class LoginModel
    {
        

        [Required(ErrorMessage = "Не указан логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
