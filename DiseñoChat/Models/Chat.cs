using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiseñoChat.Models
{
    public class Chat
    {
        public string Mensaje { get; set; }
        public DateTime HoraFecha { get; set; }
        public string Receptor { get; set; } //para quien es
        public string Emisor { get; set; } //Quien lo envia

    }
}