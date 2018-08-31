using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;

namespace BoVoyage.Core.DAL
{
    class ParticipantSQL
    {
        public List<Participant> GetList()
        {
            using (var contexte = new Contexte())
            {
                return contexte.Participants.ToList();
            }

        }
        public Participant Ajouter(Participant Participant)
        {
            using (var contexte = new Contexte())
            {
                contexte.Participants.Add(Participant);
                contexte.SaveChanges();
            }
            return Participant;

        }
    }
}
