using System.ComponentModel.DataAnnotations;

namespace TestCompany.TestProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}