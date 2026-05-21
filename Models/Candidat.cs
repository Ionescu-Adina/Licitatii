using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Licitatii.Models
{
    public class Candidat
    {
        public int CandidatId { get; set; }
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public string Adresa { get; set; }
        public List<Oferta> Oferte { get; set; } = new List<Oferta>();
        public List<Licitatie> Licitatii { get; set; } = new List<Licitatie>();
    }
}
