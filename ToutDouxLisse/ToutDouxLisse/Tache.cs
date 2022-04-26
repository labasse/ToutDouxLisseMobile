using System;
using System.Collections.Generic;

namespace ToutDouxLisse
{
    public class Tache
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int Priorite { get; set; } = 1;
    }
}
