using Microsoft.AspNetCore.Http;
// using ServiceStack.Messaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Oasis.Services
{
	public class MessageService
	{
    private static void SetupServer()
		{
      WebMail.SmtpServer = "smtp.169.254.119.101";
      WebMail.SmtpPort = 25;
      WebMail.EnableSsl = false;
      WebMail.From = "ecommerce";
    }

    public static async Task<Task<int>> Send(string email, string subject, string message)
    {
      SetupServer();
      // WebMail.Send(to: email, subject: subject + email, body: message);
      var emailMessage = $"To: {email}\nSubject: {subject}\nMessage: {message}\n\n";
      File.AppendAllText("emails.txt", emailMessage);
      return Task.FromResult(0);
    }
  }
}