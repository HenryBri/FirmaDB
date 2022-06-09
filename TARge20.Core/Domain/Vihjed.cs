using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Vihjed
    {
        [Key]
        public Guid Id { get; set; }
        public string Sisu { get; set; }
        public string Põhjus { get; set; }
        public DateTime Kuupäev { get; set; }

        public Guid PeakontorId { get; set; }
        public Peakontor Peakontor { get; set; }
    }
}