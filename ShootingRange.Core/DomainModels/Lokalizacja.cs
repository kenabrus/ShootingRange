using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShootingRange.Core.DomainModels
{
    public class Lokalizacja
    {
        public int Id {get; set;}
        public string Adres {get; set;}
        public string MapaUrl {get; set;}

        public ICollection<Samochod> ListaSamochodow {get; set;}

        public Lokalizacja(){}
    }
}