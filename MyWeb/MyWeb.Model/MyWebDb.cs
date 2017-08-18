using System.Data.Entity;

namespace MyWeb.Model
{
    public class MyWebDb:DbContext
    {

        public IDbSet<User.User> Users { get; set; }

        public IDbSet<Passage.Passage> Passages { get; set; }
    }
}
