namespace OnlineBookstore.Services
{
    using OnlineBookstore.Entities;
    using OnlineBookstore.Repository.Interfaces;
    using OnlineBookstore.Service.Interfaces;
    using System;
    using System.Collections.Generic;

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(User user)
        {
            _userRepository.Add(user);
           // throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
           // throw new NotImplementedException();
        }

        public void Edit(User user)
        {
            _userRepository.Edit(user);
           // throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var result = _userRepository.GetAllUsers();
            return result;
           // throw new NotImplementedException();
        }

        public User GetUserById(string id)
        {
            var result = _userRepository.GetUserById(id);
            return result;
           // throw new NotImplementedException();
        }

        public User GetUserByUsername(string username)
        {
            var result= _userRepository.GetUserByUsername(username);
            return result;
           // throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByCity(string city)
        {
            var result= _userRepository.GetUsersByCity(city);
            return result;
           // throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByCountry(string country)
        {
            var result= _userRepository.GetUsersByCountry(country);
            return result;
           // throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByEmail(string email)
        {
            var result = _userRepository.GetUsersByEmail(email);
            return result;
            //throw new NotImplementedException();
        }
    }
}
