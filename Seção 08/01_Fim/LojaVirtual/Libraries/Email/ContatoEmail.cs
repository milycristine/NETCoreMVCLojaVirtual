using LojaVirtual.Models;
using System.Net;
using System.Net.Mail;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato) 
        { 
            //necessario smtp - Servidor que vai enviar a mensagem   
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); //porta 587
            smtp.UseDefaultCredentials= false;
            smtp.Credentials = new NetworkCredential("email@gmail.com", "senha");// 
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - Loja Virtual</h2>" + "<b>Nome: </b> {0} <br/>"+ "<b>E-mail: </b> {1} </br>"+ "<b>Texto: </b> {2} </br>" + " E-mail enviado automaticamente :) " , contato.Nome,contato.Email, contato.Texto );


            //MailMessage > Construir mensagem

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("email@gmail.com");
            mensagem.To.Add("email@gmail.com@gmail.com");
            mensagem.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
            mensagem.Body= corpoMsg;
            mensagem.IsBodyHtml= true;

            //Enviar Mensagem via SMTP
            smtp.Send(mensagem);
        }
    }
}
