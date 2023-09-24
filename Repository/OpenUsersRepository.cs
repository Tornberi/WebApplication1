using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class OpenUsersRepository
    {
        private readonly WebApplication1Context context;

        public OpenUsersRepository(WebApplication1Context context)
        {
            this.context = context;
        }

        public OpenUsers GetUserByName(string UserName)
        {
            return context.openUsers.Single(x => x.UserName == UserName);
        }
    }
}
