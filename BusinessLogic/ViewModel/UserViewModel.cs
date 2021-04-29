using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModel
{
    public class UserViewModel
    {
        public int? Id { get; set; }
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [DisplayName("ФИО")]
        public string FIO { get; set; }
    }
}
