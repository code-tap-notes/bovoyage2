using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;
using BoVoyage.Core.DAL;


namespace BoVoyage.Core.Services
{
    public class ClientService
    {
        public Client Ajouter(Client client)
        {
            var cli = new ClientSQL();
            cli.Ajouter(client);
            return client;
        }

    }
}
