using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Tervisekontroll
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime KontrolliAeg { get; set; }
        public string Asutus { get; set; }
        public string Tulemus { get; set; }

        public Guid TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
    }
}