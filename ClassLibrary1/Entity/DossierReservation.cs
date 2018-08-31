using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.Core.Entity
{
       public class DossierReservation
        {
            public int Id { get; set; }
            public EtatDossierReservation EtatDossier { get; set; }
            public EtatDossierReservation EtatAnnulation { get; set; }
            public string NumeroCarteBancaire { get; set; }
        //FK 
            public virtual AgenceVoyage agenceVoyage { get; set; }
            public int IdVoyage { get; set; }

            public double CaculerPrixTotal(int nbpersonne)
            {
                return 0d;
            }    
        }
        enum EtatDossierReservation { enAttente, enCours, refuse, accepte }
        enum RaisonAnnulationDossier { parClient, placeInsuffisantes }

}
