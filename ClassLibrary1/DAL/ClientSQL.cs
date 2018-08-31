using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;
using System.IO;

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
        public Client Ajouter(Client client)
        {
            using (var contexte = new Contexte())
            {
                contexte.Clients.Add(client);
                contexte.SaveChanges();
            }
            return client;

        }
    }
}
