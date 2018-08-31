using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.EnTity;


namespace BoVoyage.Core.DAL
{
    class DossierReservationSQL
    {
        public List<DossierReservation> GetList()
        {

            using (var contexte = new Contexte())
            {
                return contexte.DossierReservations.ToList();
            }
        }
        public DossierReservation Ajouter(DossierReservation DossierReservation)
        {
            using (var contexte = new Contexte())
            {
                contexte.DossierReservations.Add(DossierReservation);
                contexte.SaveChanges();
            }
            return DossierReservation;
        }
    }
}
