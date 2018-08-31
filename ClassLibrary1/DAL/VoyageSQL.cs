using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;
using System.IO;


namespace BoVoyage.Core.DAL
{
    class VoyageSQL
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

    }
}
