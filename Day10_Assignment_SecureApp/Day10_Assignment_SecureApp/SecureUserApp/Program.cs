using SecureUserApp.Services;
using System;

class Program
{
    static void Main()
    {
        var auth = new AuthService();

        while (true)
        {
            Console.WriteLine("\n1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Username: ");
                var user = Console.ReadLine();

                Console.Write("Password: ");
                var pass = Console.ReadLine();

                Console.Write("Secret Data: ");
                var secret = Console.ReadLine();

                bool ok = auth.Register(user, pass, secret);
                Console.WriteLine(ok ? "Registered!" : "User exists!");
            }
            else if (choice == "2")
            {
                Console.Write("Username: ");
                var user = Console.ReadLine();

                Console.Write("Password: ");
                var pass = Console.ReadLine();

                if (auth.Login(user, pass))
                {
                    Console.WriteLine("Login Success!");
                    Console.WriteLine("Decrypted Secret: " + auth.GetSecret(user));
                }
                else
                {
                    Console.WriteLine("Invalid credentials");
                }
            }
            else break;
        }
    }
}