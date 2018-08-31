using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;
using BoVoyage.Core.DAL;

namespace BoVoyage.Core.Services
{

    public class ServiceClient

    {
     
        public void ServicerAjouter(Client Client)
        {
            ClientSQL ServiveClient = new ClientSQL;
            ServiceClient.Ajouter(Client);
          
        }

    }
}