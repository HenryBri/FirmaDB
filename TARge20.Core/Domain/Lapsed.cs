using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Lapsed
    {
        [Key]
        public Guid Id { get; set; }
        public string Eesnimi { get; set; }
        public string Perekonnanimi { get; set; }
        public string Note { get; set; }

        public Guid TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
    }
}