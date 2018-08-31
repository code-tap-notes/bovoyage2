using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;

namespace BoVoyage.Core.DAL
{
    public class DSQL
    {
        public List<Destination> GetList()
        {
            using (var contexte = new Contexte())
            {
                return contexte.Destinations.ToList();
            }
        }
        public Destination Ajouter(Destination Destination)
        {
            using (var contexte = new Contexte())
            {
                contexte.Destinations.Add(Destination);
                contexte.SaveChanges();
            }
            return Destination;
        }

    }
}
