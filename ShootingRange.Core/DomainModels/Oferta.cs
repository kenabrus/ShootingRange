using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShootingRange.Core.DomainModels
{
    public class Oferta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id {get; set;}

        public int SamochodId {get; set;}
        public float Poczatek {get; set; }
        public bool GodzinyDoby {get; set;}
        public int IloscGodzinDob {get; set;}
        public float CenaZaH {get; set;}
        public bool Wykupiona {get; set;}

        public ICollection<Samochod> ListaSamochodow {get; set;}

        public Oferta(){}
    }
}