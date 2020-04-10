using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShootingRange.Core.DomainModels
{
    public class Samochod
    {
        public int Id {get; set;}

        public int UzytkownikId {get; set;}
        public Uzytkownik Uzytkownik {get; set;}

        public int LokalizacjaId {get; set; }
        public Lokalizacja Lokalizacja {get; set;}

        public Samochod(){}
    }
}