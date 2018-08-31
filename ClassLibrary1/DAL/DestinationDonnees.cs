using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BoVoyage.Core.Entity;

namespace BoVoyage.Core.DAL
{
    class DestinationDonnee
    {
            const string CheminFichier = @"..\..\Fichier\Destinations.txt";
            const char SeparateurChamps = ';';

            private List<Destination> Destinations;
            public List<Destination> GetListe()
            {
                if (this.Destinations == null)
                {
                    LireFichier();
                }

                return this.Destinations;
            }

            public Destination Enregistrer(Destination destination)
            {
                destination.Id = GetListe().Count + 1;
                if (!this.Destinations.Contains(destination))
                {
                    this.Destinations.Add(destination);
                }

                this.EcrireFichier();
                return destination;
            }

            public void Supprimer(Destination Destination)
            {
                this.Destinations.Remove(Destination);
                this.EcrireFichier();
            }

            private void LireFichier()
            {
                this.Destinations = new List<Destination>();
                if (File.Exists(CheminFichier))
                {
                    var lignes = File.ReadAllLines(CheminFichier);
                    foreach (var ligne in lignes)
                    {
                        var champs = ligne.Split(SeparateurChamps);

                        var Destination = new Destination();
                        Destination.Id = int.Parse(champs[0]);
                        Destination.Continent = champs[1];
                        Destination.Pay = champs[2];
                        Destination.Region = champs[3];
                        Destination.Description = champs[4];

                        Destinations.Add(Destination);
                    }
                }
            }

            private void EcrireFichier()
            {
                var contenuFichier = new StringBuilder();
                foreach (var Destination in this.Destinations)
                {
                    contenuFichier.AppendLine(string.Join(
                                                SeparateurChamps.ToString(),
                                                Destination.Id,
                                                Destination.Continent,
                                                Destination.Pay,
                                                Destination.Region,
                                                Destination.Description));
                }

                File.WriteAllText(CheminFichier, contenuFichier.ToString());
            }
        
    }
}

