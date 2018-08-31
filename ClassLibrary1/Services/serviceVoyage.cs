using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.DAL;
using BoVoyage.Core.Entity;
using System.IO;
using System.Data.Entity;

namespace BoVoyage.Core.Service
{      
    class ServiceVoyage
    {
        public Voyage TrouverVoyage(int id)
        {
            var voyageService= VoyageSQL;
            return voyageServive.GetList()[id];
        }

        public void EnregistrerVoyage()
         {
        var voyage = new Voyage();
        if (voyage.Id == 0)
        {
            CreerVoyage(voyage);
        }
        else
        {
            ModifierVoyage(voyage);
        }
        }
        public void CreerVoyage(Voyage voyage)
        {
            using (var contexte = new Contexte())
            {
                contexte.Voyages.Add(voyage);

                contexte.SaveChanges();
            }
        }
        public List<Voyage> ListerVoyage()
        {
                using (var contexte = new Contexte())
                {
                    return contexte.Voyages.
                        OrderBy(x => x.DateAller).

                         ToList();
                }
              
         }

        public void ModifierVoyage(Voyage voyage)

        {
                using (var contexte = new Contexte())
                {
                    contexte.Voyages.Attach(voyage);
                    contexte.Entry(voyage).State = EntityState.Modified;
                    contexte.SaveChanges();

                }
        }

        public void SupprimerVoyage(int id)
        {
                using (var contexte = new Contexte())
                {
                    var voyage = contexte.Voyages.Find(id);
                    contexte.Entry(voyage).State = EntityState.Deleted;
                    contexte.SaveChanges();
                }
        }
     } 
}



