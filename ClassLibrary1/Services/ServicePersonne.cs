using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;
using BoVoyage.Core.DAL;


namespace BoVoyage.Core.Services
{
    public class ServicePersonne
    {
        public void Ajouter(Personne personne)
        {
            var cli = new PersonneSQL();
            cli.Ajouter(personne);
            
        }
        public void Creerpersonne (Personne personne)
        {
            var cli = new PersonneSQL();
            cli.CreerPersonne(personne);        
        }

        public List<Personne> GetList()
        {
            var servicePersonne = new PersonneSQL();
            return servicePersonne.GetList();
        }


        public void SupprimerPersonne(int id)
        {
            var cli = new PersonneSQL();
            cli.SupprimerPersonne(id);
        }
        public void Modifierpersonne(Personne personne)
        {
            var cli = new PersonneSQL();
            cli.ModifierPersonne(personne);
        }
    }
}
