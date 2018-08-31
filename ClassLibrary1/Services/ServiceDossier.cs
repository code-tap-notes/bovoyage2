using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.DAL;
using BoVoyage.Core.Entity;


namespace BoVoyage.Core.Services
{
    class ServiceDossier
    {
        public EtatDossierReservation EtatDossier { get; set; }

        public RaisonAnnulationDossier RaisonAnnulationDossier { get; set; }

        public int IdVoyage { get; set; } 

        public virtual Client Client { get; set; }


        public virtual Assurance Assurances { get; set; }

        public virtual Participant Participants { get; set; }


    }
    enum EtatDossierReservation { enAttente, enCours, refuse, accepte }
    enum RaisonAnnulationDossier { parClient, placeInsuffisantes }
}
