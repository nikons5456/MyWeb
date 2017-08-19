using MyWeb.BLL.UserApplication;
using MyWeb.Model;
using MyWeb.Model.User.Dto;
using Shouldly;
using Xunit;

namespace MyWeb.Test
{
    public class Add_User_To_Db
    {
        private static UserApplication _userApplication=new UserApplication();


        [Fact(DisplayName ="数据库添加用户")]
        public void AddUSer()
        {
            RegistUserDto dto = new RegistUserDto {
                TelNum = "12345678910",
                UserName = "Niko",
                PassWord = "123"
            };
            _userApplication.Add(dto);
            _userApplication.GetUserNum().ToString().ShouldBe("2");
        }
    }
}
