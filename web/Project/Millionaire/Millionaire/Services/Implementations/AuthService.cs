﻿using Millionaire.Filters;
using Millionaire.Models;
using Millionaire.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Services.Implementations {
    public class AuthService : IAuthService {
        private readonly IUserService _userService;
        public AuthService(IUserService userService) {
            _userService = userService;
        }

        public bool isTokenValid(string token) {
            return _userService.GetAll().Any(x => x.Password == token);
        }

        public bool IsUserValid(User user, out string token) {
            token = string.Empty;
            var users = _userService.GetAll();
            var currentUser = users.SingleOrDefault(x => x.UserName == user.UserName && x.Password == HashWithSalt(user.Password));

            var isUserValid = currentUser != null;

            if (isUserValid) {
                token = HashWithSalt(user.Password);
                return true;
            }

            return isUserValid;

        }

        private string HashWithSalt(string source) {
            return Sha1Helper.HashPassword(source + constants.Salt);
        }
    }
}
