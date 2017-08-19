using MyWeb.BLL.Application;
using MyWeb.BLL.AutoMapperExtension;
using MyWeb.DAL.UserApplication;
using MyWeb.Model;
using MyWeb.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.BLL.UserApplication
{ 
    public class UserApplication : IApplication
    {
        private static UserDbApplication _userDbApplication=new UserDbApplication();
        public void Add<UserDto>(UserDto input)
        {
            User newuser = input.MapTo<User>();
            _userDbApplication.AddUser(newuser);
        }

        public void Change<T>(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public T Search<T>()
        {
            throw new NotImplementedException();
        }

        public int GetUserNum()
        {
            return   _userDbApplication.GetUserNum();
        }
    }
}
