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
    public class ServiceVoyage
    {
        public Voyage GetVoyage(int id)
        {
            var service= new VoyageSQL();
            return service.GetList()[id];
        }

        public List<Voyage> GetList()
        {
            var service = new VoyageSQL();
            return service.GetList();
        }

        public void CreerVoyage(Voyage voyage)
        {
            var service = new VoyageSQL();
            service.CreerVoyage(voyage);
        }
       
    } 
}



