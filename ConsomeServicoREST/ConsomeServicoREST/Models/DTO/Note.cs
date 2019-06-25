using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsomeServicoREST.Models.DTO
{
    public class Note
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Body { get; set; }
    }
}