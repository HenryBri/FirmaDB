using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Peakontor
    {
        [Key]
        public Guid Id { get; set; }
        public string RegistriNr { get; set; }
        public string FirmaNimi { get; set; }
        public string LühiNimi { get; set; }
        public string Aadress { get; set; }
        public string Kontaktisik { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        
        public List<Palved> Palved { get; set; }
        public List<Harukontor> Harukontor { get; set; }
        public List<Vihjed> Vihjed { get; set; }
    }
}