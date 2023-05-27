using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
namespace AgricultureUl.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage = "Başlık boş geçilmez")]
        public string Title { get; set; }


        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama boş geçilmez")]
        public string Description { get; set; }


        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel değeri boş geçilmez")]
        public string Image { get; set; }
    }
}
