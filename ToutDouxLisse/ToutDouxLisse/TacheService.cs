using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;

namespace ToutDouxLisse
{
    public class TacheService
    {
        private readonly ObservableCollection<Tache> taches = new ObservableCollection<Tache>()
        {
            new Tache() {
                Id=1,
                Date=DateTime.Parse("2022-04-25"),
                Nom="Lorem",
                Description="In quis fermentum magna. Nullam purus nisi, imperdiet ut finibus in, euismod fermentum sem.",
                Priorite=3
            },
            new Tache() {
                Id=2,
                Date=DateTime.Parse("2022-04-15"),
                Nom="Ipsum dolor",
                Description="In quis fermentum magna. Nullam purus nisi, imperdiet ut finibus in, euismod fermentum sem.",
                Priorite=1
            },
            new Tache() {
                Id=3,
                Date=DateTime.Parse("2022-03-25"),
                Nom="Nulla ac ipsum",
                Description="In quis fermentum magna. Nullam purus nisi, imperdiet ut finibus in, euismod fermentum sem.",
                Priorite=5
            },
            new Tache() {
                Id=8,
                Date=DateTime.Parse("2022-01-25"),
                Nom="Proin sodales",
                Description="In quis fermentum magna. Nullam purus nisi, imperdiet ut finibus in, euismod fermentum sem.",
                Priorite=7
            },
            new Tache() {
                Id=9,
                Date=DateTime.Parse("2022-04-25 12:31", CultureInfo.InvariantCulture),
                Nom="Phasellus porta",
                Description="In quis fermentum magna. Nullam purus nisi, imperdiet ut finibus in, euismod fermentum sem.",
                Priorite=2
            },
            new Tache() {
                Id=10,
                Date=DateTime.Parse("2022-01-31"),
                Nom="Suspendisse at",
                Description="In quis fermentum magna. Nullam purus nisi, imperdiet ut finibus in, euismod fermentum sem.",
                Priorite=4
            }
        };
        
        public void SupprimerMoinsPrio()
        {
            taches.Remove(taches.OrderByDescending(t => t.Priorite).OrderBy(t => t.Date).First());
        }

        public IEnumerable<Tache> ToutesLesTaches => taches;
    }
}
