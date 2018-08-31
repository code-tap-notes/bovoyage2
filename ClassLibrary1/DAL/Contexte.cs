using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;
using System.Configuration;

namespace BoVoyage.Core.DAL
{
    internal class Contexte : DbContext
    {
        public BdSet<Destination> Destinations { get; set; }
        public BdSet<Voyage> Voyages { get; set; }
        public BDSet<AgenceVoyage> AgenceVoyages { get; set; }
        public BdSet<Client> Clients { get; set; }
        public BdSet<DossierReservation> DossierReservations { get; set; }
        public BdSet<participantReservation> ParticipantReservation { get; set; }
        public BdSet<Participant> Participants { get; set; }
        public BdSet<Assurance> Assurances { get; set; }

       

    }
}