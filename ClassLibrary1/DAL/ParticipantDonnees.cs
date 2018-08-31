using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyage.Core.Entity;
using System.IO;

namespace BoVoyage.Core.DAL
{
    class ParticipantDonnees
    {

        const string CheminFichier = @"..\..\Fichier\Participants.txt";
        const char SeparateurChamps = ';';

        private List<Participant> Participants;
        public List<Participant> GetListe()
        {
            if (this.Participants == null)
            {
                LireFichier();
            }

            return this.Participants;
        }

        public Participant Enregistrer(Participant Participant)
        {
            Participant.Id = GetListe().Count + 1;
            if (!this.Participants.Contains(Participant))
            {
                this.Participants.Add(Participant);
            }

            this.EcrireFichier();
            return Participant;
        }

        public void Supprimer(Participant Participant)
        {
            this.Participants.Remove(Participant);
            this.EcrireFichier();
        }

        private void LireFichier()
        {
            this.Participants = new List<Participant>();
            if (File.Exists(CheminFichier))
            {
                var lignes = File.ReadAllLines(CheminFichier);
                foreach (var ligne in lignes)
                {
                    var champs = ligne.Split(SeparateurChamps);

                    var Participant = new Participant();
                    Participant.Id = int.Parse(champs[0]);

                    Participant.Nom = champs[1];
                    Participant.Prenom = champs[2];
                    Participant.Adresse = champs[3];
                    Participant.Telephone = champs[4];
                    Participant.Adresse = champs[5];
                    Participant.DateNaissance = DateTime.Parse(champs[6]);
                    Participant.NumeroUnique = int.Parse(champs[7]);
                    Participants.Add(Participant);
                }
            }
        }

        private void EcrireFichier()
        {
            var contenuFichier = new StringBuilder();
            foreach (var Participant in this.Participants)
            {
                contenuFichier.AppendLine(string.Join(
                                            SeparateurChamps.ToString(),
                                            Participant.Id,
                                            Participant.Nom,
                                            Participant.Prenom,
                                            Participant.Adresse,
                                            Participant.NumeroUnique));
            }

            File.WriteAllText(CheminFichier, contenuFichier.ToString());
        }
    }
}
