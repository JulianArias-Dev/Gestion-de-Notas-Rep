using Entity;
using System;
using System.Net.Mail;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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
                string year = DateTime.Now.Year.ToString();

                switch (procedimiento)
                {
                    case 2:
                        title = "Bienvenido a ISMI by Hola Mundo Dev's House ©";
                        notificacion = "Sus datos han sido registrados exitosamente en el sistema.";
                        asunto = "Registro Exitoso";
                        break;
                    case 3:
                        title = "Actualización de Datos en ISMI by Hola Mundo Dev's House ©";
                        notificacion = "Sus datos han sido actualizados correctamente. Si no tiene conocimiento del proceso, lo invitamos a contactarse con el administrador del sistema.";
                        asunto = "Modificación Exitosa";
                        break;
                    case 4:
                        title = "Eliminación de Datos en ISMI by Hola Mundo Dev's House ©";
                        notificacion = "Sus datos han sido eliminados correctamente del sistema.";
                        asunto = "Eliminación de Datos";
                        break;
                }

                string from = "ismibyhmdh@gmail.com";
                string to = email;
                string subject = asunto;

                string body = $@"
                <html lang='es'>
                <head>
                    <style>
                        body {{
                            font-family: 'Arial', sans-serif;
                            background-color: #f4f4f4;
                            margin: 0;
                            padding: 0;
                        }}
                        .container {{
                            width: 80%;
                            margin: auto;
                            background-color: #ffffff;
                            padding: 20px;
                            border-radius: 10px;
                            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                        }}
                        .header {{
                            text-align: center;
                            margin-bottom: 20px;
                        }}
                        .header img {{
                            max-width: 120px;
                            margin: 0 20px;
                        }}
                        .title {{
                            font-size: 24px;
                            color: #333333;
                        }}
                        .content {{
                            font-size: 16px;
                            line-height: 1.6;
                            color: #333333;
                        }}
                        .footer {{
                            font-size: 14px;
                            color: #888888;
                            margin-top: 20px;
                            text-align: center;
                        }}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <div class='header'>
                            <h1 class='title'>{title}</h1>
                            <div style='display: flex; justify-content: center; align-items: center;'>
                                <img src='https://res.cloudinary.com/dlx1sufu4/image/upload/v1718503909/ISMI_kz6yow.png' alt='ISMI Logo'>
                                <img src='https://res.cloudinary.com/dlx1sufu4/image/upload/v1718503968/HMDH_jlnt45.png' alt='HMDH Logo'>
                            </div>
                        </div>
                        <div class='content'>
                            <p>Estimado/a {name},</p>
                            <p>{notificacion}</p>
                            <p>Gracias por confiar en nosotros.</p>
                            <p><strong>Intelligent Score Management for Institutes (ISMI)</strong> es una plataforma diseñada para optimizar el proceso de control académico dentro de las instituciones. Esperamos que este año obtenga los resultados que espera.</p>
                        </div>
                        <div class='footer'>
                            <p>&copy; {year} ISMI by Hola Mundo Dev's House. Todos los derechos reservados.</p>
                        </div>
                    </div>
                </body>
                </html>";

                // Create a MailMessage object
                MailMessage myMail = new MailMessage();
                myMail.From = new MailAddress(from);
                myMail.To.Add(new MailAddress(to));
                myMail.Subject = subject;
                myMail.Body = body;
                myMail.IsBodyHtml = true;

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
