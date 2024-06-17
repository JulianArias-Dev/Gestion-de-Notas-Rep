using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class SendMails
    {
        public static void EnviarNotificacion(string[] args, int procedimiento)
        {
            try
            {
                string email = args[0];
                string name = args[1];

                string title = "";
                string notificacion = "";
                string asunto = "";

                switch (procedimiento)
                {
                    case 2:
                        title = "Bienvenido a ISMI by Hola Mundo Dev's House ©";
                        notificacion = "Sus datos han sido registrados exitosamente en el sistema.";
                        asunto = "Registro Exitoso";
                        break;
                    case 3:
                        title = "Este es un mensaje de ISMI by Hola Mundo Dev´s House ©";
                        notificacion = "Sus datos han sido actualizados correctamente. Si no tiene conocimiento del proceso, lo invitanmos a contactarse con el administrador del sistema.";
                        asunto = "Modificación Exitosa";
                        break;
                    case 4:
                        title = "Este es un mensaje de ISMI by Hola Mundo Dev´s House ©";
                        notificacion = "Sus datos han sido eliminados correctamente del sistema.";
                        asunto = "Rescisión";
                        break;
                }

                string from = "ismibyhmdh@gmail.com";
                string to = email;
                string subject = asunto;
                string body = $"<html lang='en'>" +
                              $"<body>\r\n        " +
                              $"<h2 style=\"font-family:Georgia, Times, serif;\">{title} {name}</h2>\r\n" +
                              $"<div style=\"display: flex; justify-content:center; align-items: center; \">\r\n   " +
                              $"<img style=\"height: 15%; width: 25%;\" src=\"https://res.cloudinary.com/dlx1sufu4/image/upload/v1718503909/ISMI_kz6yow.png\" alt=\"Img\">\r\n" +
                              $"<img style=\"height: 20%; width: 30%;\" src=\"https://res.cloudinary.com/dlx1sufu4/image/upload/v1718503968/HMDH_jlnt45.png\" alt=\"hmdv\">\r\n" +
                              $" </div>\r\n        " +
                              $"<div style=\"font-size: larger; font-family: Georgia, 'Times New Roman', Times, serif;\">\r\n" +
                              $"<p style=\"font-weight: bold;\">{notificacion}</p>\r\n            " +
                              $"<p>Gracias por confiar en nosotros</p>" +
                              $"<p>Intelligent Score Management for Institutes (ISMI) es una plataforma que busca optimizar el proceso de " +
                              $"control academico dentro de las instituciones. Esperamos que este año obtengas los resultados que esperas.</p>\r\n\r\n" +
                              $"</div>\r\n" +
                              $"</body>\r\n\r\n" +
                              $"</html>";

                // Create a MailMessage object
                MailMessage myMail = new MailMessage();
                myMail.From = new MailAddress(from);
                myMail.To.Add(new MailAddress(to));
                myMail.Subject = subject;
                myMail.Body = body;
                myMail.IsBodyHtml = true;

                // Optional: Add an attachment
                // MailAttachment myAttachment = new MailAttachment("c:\\attach\\attach1.txt", MailEncoding.Base64);
                // myMail.Attachments.Add(myAttachment);

                // Configure the SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new System.Net.NetworkCredential("ismibyhmdh@gmail.com", "sudwvicyrselxuca");
                smtpClient.EnableSsl = true;

                // Send the email
                smtpClient.Send(myMail);

                Console.WriteLine("Email sent successfully.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid email format: " + ex.Message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("SMTP error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
