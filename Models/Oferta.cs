using System;
using System.Collections.Generic;
using System.Text;

namespace Licitatii.Models
{
    public class Oferta
    {
        public int OfertaId { get; set; }
        public int CandidatId { get; set; }
        public Candidat Candidat { get; set; }
        public int LicitatieId { get; set; }
        public Licitatie Licitatie { get; set; }
        public decimal SumaOferita { get; set; }
        public DateTime DataOferta  { get; set; }
    }
}
