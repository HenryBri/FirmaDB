using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Ametinimetus
    {
        [Key]
        public Guid Id { get; set; }
        public string Kvalifikatsioonid { get; set; }
        public string Tööülesanded { get; set; }

        public Guid TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
    }
}