﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository;

        public PasswordCheckerService(IRepository repository)
        {
           this.repository = repository;
        }

        public static Tuple<bool, string> EmptyPassWordChecker(string password)
        {
            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");
            return null;
        }

        public static Tuple<bool, string> ShortPassWordChecker(string password)
        {
            // check if length more than 7 chars 
            if (password.Length <= 7)
                return Tuple.Create(false, $"{password} length too short");
            return null;
        }


        public static Tuple<bool, string> LongPassWordChecker(string password)
        {
            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return Tuple.Create(false, $"{password} length too long");
            return null;
        }


        public static Tuple<bool, string> AlphabeticCharactersPassWordChecker(string password)
        {
            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");
            return null;
        }


        public static Tuple<bool, string> DigitCharactersPassWordChecker(string password)
        {
            // check if password conatins at least one digit character 
            if (!password.Any(char.IsNumber))
                return Tuple.Create(false, $"{password} hasn't digits");
            return null;
        }


        public Tuple<bool, string> VerifyPassword(string password, params Func<string, Tuple<bool, string>>[] passwordCheckers)
        {
            Tuple<bool, string> result = null;

            foreach(var passwordChecker in passwordCheckers)
            {
                result = passwordChecker(password);
                if (result != null)
                    return result;
            }

            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
