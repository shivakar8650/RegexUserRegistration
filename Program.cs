using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration problem.\n");

            registration register = new registration();
            Console.WriteLine("validation for first name is:"+register.isValidFistName("Shivakar") );
            Console.WriteLine("validation for name is:"+ register.isValidLastName("Kumar"));
            Console.WriteLine("validation for Email is:" + register.isValidEmail("shivakar.up99@gmail.com"));
            Console.WriteLine("validation for mobile is:"+ register.isValidMobile("91 8650248107"));
            Console.WriteLine("validation for passWord is:" + register.isValidPassword("@Shivaka464"));
        }
    }
}
