using System.ComponentModel.DataAnnotations;

namespace MyWeb.Model.User
{
    public class User
    {
        private const int UserNameMaxlength = 20;

        private const int PasswordMaxLength = 16;

        private const int TelNumStringLength = 11;

        private const int QQNumMinLength = 5;
        private const int QQNumMaxLength = 11;

        [Key]
        [StringLength(TelNumStringLength)]
        public string TelNum { get; set; }

        [MaxLength(UserNameMaxlength)]
        [Required]
        public string UserName { get; set; }

        [MaxLength(PasswordMaxLength)]
        [Required]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        public bool IsValidated { get; set; }

        [MinLength(QQNumMinLength)]
        [MaxLength(QQNumMaxLength)]
        public string QQNum{ get; set; }

    }
}
