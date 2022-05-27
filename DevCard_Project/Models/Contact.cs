using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Project.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        [MaxLength(100,ErrorMessage = "حداکثر مقدار ورودی 100 کاراکتر میباشد")]
        [MinLength(3,ErrorMessage = "حداقل مقدار ورودی 3 کاراکتر میباشد")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "مقدار وارد شده صحیح نمیباشد")]
        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        public string Email { get; set; }
        public int Service { get; set; }
        public string Message { get; set; }
        public SelectList Services { get; set; }
    }
}
