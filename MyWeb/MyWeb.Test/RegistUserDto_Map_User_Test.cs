using MyWeb.BLL.AutoMapperExtension;
using MyWeb.Model.User;
using MyWeb.Model.User.Dto;
using Shouldly;
using Xunit;

namespace MyWeb.Test
{
    public class RegistUserDto_Map_User_Test
    {
        [Fact(DisplayName ="RegistUserDto映射User")]
       public void UserDtoMapper()
        {
            RegistUserDto dto = new RegistUserDto
            {
                TelNum = "12345678910",
                UserName = "Niko",
                PassWord = "123",
            };
            User user = dto.MapTo<User>();
            user.IsValidated.ShouldBeFalse();
            user.PassWord.ShouldBe("123");
            user.QQNum.ShouldBeNullOrEmpty();
            user.TelNum.ShouldBe("12345678910");
            user.UserName.ShouldBe("Niko");
        }
    }
}
