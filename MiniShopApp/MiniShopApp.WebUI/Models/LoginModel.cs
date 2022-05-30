using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz!")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Lütfen şifrenizi giriniz!")]
        [DataType(DataType.Password)] //Datatype.Password yazarsak yıldız olarak gösterir.
        public string Password { get; set; }

    }
}
