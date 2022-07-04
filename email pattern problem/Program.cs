﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmailAddressValidationConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emailAddresses = new List<string>
            {
                // Valid email addresses based on regex defined
                "tony@example.com",
                "tony.stark@example.net",
                "tony.stark@example.gov",
                "TONY@EXAMPLE.GOV",

                // Invalid email addresses based on regex defined
                "tony@example",
                "tony@example.co.uk",
                "tony@example.me"
            };

            foreach (var emailAddress in emailAddresses)
            {
                Console.WriteLine($"{emailAddress} is" + (IsValid(emailAddress) ? " a valid" : " an invalid") + " email address.");
            }

            Console.ReadLine();
        }

        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
    }
}