using Microsoft.AspNetCore.Http;
using System;

namespace BlazorApp1.Models
{
    public class MeldeDaten
    {
        public MeldeDaten(string bereich)
        {
            Datum = DateOnly.FromDateTime(DateTime.Now);
            TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
            AnmeldeZeit = time.ToString("HH:mm");
            AbmeldeZeit = "--:--";
            Bereich = bereich;
        }
        public DateOnly Datum { get; set; }
        public string AnmeldeZeit { get; set; }
        public string AbmeldeZeit { get; set; }
        public string Bereich { get; set; }
    }
}
