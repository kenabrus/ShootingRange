using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShootingRange.Core.DomainModels
{
    public class Uzytkownik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id {get; set;}
        public string NrTelefonu {get; set;}

        public string Haslo {get; set;}

        public float StanKonta {get; set;}

        public ICollection<Samochod> ListaSamochodow {get; set;}

        public Uzytkownik(){}
    }
}