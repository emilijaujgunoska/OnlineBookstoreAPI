﻿using OnlineBookstore.Entities;
using OnlineBookstore.Repository.Interfaces;
using OnlineBookstore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public Task<User> Login(string username, string password)
        {
            var result = _authRepository.Login(username, password);
            return result;
        }

        public Task<User> Register(User user, string password)
        {
            var result = _authRepository.Register(user, password);
            return result;
        }

        public Task<bool> UserExists(string email)
        {
            var result = _authRepository.UserExists(email);
            return result;
        }
    }
}
