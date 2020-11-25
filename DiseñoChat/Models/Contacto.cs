using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiseñoChat.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}