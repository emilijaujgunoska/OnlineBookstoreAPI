using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Repository.Interfaces
{
   
    using OnlineBookstore.Entities;
    using System.Threading.Tasks;

    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> UserExists(string email);
    }
}

