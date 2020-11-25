using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiseñoChat.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }
    }
}