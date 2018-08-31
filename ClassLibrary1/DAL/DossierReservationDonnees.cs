using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BoVoyage.Core.Entity;

namespace BoVoyage.Core.DAL
{
    public class DossierReservationDonnee
    {
        const string CheminFichier = @"..\..\Fichier\DossierReservation.txt";
        const char SeparateurChamps = ';';

        private List<DossierReservation> DossierReservation;

        public List<DossierReservation> Creer()
        {
            
        }

        public List<DossierReservation> GetListe()
        {
            if (this.DossierReservation == null)
            {
                LireFichier();
            }

            return this.DossierReservation;
        }

        public DossierReservation Enregistrer(DossierReservation DossierReservation)
        {
            DossierReservation.Id = GetListe().Count + 1;
            if (!this.DossierReservation.Contains(DossierReservation))
            {
                this.DossierReservation.Add(DossierReservation);
            }

            this.EcrireFichier();
            return DossierReservation;
        }

        public void Supprimer(DossierReservation DossierReservation)
        {
            this.DossierReservation.Remove(DossierReservation);
            this.EcrireFichier();
        }

        private void LireFichier()
        {
            this.DossierReservation = new List<DossierReservation>();
            if (File.Exists(CheminFichier))
            {
                var lignes = File.ReadAllLines(CheminFichier);
                foreach (var ligne in lignes)
                {
                    var champs = ligne.Split(SeparateurChamps);

                    var DossierReservation = new DossierReservation();
                    DossierReservation.Id = int.Parse(champs[0]);
                    DossierReservation.NumeroCarteBancaire = champs[1];
                    DossierReservation. = champs[2];
                    DossierReservation.Region = champs[3];
                    DossierReservation.Description = champs[4];

                    DossierReservation.Add(DossierReservation);
                }
            }
        }

        private void EcrireFichier()
        {
            var contenuFichier = new StringBuilder();
            foreach (var DossierReservation in this.DossierReservation)
            {
                contenuFichier.AppendLine(string.Join(
                                            SeparateurChamps.ToString(),
                                            DossierReservation.Id,
                                            DossierReservation.Continent,
                                            DossierReservation.Pay,
                                            DossierReservation.Region,
                                            DossierReservation.Description));
            }

            File.WriteAllText(CheminFichier, contenuFichier.ToString());
        }

    }
}
