using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoVoyage.Core.Entity
{
        public class Destination
        {
            public int Id { get; set; }
            public string Continent { get; set; }
            public string Pay { get; set; }
            public string Region { get; set; }
            public string Description { get; set; }
        }
}