using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new SqlRepository();
            PasswordCheckerService passwordCheckerService = new PasswordCheckerService(repository);
            string result = passwordCheckerService.VerifyPassword("helloIloveU", PasswordCheckerService.DigitCharactersPassWordChecker, PasswordCheckerService.EmptyPassWordChecker).Item2;
            System.Console.WriteLine(result);
            result = passwordCheckerService.VerifyPassword("helloIloveU", PasswordCheckerService.AlphabeticCharactersPassWordChecker, PasswordCheckerService.EmptyPassWordChecker).Item2;
            System.Console.WriteLine(result);
            System.Console.ReadKey();

        }
    }
}
