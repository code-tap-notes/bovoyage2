using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;
using BoVoyage.Core.DAL;


namespace BoVoyage.Core.Services
{
    public class ServiceParticipant
    {
        public Participant Ajouter(Participant participant)
        {
            var cli = new ParticipantSQL();
            cli.Ajouter(participant);
            return participant;
        }


        public Participant GetParticipant(int id)
        {
            var service = new ParticipantSQL();
            return service.GetList()[id];
        }

        public void CreerParticipant(Participant Participant)
        {
            var cli = new ParticipantSQL();
            cli.CreerParticipant(Participant);        
        }


        public void SupprimerParticipant(int id)
        {
            var cli = new ParticipantSQL();
            cli.SupprimerParticipant(id);
        }
        public void ModifierParticipant(Participant Participant)
        {
            var cli = new ParticipantSQL();
            cli.ModifierParticipant(Participant);
        }
    }
}
