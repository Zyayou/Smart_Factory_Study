using System.ComponentModel.DataAnnotations;

namespace ValidationAttribute.Models
{
    public class Student
    {
        [Required(ErrorMessage = "이름을 작성해 주세요.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage ="이름은 두자 이상 가능합니다.")]
        public string Name { get; set; }
    }
}
