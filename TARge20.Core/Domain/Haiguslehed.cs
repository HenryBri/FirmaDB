using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Haiguslehed
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Algus { get; set; }
        public DateTime Lõpp { get; set; }
        public string Põhjus { get; set; }

        public Guid TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
    }
}