using System;
using System.Net;
using System.Net.Mail;

namespace EmailNotificationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collect email address from user input
            Console.WriteLine("Enter your email address:");
            string emailAddress = Console.ReadLine();


            // Validate email address format
            if (!IsValidEmail(emailAddress))
            {
                Console.WriteLine("Invalid email address format.");
                return;
            }

            //SMTP  Configuration

            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "negaimarin@gmail.com";
            string smtpPassword = "ksnd bpao xdxj qqll";
           
            SmtpClient smtpClient = null;

            SmtpClient client = null;
            MailMessage message = null;
            // ksnd bpao xdxj qqll

            try
            {
                // Create SMTP client and message
                client = new SmtpClient(smtpServer,smtpPort);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(smtpUsername,smtpPassword);                

                // Create email message
                message = new MailMessage(smtpUsername,emailAddress);
                message.Subject = "Thank you for subscribing";
                message.Body = "Dear subscriber, \n\nThank you for subscribing to our newsletter.";

                // Send email
                client.Send(message);
                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Cleanup resources
                if (message != null)
                    message.Dispose();

                if (client != null)
                    client.Dispose();
            }
        }

        // Validate email address format
        static bool IsValidEmail(string email)
        {
            return MailAddress.TryCreate(email, out MailAddress add) && add.Address == email;
        }
    }
}
