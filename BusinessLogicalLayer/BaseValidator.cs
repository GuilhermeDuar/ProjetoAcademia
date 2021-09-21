using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class BaseValidator<T>
    {
        private StringBuilder errors = new StringBuilder();
        protected void AddError(string error)
        {
            if (!string.IsNullOrWhiteSpace(error))
            {
                this.errors.AppendLine(error);
            }
        }
        public virtual Feedback Validate(T item)
        {
            Feedback response = new Feedback();
            if (this.errors.Length != Basic_Values.Zero)
            {
                response = ResponseFactory<T>.CreateFailedResponse();
                response.Report = errors.ToString();
                this.errors.Clear();
                return response;
            }
            response = ResponseFactory<T>.CreateSuccessResponse();
            return response;
        }
        public static string IsValidLength(string word, int min, int max, string fieldName)
        {
            return (word.Length < min || word.Length > max)? $"{fieldName} should be between {min} and {max} characters" : "";
        }
        public static string IsValidLength(int min, string word, string fieldName)
        {
            return (word.Length < min)? $"{fieldName} lenght should be higher than {min} characters" : "";
        }
        public static string IsValidLength(string word, string fieldName, int max)
        {
            return (word.Length > max) ? $"{fieldName} lenght can't be higher than {max} characters" : "";
        }
        public static string IsValidLength(string fieldName, int fixedLenght, string word)
        {
            return (word.Length != fixedLenght) ? $"{fieldName} lenght should be {fixedLenght} characters. No more, nor less!" : "";
        }
        public static string IsValidPrice(double value, double minValue)
        {
            return (value < minValue)? $"Price value should be higher than {minValue.ToString("C2")}" : "";
        }
        public static string RegexValidation(string word, string regex, string fieldName)
        {
            bool isValid = Regex.IsMatch(word, regex);
            return (!isValid)? $"Invalid {fieldName}!" :  "";
        }
        public static string AssertOnlyLetters(string word, string fieldName)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i];
                if (!char.IsLetter(character) && character != ' ' && character != '\'')
                {
                    return $"One of the characters in this {fieldName} is invalid";
                }
            }
            return "";
        }
        public static string IsValidAge(DateTime birthdate)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-age))
            {
                age--;
            }
            return (age<18)? "Invalid age. Only 18 or older can register!" : "";
        }
        public static string IsValidCPF(string cpf)
        {
            int[] multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string character;
            int sum;
            int leftover;
            tempCpf = cpf.Substring(0, 9);
            sum = 0;
            for (int i = 0; i < 9; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiplier1[i];
            leftover = sum % 11;
            if (leftover < 2)
                leftover = 0;
            else
                leftover = 11 - leftover;
            character = leftover.ToString();
            tempCpf = tempCpf + character;
            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiplier2[i];
            leftover = sum % 11;
            if (leftover < 2)
                leftover = 0;
            else
                leftover = 11 - leftover;
            character = character + leftover.ToString();
            bool valid = cpf.EndsWith(character);
            if (!valid)
            {
                return "Invalid CPF";
            }
            return "";
        }
        public static string HashPassword(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] _passwordBytes = Encoding.ASCII.GetBytes(password);
            byte[] md5Data = md5.ComputeHash(_passwordBytes);
            return Convert.ToBase64String(md5Data);
        }
    }
}

