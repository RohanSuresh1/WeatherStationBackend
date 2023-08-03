namespace Utils
{
    public interface IEmailManager
    {
        Task<string> SendDefaultPassowrdEmail(string emailID, string pwd);
        Task<string> SendAlertMail(string emailID, string message);
        Task<string> SendResetPasswordAsync(string emailID, string pwd);
        Task<string> SendUserAddedMail(string emailID, string pwd);
    }
}