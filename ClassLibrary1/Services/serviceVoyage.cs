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
    class ServiceVoyage
    {
        public Voyage getVoyage(int id)
        {
            var service= new VoyageSQL();
            return service.GetList()[id];
        }
        public List<Client> Liste()
        {
            var service = new ClientSQL();
            return service.GetList();
        }
    } 
}



