using System;
using System.Collections.Generic;
using System.Text;

namespace Licitatii.Models
{
    public class Licitatie
    {
        public int LicitatieId { get; set; }
        public string Nume { get; set; }
        public decimal ValoareStart { get; set; }
        public decimal ValoareFinala { get; set; }
        public DateTime DataInceput { get; set; }
        public bool EsteFinalizata { get; set; }
        public List<Candidat> Candidati { get; set; } = new List<Candidat>();
        public List<Oferta> Oferte { get; set; } = new List<Oferta>();
    }
}
