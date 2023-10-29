using LoginServiceApp;
using LoginServiceApp;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        LoginService loginService = new LoginService();

        // Test the CheckLogin method
        bool loginResult1 = loginService.CheckLogin("user1", "password1");
        bool loginResult2 = loginService.CheckLogin("user2", "password2");
        bool loginResult3 = loginService.CheckLogin("user1", "wrongpassword");

        Console.WriteLine("Login Result 1: " + loginResult1); // Should be true
        Console.WriteLine("Login Result 2: " + loginResult2); // Should be true
        Console.WriteLine("Login Result 3: " + loginResult3); // Should be false
    }
}
