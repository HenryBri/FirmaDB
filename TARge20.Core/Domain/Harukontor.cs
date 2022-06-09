using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Harukontor
    {
        [Key]
        public Guid Id { get; set; }
        public string RegistriNr { get; set; }
        public string Nimi { get; set; }
        public string Lühinimi { get; set; }
        public string Aadress { get; set; }
        public string Kontaktisik { get; set; }
        public string TelefoniNr { get; set; }
        public string Email { get; set; }

        public Guid PeakontorId { get; set; }
        public Peakontor Peakontor { get; set; }

        public List<Töötaja> Töötaja { get; set; }
        public List<Ligipääsuload> Ligipääsuload { get; set; }
    }
}