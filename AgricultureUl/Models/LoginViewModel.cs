using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
namespace AgricultureUl.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin")]
		public string username { get; set; }
		[Required(ErrorMessage = "Lütfen Şifrenizi Girin")]
		public string password { get; set; }
	}
}
