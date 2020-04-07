using System;

namespace ShootingRange.Core.DomainModels
{
    public class Weather
    {
        public DateTime Date {get; set;}
        public int TempereatureC {get; set;}
        public string Summary {get; set;}
        public int TemperatureF {get; set;}
    }
}