﻿using System.ComponentModel.DataAnnotations;
using LojaVirtual.Libraries.Lang;


namespace LojaVirtual.Models
{
    public class Contato
    {
        
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName ="MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E004")]
        public string Email { get; set;}

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(10, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E003")]
        public string Texto { get; set;}
    }
}
