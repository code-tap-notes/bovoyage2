using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.Core.Entity
{
    class AgenceVoyage
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Voyage> OffreVoyages { get; set; }
    }
}
