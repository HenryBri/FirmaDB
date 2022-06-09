using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Palved
    {
        [Key]
        public Guid Id { get; set; }
        public string Sisu { get; set; }
        public string Põhjus { get; set; }
        public string Ettepanek { get; set; }
        public DateTime Kuupäev { get; set; }

        public Guid TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }

        public Guid? PeakontorId { get; set; }
        public Peakontor Peakontor { get; set; }
    }
}