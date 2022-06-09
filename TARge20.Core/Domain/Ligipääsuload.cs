using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Ligipääsuload
    {
        [Key]
        public Guid Id { get; set; }
        public string Kasutajatunnus { get; set; }
        public string Parool { get; set; }
        public DateTime ViimaneKülastus { get; set; }

        public Guid TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        public Guid? HarukontorId { get; set; }
        public Harukontor Harukontor { get; set; }
    }
}