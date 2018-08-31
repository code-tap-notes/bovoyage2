using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;
using System.IO;
using System.Data.Entity;

namespace BoVoyage.Core.DAL
{
    public class VoyageSQL
    {
        public List<Voyage> GetList()
        {

            using (var contexte = new Contexte())
            {
                return contexte.Voyages.ToList();
            }
        }
       


        public Voyage Ajouter(Voyage Voyage)
        {
            using (var contexte = new Contexte())
            {
                contexte.Voyages.Add(Voyage);
                contexte.SaveChanges();
            }
            return Voyage;
        }
        public void CreerVoyage(Voyage Voyage)
        {
            using (var contexte = new Contexte())
            {
                contexte.Voyages.Add(Voyage);

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
                var Voyage = contexte.Voyages.Find(id);
                contexte.Entry(Voyage).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }
    }
}
