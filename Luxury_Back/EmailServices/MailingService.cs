using Luxury_Back.EmailSetting;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;

namespace Luxury_Back.EmailServices
{
    public class MailingService : IMailingService
    {
        //read data of MailSettings from appsettings by inject by IOptions to fill  _mailSettings
        private readonly MailSettings _mailSettings;
        public MailingService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings =mailSettings.Value;
        }
        public async Task SendEmailAsync(string mailTo, string subject, string body, IList<IFormFile> attachments = null)
        {
            //instance from mimeMessage to get all of data mail
            var email = new MimeMessage
            {
                Sender=MailboxAddress.Parse(_mailSettings.Email),
                Subject=subject,
            };
            email.To.Add(MailboxAddress.Parse(mailTo));

            //data of body
            var builder = new BodyBuilder();
            if (attachments != null)
            {
                byte[] filebytes;
                foreach(var attachment in attachments)
                {
                    if (attachment.Length > 0)
                    {
                        //create obj fro MemoryStream to put attachment in it so can controll in it like convert to array
                        using var ms=new MemoryStream();
                        attachment.CopyTo(ms);
                        filebytes = ms.ToArray();

                        builder.Attachments.Add(attachment.FileName, filebytes,ContentType.Parse(attachment.ContentType));
                    }
                }
            } 
            builder.HtmlBody= body;
            email.Body=builder.ToMessageBody(); 
            email.From.Add(new MailboxAddress(_mailSettings.DisplayName, _mailSettings.Email));

            //connect on smtp provider outlook
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Host,_mailSettings.Port,SecureSocketOptions.StartTls);
            //send my mail and password to smtp provider
            smtp.Authenticate(_mailSettings.Email, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
           
        }
    }
}
