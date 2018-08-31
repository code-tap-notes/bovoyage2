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
    class ServiceClient
    {
        public Client TrouverClient(int id)
        {
            var service= new ClientSQL;
            return service.GetList()[id];
        }
        public Clients Liste()
        {
            var service = ClientSQL;
            return service.GetList();
        }
    } 
}



