namespace LoginDashboardAPI.Models
{
public class LoginResponse
{
    public string Token { get; set; } = string.Empty;
    public User User { get; set; } = null!;
}
}