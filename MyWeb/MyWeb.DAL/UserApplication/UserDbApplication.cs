using MyWeb.Model;
using MyWeb.Model.User;
using System.Linq;

namespace MyWeb.DAL.UserApplication
{
    public class UserDbApplication
    {
        private static MyWebDb _myWebDb=new MyWebDb();
        public void AddUser(User newUser)
        {
            _myWebDb.Users.Add(newUser);
            _myWebDb.SaveChanges();
        }

        public int GetUserNum()
        {
            return _myWebDb.Users.Count();
        }
    }
}
