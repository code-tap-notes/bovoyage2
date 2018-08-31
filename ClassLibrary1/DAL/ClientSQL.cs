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
    class ClientSQL
    {

        public List<Client> GetList()
        {

            using (var contexte = new Contexte())
            {
                return contexte.Clients.ToList();
            }
        }
        public Client Ajouter(Client Client)
        {
            using (var contexte = new Contexte())
            {
                contexte.Clients.Add(Client);
                contexte.SaveChanges();
            }
            return Client;
        }
        public void CreerClient(Client Client)
        {
            using (var contexte = new Contexte())
            {
                contexte.Clients.Add(Client);

                contexte.SaveChanges();
            }
        }
        public List<Client> ListerClient()
        {
            using (var contexte = new Contexte())
            {
                return contexte.Clients.
                    OrderBy(x => x.Nom).

                     ToList();
            }

        }

        public void ModifierClient(Client Client)

        {
            using (var contexte = new Contexte())
            {
                contexte.Clients.Attach(Client);
                contexte.Entry(Client).State = EntityState.Modified;
                contexte.SaveChanges();

            }
        }

        public void SupprimerClient(int id)
        {
            using (var contexte = new Contexte())
            {
                var Client = contexte.Clients.Find(id);
                contexte.Entry(Client).State = EntityState.Deleted;
                contexte.SaveChanges();
            }
        }
    }
}
