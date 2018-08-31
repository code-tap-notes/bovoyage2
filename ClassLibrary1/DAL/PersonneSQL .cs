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
    class PersonneSQL
    {

        public List<Personne> GetList()
        {

            using (var contexte = new Contexte())
            {
                return contexte.Personne.ToList();
            }
        }
        public Personne Ajouter(Personne Personne)
        {
            using (var contexte = new Contexte())
            {
                contexte.Personne.Add(Personne);
                contexte.SaveChanges();
            }
            return Personne;
        }
        public void CreerPersonne(Personne Personne)
        {
            using (var contexte = new Contexte())
            {
                contexte.Personne.Add(Personne);

                contexte.SaveChanges();
            }
        }
        public List<Personne> ListerPersonne()
        {
            using (var contexte = new Contexte())
            {
                return contexte.Personne.
                    OrderBy(x => x.Nom).

                     ToList();
            }

        }

        public void ModifierPersonne(Personne Personne)

        {
            using (var contexte = new Contexte())
            {
                contexte.Personne.Attach(Personne);
                contexte.Entry(Personne).State = EntityState.Modified;
                contexte.SaveChanges();

            }
        }

        public void SupprimerPersonne(int id)
        {
            using (var contexte = new Contexte())
            {
                var Personne = contexte.Personne.Find(id);
                contexte.Entry(Personne).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }
    }
}
