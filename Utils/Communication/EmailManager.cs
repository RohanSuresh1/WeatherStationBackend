using FluentEmail.Core;
using FluentEmail.Smtp;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Utils;

public class EmailManager : IEmailManager
{
    private readonly IConfiguration _config;
    private SmtpSender? _supportSmtpSender;
    private SmtpSender? _alertSmtpSender;
    public EmailManager(IConfiguration configuration)
    {
        _config = configuration;
        Init();
    }
    private SmtpSender GetSMTP(string EmailID, string EmailPWD)
    {
        var trackingInfo = new Dictionary<string, string>();
        try
        {
            var smtpClient = new SmtpSender(new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(EmailID, EmailPWD),
                EnableSsl = true
            });
            return smtpClient;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    private void Init()
    {
        _supportSmtpSender = GetSMTP(_config["EmailSettings:Sender"], _config["EmailSettings:Password"]);
        _alertSmtpSender = GetSMTP(_config.GetSection("EmailSender").Value, _config.GetSection("EmailPassword").Value);
    }
    public async Task<string> SendDefaultPassowrdEmail(string emailID, string pwd)
    {
        var trackingInfo = new Dictionary<string, string>();
        try
        {
            var template = new StringBuilder();
            var htmlTempalte = ApplicationConstants.SendDefaultPassowrdEmail;
            htmlTempalte = htmlTempalte.Replace("{password}", pwd);
            htmlTempalte = htmlTempalte.Replace("{emailid}", emailID);
            template.AppendLine(htmlTempalte);
            Email.DefaultSender = _supportSmtpSender;
            var email = await Email
                .From(_config["EmailSettings:Sender"], _config["EmailSettings:SenderName"])
                .To(emailID)
                .Subject("Account Created")
                .UsingTemplate(template.ToString(), new { })
                .SendAsync()
                .ConfigureAwait(false);
            return emailID;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public async Task<string> SendUserAddedMail(string emailID, string pwd)
    {
        var trackingInfo = new Dictionary<string, string>();
        try
        {
            var template = new StringBuilder();
            template.AppendLine("Hi,");
            template.Append("\nYour account has been added for a new weather station.");
            template.AppendLine("\n-Weather Station App");
            Email.DefaultSender = _supportSmtpSender;
            var email = await Email
                .From(_config["EmailSettings:Sender"], _config["EmailSettings:SenderName"])
                .To(emailID)
                .Subject("Account Created")
                .Body(template.ToString())
                .SendAsync()
                .ConfigureAwait(false);
            return emailID;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public async Task<string> SendAlertMail(string emailID, string message)
    {
        var trackingInfo = new Dictionary<string, string>();
        try
        {
            var template = new StringBuilder();
            template.AppendLine(message);
            Email.DefaultSender = _alertSmtpSender;
            var email = await Email
                .From(_config.GetSection("EmailSender").Value, "Weather Station App")
                .To(emailID)
                .Subject("Alert")
                .UsingTemplate(template.ToString(), new { })
                .SendAsync()
                .ConfigureAwait(false);
            return emailID;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public async Task<string> SendResetPasswordAsync(string emailID, string pwd)
    {
        var trackingInfo = new Dictionary<string, string>();
        try
        {
            var template = new StringBuilder();
            var htmlTempalte = ApplicationConstants.ResetPassword;
            htmlTempalte = htmlTempalte.Replace("{password}", pwd);
            template.AppendLine(htmlTempalte);
            Email.DefaultSender = _supportSmtpSender;
            var email = await Email
                .From(_config["EmailSettings:Sender"], _config["EmailSettings:SenderName"])
                .To(emailID)
                .Subject("Reset Password")
                .UsingTemplate(template.ToString(), new { })
                .SendAsync()
                .ConfigureAwait(false);
            return emailID;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}