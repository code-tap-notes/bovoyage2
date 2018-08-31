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
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Voyage> Voyages { get; set; }
        public DbSet<AgenceVoyage> AgenceVoyages { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DossierReservation> DossierReservations { get; set; }
        public DbSet<ParticipantReservation> ParticipantReservation { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Assurance> Assurances { get; set; }
    }
}