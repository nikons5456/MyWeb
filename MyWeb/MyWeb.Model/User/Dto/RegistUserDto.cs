using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyWeb.Model.User.Dto
{
    public  class RegistUserDto
    {
        private const int UserNameMaxlength = 20;

        private const int PasswordMaxLength = 16;

        private const int TelNumStringLength = 11;

        [Required]
        [DisplayName("手机")]
        [Description("{0}不能为空")]
        [StringLength(TelNumStringLength)]
        public string TelNum { get; set; }

        [Required]
        [DisplayName("用户名")]
        [Description("{0}不能为空")]
        [MaxLength(UserNameMaxlength)]
        public string UserName { get; set; }

        
        [Required]
        [DisplayName("密码")]
        [Description("{0}不能为空")]
        [MaxLength(PasswordMaxLength)]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}
