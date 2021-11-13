using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace UserRegistration
{
    class registration
    {
        public static string RegexFirstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string RegexLastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string RegexEmail= "^[a-zA-Z]{3,8}([_|+|.|-]{0,1}[a-zA-Z0-9]{0,5}){0,1}[@][a-zA-Z0-9]{1,10}([.][a-z]{2,4}){1,2}$";
        public static string RegexMobile = "^[0-9]{2}[\\s][6-9]{1}[0-9]{6}$";
        public static string RegexPassword = @"^(?=.{8,15}$)(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])([^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*)[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]([^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*)$";
       
        //"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(.{8,15})$"
        //^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$   ([!@#$%^&*]{1})
        /* public static string RegexLastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
         public static string RegexLastName = "^[A-Z]{1}[a-zA-Z]{2,}$";*/
        //^(?=.{8}$)(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])([^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*)[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\](?1)$
        public bool isValidFistName(string input)
        {
            return Regex.IsMatch(input, RegexFirstName);
        }

        public bool isValidLastName(string input)
        {
            return Regex.IsMatch(input, RegexLastName);
        }

        public bool isValidEmail(string input)
        {
            return Regex.IsMatch(input, RegexEmail);
        }
        public bool isValidMobile(string input)
        {
            return Regex.IsMatch(input, RegexMobile);
        }
        public bool isValidPassword(string input)
        {
            return Regex.IsMatch(input, RegexPassword);
        }
    }
}
