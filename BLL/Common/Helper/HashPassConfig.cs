namespace BLL;

public class HashPassConfig
{
    public static string HashPass(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12);
    }

    public static bool VerifyPass(string password, string hashPassword)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashPassword);
    }
}
