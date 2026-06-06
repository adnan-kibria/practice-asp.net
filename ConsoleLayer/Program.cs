using System.ComponentModel;

Console.WriteLine("Hello, World!");
var rawPassword = "Admin@123";
var hashedPassword = BCrypt.Net.BCrypt.HashPassword(rawPassword, workFactor: 12);
Console.WriteLine(hashedPassword);
