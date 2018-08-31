using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.Core.Entity
{
    class Voyage
    {
        public int Id { get; set; }
        public DateTime DateAller { get; set; }
        public DateTime DateRetour { get; set; }
        public int PlacesDisponible { get; set; }
        public double PrixParPersonne { get; set; }
        public void Reserver(int places)
        {
        }
        // [Foreingkey("IdDestination")]
        public virtual Destination Destination { get; set; }
        //  [Foreingkey("IdDestination")]
        public virtual AgenceVoyage AgenceVoyage { get; set; }

    }
}

