using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BoVoyage.Core.Entity;

namespace BoVoyage.Core.DAL
{
    class VoyageDonnee
   
        {
            const string CheminFichier = @"..\..\Fichier\Voyages.txt";
            const char SeparateurChamps = ';';

            private List<Voyage> Voyages;
            public List<Voyage> GetListe()
            {
                if (this.Voyages == null)
                {
                    LireFichier();
                }

                return this.Voyages;

            }

            public void Enregistrer(Voyage voyage)
            {
                voyage.Id = GetListe().Count + 1;
                if (!this.Voyages.Contains(voyage))
                {
                    this.Voyages.Add(voyage);
                }

                this.EcrireFichier();
            }

            public void Supprimer(Voyage Voyage)
            {
                this.Voyages.Remove(Voyage);
                this.EcrireFichier();
            }

            private void LireFichier()
            {
                this.Voyages = new List<Voyage>();
                if (File.Exists(CheminFichier))
                {
                    var lignes = File.ReadAllLines(CheminFichier);
                    foreach (var ligne in lignes)
                    {
                        var champs = ligne.Split(SeparateurChamps);

                        var Voyage = new Voyage();
                        Voyage.Id = int.Parse(champs[0]);
                        Voyage.Destination.Id = int.Parse(champs[1]);
                        Voyage.DateAller = DateTime.Parse(champs[2]);
                        Voyage.DateRetour = DateTime.Parse(champs[3]);
                        Voyage.PlacesDisponible = int.Parse(champs[4]);

                        Voyages.Add(Voyage);
                    }
                }
            }

            private void EcrireFichier()
            {
                var contenuFichier = new StringBuilder();
                foreach (var Voyage in this.Voyages)
                {
                    contenuFichier.AppendLine(string.Join(
                                                SeparateurChamps.ToString(),
                                                Voyage.Id,
                                                Voyage.Destination.Id,
                                                Voyage.DateAller,
                                                Voyage.DateRetour,
                                                Voyage.PlacesDisponible));
                }

                File.WriteAllText(CheminFichier, contenuFichier.ToString());
            }
    }
}

