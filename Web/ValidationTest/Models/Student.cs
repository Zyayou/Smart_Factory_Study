using System.ComponentModel.DataAnnotations;

namespace ValidationTest.Models
{
    public class Student
    {
        [Display(Name ="이름 : ")]
        [Required(ErrorMessage = "이름을 작성해주세요.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "이름은 두자 이상 가능합니다.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "나이를 작성해주세요.")]
        [Range(20,70,ErrorMessage ="20살 ~ 70세 까지 가능합니다.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "패스워드를 적어주세요.")]
        [RegularExpression(@"(?=.*[a-zA-Z])(?=.*[0-9]).{8,25}$", ErrorMessage = "영문자로 대소문자와 숫자조합으로 8자리이상")]
        public string Password { get; set; }

    }
}
