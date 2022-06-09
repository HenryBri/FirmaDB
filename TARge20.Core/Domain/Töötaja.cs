using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Töötaja
    {
        [Key]
        public Guid Id { get; set; }
        public string Eesnimi { get; set; }
        public string Perekonnanimi { get; set; }
        public string Isikukood { get; set; }
        public string Aadress { get; set; }
        public string Email { get; set; }
        public DateTime TöölAlates { get; set; }
        public DateTime TöölKuni { get; set; }
        public string Kandevõime { get; set; }
        
        public Guid HarukontorId { get; set; }
        public Harukontor Harukontor { get; set; }
        
        public List<Ametinimetus> Ametinimetus { get; set; }
        public List<Haiguslehed> Haiguslehed { get; set; }
        public List<Laenutus> Laenutus { get; set; }
        public List<Lapsed> Lapsed { get; set; }
        public List<Ligipääsuload> Ligipääsuload { get; set; }
        public List<Palved> Palved { get; set; }
        public List<Puhkused> Puhkused { get; set; }
        public List<Tervisekontroll> Tervisekontroll { get; set; }
    }
}