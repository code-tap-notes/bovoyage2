using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace BoVoyage.Core.Entity
{
       public class Participant:Personne
        {
            public int NumeroUnique { get; set; }

            public bool Reduction()
            {
            return (GetAge() < 12);
            }
        
            public int IdDossierReservation { get; set; }
               // [ForeignKey("DossierReservationId")]
        public virtual DossierReservation DossierReservation { get; set; }
    }
    
}
